using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public int email { get; set; }

        public int senha { get; set; }
    }
    -
    //Teste comit
}
