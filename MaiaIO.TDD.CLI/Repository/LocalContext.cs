﻿using MaiaIO.TDD.CLI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MaiaIO.TDD.CLI.Repository
{
    public class LocalContext : DbContext
    {

        protected readonly IConfiguration _configuration;

        public DbSet<User> Users { get; set; }
        public DbSet<Aplicacao> Aplicacoes { get; set; }


        public LocalContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseInMemoryDatabase("DbMock");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
