using filmHub.data;
using filmHub.Data.Base;
using filmHub.Models;

namespace filmHub.Data.Services
{
    public class MoviesService:EntityBaseRepository<Movie>,IMoviesService
    {
        public MoviesService(AppDbContext context):base(context)
        {

        }
    }
}
