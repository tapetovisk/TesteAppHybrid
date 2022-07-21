using Teste.View.Page.Interface;

namespace Teste.Client.Maui.Classe
{
    public class MessageB : IMessageB
    {
        public async void Msg() {

            await App.Current.MainPage.DisplayAlert("Alert", "You have been alerted", "OK");
        }

    }
}
