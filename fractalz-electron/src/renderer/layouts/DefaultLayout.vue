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
            <router-link :to="{ name: 'VideoChatPage' }"  id="videoChatLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg version="1.0" xmlns="http://www.w3.org/2000/svg" width="29" height="29" viewBox="0 0 512.000000 512.000000" fill="white">
                <g transform="translate(0.000000,512.000000) scale(0.100000,-0.100000)" stroke="none">
                  <path d="M2370 5114 c-19 -2 -78 -9 -130 -15 -788 -90 -1517 -582 -1919 -1296 -313 -555 -401 -1238 -241 -1873 45 -180 103 -335 186 -503 l44 -89 -156 -581 c-120 -448 -155 -591 -151 -621 9 -68 65 -124 133 -133 30 -4 174 31 620 151 l582 156 133 -64 c880 -419 1931 -294 2694 321 1101 887 1274 2498 388 3598 -409 507 -974 829 -1633 930 -100 15 -472 28 -550 19z m545 -343 c151 -26 293 -62 415 -108 688 -256 1212 -832 1394 -1533 57 -221 70 -327 70 -570 0 -243 -13 -349 -70 -570 -181 -696 -698 -1268 -1381 -1528 -107 -41 -320 -96 -458 -119 -166 -26 -507 -24 -675 5 -256 44 -424 99 -666 218 -85 42 -164 74 -181 74 -16 0 -240 -56 -497 -126 -258 -69 -470 -123 -473 -121 -2 3 53 215 122 472 69 257 125 481 125 498 0 17 -32 95 -74 181 -119 242 -174 410 -218 666 -29 168 -31 509 -5 675 81 497 291 912 636 1255 382 381 862 605 1401 654 108 10 418 -4 535 -23z"/>
                  <path d="M1348 3691 c-158 -51 -279 -186 -314 -350 -20 -98 -20 -1465 1 -1564 34 -163 158 -299 316 -348 57 -18 103 -19 824 -19 719 0 767 1 824 19 86 27 140 61 204 130 64 70 100 140 118 231 6 36 13 66 14 68 2 2 126 -68 276 -155 263 -152 276 -158 329 -158 68 0 114 29 141 89 18 39 19 84 19 926 0 842 -1 887 -19 926 -27 60 -73 89 -141 89 -53 0 -66 -6 -329 -158 -150 -87 -274 -157 -276 -155 -1 2 -8 32 -14 68 -18 91 -54 161 -118 231 -64 69 -118 103 -204 130 -57 18 -104 19 -827 18 -716 0 -771 -1 -824 -18z m1593 -324 c72 -48 69 -10 69 -807 0 -797 3 -759 -69 -807 l-34 -23 -731 0 c-715 0 -732 1 -764 20 -19 12 -41 38 -52 63 -19 40 -20 73 -20 747 0 674 1 707 20 747 11 25 33 51 52 63 32 19 49 20 764 20 l731 0 34 -23z m839 -808 c0 -319 -4 -579 -8 -577 -5 2 -106 59 -225 128 l-217 124 0 326 0 326 218 126 c119 69 220 127 225 127 4 1 7 -260 7 -580z"/>
                  <path d="M2505 3159 c-16 -4 -47 -23 -69 -41 -131 -108 -84 -322 80 -368 185 -52 339 152 239 316 -51 83 -154 122 -250 93z"/>
                </g>
              </svg>
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

          <div class="row" >
            <books-modal hidden :api="this.api"></books-modal>
            <router-link :to="{name: 'BookPage'}"  id="documentsLeftButtone" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" x="0px" y="0px" viewBox="0 0 293.151 293.151" style="fill:white" xml:space="preserve" color="#0000">
                <path d="M255.316,55.996l-51.928-52.94C201.471,1.102,198.842,0,196.104,0h-82.302h-8.232H45.113    c-5.631,0-10.197,4.566-10.197,10.192c0,5.626,4.566,10.192,10.197,10.192h60.457h8.232h72.11l0.005,44.231    c0,5.631,4.561,10.197,10.192,10.197h41.731v197.955H56.592V47.828c0-5.631-4.566-10.197-10.197-10.197    c-5.631,0-10.192,4.566-10.192,10.197v235.131c0,5.631,4.566,10.192,10.192,10.192h201.642c5.631,0,10.197-4.566,10.197-10.192    V63.137C258.229,60.467,257.185,57.903,255.316,55.996z M206.307,54.423V35.147l18.906,19.276H206.307z"/>
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
            <a v-on:click="showModal = true" id="registrationLeftButton" class="button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="white" class="bi bi-box-arrow-right" viewBox="0 0 16 16">
                <path fill-rule="evenodd" d="M10 12.5a.5.5 0 0 1-.5.5h-8a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5h8a.5.5 0 0 1 .5.5v2a.5.5 0 0 0 1 0v-2A1.5 1.5 0 0 0 9.5 2h-8A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h8a1.5 1.5 0 0 0 1.5-1.5v-2a.5.5 0 0 0-1 0v2z"/>
                <path fill-rule="evenodd" d="M15.854 8.354a.5.5 0 0 0 0-.708l-3-3a.5.5 0 0 0-.708.708L14.293 7.5H5.5a.5.5 0 0 0 0 1h8.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3z"/>
              </svg>
            </a>
          </div>
        </div>
      </div>


      <div class="col p-0" >
        <section class="content">
          <slot/>
        </section>

      </div>




    </div>
    <CreateNotyModal v-if="CreateNotyModal" @close="CreateNotyModal = false"></CreateNotyModal>
    <exit-modal v-if="showModal" @close="showModal = false" ></exit-modal>
  </div>
</template>

<script>
import Vue from "vue";
import NotifyCenter from "../services/NotifyCenter";
import CreateNotyModal from "../components/modals/CreateNotyModal";
import ChatPart from "../api/ChatPart";
import ExitModal from "../components/modals/ExitModal";

Vue.component ('CreateNotyModal', CreateNotyModal)


export default {
  name: "DefaultLayout",
  components: {ExitModal},

  data(){
    return {
      CountDialogsNoty: 0,
      CreateNotyModal: false,
      showModal:false,
    }
  },
  props:{
    api: Object,
    noty: Object,
    exitNotyModel:null
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
