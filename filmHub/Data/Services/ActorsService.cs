using filmHub.data;
using filmHub.Data.Base;
using filmHub.Models;
using Microsoft.EntityFrameworkCore;

namespace filmHub.Data.Services
{
    public class ActorsService : EntityBaseRepository <Actor>,IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
       
      
    }
}
