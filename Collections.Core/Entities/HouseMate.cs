using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Collektions.Core.Entities
{
    public class HouseMate : BaseEntity
    {
        [Required(ErrorMessage ="Please enter Name.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter a valid Email.")]
        [EmailAddress(ErrorMessage ="Please enter a valid Email.")]
        [MaxLength(200)]
        public string Email { get; set; }


        public int? HouseId { get; set; }

        public House House { get; set; }
    }
}
