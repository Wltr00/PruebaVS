using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Common
{
    public class AuditEntity
    {
        public String CreatedBy { get; set; }
        public String LastEditedBy { get; set; }
        public DateTime LastEdited { get; set; }
    }
}
