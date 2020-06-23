using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Collektions.Core.Entities
{
    public class Repayment : BaseEntity
    {

        [MaxLength(350)]
        public string Note { get; set; }

        public int Amount { get; set; }

        [ForeignKey("Payer")]
        [MaxLength(200)]
        public string PayerId { get; set; }

        [ForeignKey("Receiver")]
        [MaxLength(200)]
        public string ReceiverId { get; set; }

        public Enumerations.RepaymentState RepaymentState { get; set; } = Enumerations.RepaymentState.Not_Paid;


        public HouseMate Payer { get; set; }
        public HouseMate Receiver { get; set; }


        public List<RepaymentBreakdown> RepaymentBreakdowns { get; set; } = new List<RepaymentBreakdown>();
    }
}
