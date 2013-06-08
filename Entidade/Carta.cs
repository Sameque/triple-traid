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
        
        public int PontoCima { get; set; }
        public int PontoBaixo { get; set; }
        public int PontoDireita { get; set; }
        public int PontoEsquerda { get; set; }
        public int Preco { get; set; }
    }
}
