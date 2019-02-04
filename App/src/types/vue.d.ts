import Vue from "vue";
import Md from "marked";
import Axios from "axios";
import * as Get from "@/libs/fetch-data";

declare module "vue/types/vue" {
    interface Vue {
        $md: typeof Md;
        $http: typeof Axios;
        $fetch: typeof Get;
    }
}