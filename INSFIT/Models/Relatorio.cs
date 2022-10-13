using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace INSFIT.Models
{
    [Table("relatorio")]

    public class Relatorio
    {
        [Key]


        public int Id { get; set; }
        public string nome { get; set; }
        public double peso { get; set; }
        public double altura { get; set; }
    }
}
