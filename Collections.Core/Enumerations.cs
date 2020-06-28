using System;
using System.Collections.Generic;
using System.Text;

namespace Collektions.Core
{
    public class Enumerations
    {
        public enum RepaymentState
        {
            Not_Paid, Partly_Paid, Fully_Paid
        }
        public enum NotificationType
        {
            Request_to_Join_House, New_Expenditure
        }
        public enum NotificationState
        {
            Not_Done, Done
        }
    }
}
