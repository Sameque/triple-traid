using BaseEntidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Carta : EntidadeBase
    {
        [MaxLength(40)]
        public string Nome { get; set; }
    }
}
