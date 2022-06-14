using PowerPlant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.Services
{
    public interface IPlantService
    {
        public IEnumerable<Plant> GetPlants();
        public Plant GetPlant(int id);
        public int AddPlant(Plant plant);

        public int UpdatePlant(Plant plant);
        public int DeletePlant(int id);

    }
}
