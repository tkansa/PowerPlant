using Dapper;
using PowerPlant.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PowerPlant.Services
{
    public class PlantService : IPlantService
    {
        private IDbConnection connection;

        public PlantService(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public int AddPlant(Plant plant)
        {
            string insertString = "INSERT INTO Plants (CommonName, ImageUrl) ";
            insertString += "VALUES (@CommonName, @ImageUrl)";
            return connection.Execute(insertString, plant);
        }

        public int DeletePlant(int id)
        {
            string deleteString = "DELETE FROM Plants WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
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

        public int UpdatePlant(Plant plant)
        {
            string updateString = "UPDATE Plants SET CommonName = @CommonName, ImageUrl = @ImageUrl WHERE Id = @Id";
            return connection.Execute(updateString, new { Id = plant.Id, CommonName = plant.CommonName, ImageUrl = plant.ImageUrl });
        }
    }
}
