import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import "./registerServiceWorker";
import plugins from "./plugins/index";

Vue.config.productionTip = false;

plugins.forEach(plugin => Vue.use(plugin));

new Vue({
  router,
  store,
  render: (h) => h(App),
}).$mount("#app");
