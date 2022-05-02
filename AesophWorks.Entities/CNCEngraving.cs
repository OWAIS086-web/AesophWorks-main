using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class CNCEngraving:BaseEntity
    {
        public string Font { get; set; }
        public string Customization { get; set; }
        public int Quantity { get; set; }
    }
}
