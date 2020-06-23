using System;
using System.Collections.Generic;
using System.Text;

namespace Collektions.Core.Entities
{
    public class FlatMate : BaseEntity
    {
        public FlatMate(int houseId, string name)
        {
            HouseId = houseId;
            Name = name;
        }
        public int? HouseId { get; private set; }

        public string  Name { get; private set; }
    }
}
