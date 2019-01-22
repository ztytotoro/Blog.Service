<template>
    <div v-html="content"></div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";

@Component
export default class Post extends Vue {
    public get content() {
        return this.$md(`# Title 1\n* li\n* li`);
    }
}
</script>
