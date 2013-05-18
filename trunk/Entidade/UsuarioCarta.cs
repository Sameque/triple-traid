using BaseEntidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class UsuarioCarta : EntidadeBase
    {
        public int Id_Usuario { get; set; }
        public int Id_Carta { get; set; }
        public int Quantidade_Cartas { get; set; }
    }
}
