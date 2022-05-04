#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCine.Models;

namespace MvcCine.Data
{
    public class MvcCineContext : DbContext
    {
        public MvcCineContext (DbContextOptions<MvcCineContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCine.Models.Movie> Movie { get; set; }
    }
}
