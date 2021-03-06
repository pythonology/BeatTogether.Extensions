﻿using Autobus;
using Microsoft.Extensions.Hosting;

namespace BeatTogether.Extensions
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder UseAutobus(this IHostBuilder hostBuilder) =>
            hostBuilder.UseAutobus((hostBuilderContext, builder) =>
                builder
                    .UseSerilog()
                    .UseBinaryRecordsSerialization()
                    .UseRabbitMQTransport(hostBuilderContext.Configuration)
                    .UseServicesFromAllAssemblies()
            );
    }
}
