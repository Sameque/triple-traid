using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Tradutor
{
    public class TradutorUsuarioRanking : BaseTradutor.TradutorBase<Entidade.Usuario, Model.UsuarioRanking>
    {
        public override Model.UsuarioRanking Traduzir(Entidade.Usuario e)
        {
            var m = base.Traduzir(e);
            if (m == null)
                return null;

            m.Nome = e.Nome;
            m.Pontos = e.Pontos;
            m.Vitoria = e.Vitoria;
            m.Derrota = e.Derrota;
            m.Empate = e.Empate;

            return m;
        }
    }
}
