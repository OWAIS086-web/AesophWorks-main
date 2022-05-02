﻿using AesophWorks.Entities;
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
        public DbSet<AdirondackChair> AdirondackChairs { get; set; }
        public DbSet<ChautericeBoard> ChautericeBoards { get; set; }
        public DbSet<CNCEngraving> CNCEngravings { get; set; }
        public DbSet<Coasters> Coasters { get; set; }
        public DbSet<CutterButter> CutterButters { get; set; }
        public DbSet<CuttingBoard> CuttingBoards { get; set; }
        public DbSet<Feet> Feets { get; set; }
        public DbSet<Inlay> Inlays { get; set; }

        public DbSet<Knives> Knives { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Ornaments> Ornaments { get; set; }
        public DbSet<ServingTrays> ServingTrays { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeddingFavor> WeddingFavors { get; set; }
        public DbSet<WoodType> WoodTypes { get; set; }

    }
}