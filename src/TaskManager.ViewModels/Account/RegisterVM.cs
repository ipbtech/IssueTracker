using System.ComponentModel.DataAnnotations;

namespace TaskManager.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9\\!@#$%^&*()_+\\-=\\[\\]{};':]", ErrorMessage = "Только буквы латинского алфавита, цифры и спецсимволы")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли должны совпадать")]
        public string ConfirmPassword { get; set; }
    }
}
