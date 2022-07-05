<template>
  <chat-page v-if="chatSelect== true">

  </chat-page>
  <div v-else-if="chatSelect == false" class="dialogs-wrap p-3" id="dialogsSpace">
    <!-- Searcher -->
    <div class="row">
      <div class="searcher-wrap row">
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
    <div class="row" v-on:click="openChat()" v-for="dialogContent in dialogContents" :key="dialogContent.$id">
      <dialog-element :dialog-name="dialogContent.name" :dialog-last-message="dialogContent.lastMessage" :dialog-date-send="dialogContent.dateSend"></dialog-element>
    </div>
  </div>
</template>

<script>
import DialogElement from "../elements/DialogElement";
import ChatPage from "./ChatPage";
import ChatPart from "../../api/ChatPart";
import NotifyCenter from "../../services/NotifyCenter";
import Vue from "vue";

Vue.component ('dialog-element', DialogElement)
Vue.component ('chat-page', ChatPage)

export default {
  name: "DialogPage",
  data(){
    return{
      findStr : '',
      chatSelect: false,
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
    console.log(Vue.$cookies.get('UserInfo'))
    console.log(Vue.$cookies.get('UserToken'))
  },
  methods: {
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
        console.log(result)
        var arr = [];
        if (result.dialogs != null){
          arr = result.dialogs;
        }
        else {
          arr = [
            {
              id: 0,
              name: 'Даниил Яковлев',
              lastMessage: 'Привед',
              dateSend: '15.04.2007',
            },
            {
              id: 1,
              name: 'Андрюшка',
              lastMessage: 'Привед',
              dateSend: '15.04.2007',
            }
          ];
        }
        for (let j in arr) {
          this.$set(this.dialogContents, j, arr[j])
        }
        this.$forceUpdate();
      } else {
        this.noty.Show({title: this.notyHeader, message: "У вас нет активных диалогов"});
      }
    },
    openChat: function (){
      this.chatSelect = true;
    },
    findUsers: async function () {
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
          }
          this.$forceUpdate();
        }
      }
      else {
        this.noty.Show({title: this.notyHeader, message: "Пользователь которого вы ищите не найден"});
      }
    },
    createDialog: async function (usersId) {
      var result = await this.api
          .CreateDialog(usersId)
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