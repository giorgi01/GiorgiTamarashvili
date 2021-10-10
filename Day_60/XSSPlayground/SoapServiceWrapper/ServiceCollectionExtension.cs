using Microsoft.Extensions.DependencyInjection;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWrapper
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCalculatoService(this IServiceCollection service, CalculatorServiceConfig config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            if (string.IsNullOrEmpty(config.ServiceEndPoint))
            {
                throw new ArgumentNullException(nameof(config.ServiceEndPoint));
            }

            service.AddTransient<CalculatorService>();

            service.AddTransient<CalculatorSoapClient>(x =>
                new CalculatorSoapClient(CalculatorSoapClient.EndpointConfiguration.CalculatorSoap, config.ServiceEndPoint)
            );

            return service;
        }
    }
}
