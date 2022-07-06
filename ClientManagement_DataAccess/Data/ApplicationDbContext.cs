using ClientManagement_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagement_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Ensures Entity Framework creates a table called Clients based on the model Client.
        public DbSet<Client> Clients { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
