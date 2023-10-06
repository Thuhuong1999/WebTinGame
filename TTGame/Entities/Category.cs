using System.ComponentModel.DataAnnotations;

namespace TTGame.Entities
{
    public class Category
    {
        [Key]  
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Post>? Posts { get; set; }
    }
}
