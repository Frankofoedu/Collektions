using System;
using System.Collections.Generic;
using System.Text;

namespace Collektions.Core.Entities
{
    public class RepaymentBreakdown : BaseEntity
    {

        public int Amount { get; set; }

        public int RepaymentId { get; set; }
        public int ExpenditureBreakdownId { get; set; }

        public Repayment Repayment { get; set; }
        public ExpenditureBreakdown ExpenditureBreakdown { get; set; }
    }
}
