using InfoClients.Api.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoClients.Api.Domain.Data
{
    public class InfoClientsContext : DbContext
    {
        public InfoClientsContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<SalesRepresentative> SalesRepresentatives { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
    }
}
