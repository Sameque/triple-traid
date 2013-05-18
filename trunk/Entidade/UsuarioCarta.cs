using BaseEntidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    class UsuarioCarta : EntidadeBase
    {
        public int id_Usuario { get; set; }
        [ForeignKey("id_Usuario")]
        public virtual Usuario Usuario { get; set; }

        public int id_Carta { get; set; }
        [ForeignKey("id_Carta")]
        public virtual Carta Carta { get; set; }

        public int Quantidade { get; set; }
    }
}
