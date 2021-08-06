using Day_36.Exceptions;
using DependencyInjectionDemo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class ApiError : ProblemDetails
    {
        public string StackTrace;
        public LogLevel LogLevel { get; set; }

        public ApiError(HttpContext context, Exception exception)
        {
            StackTrace = exception.StackTrace;
            Status = (int)HttpStatusCode.InternalServerError;
            Title = exception.Message;
            LogLevel = LogLevel.Error;
            Instance = context.Request.Path;
        }
    }
}