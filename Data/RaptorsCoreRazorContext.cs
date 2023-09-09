using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RaptorsCoreRazor.Models;

namespace RaptorsCoreRazor.Data
{
    public class RaptorsCoreRazorContext : DbContext
    {
        public RaptorsCoreRazorContext (DbContextOptions<RaptorsCoreRazorContext> options)
            : base(options)
        {
        }

        public DbSet<RaptorsCoreRazor.Models.Raptor> Raptor { get; set; } = default!;
    }
}
