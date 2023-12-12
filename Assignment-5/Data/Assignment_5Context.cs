using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_5.Models;

namespace Assignment_5.Data
{
    public class Assignment_5Context : DbContext
    {
        public Assignment_5Context (DbContextOptions<Assignment_5Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment_5.Models.Genre> Genre { get; set; } = default!;

        public DbSet<Assignment_5.Models.Artist>? Artist { get; set; }

        public DbSet<Assignment_5.Models.Song>? Song { get; set; }

        public DbSet<Assignment_5.Models.Media>? Media { get; set; }
    }
}
