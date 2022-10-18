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

        [Required(ErrorMessage = "Obrigat�rio inserir um nome")]
        public int email { get; set; }

        [Required(ErrorMessage = "Obrigat�rio inserir uma senha")]
        [DataType(DataType.Password)]
        public int senha { get; set; }

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
