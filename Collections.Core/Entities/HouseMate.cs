using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Collektions.Core.Entities
{
    public class HouseMate : IdentityUser
    {
        [Required(ErrorMessage ="Please enter Name.")]
        [MaxLength(100)]
        public string Name { get; set; }


        public int? HouseId { get; set; }

        public House House { get; set; }
    }
}
