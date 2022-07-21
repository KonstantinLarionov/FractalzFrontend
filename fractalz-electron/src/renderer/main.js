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
  notyReceive : function (message)
  { console.log("Пришло NOTY:"); console.log(message); },
  usersReceive : function (message)
  { console.log("Пришло USERS:"); console.log(message); },
  dialogsReceive : function (message)
  { console.log("Пришло DIALOG:"); console.log(message); },

  onopen : function() {
    console.log("Соединение установлено.");

    Vue.socket.send("dialog, users, message, noty");
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
    if(event.type === 0)//Users
    { Vue.socketEvents.usersReceive(event.data);}
    if(event.type === 1)//Dialogs
    { Vue.socketEvents.dialogsReceive(event.data);}
    if(event.type === 2)//Message
    { Vue.socketEvents.messageReceive(event.data);}
    if(event.type === 4)//Noty
    { Vue.socketEvents.notyReceive(event.data);}
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
