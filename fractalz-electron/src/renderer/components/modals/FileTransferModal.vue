<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Отправка файлов</p>
              <a class="modal-header-close" >
                <button class="click" v-on:click="$emit('close')" hidden></button>
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </a>
            </slot>
          </div>

          <div class="modal-drag-drop">
            <slot name="header">
              <p class="modal-header-title">Отправка файлов</p>
              <div class="form-group inputDnD" >
                <label class="sr-only" for="inputFile"></label>
                <input type="file" class="form-control-file text-primary font-weight-bold" id="inputFile" v-on:change="getFile($event)">
              </div>
            </slot>
          </div>

          <div class="modal-file-selector">
            <slot name="selector">
              <input class="p-2 select" v-on:change="getFile($event)" type="file" multiple width="310px" height="41px" ref="files">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
            </slot>
          </div>

          <div class="modal-footer">
            <slot name="footer">
              <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="fileTransfer()" @click="$emit('close')">
                Добавить
              </button>
            </slot>
          </div>

        </div>
      </div>
    </div>
  </transition>
</template>

<script>
import ChatPage from "../pages/ChatPage";
export default {
  name: "FileTransferModal",

  props: {
    idUserSender: null,
    dialogId: null,
    api: Object,
    noty: Object,
  },

  data() {
    return{
      Files:[],
      formData: '',
      uploadURL: "http://localhost:5001/chat/fileTransfer",
      TodoListId: this.$cookies.get("UserInfo").todoList.id,
    }
  },

  methods:
      {
        getFile(event) {
          //this.Files = event.target.files[0];
          this.Files = this.$refs.files.files;
          console.log(this.Files);
        },
        fileTransfer() {
          //event.preventDefault();
          let formData = new FormData();
          //formData.append("Files", this.Files);
          for( var i = 0; i < this.Files.length; i++ ){
            let file = this.Files[i];
            formData.append("Files", file);
          }
          formData.append("DialogId", this.dialogId)
          formData.append("IdSender", this.$cookies.get("UserInfo").id)
          let config = {
            headers: {
              "Content-Type": "multipart/form-data"
            }
          };
          this.$http
              .post(this.uploadURL, formData, config)
              .then(function (response)
              {
                if (response.status === 200) {
                  console.log(response.data);
                }
              });
        },
      }
}

</script>

<style lang="css">

.modal-mask {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  display: table;
  transition: opacity 0.3s ease;
}

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}
.form-group inputDnD
{
  height: 50px;
}

.modal-container {
  width: 600px;
  margin: 0px auto;
  background-color: #fff;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
}
.modal-header{
  display: flex;
  padding: 10px 10px 0px 10px;
}
.modal-header-title{
  position: relative;
  display: flex;
  flex-direction: row;
  align-items: center;
  font-size: 16px;
  color: #0d0f12;
  justify-content: space-between;
  width: 100%;
  margin: 0;
  padding: 0 0 1.25rem;
}
.modal-header-close{
  cursor: pointer;
}
.modal-drag-drop
  {
    width: 180px;
    height: 180px;
    align-items: center;

  }
.modal-drag-drop
  {
    padding: 10px 10px 0px 10px;
    height: 100%;
    width: 100%;
  }

</style>