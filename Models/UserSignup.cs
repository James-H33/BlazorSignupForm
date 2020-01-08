
using System.ComponentModel.DataAnnotations;

namespace BlazorSignupForm.Models
{
    public class UserSignup
    {
        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Must be between 3 and 25 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Must be between 3 and 25 characters.")]
        public string LastName { get; set; }

        [Required]
        [Range(1, 120, ErrorMessage = "Must be an appropriate age.")]
        public int Age { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Must be between 3 and 25 characters.")]
        public string Username { get; set; }

        public Gender Gender { get; set; }
        
        public string Password { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
        
        public string Zip { get; set; }

        [Required]
        public string State { get; set; }

        public string Photo { get; set; }
    }
}
