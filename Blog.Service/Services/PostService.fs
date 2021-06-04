﻿namespace Blog.Service.Services

open Blog.Service.Models
open MongoDB.Driver
open System

type PostService(store: BlogStore) =
    let client = MongoClient store.ConnectionString
    let db = client.GetDatabase store.DatabaseName
    let _posts = db.GetCollection<Post> "Posts"
    let _postHistory = db.GetCollection<Post> "PostHistory"

    member _.Get() =
        _posts.Find(fun _ -> true).ToList()

    member _.Get(id: string) =
        _posts.Find(fun post -> post.Id = id).FirstOrDefault()

    member this.Create(post: Post): Post =
        if this.CheckName post.Name then
            raise (Exception "name exists")
        else
            _posts.InsertOne({post with CreateTime = DateTime.Now})
            post

    member _.Update(id: string, post: Post) =
        let old = _posts.Find(fun post -> post.Id = id).ToList() |> Seq.head            
        _posts.ReplaceOne ((fun p -> p.Id = id), { post with Ver = post.Ver + 1; LastUpdateTime = DateTime.Now }) |> ignore

    member _.Remove(id: string) =
        _posts.DeleteOne(fun p -> p.Id = id)

    member _.Remove(post: Post) =
        _posts.DeleteOne(fun p -> p.Id = post.Id)

    member _.CheckName(name: string) =
        _posts.Find(fun post -> post.Name = name).CountDocuments() > int64(0)