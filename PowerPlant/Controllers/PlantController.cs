using PowerPlant.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerPlant.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace PowerPlant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private IPlantService plantService;
        private IConfiguration configuration;

        public PlantController(IConfiguration config)
        {
            configuration = config;
            plantService = new PlantService(configuration.GetConnectionString("DefaultConnection"));
        }

        [HttpGet]
        public IEnumerable<Plant> Get()
        {
            return plantService.GetPlants().ToArray();
        }
        [HttpGet("{id}")]
        public Plant GetPlant(int id)
        {
            return plantService.GetPlant(id);
        }
        [HttpPost]
        public void AddPlant(Plant plant)
        {
            plantService.AddPlant(plant);
        }
        [HttpPut]
        public void UpdatePlant(Plant plant)
        {
            plantService.UpdatePlant(plant);
        }

        [HttpDelete("{id}")]
        public void DeletePlant(string id)
        {
            plantService.DeletePlant(id);
        }
    }
}
