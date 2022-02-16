using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MonitoriaMVC.Models
{
    public class ClienteDbContext : DbContext 
    {
        public ClienteDbContext(DbContextOptions<ClienteDbContext> options):base(options)
        {

        }

        public DbSet<Cliente> clientes { get; set; }

    }
}
