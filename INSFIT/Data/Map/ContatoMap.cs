using INSFIT.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace INSFIT.Data.Map
{
    public class ContatoMap : IEntityTypeConfiguration<Contatos>
    {
        public void Configure(EntityTypeBuilder<Contatos> builder)
        {
            builder.HasKey(x => x.id_contato);
            builder.HasOne(x=>x.usuario);
        }
    }
}
