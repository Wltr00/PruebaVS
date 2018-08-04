using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities.Common
{
    public class NamedEntity:BaseEntity
    {
        
        public String Name { get; set; }
    }
}
