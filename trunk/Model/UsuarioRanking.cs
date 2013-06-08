using BaseModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TripleTriad.Model
{
    public class UsuarioRanking : ModeloBase
    {
        public string Nome
        {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }
        public static readonly DependencyProperty NomeProperty = DependencyProperty.Register("Nome", typeof(string), typeof(UsuarioRanking), new PropertyMetadata(string.Empty));

        public int Pontos
        {
            get { return (int)GetValue(PontosProperty); }
            set { SetValue(PontosProperty, value); }
        }
        public static readonly DependencyProperty PontosProperty = DependencyProperty.Register("Pontos", typeof(int), typeof(UsuarioRanking), new PropertyMetadata(0));

        public int Vitoria
        {
            get { return (int)GetValue(VitoriaProperty); }
            set { SetValue(VitoriaProperty, value); }
        }
        public static readonly DependencyProperty VitoriaProperty = DependencyProperty.Register("Vitoria", typeof(int), typeof(UsuarioRanking), new PropertyMetadata(0));

        public int Empate
        {
            get { return (int)GetValue(EmpateProperty); }
            set { SetValue(EmpateProperty, value); }
        }
        public static readonly DependencyProperty EmpateProperty = DependencyProperty.Register("Empate", typeof(int), typeof(UsuarioRanking), new PropertyMetadata(0));

        public int Derrota
        {
            get { return (int)GetValue(DerrotaProperty); }
            set { SetValue(DerrotaProperty, value); }
        }
        public static readonly DependencyProperty DerrotaProperty = DependencyProperty.Register("Derrota", typeof(int), typeof(UsuarioRanking), new PropertyMetadata(0));
    }
}
