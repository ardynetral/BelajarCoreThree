using BelajarCoreThree.Infrastructures;
using BelajarCoreThree.Infrastructures.DataAccess;
using BelajarCoreThree.Domains.Movie.Entites;
using System.Collections.Generic;
using System.Linq;
using BelajarCoreThree.Models.Request;
using AutoMapper;
using System;
using Microsoft.Extensions.Logging;

namespace BelajarCoreThree.Domains.Movie.Repositories
{
    public class MovieRepository : BaseRepository
    {

        private readonly IMapper _mapper;
        private ILogger Logger { get; }
        public MovieRepository(DataContext dataContext, IMapper mapper, ILoggerFactory logFactory) : base(dataContext)
        {
            _mapper = mapper;
            Logger = logFactory.CreateLogger<Startup>();
        }

        public IEnumerable<MovieEntity> GetListMovie()
        {
            return _dbContext.MovieEntities;
        }

        public IEnumerable<MovieEntity> GetById(int id)
        {
            return _dbContext.MovieEntities.Where(x => x.id.Equals(id));
        }

        public void AddMovie(MovieRequest movieRequest)
        {
            Logger.LogInformation("lihat isinya : " + movieRequest.title);
            var movie = _mapper.Map<MovieEntity>(movieRequest);
            Logger.LogInformation("apa inn : " + movie.title);
            _dbContext.MovieEntities.Add(movie);
            _dbContext.SaveChanges();

        }

        public void Deleted(int id)
        {
            var movie = _dbContext.MovieEntities.Find(id);
            _dbContext.MovieEntities.Remove(movie);
            _dbContext.SaveChanges();
        }

        public void update(int id, MovieRequest movieRequest)
        {
            var movie = _dbContext.MovieEntities.Find(id);
            if (movie == null)
                _mapper.Map(movieRequest, movie);
            _dbContext.MovieEntities.Update(movie);
            _dbContext.SaveChanges();

        }

    }
}
