using Hangfire;


GlobalConfiguration.Configuration
    .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
    .UseColouredConsoleLogProvider()
    .UseSimpleAssemblyNameTypeSerializer()
    .UseRecommendedSerializerSettings()
    .UseSqlServerStorage("Server=localhost;Initial Catalog=pruebas;User ID=sa;Password=Pass@Word;Encrypt=True;TrustServerCertificate=True;");

BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world!"));

using (var server = new BackgroundJobServer())
{
    Console.ReadLine();
}
