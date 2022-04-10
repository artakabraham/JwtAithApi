using System.ComponentModel.DataAnnotations;

namespace JwtAithApi.Models
{
    public class ChangePasswordModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Current password is required")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "New password is required")]
        public string NewPassword { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "ConfirmNewPassword is required")]
        public string ConfirmNewPassword { get; set; }
    }
}
