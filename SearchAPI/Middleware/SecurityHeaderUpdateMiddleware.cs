﻿namespace SearchAPI.Middleware
{
    using Microsoft.Extensions.Logging;
    using Serilog;

    public class SecurityHeadersMiddleware
    {
        private readonly RequestDelegate _next;


        public SecurityHeadersMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {

            context.Response.Headers.Add("Strict-Transport-Security", "max-age=31536000; includeSubDomains");
            context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            context.Response.Headers.Add("X-Frame-Options", "DENY");
            context.Response.Headers.Add("Referrer-Policy", "no-referrer");
            context.Response.Headers.Add("X-Xss-Protection", "1; mode=block");


            await _next(context);

        }
    }
}