using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMVC.Models
{
public    class CidadeMetadado
    {
        [MetadataType(typeof(CidadeMetadado))]
        public partial class Cidade
        {
            [Required(ErrorMessage ="Digite a Cidade")]
        }
    }
}
