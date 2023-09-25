using Topshelf;


var rc = HostFactory.Run(x =>
{
    x.Service<HangfireConsole.HangfireService>(s =>
    {
        s.ConstructUsing(name => new HangfireConsole.HangfireService());
        s.WhenStarted(tc => tc.Start());
        s.WhenStopped(tc => tc.Stop());
    });
    x.RunAsLocalSystem();

    x.SetDescription("Hangfire Topshelf Service");
    x.SetDisplayName("HangfireService");
    x.SetServiceName("HangfireService");
});

