using INSFIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace INSFIT.Data.Map
{
    public class MapPerfilCadastro: IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            /*Indicando qual e a chave principal*/
            builder.HasKey(x => x.id_cadastro);
            /*Com o HasOne falo que o perfil tem uma ligação com o feed
            builder.HasOne(x => x.perfil);*/
        }
    }
}
