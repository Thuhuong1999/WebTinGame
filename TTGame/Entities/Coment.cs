using System.ComponentModel.DataAnnotations;

namespace TTGame.Entities
{
    public class Coment
    {
        [Key]  
        
        public int ComentId { get; set; }
        public string? ComentName { get; set; }
        public string? ComentContent { get; set;}
        public string? UserComent { get; set; }
        public string? ImageUser { get; set; }
        public DateTime? ComentCreate {  get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }

    }
}
