using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Tradutor
{
    public class TradutorUsuarioCadastro : BaseTradutor.TradutorBase<Entidade.Usuario, Model.UsuarioCadastro>
    {
        public override Model.UsuarioCadastro Traduzir(Entidade.Usuario e)
        {
            var m = base.Traduzir(e);
            if (m == null)
                return null;

            m.Nome = e.Nome;
            m.Email = e.Email;
            m.Senha = e.Senha;

            return m;
        }
        public override Entidade.Usuario Traduzir(Model.UsuarioCadastro m)
        {
            var e = base.Traduzir(m);
            if (e == null)
                return null;

            e.Nome = m.Nome;
            e.Email = m.Email;
            e.Senha = m.Senha;

            return e;
        }
    }
}
