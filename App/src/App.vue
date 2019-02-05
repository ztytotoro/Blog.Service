<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<style lang="less">
html {
  background-color: rgb(62, 61, 61);
}
html, body, #app {
  height: 100%;
}

#app {
  font-family:  "Courier New", Helvetica, "Avenir", Arial, sans-serif, "Dengxian", "Microsoft Yahei";
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: rgb(210, 210, 210);
  font-weight: bold;
}
</style>
