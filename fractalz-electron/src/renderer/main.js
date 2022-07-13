import Vue from 'vue'
import axios from 'axios'

import App from './App'
import router from './router'
import store from './store'
import DefaultLayout from "./layouts/DefaultLayout"

Vue.component("default-layout", DefaultLayout)

axios.defaults.baseURL = "http://localhost:5001"

if (!process.env.IS_WEB) Vue.use(require('vue-electron'))
Vue.http = Vue.prototype.$http = axios
Vue.config.productionTip = false
Vue.socket = {};
Vue.socketEvents = {
  messageReceive : function (message)
  { console.log("Пришло MESSAGE:"); console.log(message); },
  usersReceive : function (message)
  { console.log("Пришло USERS:"); console.log(message); },
  dialogsReceive : function (message)
  { console.log("Пришло DIALOG:"); console.log(message); },

  onopen : function() {
    console.log("Соединение установлено.");

    Vue.socket.send("dialog, users, message");
  },
  onclose : function(event) {
    if (event.wasClean) {
      console.log('Соединение закрыто чисто');
    } else {
      console.log('Обрыв соединения'); // например, "убит" процесс сервера
    }
    console.log('Код: ' + event.code + ' причина: ' + event.reason);
  },
  onmessage : function(event) {
    console.log("RAW Message:");
    console.log(event);

    event = JSON.parse(event.data);
    if(event.Type === 0)//Users
    { Vue.socketEvents.usersReceive(event.Data);}
    if(event.Type === 1)//Dialogs
    { Vue.socketEvents.dialogsReceive(event.Data);}
    if(event.Type === 2)//Message
    { Vue.socketEvents.messageReceive(event.Data);}
  },
  onerror : function(error) {
    console.log("Ошибка " + error.message);
  }
}

/* eslint-disable no-new */
new Vue({
  components: { App },
  router,
  store,
  template: '<App/>'
}).$mount('#app')
