<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container-exit">

          <div class="modal-header">
            <slot name="header">
              <div class="header">

                <label style="font-size: 18px" type="text" >
                  Вы действительно хотите выйти?
                </label>
              </div>
            </slot>
          </div>


          <div class="footer" style="margin-top: 50px">

                <span class="buttons" >
                    <router-link :to="{ name: 'RegistrationPage' }">
                      <button class="btn btn-danger" v-on:click="logOut" style="margin-left: 100px">
                        Да
                      </button>

                    </router-link>

                  <button  class="btn btn-success" @click="$emit('close')" >Нет</button>
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
      Vue.socket.close(1000, "UserDisconnect");

      this.noty.Show({title : "Выход из системы Fractalz", message : "Вы успешно покинули систему!\rЖдем вас снова."});
    },
  }
}
</script>

<style lang="css">

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

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.modal-container-exit {
  width: 305px;
  height: 150px;
  margin: 0px auto;
  background-color: #fff;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 5px;
  border-style: solid;
  border-color: #0c675e;
}
.modal-header{
  display: flex;
  padding: 10px 10px 0px 10px;
}
.buttons
{
  horiz-align: center;
}

</style>

