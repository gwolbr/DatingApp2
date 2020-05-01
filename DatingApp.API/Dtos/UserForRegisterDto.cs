using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]

        [StringLength(8, MinimumLength = 4, ErrorMessage = "The password must be between 4 and 8 characters")]    // "The {0} value cannot exceed {1}} characters"
        public string Password { get; set; }
    }
}