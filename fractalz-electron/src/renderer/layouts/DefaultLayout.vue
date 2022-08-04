<template>
  <div class="container-fluid" style="overflow-y: hidden; overflow-x: hidden;">
    <div class="row" style="height: 100vh; ">
      <div class="p-0 m-0 teal">
        <div class="container d-flex flex-column" style="height: 100%;">
          <div class="row mt-2">
            <div class="col d-flex justify-content-center mt-1">
              <img src="https://via.placeholder.com/40" class="logo-left"  alt=""/>
            </div>
          </div>
          <div class="row mt-1">
            <router-link :to="{ name: 'AccountPage' }" id="accountLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-2 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-person-circle" viewBox="0 0 16 16">
                <path d="M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"/>
                <path fill-rule="evenodd" d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"/>
              </svg>
            </router-link>
          </div>
          <div class="row">
            <router-link :to="{ name: 'DialogPage' }" id="dialogsLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-chat-dots-fill" viewBox="0 0 16 16">
                <path d="M16 8c0 3.866-3.582 7-8 7a9.06 9.06 0 0 1-2.347-.306c-.584.296-1.925.864-4.181 1.234-.2.032-.352-.176-.273-.362.354-.836.674-1.95.77-2.966C.744 11.37 0 9.76 0 8c0-3.866 3.582-7 8-7s8 3.134 8 7zM5 8a1 1 0 1 0-2 0 1 1 0 0 0 2 0zm4 0a1 1 0 1 0-2 0 1 1 0 0 0 2 0zm3 1a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"/>
              </svg>
              <span v-if="CountDialogsNoty!= 0" class="position-absolute ml-3 badge rounded-pill bg-danger" style="margin-top: -8px; font-size: 10px; border: 2px solid rgb(0, 151, 136)"> {{ CountDialogsNoty }}</span>
            </router-link>
          </div>
          <div class="row">
            <router-link :to="{ name: 'TimetablePage' }" id="timetableLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="currentColor" class="bi bi-calendar2-week-fill" viewBox="0 0 16 16">
                <path d="M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zm9.954 3H2.545c-.3 0-.545.224-.545.5v1c0 .276.244.5.545.5h10.91c.3 0 .545-.224.545-.5v-1c0-.276-.244-.5-.546-.5zM8.5 7a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h1a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5h-1zm3 0a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h1a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5h-1zM3 10.5v1a.5.5 0 0 0 .5.5h1a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5zm3.5-.5a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h1a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5h-1z"/>
              </svg>
            </router-link>
          </div>
<!--          <div class="row">-->
<!--            <router-link :to="{ name: 'NewsPage' }"  id="newsLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">-->
<!--              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-chat-dots-fill" viewBox="0 0 16 16">-->
<!--                <path d="M0 2.5A1.5 1.5 0 0 1 1.5 1h11A1.5 1.5 0 0 1 14 2.5v10.528c0 .3-.05.654-.238.972h.738a.5.5 0 0 0 .5-.5v-9a.5.5 0 0 1 1 0v9a1.5 1.5 0 0 1-1.5 1.5H1.497A1.497 1.497 0 0 1 0 13.5v-11zM12 14c.37 0 .654-.211.853-.441.092-.106.147-.279.147-.531V2.5a.5.5 0 0 0-.5-.5h-11a.5.5 0 0 0-.5.5v11c0 .278.223.5.497.5H12z"/>-->
<!--                <path d="M2 3h10v2H2V3zm0 3h4v3H2V6zm0 4h4v1H2v-1zm0 2h4v1H2v-1zm5-6h2v1H7V6zm3 0h2v1h-2V6zM7 8h2v1H7V8zm3 0h2v1h-2V8zm-3 2h2v1H7v-1zm3 0h2v1h-2v-1zm-3 2h2v1H7v-1zm3 0h2v1h-2v-1z"/>-->
<!--              </svg>-->

<!--            </router-link>-->
<!--          </div>-->
          <div class="row">
            <router-link :to="{ name: 'TodoPage' }"  id="todosLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-chat-dots-fill" viewBox="0 0 16 16">
                <path fill-rule="evenodd" d="M2 2.5a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h1a.5.5 0 0 0 .5-.5V3a.5.5 0 0 0-.5-.5H2zM3 3H2v1h1V3z"/>
                <path d="M5 3.5a.5.5 0 0 1 .5-.5h9a.5.5 0 0 1 0 1h-9a.5.5 0 0 1-.5-.5zM5.5 7a.5.5 0 0 0 0 1h9a.5.5 0 0 0 0-1h-9zm0 4a.5.5 0 0 0 0 1h9a.5.5 0 0 0 0-1h-9z"/>
                <path fill-rule="evenodd" d="M1.5 7a.5.5 0 0 1 .5-.5h1a.5.5 0 0 1 .5.5v1a.5.5 0 0 1-.5.5H2a.5.5 0 0 1-.5-.5V7zM2 7h1v1H2V7zm0 3.5a.5.5 0 0 0-.5.5v1a.5.5 0 0 0 .5.5h1a.5.5 0 0 0 .5-.5v-1a.5.5 0 0 0-.5-.5H2zm1 .5H2v1h1v-1z"/>
              </svg>
            </router-link>
          </div>
          <div class="row">
            <div id="kanbanLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-chat-dots-fill" viewBox="0 0 16 16">
                <path d="M13.5 1a1 1 0 0 1 1 1v12a1 1 0 0 1-1 1h-11a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1h11zm-11-1a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h11a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2h-11z"/>
                <path d="M6.5 3a1 1 0 0 1 1-1h1a1 1 0 0 1 1 1v3a1 1 0 0 1-1 1h-1a1 1 0 0 1-1-1V3zm-4 0a1 1 0 0 1 1-1h1a1 1 0 0 1 1 1v7a1 1 0 0 1-1 1h-1a1 1 0 0 1-1-1V3zm8 0a1 1 0 0 1 1-1h1a1 1 0 0 1 1 1v10a1 1 0 0 1-1 1h-1a1 1 0 0 1-1-1V3z"/>
              </svg>
            </div>
          </div>
          <div class="row">
            <button id="notyCreateLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left " v-on:click="CreateNotyModal = true">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-send-exclamation" viewBox="0 0 16 16">
                <path d="M15.964.686a.5.5 0 0 0-.65-.65L.767 5.855a.75.75 0 0 0-.124 1.329l4.995 3.178 1.531 2.406a.5.5 0 0 0 .844-.536L6.637 10.07l7.494-7.494-1.895 4.738a.5.5 0 1 0 .928.372l2.8-7Zm-2.54 1.183L5.93 9.363 1.591 6.602l11.833-4.733Z"/>
                <path d="M12.5 16a3.5 3.5 0 1 0 0-7 3.5 3.5 0 0 0 0 7Zm.5-5v1.5a.5.5 0 0 1-1 0V11a.5.5 0 0 1 1 0Zm0 3a.5.5 0 1 1-1 0 .5.5 0 0 1 1 0Z"/>
              </svg>
            </button>
          </div>

          <div class="row" style="margin-top: auto; ">
            <router-link :to="{ name: 'RegistrationPage' }"  id="registrationLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-box-arrow-right" viewBox="0 0 16 16">
                <path fill-rule="evenodd" d="M10 12.5a.5.5 0 0 1-.5.5h-8a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5h8a.5.5 0 0 1 .5.5v2a.5.5 0 0 0 1 0v-2A1.5 1.5 0 0 0 9.5 2h-8A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h8a1.5 1.5 0 0 0 1.5-1.5v-2a.5.5 0 0 0-1 0v2z"/>
                <path fill-rule="evenodd" d="M15.854 8.354a.5.5 0 0 0 0-.708l-3-3a.5.5 0 0 0-.708.708L14.293 7.5H5.5a.5.5 0 0 0 0 1h8.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3z"/>
              </svg>
            </router-link>
          </div>
        </div>
      </div>
      <div class="col p-0" id="spaces">
        <section class="content">
          <slot/>
        </section>
      </div>
    </div>
    <CreateNotyModal v-if="CreateNotyModal" @close="CreateNotyModal = false"></CreateNotyModal>
  </div>
</template>

<script>
import Vue from "vue";
import NotifyCenter from "../services/NotifyCenter";
import CreateNotyModal from "../components/modals/CreateNotyModal";
import ChatPart from "../api/ChatPart";

Vue.component ('CreateNotyModal', CreateNotyModal)


export default {
  name: "DefaultLayout",
  data(){
    return {
      CountDialogsNoty: 0,
      CreateNotyModal: false
    }
  },
  props:{
    api: Object,
    noty: Object
  },
  mounted() {
    this.api = new ChatPart(this.$http);
    this.noty = new NotifyCenter();
    //Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
    Vue.socketEvents.notyReceive = this.onNotyGlobal;
    //Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
    Vue.socketEvents.messageReceive = this.onMessageUpdate;
    this.getDialogsInfo();
  },
  methods: {
    onMessageUpdate : function (message){
      console.log(message)
      if (message.idSender != Vue.$cookies.get('UserInfo').id)
      {
        this.noty.Show({title: "Новое сообщение от " + message.nameSender , message : message.text});
        require('electron').ipcRenderer.send('flash-noty', function (){});
        if(this.CountDialogsNoty >= 100) {
          this.CountDialogsNoty = "99+";
        }
        else {
          this.CountDialogsNoty++;
        }
      }
      //TODO :  + Подсветить жирным диалог который пришел
    },
    onNotyGlobal : function (message) {
      console.log(message);
      this.noty.Show({title: message.Title.toString() , message : message.Message})
      require('electron').ipcRenderer.send('flash-noty', function (){});
    },
/*    onDialogsUpdate : function (message) {
      console.log(message)
      if (message.idSender != Vue.$cookies.get('UserInfo').id)
      {
        this.noty.Show({title: "Новое сообщение" + message.nameSender , message : "DialogId: " + message.text});
        require('electron').ipcRenderer.send('flash-noty', function (){});
        if(this.CountDialogsNoty >= 100) {
          this.CountDialogsNoty = "99+";
        }
        else {
          this.CountDialogsNoty++;
        }
      }
      //TODO :  + Подсветить жирным диалог который пришел
    },*/
    getDialogsInfo : async function () {
      var result = await this.api
          .GetDialogs(Vue.$cookies.get('UserInfo').id)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        if (result.data.dialogs != null) {
          for (let j in result.data.dialogs) {
            if (result.data.dialogs[j].countUnReadMessage != 0) {
              this.CountDialogsNoty++;
            }
          }
        }
      }
    },
  }
}
</script>

<style scoped>
.content{
  width: 100%;
  height: 100%;
}
</style>
