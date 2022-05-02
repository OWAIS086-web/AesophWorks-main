using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class ServingTrays:BaseEntity
    {
        public string TypeOfServingTrays { get; set; }
        public string Type { get; set; }
        public bool Handles { get; set; }
    }
}
