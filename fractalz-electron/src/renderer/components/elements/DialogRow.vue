<template>
    <div class="d1">
          <div class="avatar">
            <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Имя Фамилия</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#23BD57"/>
              </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения полный</p>
          </div>
          <div class="timess">
            <p>Часы:минуты</p>
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
    // this.api = new ChatPart(this.$http);
    // this.noty = new NotifyCenter();
    // this.dialogContents = [];
    // this.getDialogs();
    // Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
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
.d1 {
    display: flex;
    flex-direction: row;
    height: 66px;
    cursor: pointer;
    transition: .3s;
  }
  .d1:hover {
    background-color:  #DCDCDC;
  }
  .photo{
    border-radius: 50%;
  }
  .avatar {
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 50%;
    width: 60px;
    margin-top: 28px;
    margin-right: 40px;
    margin-left: 20px;
    margin-bottom: 30px;
  }
  .cenetmasseg {
    display: flex;
    flex-direction: column;
    margin-left: -20px;
    width: 85%;
    color: black;
  }
  .namean{
    margin-top: 5px;
    font-family: 'Roboto';
    font-style: normal;
    font-weight: 500;
    display: flex;
    flex-direction: row;
    font-size: 13px;
  }
  .tchk {
    margin-top: 20px;
    margin-left: 4px;
    width: 4px;
    height: 4px;
  }
  .textLastMasseg {
    font-family: 'Roboto';
    font-style: normal;
    margin-top: -6px;
    font-size: 11px;
    line-height: 7px;
    color: dimgray;
  }
  .timess {
    color: black;
    display: flex;
    flex-direction: column;
    justify-content: flex-end;
    align-items: center;
    width: 20px;
    position: fixed;
    right: 20px;
    font-size: 9px;
    margin-top: 6px;
  }
  </style>