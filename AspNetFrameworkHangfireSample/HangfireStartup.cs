﻿using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFrameworkHangfireSample
{
    public class HangfireStartup
    {
        public static void ConfigureHangfire()
        {
            GlobalConfiguration.Configuration
                .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
                .UseSimpleAssemblyNameTypeSerializer()
                .UseRecommendedSerializerSettings()
                .UseSqlServerStorage("Server=localhost;Initial Catalog=pruebas;User ID=sa;Password=Pass@Word;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}