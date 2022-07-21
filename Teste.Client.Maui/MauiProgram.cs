using Teste.Client.Maui.Classe;
using Teste.Core.Core.Controllers;
using Teste.Data.Domain.Interfaces.Controle;
using Teste.Data.IaC;
using Teste.View.Page.Interface;

namespace Teste.Client.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddSingleton<IMessageB, MessageB>();
            builder.Services.RegisterServices();
            builder.Services.AddSingleton<IWeatherForecastControle, WeatherForecastControle>();

            builder.Services.AddScoped(sp => new HttpClient());

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            return builder.Build();
        }
    }
}