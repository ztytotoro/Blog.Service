﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

namespace ApiDocument
{
    public static class OpenApiExtension
    {
        public static void AddApiDocument(this IServiceCollection services)
        {
            services.AddOpenApiDocument();
        }

        public static void AddJson(this IMvcBuilder mvcBuilder)
        {
            mvcBuilder.AddNewtonsoftJson();
        }

        public static void UseApiDocument(this IApplicationBuilder app)
        {
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
