using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using INSFIT.Models;

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

    }
}
