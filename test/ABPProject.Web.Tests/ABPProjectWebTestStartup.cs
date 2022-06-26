using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ABPProject;

public class ABPProjectWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ABPProjectWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
