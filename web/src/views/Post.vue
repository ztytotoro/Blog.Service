<template>
    <div class="post" v-html="content"></div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";

@Component
export default class Post extends Vue {
    public get content() {
        return this.$md(`# Title=> 1\n\nasdfsafasdfa\n\n* li\n* li\n你好[bing](https://www.bing.com)12321\`code => \`12321\n\nasdfsafasdfa`);
    }
}
</script>

<style lang="less">
.post {
    display: flex;
    flex-direction: column;
    padding: 0 15%;
    & h1 {
        text-align: center;
    }
    & a {
        text-decoration: none;
        color: #1693ef;
        margin: 0 4px;
        &:hover {
            text-decoration: underline;
        }
        &:visited {
            color: #af5a00;
        }
    }
    & code {
        font-family: "Fira code";
        padding: 0px 4px;
        border-radius: 2px;
        background-color: gray;
        color: white;
        font-weight: normal;
        margin: 0 2px;
    }
}
</style>
