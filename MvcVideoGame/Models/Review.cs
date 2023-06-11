using System.ComponentModel.DataAnnotations;

namespace MvcVideoGame.Models
{
    public class Review
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public DateTime ReviewDate { get; set; }
        public int GameId { get; set; }
        public Review()
        {
            ReviewDate = DateTime.Now;
        }
        

    }
}