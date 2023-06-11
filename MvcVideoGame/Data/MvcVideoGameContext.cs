using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcVideoGame.Models;

namespace MvcVideoGame.Data
{
    public class MvcVideoGameContext : DbContext
    {
        public MvcVideoGameContext (DbContextOptions<MvcVideoGameContext> options)
            : base(options)
        {
        }

        public DbSet<MvcVideoGame.Models.Game> Game { get; set; } = default!;

        public DbSet<MvcVideoGame.Models.Review> Review { get; set; }
    }
}
