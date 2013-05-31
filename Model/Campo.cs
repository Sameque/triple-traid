using BaseModelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TripleTriad.Model
{
    public class Campo : ModeloBase
    {
        public CartaCampo[,] CartasEmCampo
        {
            get { return (CartaCampo[,])GetValue(CartasEmCampoProperty); }
            set { SetValue(CartasEmCampoProperty, value); }
        }
        public static readonly DependencyProperty CartasEmCampoProperty = DependencyProperty.Register("CartasEmCampo", typeof(CartaCampo[,]), typeof(Campo), new PropertyMetadata(null));

        public Carta CartaAtualJogador1
        {
            get { return (Carta)GetValue(CartaAtualJogador1Property); }
            set { SetValue(CartaAtualJogador1Property, value); }
        }
        public static readonly DependencyProperty CartaAtualJogador1Property = DependencyProperty.Register("CartaAtualJogador1", typeof(Carta), typeof(Campo), new PropertyMetadata(null));

        public ObservableCollection<Carta> CartasJogador1
        {
            get { return (ObservableCollection<Carta>)GetValue(CartasJogador1Property); }
            set { SetValue(CartasJogador1Property, value); }
        }
        public static readonly DependencyProperty CartasJogador1Property = DependencyProperty.Register("CartasJogador1", typeof(ObservableCollection<Carta>), typeof(Campo), new PropertyMetadata(null));

        public Carta CartaAtualJogador2
        {
            get { return (Carta)GetValue(CartaAtualJogador2Property); }
            set { SetValue(CartaAtualJogador2Property, value); }
        }
        public static readonly DependencyProperty CartaAtualJogador2Property = DependencyProperty.Register("CartaAtualJogador2", typeof(Carta), typeof(Campo), new PropertyMetadata(null));


        public ObservableCollection<Carta> CartasJogador2
        {
            get { return (ObservableCollection<Carta>)GetValue(CartasJogador2Property); }
            set { SetValue(CartasJogador2Property, value); }
        }
        public static readonly DependencyProperty CartasJogador2Property = DependencyProperty.Register("CartasJogador2", typeof(ObservableCollection<Carta>), typeof(Campo), new PropertyMetadata(null));
    }
}
