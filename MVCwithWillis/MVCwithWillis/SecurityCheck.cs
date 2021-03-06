﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace MVCwithWillis
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class SecurityCheck
    {
        private readonly RequestDelegate _next;

        public SecurityCheck(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
           // logic
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class SecurityCheckExtensions
    {
        public static IApplicationBuilder UseSecurityCheck(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SecurityCheck>();
        }
    }
}
