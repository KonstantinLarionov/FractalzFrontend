<template>
  <chat-page v-if="chatSelect=== true" @back="chatSelect = false" :dialog-id="this.dialogId" :api="this.api" :noty="this.noty" :id-user-sender="this.idUserSender">
  </chat-page>
<!--  <books-modal :api="this.api" :noty="this.noty"></books-modal>-->
  <div v-else-if="chatSelect === false" class="dialogs-wrap p-3" id="dialogsSpace">
    <!-- Searcher -->
    <div class="row">
      <div class="searcher-wrap row"
      @keyup.enter="findUsers">
        <div class="searcher-icon col-2 find" v-on:click="findUsers() ">
          <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="gray" class="bi bi-search" viewBox="0 0 16 16">
            <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"/>
          </svg>
        </div>
        <div class="searcher-input col-10">
          <input type="text" v-model="findStr" placeholder="Найти диалог"/>
        </div>
      </div>
    </div>
    <!-- Dialogs -->
    <div class="row" v-for="dialogContent in dialogContents" :key="dialogContent.$id" v-on:click="openChat(dialogContent.id )">
      <dialog-element :dialog-unread-message="dialogContent.countUnReadMessage" :dialog-name="dialogContent.name" :dialog-last-message="dialogContent.lastMessage" :dialog-date-send="dialogContent.dateSend" ></dialog-element>
    </div>
  </div>
</template>

<script>
import DialogElement from "../elements/DialogElement";
import ChatPage from "./ChatPage";
import ChatPart from "../../api/ChatPart";
import NotifyCenter from "../../services/NotifyCenter";
import Vue from "vue";
import UnknownFile from "../elements/chat/filesextensions/UnknownFile";

Vue.component ('dialog-element', DialogElement)
Vue.component('unknown-file', UnknownFile)
Vue.component ('chat-page', ChatPage)
Vue.config.productionTip = false

export default {
  name: "DialogPage",
  data(){
    return{
      findStr : '',
      chatSelect: false,
      dialogId: null,
      idUserSender: Vue.$cookies.get('UserInfo').id,
      isFindUsers: false,
      notyHeader: "Диалоги Fractalz"
    }
  },
  date() {
    return {
      dialogContents: [],
    }
  },
  props:{
    api: Object,
    noty: Object
  },
  mounted: async function () {
    this.api = new ChatPart(this.$http);
    this.noty = new NotifyCenter();
    this.dialogContents = [];
    this.getDialogs();
    Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
  },
  methods: {
    onDialogsUpdate : function (message) {
      var index = this.dialogContents.map(x => {
        return x.id;
      }).indexOf(message.id);
      var unreadMess = this.dialogContents[index].countUnReadMessage;
      message.countUnReadMessage = unreadMess + 1;
      console.log(unreadMess)
      console.log(message.countUnReadMessage)
      this.dialogContents.splice(index, 1);
      this.dialogContents.unshift(message);
      this.$forceUpdate();
      this.noty.Show({title: "Новое сообщение" , message : "DialogId: " + message.id})
      //TODO :  + Подсветить жирным диалог который пришел
    },
    openChat: async function (id){
      if (this.isFindUsers){
        let arr = [Vue.$cookies.get('UserInfo').id, id];
        this.dialogId = await this.createDialog(arr);
        this.chatSelect = true;
        return true;
      }
      this.dialogId = id;
      this.chatSelect = true;
    },
    getDialogs: async function () {
      var result = await this.api
          .GetDialogs(Vue.$cookies.get('UserInfo').id)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        var arr = [];
        if (result.data.dialogs != null){
          arr = result.data.dialogs.$values;
          for (let j in arr) {
            this.$set(this.dialogContents, j, arr[j])
          }
          this.$forceUpdate();
        }
      } else {
        this.noty.Show({title: this.notyHeader, message: "У вас нет активных диалогов"});
      }
    },
    findUsers: async function () {
      this.isFindUsers =true;
      var result = await this.api
          .FindUsers(this.findStr)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
        var arr = [];
        if (result.data.users != null){
          arr = result.data.users.$values;
          this.dialogContents = [];
          for (let j in arr) {
            this.$set(this.dialogContents, j, arr[j])
            console.log(this.dialogContents)
          }
          this.$forceUpdate();
        }
      }
      else {
        this.noty.Show({title: this.notyHeader, message: "Пользователь которого вы ищите не найден"});
      }
    },
    createDialog: async function (usersId) {
      console.log(usersId)
      var result = await this.api
          .CreateDialog(usersId)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result.data)
        console.log(result.data.dialog.id)
        return result.data.dialog.id
      }
      else {
        this.noty.Show({title: this.notyHeader, message: "Не удалось создать диалог"});
      }
    },
    deleteDialog: async function (dialogId) {
      var result = await this.api
          .DeleteDialog(dialogId)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      }
      else {
        this.noty.Show({title: this.notyHeader, message: "Не удалось удалить диалог"});
      }
    }
  }
}
</script>

<style>
.find{
  cursor: pointer;
}
</style>
