using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaMVC.Models
{
    public class EspecialidadeMetadado
    {
        [MetadataType(typeof(EspecialidadeMetadado))]
        public partial class Especialidade
        {
        }
        public string Nome { get; set; }
    }
}
