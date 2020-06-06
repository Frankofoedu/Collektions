using System;
using System.Collections.Generic;
using System.Text;

namespace Collektions.Core.Entities
{
    public class FlatMate : BaseEntity
    {
        public int? HouseId { get; private set; }

        public string  Name { get; set; }
    }
}
