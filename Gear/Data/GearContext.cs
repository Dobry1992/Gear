using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gear.Models;

namespace Gear.Data
{
    public class GearContext : DbContext
    {
        public GearContext (DbContextOptions<GearContext> options)
            : base(options)
        {
        }

        public DbSet<Gear.Models.Spur> Spur { get; set; }

        public DbSet<Gear.Models.Worm> Worm { get; set; }

        public DbSet<Gear.Models.Bevel> Bevel { get; set; }
    }
}
