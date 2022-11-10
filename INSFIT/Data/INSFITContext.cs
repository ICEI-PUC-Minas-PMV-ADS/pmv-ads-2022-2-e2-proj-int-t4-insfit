using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using INSFIT.Models;
using INSFIT.Data.Map;

namespace INSFIT.Data
{
    public class INSFITContext : DbContext
    {
        public INSFITContext (DbContextOptions<INSFITContext> options)
            : base(options)
        {
        }

        public DbSet<INSFIT.Models.Perfil> Perfil { get; set; } = default!;

        public DbSet<INSFIT.Models.Cadastro> Cadastro { get; set; }

        public DbSet<INSFIT.Models.Feed> Feed { get; set; }

       // public DbSet<INSFIT.Models.Mapa> Mapa { get; set; }

        public DbSet<INSFIT.Models.Dieta> Dieta { get; set; }

       // public DbSet<INSFIT.Models.Mapa> Mapa { get; set; }

        public DbSet<INSFIT.Models.Relatorio> Relatorio { get; set; }

       /*Criando metodo para adicionar as relações da tabela*/
     //   protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
         //   modelBuilder.ApplyConfiguration(new MapPerfilFeed());
           // modelBuilder.ApplyConfiguration(new MapPerfilCadastro());
            //modelBuilder.ApplyConfiguration(new MapPerfilDieta());
            //modelBuilder.ApplyConfiguration(new MapPerfilRelatorio());
           // base.OnModelCreating(modelBuilder);
        //}
    }
}
