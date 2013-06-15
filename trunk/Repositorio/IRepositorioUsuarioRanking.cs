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
        private static System.Collections.ObjectModel.ObservableCollection<Model.UsuarioRanking> Ranking = new System.Collections.ObjectModel.ObservableCollection<Model.UsuarioRanking>()
        {
            new Model.UsuarioRanking()
            {
                Posicao = 001,
                Nome = "Caio",
                Pontos = 100,
                Vitoria = 30          
            },
            new Model.UsuarioRanking()
            {
                Posicao = 002,
                Nome = "Sameque",
                Pontos = 1,
                Vitoria = -3          
            },
            new Model.UsuarioRanking()
            {
                Posicao = 003,
                Nome = "Foguinho",
                Pontos = 100,
                Vitoria = 30          
            },
        };

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
            return Ranking;
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
