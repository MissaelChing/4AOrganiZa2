using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using OrganiZa.Domain.Entities;
using OrganiZa.Infraestructure.Data.Configurations;

#nullable disable

namespace OrganiZa.Infraestructure.Data
{
    public partial class OrganizarecContext : DbContext
    {
        public class OrganizarecContextFactory : IDesignTimeDbContextFactory<OrganizarecContext>
        {
            public OrganizarecContext CreateDbContext(string[] args)
            {
                var basePath = Directory.GetCurrentDirectory();
                var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                var configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                    .AddEnvironmentVariables()
                    .Build();

                var builder = new DbContextOptionsBuilder<OrganizarecContext>();
                var connectionString = configuration.GetConnectionString("Missael");

                builder.UseSqlServer(connectionString);

                return new OrganizarecContext(builder.Options);
            }
        }

        public OrganizarecContext(DbContextOptions<OrganizarecContext> options): base(options)
        {

        }


        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<Calendario> Calendarios { get; set; }
        public virtual DbSet<Escuela> Escuelas { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Tutor> Tutors { get; set; }
        public virtual DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }



}

