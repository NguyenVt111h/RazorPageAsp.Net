using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using RazorPageMovie2.Models;

namespace RazorPageMovie2.Models
{
    public class RazorPageMovie2Context : DbContext
    {
        public RazorPageMovie2Context (DbContextOptions<RazorPageMovie2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }
    }

}
