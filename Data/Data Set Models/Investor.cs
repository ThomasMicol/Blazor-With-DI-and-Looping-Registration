using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models
{
    public class Investor
    {
        [Required]
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Id")]
        public virtual IEnumerable<IncomeTransaction> Income { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Id")]
        public virtual IEnumerable<ExpenseTransaction> Expenses { get; set; }
    }
}
