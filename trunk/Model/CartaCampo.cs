using BaseModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TripleTriad.Model
{
    public class CartaCampo : ModeloBase
    {
        public Carta Carta
        {
            get { return (Carta)GetValue(CartaProperty); }
            set { SetValue(CartaProperty, value); }
        }
        public static readonly DependencyProperty CartaProperty = DependencyProperty.Register("Carta", typeof(Carta), typeof(CartaCampo), new PropertyMetadata(null));

        public DonoDaCarta DonoDaCarta
        {
            get { return (DonoDaCarta)GetValue(DonoDaCartaProperty); }
            set { SetValue(DonoDaCartaProperty, value); }
        }
        public static readonly DependencyProperty DonoDaCartaProperty = DependencyProperty.Register("DonoDaCarta", typeof(DonoDaCarta), typeof(CartaCampo), new PropertyMetadata(DonoDaCarta.Jogador1));
    }
}
