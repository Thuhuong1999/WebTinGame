using System.ComponentModel.DataAnnotations;

namespace TTGame.Entities
{
    public class User
    {
        [Key]  
        
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }= string.Empty;
        public string? UserPassword { get; set; } = string.Empty;
        public string? UserImage {  get; set; }
        public string? RoleName { get; set;}
        public string? Token { get; set; }
        public DateTime? Expires {  get; set; }
        public string ConfigCode { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
