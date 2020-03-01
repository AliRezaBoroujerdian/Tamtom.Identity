using System.ComponentModel.DataAnnotations;


namespace Tamtom.Identity.Authentication.Models
{
    public class LoginModel
    {
        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        public string Platform { get; set; }

        public string OS { get; set; }

        public string Model { get; set; }

        public string Version { get; set; }

        public string IP { get; set; }
    }
}
