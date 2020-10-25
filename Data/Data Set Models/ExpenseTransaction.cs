using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_With_DI_and_Looping_Registration.Data.Data_Set_Models
{
    public class ExpenseTransaction
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public virtual Investor Investor { get; set; }
        public decimal TransactionAmount { get; set; }
        public TransactionFrequency Frequency { get; set; }
        public TransactionType TransactionType { get; set; } = TransactionType.Expense;
    }
}
