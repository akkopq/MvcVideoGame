﻿using System.ComponentModel.DataAnnotations;

namespace MvcVideoGame.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
        public List<Review> Review { get; set; }
    }
}
