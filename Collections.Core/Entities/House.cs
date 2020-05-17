using System;
using System.Collections.Generic;
using System.Text;

namespace Collektions.Core.Entities
{
    class House : BaseEntity
    {
        public string Name { get; private set; }
        public string Address { get; private set; }

        public House(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }
}
