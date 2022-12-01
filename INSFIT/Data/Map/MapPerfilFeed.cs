using INSFIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INSFIT.Data.Map
{
    public class MapPerfilFeed : IEntityTypeConfiguration<Feed>
    {
        public void Configure(EntityTypeBuilder<Feed> builder)
        {
            /*Indicando qual e a chave principal*/
            builder.HasKey(x => x.Id_Feed);
            /*Com o HasOne falo que o perfil tem uma ligação com o feed*/
           // builder.HasOne(x => x.perfil);
        }
    }
}
