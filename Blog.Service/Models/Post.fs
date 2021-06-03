namespace Blog.Service.Models

open System
open MongoDB.Bson.Serialization.Attributes
open MongoDB.Bson

type Post =
    {
      [<BsonId>]
      [<BsonRepresentation(BsonType.ObjectId)>]
      Id: string
      Title: string
      Ver: int
      Name: string
      Tags: string[]
      Author: string
      CreateTime: DateTime
      LastUpdateTime: DateTime
      Content: string }