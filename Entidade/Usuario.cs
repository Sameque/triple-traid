using BaseEntidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Usuario : EntidadeBase
    {
        [MaxLength(40)]
        public string Nome { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Senha { get; set; }

        public int Pontos { get; set; }
        public int Vitoria { get; set; }
        public int Derrota { get; set; }
        public int Empate { get; set; }

        public virtual List<UsuarioCarta> Cartas { get; set; }
    }
}
