using Microsoft.AspNetCore.Mvc;
using BelajarCoreThree.Domains.Movie.Repositories;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;

namespace BelajarCoreThree.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {

        

        private static readonly string[] movies = new[]
        {
            "avenger", "Monata", "Spiderman"
        };

        private readonly MovieRepository _movieRepository;
        private ILogger Logger { get; }


        public MovieController(ILoggerFactory logFactory, MovieRepository movieRepository)
        {
            Logger = logFactory.CreateLogger<Startup>();
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var moviee = _movieRepository.GetListMovie();
            Logger.LogInformation("lihat isinya : "+moviee);


            return Ok(moviee);
        }
    }
}
