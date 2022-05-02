using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class Knives:BaseEntity
    {
        public string TypeOfKnives { get; set; }
        public string TypeOfKnivesOrder { get; set; }
        public bool GiftBox { get; set; }
        public bool Handles { get; set; }
    }
}
