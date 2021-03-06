﻿using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace IEvangelist.Blazing.Chuck
{
    public class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args)
            => BlazorWebAssemblyHost.CreateDefaultBuilder()
                                    .UseBlazorStartup<Startup>();
    }
}