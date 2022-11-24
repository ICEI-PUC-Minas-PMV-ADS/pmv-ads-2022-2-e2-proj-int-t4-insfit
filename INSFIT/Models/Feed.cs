
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace INSFIT.Models
{
    [Table("Feed")]
    public class Feed
    {
        [Key]
        public int Id_Feed { get; set; }
        public string CampoTexto { get; set; }
        public string CampoImgem { get; set; }
      //  public string CampodePesquisa { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Comentario { get; set; }
      //  public int? IdUser { get; set; }
      //  public Perfil perfil { get; set; }
    }
}
