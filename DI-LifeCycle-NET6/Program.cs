// See https://aka.ms/new-console-template for more information

using DI_LifeCycle_NET6.Interface;
using DI_LifeCycle_NET6.LifeCycles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder();

//builder.ConfigureServices(services => services.AddSingleton<ILifeCycle, ExampleSingleton>());
//builder.ConfigureServices(services => services.AddScoped<ILifeCycle, ExampleScoped>());
builder.ConfigureServices(services => services.AddTransient<ILifeCycle, ExampleTransient>());

var app = builder.Build();

app.Services.GetService<ILifeCycle>().Run();

app.Services.GetService<ILifeCycle>().Run();


Console.ReadKey();
