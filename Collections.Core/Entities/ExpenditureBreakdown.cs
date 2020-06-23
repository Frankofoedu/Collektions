using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Collektions.Core.Entities
{
    public class ExpenditureBreakdown : BaseEntity
    {

        public int Amount { get; set; }
        public int Remainder { get; set; }

        [MaxLength(200)]
        public string HouseMateId { get; set; }
        public int ExpenditureId { get; set; }

        public Enumerations.RepaymentState RepaymentState { get; set; } = Enumerations.RepaymentState.Not_Paid;


        public HouseMate HouseMate { get; set; }
        public Expenditure Expenditure { get; set; }

        public List<RepaymentBreakdown> RepaymentBreakdowns { get; set; } = new List<RepaymentBreakdown>();
    }
}
