import marked from "marked";
import Vue from "vue";

export default {
    install($Vue: typeof Vue) {
        $Vue.prototype.$md = marked;
    }
};