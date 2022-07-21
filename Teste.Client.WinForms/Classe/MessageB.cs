using Teste.View.Page.Interface;

namespace Teste.Client.WinForms.Classe
{
    public class MessageB : IMessageB
    {
        public void Msg() {
            MessageBox.Show("oi");
        }
    }
}
