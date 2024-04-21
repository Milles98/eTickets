using eTickets.Data;
using eTickets.Data.Base;
using eTickets.Models;
using Library.Services.Interfaces;

namespace Library.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
