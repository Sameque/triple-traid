using BaseModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TripleTriad.Model
{
    public class UsuarioCadastro : ModeloBase
    {


        public string Nome
        {
            get { return (string)GetValue(NomeProperty); }
            set { SetValue(NomeProperty, value); }
        }
        public static readonly DependencyProperty NomeProperty = DependencyProperty.Register("Nome", typeof(string), typeof(UsuarioCadastro), new PropertyMetadata(string.Empty));



        public string Email
        {
            get { return (string)GetValue(EmailProperty); }
            set { SetValue(EmailProperty, value); }
        }
        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register("Email", typeof(string), typeof(UsuarioCadastro), new PropertyMetadata(string.Empty));



        public string Senha
        {
            get { return (string)GetValue(SenhaProperty); }
            set { SetValue(SenhaProperty, value); }
        }
        public static readonly DependencyProperty SenhaProperty =
            DependencyProperty.Register("Senha", typeof(string), typeof(UsuarioCadastro), new PropertyMetadata(string.Empty));


    }
}
