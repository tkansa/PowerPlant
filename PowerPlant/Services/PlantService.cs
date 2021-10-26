using PowerPlant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.Services
{
    public class PlantService : IPlantService
    {
        List<Plant> plants = new List<Plant>()
        {
            new Plant(1, "Devil's Tongue", "Pothos", "The species is a popular houseplant in temperate regions but has also become naturalised in tropical and sub-tropical forests worldwide.", "Indirect Sun", 1, 4, "All purpose", 1, 4, "https://www.almanac.com/sites/default/files/styles/primary_image_in_article/public/image_nodes/pothos_usmee_ss-crop.jpg?itok=5Wgvlf8W"),
            new Plant(2, "Aloe Vera", "Aloe Vera", "An evergreen perennial, it originates from the Arabian Peninsula, but grows wild in tropical, semi-tropical, and arid climates around the world", "Indirect Sun", 4, 8, "Balanced", 1, 4, "https://www.almanac.com/sites/default/files/users/Almanac%20Staff/aloe-vera-plant1_full_width.jpg")
        };
        public void AddPlant(Plant plant)
        {
            plant.Id = plants.Count() + 1;
            plants.Add(plant);
        }

        public IEnumerable<Plant> GetPlants()
        {
            return plants;
        }
    }
}
