using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Teste.Client.Blazor.Classe;
using Teste.View.Page;
using Teste.View.Page.Interface;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddSingleton<IMessageB, MessageB>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
