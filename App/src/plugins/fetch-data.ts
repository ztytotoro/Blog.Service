import * as Get from "@/libs/fetch-data";
import Vue from "vue";

export default {
    install($Vue: typeof Vue) {
        $Vue.prototype.$fetch = Get;
    }
};