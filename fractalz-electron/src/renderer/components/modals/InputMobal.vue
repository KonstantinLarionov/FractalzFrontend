<template>
    <transition name="modal">
     <div class="modal-mask">
       <div class="modal-wrapper">
        <div class="modal-container-input">
              <slot name="header">
                <div class="header">
                  <div class="question-exit">
                    <br>
                    <br>
                    <br>
                  <p class="text">
                    Название поля для ввода 
                  </p>
                  </div>
                  <input class="inpt"/>
                </div>
              </slot>
              <div class="footer-modal">
                  <span class="buttons" >
                      <router-link :to="{ name: 'RegistrationPage'}"/>
                    <br>
                    <button  class="send-btn" @click="$emit('close')" >Ввести</button>
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
    name: "RegistrationModal",
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
  .modal-container-input {
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
  .header{
    margin-top: 10px;
    margin-left: 20px;
    width: 100%;
    height: 110px;
    color: #00627A;
    font-size: 14px;
  }
  .text{
    font-size: 17px;
    text-align: center;
    margin-right:120px;
  }
  .footer-modal{
  margin-top: 100px;
  margin-left: 185px;
  }
.send-btn{
    border-radius: 20px;
    color: white;
    height: 40px;
    width: 120px;
    border-radius: 20px;
    background: #00627A;
    margin-left: 30px;
    border: transparent;
    font-size: 15px;
    font-weight: 300;
    box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  }
  .send-btn:hover{
    background: #003947;
  }
  .send-btn:active{
    background: #003947;
  }
  .send-btn:focus{
    background: #003947;
  }
  .inpt{
    margin-left: 30px;
    height: 30px;
    width: 280px;
    border-radius: 20px;
    border: 1px transparent solid;
    box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
  </style>
  
  