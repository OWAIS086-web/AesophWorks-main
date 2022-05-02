using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Entities
{
    public class CuttingBoard : BaseEntity
    {
        public string Name { get; set; }
        public bool JuiceGroove { get; set; }
        public string TypeOfCuttingBoard { get; set; }
        public bool FingerGroove { get; set; }
    }
}
