using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<Homepage> homepages { get; set; }
        public DbSet<Icon> icons { get; set; }
        public DbSet<Images> images { get; set; }

        public DbSet<Slider> sliders { get; set; }
        public DbSet<Galery> galeries { get; set; }



    }
}