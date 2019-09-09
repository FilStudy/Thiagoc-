using _06_Fiap.Web.aspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.aspNet.Persistence
{
    public class CorridaContext : DbContext
    {
        public DbSet<Corrida> Corridas { get; set; }
        public CorridaContext(DbContextOptions options) : base(options)
        {

        }
    }
}
