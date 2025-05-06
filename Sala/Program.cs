using Microsoft.AspNetCore.Mvc;
using Sala.Core;
using Sala.Database;
using Sala.Infrastructure.Config;
using Sala.Database.Context;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Adăugăm controller-ele MVC
builder.Services.AddControllers();

// 🧩 Suport Swagger (înlocuiește AddOpenApi)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Sala API", Version = "v1" });
});

// 🔐 Autorizare
builder.Services.AddAuthorization();

// 🧠 Înregistrăm DbContext-ul
builder.Services.AddDbContext<SalaDatabaseContext>();

// 🧱 Înregistrăm serviciile și repository-urile
builder.Services.AddCoreServices(); // asta conține deja AddScoped pentru tot

var app = builder.Build();

// 🔧 Inițializăm configurația (inclusiv conexiunea la baza de date)
AppConfig.Init(app.Configuration);

// 🌐 Activăm Swagger în Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "OpenAPI V1");
    });
}

app.UseHttpsRedirection();
app.UseAuthentication(); // dacă ai autentificare, altfel poți șterge
app.UseAuthorization();
app.MapControllers();

app.Run();
