using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Key]
        public int id_cadastro { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir um nome")]
        public string name { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir um e-mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string email { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir uma senha")]
        [DataType(DataType.Password)]
        public string senha { get; set; }


       //public virtual List<Contatos> Contatos { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        public ICollection<Perfil> Perfil { get; set; }=new List<Perfil>(); 

        /*Eu criando a relação com o perfil
        public int? IdUser { get; set; }
        public Perfil perfil { get; set; }*/

        public enum TipoUsuario
        {
            Aluno,
            Personal
        }

    }
}
