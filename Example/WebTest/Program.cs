using WebTest.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITestService, TestService>();
builder.Services.AddScoped<ITestService2, TestService>(o => o.GetRequiredService<TestService>());

var app = builder.Build();

app.MapGet("/", (ITestService service) =>
{
    service.GetOne();
    return "Hello World!";
});

app.Run();