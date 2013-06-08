using BaseModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TripleTriad.Model
{
    public class Carta : ModeloBase
    {


        public string Nome
        {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }
        public static readonly DependencyProperty NomeProperty =  DependencyProperty.Register("Nome", typeof(string), typeof(Carta), new PropertyMetadata(string.Empty));

        public int PontoCima
        {
            get { return (int)GetValue(PontoCimaProperty); }
            set { SetValue(PontoCimaProperty, value); }
        }
        public static readonly DependencyProperty PontoCimaProperty = DependencyProperty.Register("PontoCima", typeof(int), typeof(Carta), new PropertyMetadata(0));

        public int PontoBaixo
        {
            get { return (int)GetValue(PontoBaixoProperty); }
            set { SetValue(PontoBaixoProperty, value); }
        }
        public static readonly DependencyProperty PontoBaixoProperty = DependencyProperty.Register("PontoBaixo", typeof(int), typeof(Carta), new PropertyMetadata(0));

        public int PontoDireita
        {
            get { return (int)GetValue(PontoDireitaProperty); }
            set { SetValue(PontoDireitaProperty, value); }
        }
        public static readonly DependencyProperty PontoDireitaProperty = DependencyProperty.Register("PontoDireita", typeof(int), typeof(Carta), new PropertyMetadata(0));

        public int PontoEsquerda
        {
            get { return (int)GetValue(PontoEsquerdaProperty); }
            set { SetValue(PontoEsquerdaProperty, value); }
        }
        public static readonly DependencyProperty PontoEsquerdaProperty = DependencyProperty.Register("PontoEsquerda", typeof(int), typeof(Carta), new PropertyMetadata(0));

        public int Preco
        {
            get { return (int)GetValue(PrecoProperty); }
            set { SetValue(PrecoProperty, value); }
        }
        public static readonly DependencyProperty PrecoProperty = DependencyProperty.Register("Preco", typeof(int), typeof(Carta), new PropertyMetadata(0));
       
    }
}
