using BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Repositorio
{
    public class IRepositorioUsuarioRanking : RepositorioBase, IRepositorioBase<Model.UsuarioRanking>
    {

        public void Deletar(Model.UsuarioRanking m)
        {
            throw new NotImplementedException();
        }

        public Model.UsuarioRanking Novo()
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<Model.UsuarioRanking> ObterLista()
        {
            throw new NotImplementedException();
        }

        public Model.UsuarioRanking ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Model.UsuarioRanking m)
        {
            throw new NotImplementedException();
        }

        public void TratarConsulta(Model.UsuarioRanking m)
        {
            throw new NotImplementedException();
        }
    }
}
