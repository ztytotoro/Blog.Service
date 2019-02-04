import axios from "axios";

export async function GetPosts() {
    try {
        const response = await axios.get("/api/Posts");
        return response.data;
    } catch (error) {
        console.log(error);
        return {};
    }
}