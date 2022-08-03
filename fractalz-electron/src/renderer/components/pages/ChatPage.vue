<template>
  <div class="chat-content-main d-flex flex-column">
    <div class="row">
      <div class="searcher-wrap row justify-content-start">
        <div class="pl-3" @click="$emit('back')">
          <svg xmlns="http://www.w3.org/2000/svg" width="40" height="40" fill="currentColor" class="bi bi-arrow-left" viewBox="0 0 16 16" color="009687FF">
            <path fill-rule="evenodd" d="M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z"/>
          </svg>
        </div>
      </div>
    </div>
    <div id="chat" class="chat col-inside-lg decor-default">
        <div class="chat-body">
          <div v-for="messageContent in messageContents" :key="messageContent.$id">
            <answer-left-element v-if="messageContent.idSender !== idUserSender"
                                 :message="messageContent.text"
                                 :date-send="messageContent.dateCreated"
                                 :name="messageContent.nameSender"
                                 :avatar="messageContent.avatar"
                                 :status="messageContent.status"
                                 :file="messageContent.file.$values">

            </answer-left-element>

            <answer-right-element v-if="messageContent.idSender === idUserSender"
                                  :message="messageContent.text"
                                  :date-send="messageContent.dateCreated"
                                  :name="messageContent.nameSender"
                                  :avatar="messageContent.avatar"
                                  :status="messageContent.status"
                                  :file="messageContent.file.$values">

            </answer-right-element>


          </div>

      </div>
    </div>

    <div v-on="" id="emojiblock" class="emoji_block" style="background: #009687" >
      <VEmojiPicker @select="selectEmoji"/>
    </div>

    <div class="d-flex align-items-center chat-content-footer" multiple>

      <label class="document" >
        <transfer-modal v-if="showModal" @close="showModal = false" :dialog-id="dialogId" :files="this.FileInfoChat"></transfer-modal>
        <input class="p-2 select" style="display: none" @click="showModal = true">
        <svg width="24" height="24" viewBox="0 0 24 24" color="#000000" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file" >
          <path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z">
          </path>
          <polyline points="13 2 13 9 20 9">
          </polyline>
        </svg>
      </label>

      <textarea v-model="message" id="message" class="p-2 textarea" placeholder="Ваше сообщение"></textarea>
      <a v-on:click="emojiHidden('visible')" class="p-2 select" title="Emoji" style="transform: rotate(0deg); right: 0">
        <svg width="25" height="25" fill="none" xmlns="http://www.w3.org/2000/svg"><path fill-rule="evenodd" clip-rule="evenodd" d="M12 4a8 8 0 1 0 0 16 8 8 0 0 0 0-16zM2 12C2 6.477 6.477 2 12 2s10 4.477 10 10-4.477 10-10 10S2 17.523 2 12z" fill="#000"/><path d="M11 9.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0zM16 9.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z" fill="#000"/><path fill-rule="evenodd" clip-rule="evenodd" d="M9 15a1 1 0 0 1 1-1h4a1 1 0 1 1 0 2h-4a1 1 0 0 1-1-1z" fill="#000"/></svg>
      </a>

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
import { VEmojiPicker } from 'v-emoji-picker';
import FileTransferModal from "../modals/FileTransferModal";


Vue.component ('answer-left-element', AnswerLeft)
Vue.component ('answer-right-element', AnswerRight)
Vue.component('transfer-modal', FileTransferModal)
Vue.config.productionTip = false

export default {
  name: "ChatPage",
  emoji: 'Demo',

  components: {
    FileTransferModal,
    VEmojiPicker
  },

  date() {
    return {
      messageContents: [],
      showModal:false,
    }
  },
  data() {
    return {
      showModal:false,
      message: '',
      notyHeader: "Диалог Fractalz",

    }
  },
  props: {
    idUserSender: null,
    dialogId: null,
    FileInfoChat:[],
    api: Object,
    noty: Object,
  },
  mounted: async function () {
    this.messageContents = [];
    await this.getMessage();
    Vue.socketEvents.messageReceive = this.onMessageReceive;
    this.scroll();
  },
  methods: {
    selectEmoji: function(emoji) {
      this.message += emoji.data;
    },
    scroll: function () {
      var block = document.getElementById("chat");
      block.scrollTop = block.scrollHeight;
    },
    onMessageReceive: function (message) {
      if (message.dialogId == this.dialogId) {
        if (message != null)
        {
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
          .GetMessages(this.dialogId, '', 100, Vue.$cookies.get('UserInfo').id)
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

          for(let i = 0; i < this.messageContents.length; i++)
            {
              let file = this.messageContents[i]
              console.log(file.file.$values)
            }

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
    emojiHidden: function (newVisibility) {
      var emoji = document.getElementById("emojiblock");
      emoji.style.visibility = newVisibility;
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
    },
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
.emoji_block{
  position: absolute;
  visibility: hidden;
  height: 437px;
  width: 327px;
  right: 0px;
  bottom: 60px;
  border-right-color: #0b0d0f;
  border-right-style: solid;
  border-right-width: 1px;
  border-bottom-color: #0b0d0f;
  border-bottom-style: solid;
  border-bottom-width: 1px;
  border-top-color: #0b0d0f;
  border-top-style: solid;
  border-top-width: 1px;
  border-left-color: #0b0d0f;
  border-left-style: solid;
  border-left-width: 1px;

}
.select{
  height: 100%;
  cursor: pointer;

}
.document{
  border: 10px solid transparent;
  background: transparent;
}
.chat-content-footer {
  background-color: white;
  bottom: 0;
  border-top: 2px solid #009788;
  border-radius: 2px;
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