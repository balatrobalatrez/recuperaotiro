using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using recuperatorio.Models;
using recuperatorio.Repositories;

namespace recuperatorio.Data
{
    public class AplicationDbContext : DbContext

    {
            public DbSet<uno> unos { get; set; }

            public DbSet<@do> dos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("data source=parcial.db");
        }

    }
}
