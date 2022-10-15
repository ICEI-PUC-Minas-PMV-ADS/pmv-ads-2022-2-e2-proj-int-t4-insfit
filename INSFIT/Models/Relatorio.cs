using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace INSFIT.Models
{
    [Table("relatorio")]

    public class Relatorio
    {
        [Key]
        public int Id_relatorio { get; set; }

        public string nome { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }

        /*Eu criando a relação com o perfil*/
        public int? IdUser { get; set; }
        public Perfil perfil { get; set; }
    }
}
