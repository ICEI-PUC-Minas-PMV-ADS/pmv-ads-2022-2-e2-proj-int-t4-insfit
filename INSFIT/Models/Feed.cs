
using System.ComponentModel.DataAnnotations;
using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace INSFIT.Models
{
    public class Feed
    {
        [Key]
        public int Id_Feed { get; set; }
        public string CampoTexto { get; set; }
        public string CampoImgem { get; set; }
        public string CampodePesquisa { get; set; }
        public string Data { get; set; }
        public string Comentario { get; set; }
    }
}
