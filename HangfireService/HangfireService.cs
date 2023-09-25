using Hangfire;

namespace HangfireConsole
{
    public class HangfireService
    {
        private BackgroundJobServer _server;

        public HangfireService()
        {
            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                .UseColouredConsoleLogProvider()
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage("Server=localhost;Initial Catalog=pruebas;User ID=sa;Password=Pass@Word;Encrypt=True;TrustServerCertificate=True;");

            _server = new BackgroundJobServer();
            BackgroundJob.Enqueue(() => Console.WriteLine("Hello, world from console and service!"));
        }

        public void Start()
        {
            _server.Start();
        }

        public void Stop()
        {
            _server.Dispose();
        }
    }
}
