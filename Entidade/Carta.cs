using BaseEntidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Entidade
{
    public class Carta : EntidadeBase
    {
        [MaxLength(40)]
        public string Nome { get; set; }
        
        public int ForcaCima { get; set; }
        public int ForcaBaixo { get; set; }
        public int ForcaDireita { get; set; }
        public int ForcaEsquerda { get; set; }
        public int Preco { get; set; }
    }
}
