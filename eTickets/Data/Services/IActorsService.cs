using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task CreateAsync(Actor actor);
        Actor UpdateAsync(int id, Actor actor);
        void DeleteAsync(int id);
    }
}
