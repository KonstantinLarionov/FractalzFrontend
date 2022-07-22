<template>
  <div class="chat-content-main d-flex flex-column">
    <div id="chat" class="chat col-inside-lg decor-default">
        <div class="chat-body">
          <div v-for="messageContent in messageContents" :key="messageContent.$id">
            <answer-left-element v-if="messageContent.idSender !== idUserSender"
                                 :message="messageContent.text"
                                 :date-send="messageContent.dateCreated"
                                 :name="messageContent.nameSender"

                                 :avatar="messageContent.avatar"
                                 :status="messageContent.status">
            </answer-left-element>
            <answer-right-element v-if="messageContent.idSender === idUserSender"
                                  :message="messageContent.text"
                                  :date-send="messageContent.dateCreated"
                                  :name="messageContent.nameSender"

                                  :avatar="messageContent.avatar"
                                  :status="messageContent.status">

            </answer-right-element>
          </div>
      </div>
    </div>
    <div class="d-flex align-items-center chat-content-footer">
      <a class="p-2 select" title="Прикрепить документ">
          <svg width="24" height="24" viewBox="0 0 24 24" color="#000000" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file">
            <path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z">
            </path>
            <polyline points="13 2 13 9 20 9">
            </polyline>
          </svg>
        </a>
      <textarea v-model="message" id="message" class="p-2 textarea" placeholder="Ваше сообщение"></textarea>
      <a v-on:click="sendMessage()" class="p-2 select" title="Отправить сообщение" style="transform: rotate(45deg); right: 0">
          <svg width="24" height="24" color="#000000" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-send">
            <line x1="22" y1="2" x2="11" y2="13"/>
            <polygon points="22 2 15 22 11 13 2 9 22 2"/>
          </svg>
        </a>
    </div>
  </div>
</template>

<script>
import AnswerLeft from "../elements/chat/AnswerLeft";
import AnswerRight from "../elements/chat/AnswerRight";
import Vue from "vue";

Vue.component ('answer-left-element', AnswerLeft)
Vue.component ('answer-right-element', AnswerRight)

export default {
  name: "ChatPage",
  date() {
    return {
      messageContents: [],
    }
  },
  data(){
    return{
      message: '',
      notyHeader: "Диалог Fractalz"
    }
  },
  props:{
    idUserSender : null,
    dialogId: null,
    api: Object,
    noty: Object
  },
  mounted: async function () {
    this.messageContents = [];
    await this.getMessage();
    Vue.socketEvents.messageReceive = this.onMessageReceive;
    this.scroll();
  },
  methods: {
    scroll : function () {
      var block = document.getElementById("chat");
      block.scrollTop  =  block.scrollHeight;
    },
    onMessageReceive : function (message) {
      console.log(message)
      if (message.idSender != this.idUserSender){
        //this.noty.Show({title: "Новое сообщение от " , message : message.Text})
      }
      if (message.dialogId == this.dialogId){
        if (message != null) {
          var arr = [];
          arr = message;
          this.messageContents.push(arr)
          console.log(this.messageContents)
        }
        this.$forceUpdate();
      }
      //TODO :  + Подсветить жирным диалог который пришел
    },
    getMessage: async function () {
      var result = await this.api
          .GetMessages(this.dialogId, '', 100)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        var arr = [];
        if (result.data.messages != null) {
          arr = result.data.messages.$values;
          for (let j in arr) {
            this.$set(this.messageContents, j, arr[j])
          }
          console.log(this.messageContents)
          console.log(this.idUserSender)
        }
        this.$forceUpdate();
      } else {
        this.noty.Show({title: this.notyHeader, message: "У вас нет сообщений начните диалог"});
      }
    },
    sendMessage: async function () {
      var obj = {
        userId: Vue.$cookies.get('UserInfo').id,
        dialogId: this.dialogId,
        message: this.message,
        files: []
      }
      var result = await this.api
          .CreateMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        this.scroll();
        console.log(result)
        this.message = ''
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка отправки сообщения"});
      }
      this.onMessageReceive
    },
    updateMessage: async function (obj) {
      var result = await this.api
          .UpdateMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка изменения сообщения"});
      }
    },
    sendReaction: async function () {
      var result = await this.api
          .ReactionMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка изменения сообщения"});
      }
    },
    downloadFile: async function () {
      var result = await this.api
          .DownloadFile(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка загрузки файла"});
      }
    },
    deleteMessage: async function () {
      var result = await this.api
          .DeleteMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка удаления сообщения"});
      }
    }
  }
}
</script>

<style scoped>
.chat-content-body{
  width: 100%;
  height: 100%;
  position: absolute;
}
.chat-content-main {
  width: 100%;
  height: 100%;
}
.textarea{
  resize: initial;
  border: none;
  outline: none;
  width: 100%;
  border-right: 1px solid #009788;
  border-left: 1px solid #009788;
}
.select{
  height: 100%;
  cursor: pointer;
}
.chat-content-footer {
  background-color: white;
  bottom: 0;
  border-top: 1px solid #009788;
}

body{
  margin-top:20px;
  background:#eee;
}
.col-inside-lg {
  padding: 20px;
}
.chat {
  position: revert;
  outline: none;
  overflow: auto;
  height: 100%;
}
.decor-default {
  background-color: #ffffff;
}
.chat-users h6 {
  font-size: 20px;
  margin: 0 0 20px;
}
.chat-users .user {
  position: relative;
  padding: 0 0 0 50px;
  display: block;
  cursor: pointer;
  margin: 0 0 20px;
}
.chat-users .user .avatar {
  top: 0;
  left: 0;
}
.chat .avatar {
  width: 40px;
  height: 40px;
  position: absolute;
}
.chat .avatar img {
  display: block;
  border-radius: 20px;
  height: 100%;
}
.chat .avatar .status.off {
  border: 1px solid #5a5a5a;
  background: #ffffff;
}
.chat .avatar .status.online {
  background: #4caf50;
}
.chat .avatar .status.busy {
  background: #ffc107;
}
.chat .avatar .status.offline {
  background: #ed4e6e;
}
.chat-users .user .status {
  bottom: 0;
  left: 28px;
}
.chat .avatar .status {
  width: 10px;
  height: 10px;
  border-radius: 5px;
  position: absolute;
}
.chat-users .user .name {
  font-size: 14px;
  font-weight: bold;
  line-height: 20px;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}
.chat-users .user .mood {
  font: 200 14px/20px "Raleway", sans-serif;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

/*****************CHAT BODY *******************/
.chat-body h6 {
  font-size: 20px;
  margin: 0 0 20px;
}
.chat-body .answer.left {
  padding: 0 0 0 58px;
  text-align: left;
  float: left;
}
.chat-body .answer {
  position: relative;
  max-width: 600px;
  overflow: hidden;
  clear: both;
}
.chat-body .answer.left .avatar {
  left: 0;
}
.chat-body .answer .avatar {
  bottom: 36px;
}
.chat .avatar {
  width: 40px;
  height: 40px;
  position: absolute;
}
.chat .avatar img {
  display: block;
  border-radius: 20px;
  height: 100%;
}
.chat-body .answer .name {
  font-size: 14px;
  line-height: 36px;
}
.chat-body .answer.left .avatar .status {
  right: 4px;
}
.chat-body .answer .avatar .status {
  bottom: 0;
}
.chat-body .answer.left .text {
  background: #ebebeb;
  color: #333333;
  border-radius: 8px 8px 8px 0;
}
.chat-body .answer .text {
  padding: 12px;
  font-size: 16px;
  line-height: 26px;
  position: relative;
}
.chat-body .answer.left .text:before {
  left: -30px;
  border-right-color: #ebebeb;
  border-right-width: 12px;
}
.chat-body .answer .text:before {
  content: '';
  display: block;
  position: absolute;
  bottom: 0;
  border: 18px solid transparent;
  border-bottom-width: 0;
}
.chat-body .answer.left .time {
  padding-left: 12px;
  color: #333333;
}
.chat-body .answer .time {
  font-size: 16px;
  line-height: 36px;
  position: relative;
  padding-bottom: 1px;
}
/*RIGHT*/
.chat-body .answer.right {
  padding: 0 58px 0 0;
  text-align: right;
  float: right;
}

.chat-body .answer.right .avatar {
  right: 0;
}
.chat-body .answer.right .avatar .status {
  left: 4px;
}
.chat-body .answer.right .text {
  background: #009788;
  color: #ffffff;
  border-radius: 8px 8px 0 8px;
}
.chat-body .answer.right .text:before {
  right: -30px;
  border-left-color: #009788;
  border-left-width: 12px;
}
.chat-body .answer.right .time {
  padding-right: 12px;
  color: #333333;
}

/**************ADD FORM ***************/
.chat-body .answer-add {
  clear: both;
  position: relative;
  margin: 20px -20px -20px;
  padding: 20px;
  background: #46be8a;
}
.chat-body .answer-add input {
  border: none;
  background: none;
  display: block;
  width: 100%;
  font-size: 16px;
  line-height: 20px;
  padding: 0;
  color: #ffffff;
}
.chat input {
  -webkit-appearance: none;
  border-radius: 0;
}
.chat-body .answer-add .answer-btn-1 {
  background: url("http://91.234.35.26/iwiki-admin/v1.0.0/admin/img/icon-40.png") 50% 50% no-repeat;
  right: 56px;
}
.chat-body .answer-add .answer-btn {
  display: block;
  cursor: pointer;
  width: 36px;
  height: 36px;
  position: absolute;
  top: 50%;
  margin-top: -18px;
}
.chat-body .answer-add .answer-btn-2 {
  background: url("http://91.234.35.26/iwiki-admin/v1.0.0/admin/img/icon-41.png") 50% 50% no-repeat;
  right: 20px;
}
.chat input::-webkit-input-placeholder {
  color: #fff;
}

.chat input:-moz-placeholder { /* Firefox 18- */
  color: #fff;
}

.chat input::-moz-placeholder {  /* Firefox 19+ */
  color: #fff;
}

.chat input:-ms-input-placeholder {
  color: #fff;
}
.chat input {
  -webkit-appearance: none;
  border-radius: 0;
}
</style>