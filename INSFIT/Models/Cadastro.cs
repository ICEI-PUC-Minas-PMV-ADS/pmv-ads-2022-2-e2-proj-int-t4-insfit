using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Key]
        public int id_cadastro { get; set; }

        public string name { get; set; }

        public int email { get; set; }

        public int senha { get; set; }

        /*Eu criando a relação com o perfil*/
        public int? IdUser { get; set; }
        public Perfil perfil { get; set; }

    }
}
