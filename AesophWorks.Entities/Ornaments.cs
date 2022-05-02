using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class Ornaments:BaseEntity
    {
        public string Shape { get; set; }
        public string Hanger { get; set; }
        public string Font { get; set; }
        public string Customization { get; set; }
    }
}
