using System.ComponentModel.DataAnnotations;

namespace SeeSharpersCinema.Models.ViewModel
{
    public class LoginUserViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}