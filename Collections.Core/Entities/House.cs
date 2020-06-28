using Collektions.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Collektions.Core.Entities
{
    public class House : BaseEntity, IAggregateRoot
    {
        [Required(ErrorMessage = "Please enter Name.")]
        [MaxLength(100)]
        public string Name { get; private set; }

        [MaxLength(350)]
        public string Address { get; private set; }



        private readonly List<HouseMate> _houseMates = new List<HouseMate>();

        public House(string name, string address)
        {
            Name = name;
            Address = address;
        }

       
        public IReadOnlyCollection<HouseMate> HouseMates => _houseMates.AsReadOnly();
    }
}
