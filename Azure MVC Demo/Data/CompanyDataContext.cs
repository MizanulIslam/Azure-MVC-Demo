using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure_MVC_Demo.Models;

namespace Azure_MVC_Demo.Data
{
    public class CompanyDataContext : DbContext
    {
        public CompanyDataContext (DbContextOptions<CompanyDataContext> options)
            : base(options)
        {
        }

        public DbSet<Azure_MVC_Demo.Models.Company> Company { get; set; } = default!;
    }
}
