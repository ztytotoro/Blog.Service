import axios from "axios";
import { API } from "@/configs/index.config";

export async function GetPosts() {
    try {
        const response = await axios.get(API + "/api/Post");
        return response.data;
    } catch (error) {
        console.log(error);
        return {};
    }
}