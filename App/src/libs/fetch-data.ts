import axios from "axios";
import { API } from "@/configs/index.config";
import { Buffer } from "buffer";
import ApolloClient from "apollo-boost";
import gql from "graphql-tag";

const client = new ApolloClient({
    headers: {
        Authorization: "bearer 4c97252918e1a714ca02b8208eb902ef6ec2bc9c"
    },
    uri: API
});

export async function GetPosts() {
    try {
        // const response = await axios.get(API + "/repos/ztytotoro/blog/contents/Posts");
        const response = await client.query({
            query: gql`
            {
                repository(name: "blog", owner: "ztytotoro") {
                    data: object(expression: "master:Posts") {
                        ... on Tree {
                            posts: entries {
                                name
                                type
                                data: object {
                                    ... on Blob {
                                        text
                                    }
                                }
                            }
                        }
                    }
                }
            }
            `
        });
        // console.log(Buffer.from("SGVsbG8gV29ybGQ=", "base64").toString("utf8"));
        console.log((response.data as any).repository.data.posts);
        return <any []> (response.data as any).repository.data.posts;
    } catch (error) {
        console.log(error);
        return [];
    }
}