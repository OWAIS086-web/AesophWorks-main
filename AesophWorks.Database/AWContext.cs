using AesophWorks.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AesophWorks.Database
{
    public class AWContext:DbContext,IDisposable
    {
        public AWContext() : base("AWConnectionStrings")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
