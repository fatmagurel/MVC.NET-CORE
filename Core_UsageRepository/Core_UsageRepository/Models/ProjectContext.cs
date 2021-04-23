using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_UsageRepository.Models
{
    public class ProjectContext :DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
            //connection string
            //startup.cs nin içerisinde tanımla
        }

        public DbSet<Product> Products { get; set; }

    }
}
