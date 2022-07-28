<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Создание уведомления</p>
              <a class="modal-header-close" @click="$emit('close')">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </a>
            </slot>
          </div>

          <div class="modal-body">
            <slot name="body">
              <input class="modal-body-input pl-2 mb-2" placeholder="Заголовок уведомления" type="text" v-model="Title">
              <input class="modal-body-input pl-2" placeholder="Сообщение уведомления" type="text" v-model="Message">
              <H5 class="text-dark mt-2">Список пользователей</H5>
              <div class="mt-2" style=" height: 200px; overflow-x: auto">
                <ul class="list-group" v-for="user in Users">
                  <user-element :isSelect="false" :Name="user.name" :id="user.userId" @select="selectUser" @unselect="unselectUser"></user-element>
                </ul>
              </div>
            </slot>
          </div>

          <div class="modal-footer">
            <slot name="footer">
              <button class="btn btn-success teal" v-on:click="sendNoty" @click="$emit('close')">
                Отправить уведомление
              </button>
            </slot>
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
  name: "CreateNotyModal",
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
  async mounted() {
    this.api = new ChatPart(this.$http);
    this.apiNoty = new NotyPart(this.$http);
    await this.getUsers();
  },
  methods: {
    getUsers: async function () {
      var result = await this.api.GetDialogs(Vue.$cookies.get('UserInfo').id);
      this.Users = result.data.dialogs.$values
      console.log(this.Users)
    },
    selectUser :function (id) {
      this.SelectedUserId.push(id)
    },
    unselectUser : function (id){
      const index = this.SelectedUserId.indexOf(id);
      if (index > -1) {
        this.SelectedUserId.splice(index, 1);
      }
    },
    sendNoty : async function (){
      await this.apiNoty.SendNoty(this.SelectedUserId, Vue.$cookies.get('UserInfo').login, this.Title, this.Message)
    }
  }
}
</script>

<style lang="css">

.modal-body{
  margin: 0 0 0 0;
  padding: 0 10px 0px 10px;
}
.modal-body-input{
  width: 100%;
  padding: 0 0 0 0;
  margin: 0px 0px 5px 0px;
}
.modal-heading{
  padding: 0 10px 0px 10px;
  margin: 0 0 0 0;
  font-size: 14px;
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

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.modal-container {
  width: 350px;
  margin: 0px auto;
  background-color: #fff;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
}
.modal-header{
  display: flex;
  padding: 10px 10px 0px 10px;
}
.modal-header-title{
  position: relative;
  display: flex;
  flex-direction: row;
  align-items: center;
  font-size: 16px;
  color: #0d0f12;
  justify-content: space-between;
  width: 100%;
  margin: 0;
  padding: 0 0 1.25rem;
}
.modal-header-close{
  cursor: pointer;
}
</style>
