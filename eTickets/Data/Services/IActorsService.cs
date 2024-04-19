using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        IEnumerable<Actor> GetAll();
        Actor GetById(int id);
        void Create(Actor actor);
        Actor Update(int id, Actor actor);
        void Delete(int id);
    }
}
