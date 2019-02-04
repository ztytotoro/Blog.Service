import axios from "axios";
import Vue from "vue";

export default {
    install($Vue: typeof Vue) {
        $Vue.prototype.$http = axios;
    }
};