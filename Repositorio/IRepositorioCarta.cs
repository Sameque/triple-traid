using BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Repositorio
{
    public class IRepositorioCarta : RepositorioBase, IRepositorioBase<Model.Carta>
    {
        private static ObservableCollection<Model.Carta> Cartas = new ObservableCollection<Model.Carta>()
            {
                new Model.Carta(){Nome="Cartinha", Preco= 100, PontoBaixo=10, PontoCima=9, PontoDireita=5, PontoEsquerda=3},
                new Model.Carta(){Nome="Carta de Baraio", Preco= 56, PontoBaixo=6, PontoCima=2, PontoDireita=6, PontoEsquerda=3},
                new Model.Carta(){Nome="Carta Foda", Preco= 2, PontoBaixo=9, PontoCima=8, PontoDireita=1, PontoEsquerda=5}
            };

        public void Deletar(Model.Carta m)
        {
            Cartas.Remove(m);
        }

        public Model.Carta Novo()
        {
            return new Model.Carta();
        }

        public System.Collections.ObjectModel.ObservableCollection<Model.Carta> ObterLista()
        {
            return Cartas;
        }

        public Model.Carta ObterPorId(int Id)
        {
            return Cartas.Where(w => w.Id == Id).FirstOrDefault();
        }

        public void Salvar(Model.Carta m)
        {
            Cartas.Add(m);
        }

        public void TratarConsulta(Model.Carta m)
        {
            
        }
    }
}
