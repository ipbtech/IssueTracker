using System.ComponentModel.DataAnnotations;

namespace TaskManager.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли должны совпадать")]
        public string ConfirmPassword { get; set; }
    }
}
