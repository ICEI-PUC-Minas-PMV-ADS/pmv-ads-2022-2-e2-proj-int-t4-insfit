using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INSFIT.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Key]
        public int id_cadastro { get; set; }

        [Required(ErrorMessage = "Obrigat�rio inserir um nome")]
        public string name { get; set; }

        [Required(ErrorMessage = "Obrigat�rio inserir um e-mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "Obrigat�rio inserir uma senha")]
        [DataType(DataType.Password)]
        public string senha { get; set; }


        public virtual List<Perfil> Perfil { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        /*Eu criando a rela��o com o perfil
        public int? IdUser { get; set; }
        public Perfil perfil { get; set; }*/

        public enum TipoUsuario
        {
            Aluno,
            Personal
        }

    }
}
