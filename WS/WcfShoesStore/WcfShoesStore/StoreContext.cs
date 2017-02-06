using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfShoesStore
{
    public class StoreContext : DbContext
    {
        public DbSet<tbl_Stores> Stores { get; set; }
        public DbSet<tbl_Articles> Articles { get; set; }
        public StoreContext() : base("ShoesStoreDB")
        {



        }
    }
}