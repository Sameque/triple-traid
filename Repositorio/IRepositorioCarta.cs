using BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Repositorio
{
    public class IRepositorioCarta : RepositorioBase, IRepositorioBase<Model.Carta>
    {
        public void Deletar(Model.Carta m)
        {
            throw new NotImplementedException();
        }

        public Model.Carta Novo()
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<Model.Carta> ObterLista()
        {
            throw new NotImplementedException();
        }

        public Model.Carta ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Model.Carta m)
        {
            throw new NotImplementedException();
        }

        public void TratarConsulta(Model.Carta m)
        {
            throw new NotImplementedException();
        }
    }
}
