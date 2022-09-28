<template>

  <div class="container-fluid" style="overflow-y: hidden; overflow-x: hidden;">
    <div class="row" style="height: 100vh; ">
      <div class="p-0 m-0 wrapper-leftbar">
        <div class="container d-flex flex-column" style="height: 100%;">
          <div class="row mt-2 flex-column align-items-center" style="height: 30px">
            <div class="mt-2" style="border-bottom: 2px solid var(--color-white); width: 30px;"></div>
            <div class="mt-1" style="border-bottom: 2px solid var(--color-white); width: 30px;"></div>
            <div class="mt-1" style="border-bottom: 2px solid var(--color-white); width: 30px;"></div>
          </div>

          <div class="row mt-2">
            <router-link :to="{ name: 'AccountPage' }" style="height: 60px; font-weight: " id="accountLeftButton" class=" flex-column button-left col d-flex justify-content-center align-items-center mt-2 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="var(--color-light-blue)" class="bi bi-person-circle" viewBox="0 0 16 16">
                <path d="M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"/>
                <path fill-rule="evenodd" d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"/>
              </svg>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Профиль</label>
            </router-link>
          </div>

          <div class="row">
            <router-link :to="{ name: 'DialogPage' }" style="height: 60px;"  id="dialogsLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <path d="M2.678 11.894C2.7818 11.9982 2.86133 12.124 2.91094 12.2625C2.96055 12.4009 2.97901 12.5486 2.965 12.695C2.89472 13.3726 2.76148 14.0421 2.567 14.695C3.962 14.372 4.814 13.998 5.201 13.802C5.4205 13.6908 5.67329 13.6645 5.911 13.728C6.59243 13.9097 7.29477 14.0011 8 14C11.996 14 15 11.193 15 8C15 4.808 11.996 2 8 2C4.004 2 1 4.808 1 8C1 9.468 1.617 10.83 2.678 11.894ZM2.185 15.799C1.94807 15.846 1.71037 15.889 1.472 15.928C1.272 15.96 1.12 15.752 1.199 15.566C1.28779 15.3566 1.36918 15.1441 1.443 14.929L1.446 14.919C1.694 14.199 1.896 13.371 1.97 12.6C0.743 11.37 0 9.76 0 8C0 4.134 3.582 1 8 1C12.418 1 16 4.134 16 8C16 11.866 12.418 15 8 15C7.20765 15.0011 6.41859 14.8982 5.653 14.694C5.133 14.957 4.014 15.436 2.185 15.799Z"/>
                <path d="M4 5.5C4 5.36739 4.05268 5.24021 4.14645 5.14645C4.24021 5.05268 4.36739 5 4.5 5H11.5C11.6326 5 11.7598 5.05268 11.8536 5.14645C11.9473 5.24021 12 5.36739 12 5.5C12 5.63261 11.9473 5.75979 11.8536 5.85355C11.7598 5.94732 11.6326 6 11.5 6H4.5C4.36739 6 4.24021 5.94732 4.14645 5.85355C4.05268 5.75979 4 5.63261 4 5.5ZM4 8C4 7.86739 4.05268 7.74021 4.14645 7.64645C4.24021 7.55268 4.36739 7.5 4.5 7.5H11.5C11.6326 7.5 11.7598 7.55268 11.8536 7.64645C11.9473 7.74021 12 7.86739 12 8C12 8.13261 11.9473 8.25979 11.8536 8.35355C11.7598 8.44732 11.6326 8.5 11.5 8.5H4.5C4.36739 8.5 4.24021 8.44732 4.14645 8.35355C4.05268 8.25979 4 8.13261 4 8ZM4 10.5C4 10.3674 4.05268 10.2402 4.14645 10.1464C4.24021 10.0527 4.36739 10 4.5 10H8.5C8.63261 10 8.75979 10.0527 8.85355 10.1464C8.94732 10.2402 9 10.3674 9 10.5C9 10.6326 8.94732 10.7598 8.85355 10.8536C8.75979 10.9473 8.63261 11 8.5 11H4.5C4.36739 11 4.24021 10.9473 4.14645 10.8536C4.05268 10.7598 4 10.6326 4 10.5Z" />
              </svg>

              <span v-if="CountDialogsNoty!= 0" class="position-absolute ml-3 badge rounded-pill bg-danger" style="margin-top: -25px; font-size: 10px; ">{{ CountDialogsNoty }}</span>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Сообщения</label>

            </router-link>
          </div>

          <div class="row">
            <router-link :to="{ name: 'VideoChatPage' }" style="height: 60px;" id="videoChatLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="30" height="30" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <path d="M0 6C0 5.46957 0.210714 4.96086 0.585786 4.58579C0.960859 4.21071 1.46957 4 2 4H14C14.5304 4 15.0391 4.21071 15.4142 4.58579C15.7893 4.96086 16 5.46957 16 6V9C16 9.53043 15.7893 10.0391 15.4142 10.4142C15.0391 10.7893 14.5304 11 14 11H9.269C9.413 11.162 9.599 11.324 9.8 11.475C10.0868 11.6886 10.3901 11.8792 10.707 12.045L10.721 12.051L10.724 12.053C10.8247 12.1034 10.9053 12.1864 10.953 12.2884C11.0006 12.3904 11.0125 12.5055 10.9865 12.6151C10.9606 12.7247 10.8985 12.8223 10.8102 12.8921C10.7219 12.962 10.6126 13 10.5 13H5.5C5.38741 13 5.27812 12.962 5.18982 12.8921C5.10152 12.8223 5.03938 12.7247 5.01346 12.6151C4.98754 12.5055 4.99937 12.3904 5.04701 12.2884C5.09466 12.1864 5.17534 12.1034 5.276 12.053L5.279 12.051L5.293 12.044C5.384 11.9977 5.47338 11.9484 5.561 11.896C5.78179 11.7679 5.99513 11.6273 6.2 11.475C6.4 11.325 6.587 11.162 6.731 11H2C1.46957 11 0.960859 10.7893 0.585786 10.4142C0.210714 10.0391 0 9.53043 0 9V6ZM2 5C1.73478 5 1.48043 5.10536 1.29289 5.29289C1.10536 5.48043 1 5.73478 1 6V9C1 9.26522 1.10536 9.51957 1.29289 9.70711C1.48043 9.89464 1.73478 10 2 10H14C14.2652 10 14.5196 9.89464 14.7071 9.70711C14.8946 9.51957 15 9.26522 15 9V6C15 5.73478 14.8946 5.48043 14.7071 5.29289C14.5196 5.10536 14.2652 5 14 5H2Z"/>
                <path d="M8 6.5C7.73478 6.5 7.48043 6.60536 7.29289 6.79289C7.10536 6.98043 7 7.23478 7 7.5C7 7.76522 7.10536 8.01957 7.29289 8.20711C7.48043 8.39464 7.73478 8.5 8 8.5C8.26522 8.5 8.51957 8.39464 8.70711 8.20711C8.89464 8.01957 9 7.76522 9 7.5C9 7.23478 8.89464 6.98043 8.70711 6.79289C8.51957 6.60536 8.26522 6.5 8 6.5ZM6 7.5C6 6.96957 6.21071 6.46086 6.58579 6.08579C6.96086 5.71071 7.46957 5.5 8 5.5C8.53043 5.5 9.03914 5.71071 9.41421 6.08579C9.78929 6.46086 10 6.96957 10 7.5C10 8.03043 9.78929 8.53914 9.41421 8.91421C9.03914 9.28929 8.53043 9.5 8 9.5C7.46957 9.5 6.96086 9.28929 6.58579 8.91421C6.21071 8.53914 6 8.03043 6 7.5ZM13 7.5C13 7.63261 12.9473 7.75979 12.8536 7.85355C12.7598 7.94732 12.6326 8 12.5 8C12.3674 8 12.2402 7.94732 12.1464 7.85355C12.0527 7.75979 12 7.63261 12 7.5C12 7.36739 12.0527 7.24021 12.1464 7.14645C12.2402 7.05268 12.3674 7 12.5 7C12.6326 7 12.7598 7.05268 12.8536 7.14645C12.9473 7.24021 13 7.36739 13 7.5Z" />
              </svg>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Конференции</label>
            </router-link>
          </div>
          <div class="row mt-1">
            <router-link :to="{ name: 'TimetablePage' }" style="height: 60px;" id="timetableLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <g clip-path="url(#clip0_39_24)">
                  <path d="M3.5 0C3.63261 0 3.75979 0.0526784 3.85355 0.146447C3.94732 0.240215 4 0.367392 4 0.5V1H12V0.5C12 0.367392 12.0527 0.240215 12.1464 0.146447C12.2402 0.0526784 12.3674 0 12.5 0C12.6326 0 12.7598 0.0526784 12.8536 0.146447C12.9473 0.240215 13 0.367392 13 0.5V1H14C14.5304 1 15.0391 1.21071 15.4142 1.58579C15.7893 1.96086 16 2.46957 16 3V14C16 14.5304 15.7893 15.0391 15.4142 15.4142C15.0391 15.7893 14.5304 16 14 16H2C1.46957 16 0.960859 15.7893 0.585786 15.4142C0.210714 15.0391 0 14.5304 0 14V3C0 2.46957 0.210714 1.96086 0.585786 1.58579C0.960859 1.21071 1.46957 1 2 1H3V0.5C3 0.367392 3.05268 0.240215 3.14645 0.146447C3.24021 0.0526784 3.36739 0 3.5 0V0ZM2 2C1.73478 2 1.48043 2.10536 1.29289 2.29289C1.10536 2.48043 1 2.73478 1 3V4H15V3C15 2.73478 14.8946 2.48043 14.7071 2.29289C14.5196 2.10536 14.2652 2 14 2H2ZM15 5H1V14C1 14.2652 1.10536 14.5196 1.29289 14.7071C1.48043 14.8946 1.73478 15 2 15H14C14.2652 15 14.5196 14.8946 14.7071 14.7071C14.8946 14.5196 15 14.2652 15 14V5Z"/>
                  <path d="M9 7.5C9 7.36739 9.05268 7.24021 9.14645 7.14645C9.24021 7.05268 9.36739 7 9.5 7H15V9H9.5C9.36739 9 9.24021 8.94732 9.14645 8.85355C9.05268 8.75979 9 8.63261 9 8.5V7.5ZM7 10.5V11.5C7 11.6326 6.94732 11.7598 6.85355 11.8536C6.75979 11.9473 6.63261 12 6.5 12H1V10H6.5C6.63261 10 6.75979 10.0527 6.85355 10.1464C6.94732 10.2402 7 10.3674 7 10.5Z"/>
                </g>
                <defs>
                  <clipPath id="clip0_39_24">
                    <rect width="16" height="16" fill="white"/>
                  </clipPath>
                </defs>
              </svg>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Расписание</label>
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
    // this.api = new ChatPart(this.$http);
    // this.noty = new NotifyCenter();
    // //Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
    // Vue.socketEvents.notyReceive = this.onNotyGlobal;
    // //Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
    // Vue.socketEvents.messageReceive = this.onMessageUpdate;
    // this.getDialogsInfo();
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


.wrapper-leftbar {
  background-color: var(--color-dark-blue);
  width: 80px;
}
</style>
