<template>
<!--  <chat-page v-if="chatSelect=== true" @back="chatSelect = false" :dialog-id="this.dialogId" :api="this.api" :noty="this.noty" :id-user-sender="this.idUserSender">-->
<!--  </chat-page>-->
<!--  <books-modal :api="this.api" :noty="this.noty"></books-modal>-->
  <div class="dialogs-wrap" id="dialogsSpace">
    <div class="dialog-wrap-search">
      <div class="search-wrap">
      <svg class="pirture" width="20" height="20"  viewBox="0 0 12 12" fill="var(--color-dark-blue)" xmlns="http://www.w3.org/2000/svg">
        <path d="M8.80627 7.75811C9.53249 6.76712 9.85776 5.53847 9.717 4.31797C9.57624 3.09746 8.97983 1.97511 8.0471 1.17545C7.11436 0.375797 5.91408 -0.0421914 4.6864 0.00511342C3.45872 0.0524183 2.29416 0.561527 1.42572 1.43059C0.557287 2.29965 0.049011 3.46456 0.00258463 4.69228C-0.0438417 5.92 0.375005 7.11998 1.17533 8.05214C1.97565 8.9843 3.09843 9.57991 4.31904 9.7198C5.53964 9.85968 6.76806 9.53354 7.75852 8.80661H7.75777C7.78027 8.83661 7.80427 8.86511 7.83127 8.89286L10.7188 11.7804C10.8594 11.9211 11.0502 12.0002 11.2491 12.0003C11.4481 12.0003 11.6389 11.9214 11.7796 11.7807C11.9204 11.6401 11.9995 11.4493 11.9995 11.2504C11.9996 11.0514 11.9207 10.8606 11.78 10.7199L8.89252 7.83236C8.86571 7.80521 8.83688 7.78014 8.80627 7.75736V7.75811ZM8.99977 4.87511C8.99977 5.41681 8.89308 5.95321 8.68578 6.45368C8.47848 6.95414 8.17463 7.40888 7.79159 7.79192C7.40855 8.17496 6.95381 8.47881 6.45334 8.68611C5.95287 8.89341 5.41648 9.00011 4.87477 9.00011C4.33307 9.00011 3.79667 8.89341 3.2962 8.68611C2.79574 8.47881 2.341 8.17496 1.95796 7.79192C1.57492 7.40888 1.27107 6.95414 1.06377 6.45368C0.856469 5.95321 0.749773 5.41681 0.749773 4.87511C0.749773 3.78109 1.18437 2.73188 1.95796 1.95829C2.73155 1.1847 3.78076 0.750106 4.87477 0.750106C5.96879 0.750106 7.018 1.1847 7.79159 1.95829C8.56518 2.73188 8.99977 3.78109 8.99977 4.87511Z"/>
      </svg>
      <input class="in"  placeholder="Найти на сервере" id="myserch" name="searhitem" type="search"/>
    <hr class="stick">
      </div>
    </div>
    <div class="dialog-wrap-dialogs">
      <div class="home-wrapp">
      <div class="home">
        <svg class="homes" width="25" height="25" viewBox="0 0 16 16" fill="none" xmlns="http://www.w3.org/2000/svg">
          <path fill-rule="evenodd" clip-rule="evenodd" d="M8 3.293L14 9.293V13.5C14 13.8978 13.842 14.2794 13.5607 14.5607C13.2794 14.842 12.8978 15 12.5 15H3.5C3.10218 15 2.72064 14.842 2.43934 14.5607C2.15804 14.2794 2 13.8978 2 13.5V9.293L8 3.293V3.293ZM13 2.5V6L11 4V2.5C11 2.36739 11.0527 2.24021 11.1464 2.14645C11.2402 2.05268 11.3674 2 11.5 2H12.5C12.6326 2 12.7598 2.05268 12.8536 2.14645C12.9473 2.24021 13 2.36739 13 2.5Z" fill="#1DC0CB"/>
          <path fill-rule="evenodd" clip-rule="evenodd" d="M7.29299 1.5C7.48052 1.31253 7.73483 1.20721 7.99999 1.20721C8.26516 1.20721 8.51946 1.31253 8.70699 1.5L15.354 8.146C15.4479 8.23989 15.5006 8.36723 15.5006 8.5C15.5006 8.63278 15.4479 8.76011 15.354 8.854C15.2601 8.94789 15.1328 9.00063 15 9.00063C14.8672 9.00063 14.7399 8.94789 14.646 8.854L7.99999 2.207L1.35399 8.854C1.2601 8.94789 1.13277 9.00063 0.999991 9.00063C0.867215 9.00063 0.739877 8.94789 0.645991 8.854C0.552104 8.76011 0.499359 8.63278 0.499359 8.5C0.499359 8.36723 0.552104 8.23989 0.645991 8.146L7.29299 1.5Z" fill="#1DC0CB"/>
        </svg>
      </div>
      </div>
      <div class="dialogues">
        <router-link :to="{ name: 'ChatPage' }" style="height: 60px; text-decoration: none !important;" class="d1">
          <div class="avatar1">
           <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
             <p>Константин Ларионов</p>
             <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
              <circle cx="1" cy="1" r="1" fill="#23BD57"/>
             </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения полный</p>
          </div>
          <div class="timess">
            <p>14:16</p>
          </div>
        </router-link>
        <div class="d2">
          <div class="avatar">
            <img src=http://s1.fotokto.ru/photo/full/493/4935264.jpg width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Мария Ларионова</p>
                <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                  <circle cx="1" cy="1" r="1" fill="#B1BD23"/>
                </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения  полный с выреза...</p>
          </div>
          <div class="timess">
            <p>14:16</p>
          </div>
        </div>
        <div class="d2">
          <div class="avatar">
            <img src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Никита Панин</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#BD2323"/>
              </svg>
            </div>
            <p class="textLastBlue">Текст последнего сообщения  полный с выреза...</p>
          </div>
          <div class="timess">
            <p>14:16</p>
            <p class="npr">3</p>
          </div>
        </div>
        <div class="d2">
          <div class="avatar">
            <img src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Никита Панин</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#BD2323"/>
              </svg>
            </div>
            <p class="textLastBlue">Текст последнего сообщения  полный с выреза...</p>
          </div>
          <div class="timess">
            <p>14:16</p>
            <p class="npr">3</p>
          </div>
        </div>
        <div class="d2">
          <div class="avatar">
            <img src=http://s1.fotokto.ru/photo/full/493/4935264.jpg width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Мария Ларионова</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#B1BD23"/>
              </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения  полный с выреза...</p>
          </div>
          <div class="timess">
            <p>14:16</p>
          </div>
        </div>
        <div class="d1">
          <div class="avatar">
            <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Константин Ларионов</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#23BD57"/>
              </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения полный</p>
          </div>
          <div class="timess">
            <p>14:16</p>
          </div>
        </div>
        <div class="d2">
          <div class="avatar">
            <img src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Никита Панин</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#BD2323"/>
              </svg>
            </div>
            <p class="textLastBlue">Текст последнего сообщения  полный с выреза...</p>
          </div>
          <div class="timess">
            <p>14:16</p>
            <p class="npr">3</p>
          </div>
        </div>
        <div class="d2">
          <div class="avatar">
            <img src=http://s1.fotokto.ru/photo/full/493/4935264.jpg width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>Мария Ларионова</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#B1BD23"/>
              </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения  полный с выреза...</p>
          </div>
          <div class="timess">
            <p>14:16</p>
          </div>
        </div>
        </div>
      </div>
    </div>
<!--    &lt;!&ndash; Searcher &ndash;&gt;-->
<!--    <div class="row">-->
<!--      <div class="searcher-wrap row"-->
<!--      @keyup.enter="findUsers">-->
<!--        <div class="searcher-icon col-2 find" v-on:click="findUsers() ">-->
<!--          <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="gray" class="bi bi-search" viewBox="0 0 16 16">-->
<!--            <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"/>-->
<!--          </svg>-->
<!--        </div>-->
<!--        <div class="searcher-input col-10">-->
<!--          <input type="text" v-model="findStr" placeholder="Найти диалог"/>-->
<!--        </div>-->
<!--      </div>-->
<!--    </div>-->
<!--    &lt;!&ndash; Dialogs &ndash;&gt;-->
<!--    <div class="row" v-for="dialogContent in dialogContents" :key="dialogContent.$id" v-on:click="openChat(dialogContent.id )">-->
<!--      <dialog-element :dialog-unread-message="dialogContent.countUnReadMessage" :dialog-name="dialogContent.name" :dialog-last-message="dialogContent.lastMessage" :dialog-date-send="dialogContent.dateSend" ></dialog-element>-->
<!--    </div>-->

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
.dialogs-wrap {
  display: flex;
  height: 100%;
  flex-direction: column;
}
.dialog-wrap-search{
  display: flex;
  flex-direction: row;
  height: 60px;
  margin-top: 12px;
}
.search-wrap{
  width: 300px;
  height: 60px;
  margin-left: 50px;
}
.in {
  width: 225px;
  border-top: transparent;
  border-right: transparent;
  border-bottom: transparent;
  border-left: transparent;
  margin-top: 4px;
  font-size: 15px;
  background-color: transparent;
}
.stick {
  border: 1px solid var(--color-dark-blue);
  width: 255px;
  height: 1px;
  margin-left: -3px;
  margin-top: 5px;
}
.dialog-wrap-dialogs{
  display: flex;
  flex-direction: column ;
  background-color: var(--color-white);
  height: calc(100% - 60px);
  width: 100%;
  border-radius: 25px 25px 0 0;
  box-shadow: var(--shadow-up-4)
}
.home-wrapp{
  display: flex;
  justify-content: flex-end;
  align-items: center;
  height: 80px;
}
.home{
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 50%;
  width: 72px;
  height: 72px;
  margin-right: 35px;
  margin-top: -35px;
  box-shadow: var(--shadow-down-4);
  transition: .3s;
  background-color: var(--color-dark-blue);
  cursor: pointer;
}
.home:hover{
  box-shadow : none;
}
.dialogues{
  display: flex;
  flex-direction: column;
  height: 1000px;
}
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

.avatar1 {
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 50%;
  width: 60px;
  margin-top: 30px;
  margin-right: 40px;
  margin-left: 20px;
  margin-bottom: 30px;
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
.photo{
  border-radius: 50%;
}
.tchk {
  margin-top: 10px;
  margin-left: 5px;
  width: 4px;
  height: 4px;
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
.textLastMasseg {
  font-family: 'Roboto';
  font-style: normal;
  margin-top: -6px;
  font-size: 11px;
  line-height: 7px;
  color: dimgray;
}
.d2 {
  display: flex;
  flex-direction: row;
  height: 66px;
  cursor: pointer;
  transition: .3s;
}
.d2:hover {
  background-color: #DCDCDC;
}
.npr {
  color: #00627A;
  margin-right: 10px;
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 500;
  font-size: 11px;
  line-height: 7px;
}
.textLastBlue {
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 500;
  font-size: 11px;
  line-height: 7px;
  color: #00627A;
  margin-top: -6px;
}
</style>
