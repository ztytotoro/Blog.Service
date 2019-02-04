<template>
  <Page class="home"></Page>
</template>

<script lang="ts">
import { Component, Vue } from "vue-class-decorator";
import Page from "../components/Page.vue";

@Component({
  components: {
    Page
  }
})
export default class Home extends Vue {
  private mounted() {
    this.$fetch.GetPosts().then(response => {
      console.log(response);
    });
  }
}
</script>
