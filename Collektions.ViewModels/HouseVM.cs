using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Collektions.ViewModels
{
    public class HouseVM
    {
        [Required(ErrorMessage = "Please enter Name.")]
        [MaxLength(100, ErrorMessage = "Maximum length is 100 characters")]
        public string Name { get; set; }

        [MaxLength(350, ErrorMessage ="Maximum length is 350 characters")]
        public string Address { get; set; }

    }
}
