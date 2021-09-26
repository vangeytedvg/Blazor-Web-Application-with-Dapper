using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class DisplayPersonModel
    {
        [Key] public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long")]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(40, ErrorMessage = "Last Name is too long")]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}