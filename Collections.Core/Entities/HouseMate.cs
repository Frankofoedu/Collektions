using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Collektions.Core.Entities
{
    public class HouseMate : IdentityUser
    {
        [MaxLength(200)]
        public override string Id { get; set; }

        [Required(ErrorMessage ="Please enter Name.")]
        [MaxLength(100, ErrorMessage ="Name should not be more than 100 characters.")]
        public string Name { get; set; }


        public int? HouseId { get; set; }

        public House House { get; set; }
    }
}
