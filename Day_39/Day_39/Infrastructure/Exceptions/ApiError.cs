using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Day_39.Infrastructure.Exceptions
{
    public class ApiError : ProblemDetails
    {
        public const string UnhandledErrorCode = "UnhandledError";

        private HttpContext _context;
        private Exception _exception;

        public string Code { get; set; }
        public string TraceId
        {
            get
            {
                if (Extensions.TryGetValue("TraceId", out var traceId))
                {
                    return (string)traceId;
                }

                return null;
            }
            set => Extensions["TraceId"] = value;
        }
        public LogLevel LogLevel { get; set; }

        public ApiError(HttpContext context, Exception exception)
        {
            _context = context;
            _exception = exception;

            TraceId = context.TraceIdentifier;

            Code = UnhandledErrorCode;
            Status = (int)HttpStatusCode.InternalServerError;
            Title = exception.Message;
            LogLevel = LogLevel.Error;
            Instance = context.Request.Path;

            HandledException((dynamic)exception);
        }

        private void HandledException(LanguageFormatException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.BadRequest;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = exception.Message;
            LogLevel = LogLevel.Information;
        }

        private void HandledException(Exception ex)
        {

        }
    }
}