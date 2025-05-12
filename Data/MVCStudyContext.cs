using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCStudy.Models;

namespace MVCStudy.Data
{
    public class MVCStudyContext : DbContext
    {
        public MVCStudyContext (DbContextOptions<MVCStudyContext> options)
            : base(options)
        {
        }

        public DbSet<MVCStudy.Models.Movie> Movie { get; set; }
    }
}
