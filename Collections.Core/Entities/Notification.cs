using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Collektions.Core.Entities
{
    public class Notification:BaseEntity
    {
        [MaxLength(350)]
        public string Message { get; set; }
        [ForeignKey("Sender")]
        [MaxLength(200)]
        public string SenderId { get; set; }
        [ForeignKey("Reciever")]
        [MaxLength(200)]
        public string ReceiverId { get; set; }

        public DateTime DateAdded { get; set; }

        public Enumerations.NotificationType NotificationType { get; set; }
        public Enumerations.NotificationState NotificationState { get; set; }

        public HouseMate Sender { get; set; }
        public HouseMate Reciever { get; set; }
    }
}
