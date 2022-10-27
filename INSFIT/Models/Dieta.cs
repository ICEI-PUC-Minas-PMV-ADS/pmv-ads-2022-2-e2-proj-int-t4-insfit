
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
namespace INSFIT.Models
{
    [Table("Dieta")]
    public class Dieta
    {
        [Key]
        public int Id_Dieta { get; set; }
        [Required(ErrorMessage = "favor informar qual dieta deseja!")]
        public string Date { get; set; }
        public string CampoImgem { get; set; }
        public string CampodePesquisa { get; set; }
        public DateTime DataPublicacao { get; set; }
        /*Eu criando a rela��o com o perfil*/
     //   public int? IdUser { get; set; }
     //   public Perfil perfil { get; set; }


    }
}
