using Microsoft.EntityFrameworkCore;
using INSFIT.Models;
namespace INSFIT.Controllers

{
    public class ConexaoBD :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=tcp:insfit.database.windows.net,1433;Initial Catalog=INSFIT;Persist Security Info=False;User 
            ID=adm_insfit;Password={Semestre02@};
            MultipleActiveResultSets=False;
            Encrypt=True;TrustServerCertificate=False;
            Connection Timeout=30;");
        }
        public DbSet<INSFIT.Models.Tela_Inical> Tela_Inical { get; set; }
    }
}
