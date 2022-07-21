using System.Net.Http;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Teste.Client.Wpf.Classe;
using Teste.Core.Core.Controllers;
using Teste.Data.Domain.Interfaces.Controle;
using Teste.Data.IaC;
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
            serviceCollection.RegisterServices();
            serviceCollection.AddSingleton<IMessageB, MessageB>();
            serviceCollection.AddScoped(sp => new HttpClient());
            serviceCollection.AddSingleton<IWeatherForecastControle, WeatherForecastControle>();

            serviceCollection.AddWpfBlazorWebView();

            serviceCollection.AddBlazorWebViewDeveloperTools();

            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}
