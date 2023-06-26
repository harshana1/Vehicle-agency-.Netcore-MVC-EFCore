using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agency.Models;

namespace Agency.Data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext (DbContextOptions<VehicleDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agency.Models.Vehicle> Vehicle { get; set; } = default!;
    }
}
