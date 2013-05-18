using MahApps.Metro.Controls;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aplicacao
{
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var campo = new Campo();

            campo.CartasJogador1 = new ObservableCollection<Carta>();
            campo.CartasJogador2 = new ObservableCollection<Carta>();

            var random = new Random();

            for (int i = 1; i <= 5; i++)
            {
                campo.CartasJogador1.Add(new Carta()
                {
                    Id = i,
                    PontoBaixo = random.Next(1, 11),
                    PontoCima = random.Next(1, 11),
                    PontoDireita = random.Next(1, 11),
                    PontoEsquerda = random.Next(1, 11),
                });
            }

            for (int i = 6; i <= 10; i++)
            {
                campo.CartasJogador2.Add(new Carta()
                {
                    Id = i,
                    PontoBaixo = random.Next(1, 11),
                    PontoCima = random.Next(1, 11),
                    PontoDireita = random.Next(1, 11),
                    PontoEsquerda = random.Next(1, 11),
                });
            }

            this.DataContext = campo;
        }
    }
}
