using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using colourapiaugtwentyone.Data;
using colourapiaugtwentyone.Models;
using Microsoft.EntityFrameworkCore;

namespace colourapiaugtwentyone.Repos
{
    public class ColourRepo: IColourRepo
    {
        private readonly AppDbContext _context;

        public ColourRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddColourAsync(Colour colour)
        {
            if(colour == null)
            {
                throw new ArgumentNullException(paramName: nameof(colour));
            }

            await _context.Colours.AddAsync(colour);
        }

        public async Task<ICollection<Colour>> GetAllColoursAsync()
        {
            return await _context.Colours.ToListAsync();
        }

        public async Task<Colour> GetColourAsync(int id)
        {
            return await _context.Colours.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChanges()
        {
            return ( await _context.SaveChangesAsync() >= 0);
        }
    }
}
