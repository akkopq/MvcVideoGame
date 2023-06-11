using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcVideoGame.Data;
using System;
using System.Linq;

namespace MvcVideoGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcVideoGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcVideoGameContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Dota 2",
                        ReleaseDate = DateTime.Parse("2013-7-9"),
                        Genre = "MOBA",
                        Price = 0.99M
                    },

                    new Game
                    {
                        Title = "GTFO",
                        ReleaseDate = DateTime.Parse("2021-12-10"),
                        Genre = "Horror",
                        Price = 39.99M
                    },

                    new Game
                    {
                        Title = "Dying Light",
                        ReleaseDate = DateTime.Parse("2015-1-26"),
                        Genre = "Zombies",
                        Price = 8.99M
                    },

                    new Game
                    {
                        Title = "Dying Light 2",
                        ReleaseDate = DateTime.Parse("2022-2-4"),
                        Genre = "Zombies",
                        Price = 29.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}