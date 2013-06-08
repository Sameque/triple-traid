using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Tradutor
{
    public class TradutorCarta : BaseTradutor.TradutorBase<TripleTriad.Entidade.Carta,TripleTriad.Model.Carta>
    {
        public override Model.Carta Traduzir(Entidade.Carta e)
        {
            var m = base.Traduzir(e);
            if (m == null)     
               return null;
            m.Nome = e.Nome;
            m.Preco = e.Preco;
            m.PontoBaixo = e.PontoBaixo;
            m.PontoCima = e.PontoCima;
            m.PontoEsquerda = e.PontoEsquerda;
            m.PontoDireita = e.PontoDireita;
            return m;
        }

        public override Entidade.Carta Traduzir(Model.Carta m)
        {
            var e = base.Traduzir(m);
            e.Nome = m.Nome;
            e.Preco = m.Preco;
            e.PontoBaixo = m.PontoBaixo;
            e.PontoCima = m.PontoCima;
            e.PontoEsquerda = m.PontoEsquerda;
            e.PontoDireita = m.PontoDireita;
            return e;
        }
    }
}
