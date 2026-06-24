using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_BackEnd_Final.Models;

namespace Projeto_BackEnd_Final.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) :base(options)
        {
            
        }
        public DbSet<Responsavel> TB_RESPONSAVEL  { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Responsavel>().ToTable("TB_RESPONSAVEL");
             
            modelBuilder.Entity<Responsavel>().HasData
            (

                 new Responsavel()  {Id = 1}, 
                 new Responsavel()  {Id = 2},
                 new Responsavel()  {Id = 3},
                 new Responsavel()  {Id = 4}

            );
            
                
            
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }

    }
}