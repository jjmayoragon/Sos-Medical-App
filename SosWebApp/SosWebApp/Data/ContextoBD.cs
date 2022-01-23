using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SosWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace SosWebApp.Data
{
    public class ContextoBD : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Ambulance> Ambulances { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Service> Services { get; set; }

        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options) { }
        
    }
}