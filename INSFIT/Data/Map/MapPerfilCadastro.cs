using INSFIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INSFIT.Data.Map
{
    public class MapPerfilCadastro: IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            /*Indicando qual e a chave principal*/
            builder.HasKey(x => x.Id);
            /*Com o HasOne falo que o perfil tem uma ligação com o feed*/
          //  builder.HasOne(x => x.cadastro);
        }
    }
}
