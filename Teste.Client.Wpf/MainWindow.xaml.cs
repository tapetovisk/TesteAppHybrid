using System.Net.Http;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Teste.Client.Wpf.Classe;
using Teste.View.Page.Interface;

namespace Teste.Client.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IMessageB, MessageB>();
            serviceCollection.AddScoped(sp => new HttpClient());

            serviceCollection.AddWpfBlazorWebView();

            serviceCollection.AddBlazorWebViewDeveloperTools();

            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}
