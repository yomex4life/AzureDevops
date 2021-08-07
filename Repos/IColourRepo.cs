using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using colourapiaugtwentyone.Models;

namespace colourapiaugtwentyone.Repos
{
    public interface IColourRepo
    {
        Task AddColourAsync(Colour colour);
        Task<bool> SaveChanges();
        Task<ICollection<Colour>> GetAllColoursAsync();
        Task<Colour> GetColourAsync(int id);
    }
}
