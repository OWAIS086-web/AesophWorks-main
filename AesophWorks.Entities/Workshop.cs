using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class Workshop : BaseEntity
    {
        public DateTime Date { get; set; }
        public Double Price { get; set; }
    }
}
