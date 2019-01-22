<template>
    <div class="post" v-html="content"></div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";

@Component
export default class Post extends Vue {
    public get content() {
        return this.$md(`# Title=> 1\n* li\n* li\n你好`);
    }
}
</script>

<style lang="less">
.post {
    display: flex;
    flex-direction: column;
    & h1 {
        font-weight: 500;
        text-align: center;
    }
}
</style>
