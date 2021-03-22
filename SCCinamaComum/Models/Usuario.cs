using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCCinamaComum.Models
{
    public class Usuario
    {
        [Key]
        public long IDUsuario { get; set; }
        public string Nome { get; set; }
    }
}
