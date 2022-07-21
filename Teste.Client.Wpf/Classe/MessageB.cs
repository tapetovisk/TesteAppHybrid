using System.Windows;
using Teste.View.Page.Interface;

namespace Teste.Client.Wpf.Classe
{
    public class MessageB : IMessageB
    {
        public void Msg() {
            MessageBox.Show("oi");
        }
    }
}
