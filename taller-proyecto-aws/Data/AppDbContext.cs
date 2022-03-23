using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using taller_proyecto_aws.Models;

namespace taller_proyecto_aws.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Participantes> participantes { get; set; }

        public AppDbContext(DbContextOptions dco) : base(dco)
        {

        }

    }
}
