namespace Blog.Service.Models

type BlogStore() =
    member val ConnectionString: string = null with get, set
    member val DatabaseName: string = null with get, set