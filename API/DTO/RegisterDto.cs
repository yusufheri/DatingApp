using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class RegisterDto
    {
        [Required(ErrorMessage="* The Username field is required.")]
        [StringLength(255, MinimumLength = 4, ErrorMessage ="* The Username must be least 4 caracters in length.")]
        public string Username { get; set; }

        [Required(ErrorMessage="* The Password field is required.")]
        [StringLength(255, MinimumLength = 6, ErrorMessage ="* The {0} Password must be least 6 caracters in length.")]
        public string Password { get; set; }
    }
}