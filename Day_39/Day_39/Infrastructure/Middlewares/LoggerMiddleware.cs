using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggerMiddleware> _logger;
        public LoggerMiddleware(RequestDelegate next, ILogger<LoggerMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            await LogRequestInfo(context);
            await LogResponseInfo(context);
            await _next.Invoke(context);
        }

        private async Task LogRequestInfo(HttpContext context)
        {
            _logger.LogInformation($"Request path: {context.Request.Path.Value}");
            _logger.LogInformation($"Request content-type: {context.Request.ContentType}");
            _logger.LogInformation($"Request query string: {context.Request.QueryString}");
            _logger.LogInformation($"Request method: {context.Request.Method}");
            string body;
            using (StreamReader reader = new StreamReader(context.Request.Body))
            {
                body = await reader.ReadToEndAsync();
            }
            _logger.LogInformation($"Request body: {body}");
        }

        private Task LogResponseInfo(HttpContext context)
        {
            _logger.LogInformation($"Response status code: {context.Response.StatusCode}");
            _logger.LogInformation($"Response content-type: {context.Response.ContentType}");
            return Task.CompletedTask;
        }
    }
}