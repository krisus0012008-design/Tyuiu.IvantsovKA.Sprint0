using Tyuiu.IvantsovKA.Sprint0.Task0.V0;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
