using SCCinamaComum.Enums;
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
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Idade { get; set; }
        public SexoEnum Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Perfil { get; set; }
    }
}
