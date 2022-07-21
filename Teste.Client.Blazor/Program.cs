using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Teste.Client.Blazor.Classe;
using Teste.Core.Service.Controllers;
using Teste.Data.Domain.Interfaces.Controle;
using Teste.View.Page;
using Teste.View.Page.Interface;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IMessageB, MessageB>();
builder.Services.AddScoped<IWeatherForecastControle, WeatherForecastControle>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();
