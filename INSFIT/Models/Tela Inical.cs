using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("cadastro")]
    public class Tela_Inical
    {
        [Key]
        public int id { get; set; }
    }
}
