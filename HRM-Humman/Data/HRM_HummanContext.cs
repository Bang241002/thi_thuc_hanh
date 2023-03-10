using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRM_Humman;

namespace HRM_Humman.Data
{
    public class HRM_HummanContext : DbContext
    {
        public HRM_HummanContext (DbContextOptions<HRM_HummanContext> options)
            : base(options)
        {
        }

        public DbSet<HRM_Humman.Employee> Employee { get; set; } = default!;
    }
}
