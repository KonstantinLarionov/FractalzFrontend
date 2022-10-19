<template>
  <transition name="modal">
   <div class="modal-mask">
     <div class="modal-wrapper">
      <div class="modal-container-exit">
        <div class="modal-header">
            <div <img src="src/renderer/assets/images/img.png" class="box-angle2">
            <div id="box-logo" class="row justify-content-center"><img src="src/renderer/assets/images/logo-img.png" height="70" width="70" class="logo2"></div>
          </div>
            <slot name="header">
              <div class="header">
                <div class="question-exit">
                <p class="question">
                  Вы действительно хотите выйти из прилжения?
                </p>
                </div>
                <ul class="notification-exit">
                  <li>отключатся уведомления из расписаний</li>
                  <li>отключатся уведомления о сообщениях</li>
                  <li>отключатся уведомления о мероприятиях</li>
                </ul>
              </div>
            </slot>
          </div>
          <div class="footer-exit" style="margin-top: -65px">
                <span class="buttons" >
                    <router-link :to="{ name: 'RegistrationPage' }">
                      <button class="btn btn-danger" v-on:click="logOut" style="margin-left: 120px">
                        Выйти
                      </button>
                    </router-link>
                  <button  class="btn btn-success" @click="$emit('close')" >Остаться</button>
                </span>
          </div>
      </div>
    </div>
  </div>
  </transition>
</template>
<script>
import Vue from "vue";
import UserNotyElement from "../elements/noty/UserNotyElement";
import ChatPart from "../../api/ChatPart";
import NotyPart from "../../api/NotyPart";

Vue.component ('user-element', UserNotyElement)

export default {
  name: "ExitModal",
  data() {
    return {
      Title : "",
      Message : "",
      Users: [],
      SelectedUserId: []
    }
  },
  props : {
    api : Object,
    apiNoty : Object
  },
  methods: {
    logOut: async function()
    {
      this.$cookies.set("UserInfo", null)
      this.$cookies.set("UserToken", null)
      this.Auth = false;
      this.login.set(null)
      this.password.set(null)
      ;Vue.socket.close(1000, "UserDisconnect")

      this.noty.Show({title : "Выход из системы Fractalz", message : "Вы успешно покинули систему!\rЖдем вас снова."});
    },
  }
}
</script>
<style lang="css">
.btn-danger{
  height: 40px;
  width: 100px;
  border-radius: 20px;
  background: #00627A;
  margin-left: 30px;
  border: transparent;
  font-size: 12px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.btn-danger:hover{
  background: #003947;
}
.btn-danger:active{
  background: #003947;
}
.btn-danger:focus{
  background: #003947;
}
.btn-success{
  height: 40px;
  width: 100px;
  border-radius: 20px;
  background: #9B9B9B;
  margin-left: 60px;
  border: transparent;
  font-size: 12px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.btn-success:hover{
  background: #7B7B7B;
}
.btn-success:active{
  background: #7B7B7B;
}
.btn-success:focus{
  background: #7B7B7B;
}
.modal-mask {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  display: table;
  transition: opacity 0.3s ease;
}
.box-angle2{
  width: 400px;
  height: 70px;
  margin-top: -10px;
  margin-left: -10px;
}
.logo2{
margin-top: -50px;
  margin-left: 170px;
}
.question{
  color: #00627AS;
  margin-left: 25px;
  font-size: 14px;
}
.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}
.modal-container-exit {
  width: 400px;
  height: 300px;
  margin: 0px auto;
  background-color: #D9D9D9;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 5px;
  border-style: solid;
  border: transparent;
}
.notification-exit{
  font-weight: 300;
  margin-left: 10px;
  line-height: 16px;
}
.modal-header{
  display: flex;
  flex-direction: column;
}
.header{
  margin-top: 10px;
  margin-left: 20px;
  width: 100%;
  height: 110px;
  color: #00627A;
  font-size: 14px;
}
.buttons
{
  horiz-align: center;
  border-radius: 20px;
}

</style>

