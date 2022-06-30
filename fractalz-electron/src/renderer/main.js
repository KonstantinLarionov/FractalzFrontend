import Vue from 'vue'
import axios from 'axios'

import App from './App'
import router from './router'
import store from './store'
import DefaultLayout from "./layouts/DefaultLayout"

Vue.component("default-layout", DefaultLayout)

axios.defaults.baseURL = "http://192.168.89.18:5200"

if (!process.env.IS_WEB) Vue.use(require('vue-electron'))
Vue.http = Vue.prototype.$http = axios
Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  components: { App },
  router,
  store,
  template: '<App/>'
}).$mount('#app')
