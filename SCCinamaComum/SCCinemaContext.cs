using Microsoft.EntityFrameworkCore;
using SCCinamaComum.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCinamaComum
{
    public class SCCinemaContext : DbContext
    {
        public SCCinemaContext(DbContextOptions<SCCinemaContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
