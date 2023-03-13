using System.ComponentModel.DataAnnotations;

namespace SocialNetworkWeb.ViewModels.Account
{
    public class LoginViewModel
    {
      
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 5)]
        public string Password { get; set; }
        public bool RememberMe { get; internal set; }
        public string ReturnUrl { get; internal set; }
    }
}
