using eTickets.Data;
using eTickets.Data.Base;
using eTickets.Models;
using Library.Services.Interfaces;

namespace Library.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
