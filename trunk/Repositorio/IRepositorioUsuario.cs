using BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleTriad.Repositorio
{
    public class IRepositorioUsuario : RepositorioBase, IRepositorioBase<Model.UsuarioCadastro>
    {
        private static ObservableCollection<Model.UsuarioCadastro> Usuarios =
            new ObservableCollection<Model.UsuarioCadastro>()
            {
                //new Model.UsuarioCadastro() { Nome="Léo", Email="@@" },
                //new Model.UsuarioCadastro() { Nome="Léo2", Email="teste@teste.com" },
                //new Model.UsuarioCadastro() { Nome="Léo3", Email="uniararas@uniararas.br" },
                //new Model.UsuarioCadastro() { Nome="Léo4", Email="leo@leo.com.br" },
            };

        private static int IdAtual = 1;

        public void Deletar(Model.UsuarioCadastro m)
        {

            IRepositorioUsuario.Usuarios.Remove(m);

        }

        public Model.UsuarioCadastro Novo()
        {
            return new Model.UsuarioCadastro() { Id = IdAtual++ };
        }

        public System.Collections.ObjectModel.ObservableCollection<Model.UsuarioCadastro> ObterLista()
        {
            return IRepositorioUsuario.Usuarios;
        }

        public Model.UsuarioCadastro ObterPorId(int Id)
        {
            return IRepositorioUsuario.Usuarios.Where(w => w.Id == Id).FirstOrDefault();
        }

        public void Salvar(Model.UsuarioCadastro m)
        {
            IRepositorioUsuario.Usuarios.Add(m);
        }

        public void TratarConsulta(Model.UsuarioCadastro m)
        {
        }
    }
}
