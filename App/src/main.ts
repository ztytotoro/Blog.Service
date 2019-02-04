import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "./registerServiceWorker";
import Md from "./plugins/markdown";

Vue.config.productionTip = false;

Vue.use(Md);

new Vue({
  router,
  store,
  render: (h) => h(App),
}).$mount("#app");
