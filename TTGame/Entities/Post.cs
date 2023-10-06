using System.ComponentModel.DataAnnotations;

namespace TTGame.Entities
{
    public class Post
    {
        [Key] 
        
        public int PostId { get; set; }
        public string? PostName { get; set; }
        public string? PostKey { get; set; } 
        public string? PostContent { get; set; }
        public string? ImagePost {  get; set; }
        public string? ImagesDetail { get; set; }
        public int? RankPost {  get; set; }
        public int? SlidePost { get; set; }
        public string? PostView { get; set; }
        public string? PostCreate { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public int? GenresId { get; set; }
        public Genres? Genres { get; set; }
        public int? UserId { get; set; }
        public User? User { get; set; }
        public IEnumerable<Coment>? Coments { get; set;}
    }
}
