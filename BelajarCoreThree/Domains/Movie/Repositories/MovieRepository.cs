using BelajarCoreThree.Infrastructures;
using BelajarCoreThree.Infrastructures.DataAccess;
using BelajarCoreThree.Domains.Movie.Entites;
using System.Collections.Generic;
using System.Linq;

namespace BelajarCoreThree.Domains.Movie.Repositories
{
    public class MovieRepository : BaseRepository
    {
        public MovieRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<MovieEntity> GetListMovie()
        {
            return _dbContext.MovieEntities;
        }

    }
}
