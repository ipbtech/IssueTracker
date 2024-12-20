﻿using System.ComponentModel.DataAnnotations;

namespace IssueTracker.ViewModels
{
    public class UserGetVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    }

    public class LoginVM
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class RegisterVM
    {
        [Required(ErrorMessage = "The Full Name field is required")]
        [MaxLength(150, ErrorMessage = "Not more 150 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Login field is required")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords should match")]
        public string ConfirmPassword { get; set; }
    }
}
