using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Inventory
{
    public class Item:NamedEntity
    {
        public Double Price { get; set; }
        public String Description { get; set; }
        public int Quantity { get; set; }
    }
}
