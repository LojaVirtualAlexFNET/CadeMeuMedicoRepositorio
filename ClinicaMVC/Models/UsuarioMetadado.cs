using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMVC.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario
    {
    }

    public class UsuarioMetadado
    {
        [Required(ErrorMessage ="Digite o Nome do Usuário")]
        [StringLength(80, ErrorMessage ="O Nome de possuir no maximo 80 caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Digite o Login")]
        [StringLength(30,ErrorMessage =  "O Login pode ter no maximo 30 caracteres")]
        public string Login { get; set; }
        [Required(ErrorMessage ="o E-mail e obrigatório")]
        [StringLength(100,ErrorMessage ="O E-mail deve possuir no máximo 100 caracteres")]
        public string Email { get; set; }
    }
}
