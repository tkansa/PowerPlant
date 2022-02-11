using Dapper;
using PowerPlant.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.Services
{
    public class PlantService : IPlantService
    {
        private string plantDbfilePath = @"PowerPlantDb.txt";
        private string plantIdCounterFilePath = @"PlantIdCounter.txt";

        private IDbConnection connection;

        public PlantService(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public int AddPlant(Plant plant)
        {
            string commandString = "INSERT INTO Plants (CommonName, ImageUrl) ";
            commandString += "VALUES (@CommonName, @ImageUrl)";
            return connection.Execute(commandString, plant);
        }

        public int DeletePlant(int id)
        {
            string commandString = "DELETE FROM Plants WHERE Id = @val";
            return connection.Execute(commandString, new { val = id });
        }

        public Plant GetPlant(int id)
        {
            string queryString = "SELECT * FROM Plants WHERE Id = @val";
            Plant plant = connection.QueryFirstOrDefault<Plant>(queryString, new { val = id });
            return plant;
        }    

        public IEnumerable<Plant> GetPlants()
        {
            string queryString = "SELECT * FROM Plants";
            return connection.Query<Plant>(queryString);
        }

        public void UpdatePlant(Plant plant)
        {
            // TODO
        }
    }
}
