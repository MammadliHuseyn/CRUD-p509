using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _031121CRUD.Models
{
    public class CrudDbContext:DbContext
    {
        public CrudDbContext(DbContextOptions<CrudDbContext> options):base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
