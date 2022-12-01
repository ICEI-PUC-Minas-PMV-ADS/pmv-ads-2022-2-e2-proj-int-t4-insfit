using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("contatos")]
    public class Contatos
    {
        [Key]
        public int id_contato { get; set; }
        public string Nome { get; set; }    

        public string contato { get; set; }

        public int? idUser { get; set; }  
        public Cadastro usuario { get; set; }
    }
}
