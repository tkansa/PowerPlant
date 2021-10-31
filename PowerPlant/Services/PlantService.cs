using PowerPlant.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.Services
{
    public class PlantService : IPlantService
    {
        private string plantDbfilePath = @"PowerPlantDb.txt";
        private string plantIdCounterFilePath = @"PlantIdCounter.txt";
        
        public void AddPlant(Plant plant)
        {
            // get the id from the db
            string idLine = File.ReadAllText(plantIdCounterFilePath);
            // increment it and set the id of the plant
            plant.Id = int.Parse(idLine) + 1;
            // write the new id back to the db
            File.WriteAllText(plantIdCounterFilePath, plant.Id.ToString());
            // write the new plant to the db
            string[] plantArray = new[] { $"{plant.Id},{plant.CommonName},{plant.ImageUrl}" };
            File.AppendAllLines(plantDbfilePath, plantArray);
        }

        public void DeletePlant(string id)
        {
            List<string> lines = File.ReadAllLines(plantDbfilePath).ToList();
            List<Plant> plants = new List<Plant>();
            foreach (string line in lines)
            {
                string[] plantArray = line.Split(",");
                Plant plant = new Plant();
                plant.Id = int.Parse(plantArray[0]);
                plant.CommonName = plantArray[1];
                plant.ImageUrl = plantArray[2];
                plants.Add(plant);
            }
            plants.RemoveAll(p => p.Id.ToString() == id);
            lines = new List<string>();
            foreach(Plant plant in plants)
            {
                string plantString = $"{plant.Id},{plant.CommonName},{plant.ImageUrl}";
                lines.Add(plantString);

            }
            File.WriteAllLines(plantDbfilePath, lines);
        }

        public Plant GetPlant(int id)
        {
            List<string> lines = File.ReadAllLines(plantDbfilePath).ToList();
            List<Plant> plants = new List<Plant>();
            foreach (string line in lines)
            {
                string[] plantArray = line.Split(",");
                Plant plant = new Plant();
                plant.Id = int.Parse(plantArray[0]);
                plant.CommonName = plantArray[1];
                plant.ImageUrl = plantArray[2];
                plants.Add(plant);
            }

            Plant foundPlant = plants.Find(p => p.Id == id);
            return foundPlant;
        }

        public IEnumerable<Plant> GetPlants()
        {
            List<string> lines = File.ReadAllLines(plantDbfilePath).ToList();
            List<Plant> plants = new List<Plant>();
            foreach (string line in lines)
            {
                string[] plantArray = line.Split(",");
                Plant plant = new Plant();
                plant.Id = int.Parse(plantArray[0]);
                plant.CommonName = plantArray[1];
                plant.ImageUrl = plantArray[2];
                plants.Add(plant);
            }

            return plants;
        }
    }
}
