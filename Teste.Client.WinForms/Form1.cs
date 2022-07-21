using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using Teste.View.Page.Interface;
using Teste.View.Page;
using Teste.Client.WinForms.Classe;
using Teste.Data.Domain.Interfaces.Controle;
using Teste.Core.Core.Controllers;
using Teste.Data.IaC;

namespace Teste.Client.WinForms
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();

            var services = new ServiceCollection();
            services.RegisterServices();
            services.AddSingleton<IMessageB, MessageB>();
            services.AddScoped(sp => new HttpClient());
            services.AddSingleton<IWeatherForecastControle, WeatherForecastControle>();

            services.AddWindowsFormsBlazorWebView();

            services.AddBlazorWebViewDeveloperTools();

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");

        }

        private void blazorWebView1_Click(object sender, EventArgs e) {

        }
    }
}