using BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Repositorio
{
    public class IRepositorioUsuario : RepositorioBase, IRepositorioBase<Model.UsuarioCadastro>
    {

        public void Deletar(Model.UsuarioCadastro m)
        {
            throw new NotImplementedException();
        }

        public Model.UsuarioCadastro Novo()
        {
            throw new NotImplementedException();
        }

        public System.Collections.ObjectModel.ObservableCollection<Model.UsuarioCadastro> ObterLista()
        {
            throw new NotImplementedException();
        }

        public Model.UsuarioCadastro ObterPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Model.UsuarioCadastro m)
        {
            throw new NotImplementedException();
        }

        public void TratarConsulta(Model.UsuarioCadastro m)
        {
            throw new NotImplementedException();
        }
    }
}
