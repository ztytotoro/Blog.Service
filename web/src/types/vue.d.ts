import Vue from "vue";
import Md from "marked";

declare module "vue/types/vue" {
    interface Vue {
        $md: typeof Md;
    }
}