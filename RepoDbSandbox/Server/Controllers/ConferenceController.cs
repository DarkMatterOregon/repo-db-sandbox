using RepoDbSandbox.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aka.Mods.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RepoDbSandbox.Shared.Models;

namespace RepoDbSandbox.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConferenceController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> logger;
        private readonly BedRockRepository repo;

        public ConferenceController(ILogger<WeatherForecastController> logger, BedRockRepository repo)
        {
            this.logger = logger;
            this.repo = repo;
        }

        [HttpGet]
        public IEnumerable<Conference> Get()
        {
            var list = repo.GetConferences();
            return list;
        }
    }
}
