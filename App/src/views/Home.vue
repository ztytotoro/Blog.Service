<template>
  <Page class="home">
    <ul class="post-list">
      <li class="post-item" v-for="post in posts" :key="post.id">
        <PostCard></PostCard>
      </li>
    </ul>
  </Page>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";
import Page from "../components/Page.vue";
import PostCard from "../components/PostCard.vue";

@Component({
  components: {
    Page,
    PostCard
  }
})
export default class Home extends Vue {
  private posts: any[] = [];
  private mounted() {
    this.$fetch.GetPosts().then(data => {
      this.posts = data;
    });
  }
}
</script>

<style lang="less">
.post-list {
  list-style: none;
  padding: 0 15%;
}

.post-item {
  & + & {
    margin-top: 22px;
  }
}
</style>
