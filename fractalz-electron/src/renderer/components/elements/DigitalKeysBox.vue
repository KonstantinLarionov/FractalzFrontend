<template>
  <div style="text-align: left" class="keysContainer">
    <span style="text-align: left">
        <span class="file-icon">
          <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" id="Capa_1" x="0px" y="0px" width="26" height="26" viewBox="0 0 266.578 266.577" style="enable-background:new 0 0 266.578 266.577;" xml:space="preserve">
            <path d="M139.065,8.692l83.959,83.959h-55.25c-15.835,0-28.709-12.877-28.709-28.709V8.692z"/>
            <path d="M203.016,266.577H63.576c-15.829,0-28.718-12.881-28.718-28.703V28.715C34.858,12.88,47.747,0,63.576,0h63.191v63.942    c0,22.614,18.398,41.007,41.007,41.007h63.945v132.925C231.719,253.696,218.845,266.577,203.016,266.577z"/>
          </svg>
        </span>
        <a class="file-link" id="file-link" @click="LogFile()">{{keyName}}</a>
    </span>
  </div>
</template>

<script>
import RegistrationPage from "../pages/RegistrationPage";
import Vue from "vue";

export default {
  name: "DigitalKeysBox",
  props:
      {
        api: Object,
        dir:'C:\\Temp\\WorkProjects\\',
        keyName:null,
        password:null,
        login:null,
        port:null,
        fileUpload:false,
        noty:Object
      },

  methods:
        {
          LogFile: async function()
          {
            const fs = require("fs")
            var fileBuffer = Buffer.from("C:\\Temp\\WorkProjects\\" + this.keyName)
            fs.readFile(fileBuffer, (err, data) =>
            {
              if (err) throw err;

              var obj = JSON.parse(data.toString());
              let reg = RegistrationPage.data()
              this.password = obj.Password
              this.login = obj.Login
              this.port = obj.Port;
              Vue.prototype.$http.defaults.baseURL = obj.Server + ":" + obj.Port
              this.fileUpload = true;
              console.log(this.api)
              this.logIn()
            });
          },
          logIn : async function () {
            var result = await this.api.Login(this.login, this.password)
                .catch(response => {
                  this.noty.Show({
                    title: "Вход в систему Fractalz",
                    message: response.response.data.message
                  });
                });
            if(result.data.success)
            {
              this.$cookies.set("UserToken", result.data.token);
              this.$cookies.set("UserInfo", result.data.user);
              this.noty.Show({title : "Вход в систему Fractalz", message : "Добро пожаловать!\rВы успешно вошли в систему."});
              this.connectWebSocket(result.data.user.id);
              await this.$router.push({ name: 'DialogPage' })
            }
            else
            {
              this.noty.Show({title : "Вход в систему Fractalz", message : "Произошла ошибка.\rПроверьте правильность данных!"});
            }
          },
          connectWebSocket : function (userId) {
            if(this.fileUpload)
            {
              Vue.socket = new WebSocket(Vue.prototype.$http.defaults.baseURL.replace('http', 'ws') + "/ws/subscribe?idUser=" + userId);
            }
            else {
              Vue.socket = new WebSocket(Vue.prototype.$http.defaults.baseURL.replace('http', 'ws') + "/ws/subscribe?idUser=" + userId);

            }
            Vue.socket.onopen = Vue.socketEvents.onopen;
            Vue.socket.onclose = Vue.socketEvents.onclose;
            Vue.socket.onmessage = Vue.socketEvents.onmessage;
            Vue.socket.onerror = Vue.socketEvents.onerror;
          },
        }
}
</script>

<style scoped>
.keysContainer
{
  margin: 8px;
  border-bottom:solid;
  border-width: 2px;
  border-bottom-color: #0c675e;
}
.file-link
{
  cursor: pointer;
  color: #0b0d0f;
}
</style>