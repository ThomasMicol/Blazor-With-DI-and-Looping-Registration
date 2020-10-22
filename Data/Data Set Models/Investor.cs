using System.ComponentModel.DataAnnotations;

namespace Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models
{
    public class Investor
    {
        [Required]
        public long Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string Name { get; set; }
        public decimal Income { get; set; }
    }
}
