﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Collektions.Core.Entities
{
    public class House : BaseEntity
    {
        [Required(ErrorMessage = "Please enter Name.")]
        [MaxLength(100)]
        public string Name { get; private set; }

        [MaxLength(350)]
        public string Address { get; private set; }
        private readonly List<HouseMate> _flatMates = new List<HouseMate>();

        public House(string name, string address)
        {
            Name = name;
            Address = address;
        }

       

        public IReadOnlyCollection<HouseMate> HouseMates => _flatMates.AsReadOnly();
    }
}
