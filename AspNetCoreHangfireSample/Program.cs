using Hangfire;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddHangfire(configuration => configuration
       .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
       .UseSimpleAssemblyNameTypeSerializer()
       .UseRecommendedSerializerSettings()
       .UseSqlServerStorage("Server=localhost;Initial Catalog=pruebas;User ID=sa;Password=Pass@Word;Encrypt=True;TrustServerCertificate=True;"));

builder.Services.AddHangfireServer(); //Comment if web app will only create jobs for another service 

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHangfireDashboard();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
