using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularPractice2.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }

        public string Description { get; set; }

        public string Light { get; set; }

        public int WateringInterval { get; set; }

        public int FeedingInterval { get; set; }

        public string FoodType { get; set; }

        public int RepottingInterval { get; set; }

        public int RotationInterval { get; set; }

        public string ImageUrl { get; set; }

        public Plant()
        {

        }

        public Plant(int id,
            string commonName,
            string scientificName,
            string description,
            string light,
            int wateringInterval, 
            int feedingInterval,
            string foodType,
            int repottingInterval,
            int rotationInterval,
            string imageUrl)
        {
            Id = id;
            CommonName = commonName;
            ScientificName = scientificName;
            Description = description;
            Light = light;
            WateringInterval = wateringInterval;
            FeedingInterval = feedingInterval;
            FoodType = foodType;
            RepottingInterval = repottingInterval;
            RotationInterval = rotationInterval;
            ImageUrl = imageUrl;
        }

    }
}
