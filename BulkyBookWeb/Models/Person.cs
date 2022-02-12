using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Person
    {
        [Key]    
        public int Id { get; set; }
        [Required]
        public string firstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string TelephoneNumber { get; set; } = default!;
        public DateTime CreateDateTime { get; set; } = DateTime.Now; //sets default
    }
}
