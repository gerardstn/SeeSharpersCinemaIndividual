using System.ComponentModel.DataAnnotations;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class RegisterUserViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Bevestig je wachtwoord.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "De wachtwoorden komen niet overeen.")]
        public string ConfirmedPassword { get; set; }
    }
}