namespace Blog.Service

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Blog.Service.Models
open Blog.Service.Services
open Microsoft.Extensions.Options

type Startup(configuration: IConfiguration) =
    member _.Configuration = configuration

    // This method gets called by the runtime. Use this method to add services to the container.
    member this.ConfigureServices(services: IServiceCollection) =
        services.Configure<BlogStore>(this.Configuration.GetSection "BlogStore") |> ignore
        services.AddSingleton<BlogStore>(fun sp ->
            sp.GetRequiredService<IOptions<BlogStore>>().Value) |> ignore

        services
            .AddSingleton<PostService>() |> ignore

        services.AddCors() |> ignore
        // Add framework services.
        services.AddControllers() |> ignore

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member _.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        if (env.IsDevelopment()) then
            app.UseDeveloperExceptionPage() |> ignore
        app.UseRouting()
           .UseCors(fun p -> p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin() |> ignore)
           .UseAuthorization()
           .UseEndpoints(fun endpoints ->
                 endpoints.MapControllers() |> ignore
             ) |> ignore