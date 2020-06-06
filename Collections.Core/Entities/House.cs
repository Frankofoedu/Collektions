using System;
using System.Collections.Generic;
using System.Text;

namespace Collektions.Core.Entities
{
    public class House : BaseEntity
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        private readonly List<FlatMate> _flatMates = new List<FlatMate>();

        public House(string name, string address)
        {
            Name = name;
            Address = address;
        }

       

        public IReadOnlyCollection<FlatMate> FlatMates => _flatMates.AsReadOnly();
    }
}
