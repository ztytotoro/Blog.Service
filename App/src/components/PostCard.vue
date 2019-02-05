<template>
    <div class="post-card">
        <div class="post-card-title">
            <h1 @click="Navigate">Hello World!</h1>
        </div>
        <div class="post-card-description">
            <span class="post-card-time">2019.2.5 18:31</span>
        </div>
        <div class="post-card-tags">
            <span class="tag">测试</span>
            <span class="tag">测试2</span>
        </div>
    </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";

@Component
export default class PostCard extends Vue {
    public Navigate() {
        this.$router.push("/post");
    }
}
</script>


<style lang="less">
.post-card {
    display: flex;
    min-height: 120px;
    background-color: rgb(220, 220, 220);
    flex-direction: column;
    box-shadow: 0px 3px 20px 2px rgba(0,0,0,0.4);
    border: 1px solid rgb(220, 220, 220);
    border-radius: 1px;
    padding: 12px 25px;
    color: #626369;
    &-title {
        display: flex;
        &>h1:hover {
            cursor: pointer;
            text-decoration-line: underline;
        }
    }
}

.tag {
    font-family: "Fira code";
    padding: 2px 4px;
    border-radius: 2px;
    background-color: gray;
    color: white;
    font-weight: normal;
    cursor: pointer;
    &+& {
        margin-left: 8px;
    }
}
</style>
