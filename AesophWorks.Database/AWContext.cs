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

        public DbSet<Accent> Accents { get; set; }

        public DbSet<CutterButter> CutterButters { get; set; }
        public DbSet<Feet> Feets { get; set; }
        public DbSet<Inlay> Inlays { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WoodType> WoodTypes { get; set; }
        public DbSet<Handle> Handles { get; set; }
        public DbSet<GiftBox> GiftBoxes { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
