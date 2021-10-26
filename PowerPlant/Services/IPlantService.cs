﻿using PowerPlant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.Services
{
    public interface IPlantService
    {
        public IEnumerable<Plant> GetPlants();
        void AddPlant(Plant plant);
    }
}
