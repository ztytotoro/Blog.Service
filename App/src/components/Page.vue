<template>
    <div class="page" v-cloak>
        <Navigation></Navigation>
        
        <div class="main">
            <slot></slot>
        </div>
        
        <Footer></Footer>
    </div>
</template>


<script lang="tsx">
import { Component, Vue } from "vue-class-decorator";
import { CreateElement, VNode } from "vue";
import Navigation from "./Navigation.vue";
import Footer from "./Footer.vue";

@Component({
    components: {
        Navigation,
        Footer
    }
})
export default class Page extends Vue {
}
</script>

<style lang="less">
[v-cloak] {
  display: none;
}
.page {
    display: flex;
    flex-direction: column;
    height: 100%;
}
.main {
    flex: 1;
}
</style>
