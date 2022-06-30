<template>
  <div class="chat-content-main d-flex flex-column">

<!--    <div class="chat-content-header" style="height: auto; padding: 10px 15px;">

    </div>-->

    <div class="chat col-inside-lg decor-default">
        <div class="chat-body">
          <div v-for="messageContent in messageContents" :key="messageContent.$id">
            <answer-left-element v-if="messageContent.from == 1"
                             :avatar="messageContent.avatar"
                             :status="messageContent.status"
                             :name="messageContent.name"
                             :message="messageContent.message"
                             :date-send="messageContent.dateSend">
            </answer-left-element>
            <answer-right-element v-else-if="messageContent.from == 0"
                                 :avatar="messageContent.avatar"
                                 :status="messageContent.status"
                                 :name="messageContent.name"
                                 :message="messageContent.message"
                                 :date-send="messageContent.dateSend">
            </answer-right-element>
          </div>
      </div>
    </div>

    <div class="d-flex align-items-center chat-content-footer">

      <a  @click="addFiles()" class="p-2 select" title="Прикрепить документ">
          <svg width="24" height="24" viewBox="0 0 24 24" color="#000000" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file">
            <path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z">
            </path>
            <polyline points="13 2 13 9 20 9">
            </polyline>
          </svg>
        </a>

      <textarea id="message" class="p-2 textarea" placeholder="Ваше сообщение"></textarea>

      <a @click="sendMessage()" class="p-2 select" title="Отправить сообщение" style="transform: rotate(45deg); right: 0">
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
  mounted: async function () {
    this.messageContents = [];
    this.getMessage();
  },
  methods: {
    getMessage: function () {
      var arr =[
        {
          id: 0,
          from: 0,
          avatar: 'https://bootdey.com/img/Content/avatar/avatar2.png',
          status : 0,
          name : "Alexander Herthic",
          message: "Lorem ipsum dolor amet, consectetur adipisicing elit Lorem ipsum dolor amet, consectetur adipisicing elit Lorem ipsum dolor amet, consectetur adiping elit",
          dateSend: "5 min ago",
        },
        {
          id: 1,
          from: 1,
          avatar: 'https://bootdey.com/img/Content/avatar/avatar1.png',
          status : 1,
          name : "Alexander Herthic",
          message: "Lorem ipsum dolor amet, consectetur adipisicing elit Lorem ipsum dolor amet, consectetur adipisicing elit Lorem ipsum dolor amet, consectetur adiping elit",
          dateSend: "5 min ago",
        }
      ];

      for (let j in arr)
      {
        this.$set(this.messageContents, j, arr[j])
      }
      console.log(arr)
      this.$forceUpdate();
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