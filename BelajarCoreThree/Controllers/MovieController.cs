using Microsoft.AspNetCore.Mvc;
using BelajarCoreThree.Domains.Movie.Repositories;
using Microsoft.Extensions.Logging;
using BelajarCoreThree.Models.Request;

namespace BelajarCoreThree.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        //nilai diinisialisasikan -> berjalan
        private readonly MovieRepository _movieRepository;
        private ILogger Logger { get; }

        //constructor ->inisialisasi awal object
        public MovieController(ILoggerFactory logFactory, MovieRepository movieRepository)
        {
            Logger = logFactory.CreateLogger<Startup>();
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var moviee = _movieRepository.GetListMovie();
            Logger.LogInformation("lihat isinya : " + moviee);


            return Ok(moviee);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var moviee = _movieRepository.GetById(id);
            Logger.LogInformation("lihat isinya : " + moviee);

            return Ok(moviee);
        }

        [HttpPost("addmovie")]
        public IActionResult AddMovie([FromBody]MovieRequest movieRequest)
        {
            _movieRepository.AddMovie(movieRequest);
            return Ok(new { message = "Add Movie Success" });
        }

        [HttpDelete("{id}")]
        public IActionResult deleted(int id)
        {
            _movieRepository.Deleted(id);
            return Ok(new { message = "deleted success" });
        }

        [HttpPut("{id}")]
        public IActionResult update(int id, MovieRequest movieRequest)
        {
            _movieRepository.update(id, movieRequest);
            return Ok(new { message = "update movie success" });
        }
    }
}
