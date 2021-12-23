using filmHub.data;
using filmHub.Data.Base;
using filmHub.Models;

namespace filmHub.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}
