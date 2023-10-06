using System.ComponentModel.DataAnnotations;

namespace TTGame.Entities
{
    public class Genres
    {
        [Key]  
        
        public int GenresId { get; set; }
        public string? GenresName { get; set; }
        public IEnumerable<Post>? Posts { get; set; }
    }
}
