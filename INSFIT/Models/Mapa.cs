using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("Mapa")]
    public class Mapa
    {
        [Key]
        public int id { get; set; }

        public string localizacao { get; set; }
        /*Eu criando a relação com o perfil*/
        public int? IdUser { get; set; }
        public Perfil perfil { get; set; }

    }
}
