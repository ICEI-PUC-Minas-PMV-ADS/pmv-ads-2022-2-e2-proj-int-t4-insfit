using INSFIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INSFIT.Data.Map
{
    public class MapPerfilRelatorio : IEntityTypeConfiguration<Relatorio>
    {
        public void Configure(EntityTypeBuilder<Relatorio> builder)
        {
            /*Indicando qual e a chave principal*/
            builder.HasKey(x => x.Id_relatorio);
            /*Com o HasOne falo que o perfil tem uma ligação com o feed*/
           // builder.HasOne(x => x.perfil);
        }
    }
}
