<template>
  <transition name="modal" class="modal" style="position: fixed">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container" style="width: 450px">

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

          <div class="drag-n-drop" style="overflow: auto">
                <form ref="fileform" class="space-drag-drop"  >
                  <title class="drop-files-title" >Drop the files here!</title>
                  <div v-for="(file, key) in Files" class="file-listing" >
                    <div class="remove-container">
                      <a class="remove" v-on:click="removeFile( key )">Удалить</a>
                    </div>
                    <img class="preview" v-bind:ref="'preview'+parseInt( key )"/>
                    {{ file.name }}
                  </div>
                </form>
          </div>

          <div class="modal-file-selector" style="vertical-align: bottom">
            <slot name="selector ">
              <input class="p-2 select navTask dark-teal" v-on:change="getFile($event)" type="file" multiple width="310px" height="41px" ref="files">
              <a class="click-selector-files-cancel">
              <button  v-on:click="Files==null">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </button>
              </a>
            </slot>
          </div>

          <div class="modal-footer" style="width: 100%" >
            <slot name="footer">
              <input class="files-preview" style="width: 320px" type="text" v-model="Message">
              <button class="modal-default-button navTask dark-teal" style="margin: 0 0 0 8px;" v-on:click="fileTransfer()" @click="$emit('close')">
                Отправить
              </button>
            </slot>
          </div>

        </div>
      </div>
    </div>
  </transition>
</template>
<chat-page :file-info-chat="Files"></chat-page>
<script>
import ChatPage from "../pages/ChatPage";
import Vue from "vue";
import {formatDate} from "../../assets/plugins/fullcalendar/js/main";
export default {
  name: "FileTransferModal",

  props: {
    idUserSender: null,
    dialogId:null,
    FilesInfo:[],
    api: Object,
    noty: Object,
  },

  data() {
    return{
      dragAndDropCapable: false,
      Message:'',
      Files:[],
      formData: '',
      uploadURL: "http://localhost:5001/chat/fileTransfer",
      TodoListId: this.$cookies.get("UserInfo").todoList.id,
    }
  },
  mounted(){
    this.dragAndDropCapable = this.determineDragAndDropCapable();
    if( this.dragAndDropCapable ){
      ['drag', 'dragstart', 'dragend', 'dragover', 'dragenter', 'dragleave', 'drop'].forEach( function( evt ) {
        this.$refs.fileform.addEventListener(evt, function(e){
          e.preventDefault();
          e.stopPropagation();
        }.bind(this), false);
      }.bind(this));
      this.$refs.fileform.addEventListener('drop', function(e){
        for( let i = 0; i < e.dataTransfer.files.length; i++ ) {
          this.Files.push(e.dataTransfer.files[i]);
        }
      }.bind(this));
    }
  },
  methods:
      {
        determineDragAndDropCapable(){
          var div = document.createElement('div');
          return ( ( 'draggable' in div )
                  || ( 'ondragstart' in div && 'ondrop' in div ) )
              && 'FormData' in window
              && 'FileReader' in window;
        },
        getFile(event) {
          this.Files = this.$refs.files.files;
          console.log(this.Files);
        },
        fileTransfer:async function() {
          let formData = new FormData();
          for( var i = 0; i < this.Files.length; i++ ){
            let file = this.Files[i];
            formData.append("Files", file);
          }
          formData.append("IdSender", this.$cookies.get("UserInfo").id)
          formData.append("Message", this.Message)
          formData.append("DialogId",  this.dialogId)
          console.log(this.formData)
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

                  let arr = [response.data.value.createdMessage.file.$values];
                  //console.log(arr)
                }
              });
        },
        removeFile( key ){
          this.Files.splice( key, 1 );
          console.log(this.Files)
        }
      }
}

</script>

<style lang="css">
.modal
{
  width: 450px;
  height: 450px;
}
.remove-container
{
  text-align: right;
}
.remove
{
  text-align: right;
  color: #9e1a1a;
}

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
.files-preview {
  horiz-align: left;
  vertical-align: center;
  position: center;
  display: table-cell;
  border-color: #009788;
  border-width: 2px;
  background-color: #e5e5e5;
  border-style: dashed;
}

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
  width: 450px;
  height: 450px;
  padding: 0%;
}

.modal-container {
  width: 450px;
  height: 450px;
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
.modal-header-close
  {
  cursor: pointer;
  }
.drag-n-drop
  {
  position: relative;
  display: flex;
  padding: 10px 10px 10px 10px;
  height: 270px;

  }
.space-drag-drop
{
  border-color: #009788;
  border-width: 2px;
  background-color: #e5e5e5;
  height: 100%;
  width: 100%;
  border-style: dashed;
  display: table;
  text-align: center;
}
.modal-file-selector
{
  margin-left: 10px;
}
.click-selector-files-cancel
{
  cursor: pointer;
}
.drop-files-title
{
  font-family: "Dosis", Arial, Helvetica, sans-serif;
  font-size: 25px;
  color: #0c675e;
  position: relative;
  display: grid;
  vertical-align: middle;
  horiz-align: center;
}
.modal-footer
{
  vertical-align: bottom;
  horiz-align: right;
  display: table;
  height: 80px;
}
.modal-default-button
{
  font-size: 12px;
  vertical-align: center;
  horiz-align: right;
  position: center;
  display: table-cell;

}
div.file-listing{
  width: 420px;
  margin: auto;
  padding: 10px;
  border-bottom: 1px solid #ddd;
}
div.file-listing img{
  height: 10px;
}

.modal-drag-drop
  {
    padding: 10px 10px 0px 10px;
    height: 100%;
    width: 100%;
  }

</style>