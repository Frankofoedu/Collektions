using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Collektions.Core.Entities
{
    class Expenditure : BaseEntity
    {

        [Required(ErrorMessage = "Please enter Name.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(350)]
        public string Description { get; set; }

        [NotMapped]
        public Enumerations.RepaymentState RepaymentState { get; set; } = Enumerations.RepaymentState.Not_Paid;

        [ForeignKey("Spender")]
        public int SpenderId { get; set; }


        public HouseMate Spender { get; set; }


        public List<ExpenditureBreakdown> ExpenditureBreakdowns { get; set; } = new List<ExpenditureBreakdown>();
    }
}
