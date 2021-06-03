namespace Blog.Service.Controllers

open Microsoft.AspNetCore.Mvc
open Blog.Service.Services
open Blog.Service.Models

[<ApiController>]
[<Route("api/[controller]")>]
type PostController (_postService: PostService) =
    inherit ControllerBase()

    [<HttpGet>]
    member this.Get() =
        this.Ok(_postService.Get())

    [<HttpPost>]
    member this.Create(post: Post) =
        this.Ok(_postService.Create(post)) :> IActionResult