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
        public override Entidade.Usuario Traduzir(Model.UsuarioRanking m)
        {
            var e = base.Traduzir(m);
            if (e == null)
                return null;

            e.Nome = m.Nome;
            e.Pontos = m.Pontos;
            e.Vitoria = m.Vitoria;
            e.Derrota = m.Derrota;
            e.Empate = m.Empate;

            return e;
        }
    }
}
