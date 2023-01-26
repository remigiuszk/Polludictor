using Polludictor.API;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup();

builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddEnvironmentVariables().Build();

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app);

app.Run();


