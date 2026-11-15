using Test_technical_ziur.application.use_cases;
using Test_technical_ziur.Components;
using Test_technical_ziur.core.utils;
using Test_technical_ziur.domain.respositories;
using Test_technical_ziur.infrastructure.gateways;

DotNetEnv.Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient<HttpRequestApi>(client =>
{
    client.BaseAddress = new Uri("https://mainserver.ziursoftware.com/Ziur.API/basedatos_01/ZiurServiceRest.svc/api/"); // Aqui agregamos la uri a la cual necesitamos hacerle las peticiones
    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Environment.GetEnvironmentVariable("API_BEARER_TOKEN")}"); // Aqui usamos el bearerToken, en este caso lo ponemos en las variables de entorno para mayor seguridad, y solo lo puedan ver personas de la prueba tecnica.
});

// Contrato -> implementación
builder.Services.AddScoped<MovementsRepository, MovementsImplGateway>(); // aqui asignamos la implementacion con el gateway de la api con el contrato principal

// Caso de uso
builder.Services.AddScoped<GetAllMovementsUseCase>(); // añadimos el unico caso de uso

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
