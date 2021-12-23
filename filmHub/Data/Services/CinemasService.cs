using filmHub.data;
using filmHub.Data.Base;
using filmHub.Models;

namespace filmHub.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>,ICinemasService
    {
        public CinemasService(AppDbContext context) :base(context)
        {
        }
    }
}
