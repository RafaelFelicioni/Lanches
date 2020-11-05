using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    { 

        [Required]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [StringLength(
            100,
            ErrorMessage = "The {0} must be at least {2} characters long.",
             MinimumLength = 6)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}
