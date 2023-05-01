using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMsalAuthentication(opt =>
{
	builder.Configuration.Bind("AzureAd", opt.ProviderOptions.Authentication); // Register the configs from appsettings
	opt.ProviderOptions.DefaultAccessTokenScopes.Add("https://graph.microsoft.com/openid"); // Define the OpenId scope
});

await builder.Build().RunAsync();
