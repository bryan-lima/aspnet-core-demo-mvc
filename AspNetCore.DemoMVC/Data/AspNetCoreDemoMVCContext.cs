using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCore.DemoMVC.Models;

namespace AspNetCore.DemoMVC.Data
{
    public class AspNetCoreDemoMVCContext : DbContext
    {
        public AspNetCoreDemoMVCContext (DbContextOptions<AspNetCoreDemoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore.DemoMVC.Models.Filme> Filme { get; set; }
    }
}
