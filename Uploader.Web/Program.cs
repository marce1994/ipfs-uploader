﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Uploader.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseSetting(WebHostDefaults.DetailedErrorsKey, "true")
            .UseUrls("http://0.0.0.0:5000")
            .UseStartup<Startup>();
    }
}
