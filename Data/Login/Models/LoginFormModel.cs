using System.ComponentModel.DataAnnotations;

namespace Blazor_With_DI_and_Looping_Registration.Data.Login
{
    public class LoginFormModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
