<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Создание нового документа</p>
              <a class="modal-header-close" @click="$emit('close')">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </a>
            </slot>
          </div>

          <div class="modal-body">
            <slot name="body">
              <p class ="modal-heading">Название документа</p>
              <textarea class="modal-body-input"  type="text" v-model="BookName">
              </textarea>
              <p class ="modal-heading">Краткое описание документа</p>
              <textarea class="modal-body-input" v-model="About" type="text"></textarea>
              <p class ="modal-heading">Цвет документа</p>
              <input class="modal-body-input" v-model="Color" type="color">
            </slot>
          </div>

          <div class="modal-footer">
            <slot name="footer">
              <button class="add-button" v-on:click="createBook()" @click="$emit('close')">
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
import Vue from "vue";
import BookElement from "../elements/books/BookElement";
import BooksPart from "../../api/BooksPart";
import NotifyCenter from "../../services/NotifyCenter";
Vue.component('book-element', BookElement)
export default {
  name: "BooksModal",
  props:
      {
        api:Object,
        noty:Object,
        BookName:null,
        About:null,
        Color:null,
      },
  mounted()
  {
    this.noty = new NotifyCenter();
    this.api = new BooksPart(this.$http)
  },
  methods:
      {
        createBook: async function()
        {
          console.log(this.BookName,this.About,this.Color)
          let objectData =[this.BookName,this.About,this.Color]
          var create = await this.api.CreateBook(this.BookName,this.About,this.Color).catch(response=>{this.noty.Show({title:"BookCreation", message:"message"})})

        }

      }
}
</script>

<style scoped>
.modal-body{
  margin: 0 0 0 0;
  padding: 0 10px 0 10px;
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

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.modal-container {
  height: auto;
  max-width: 1450px;
  margin: 0 auto;
  background-color: #fff;
  border-radius: 8px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 4px;
  border-color: #009688;
  border-style: solid;
}
.modal-header{
  display: flex;
  padding: 10px 10px 0 10px;
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
.modal-body-input
{
  background-color: #cccccc;
  border-radius: 8px;
}
.modal-footer
{
  width: 100%;
}
.add-button
{
  background-color: rgb(67, 234, 11);
  border-style: solid;
  border-color: #0b0d0f;
  border-radius: 8px;
  border-width: 1px;
  margin-top: 10px;
  margin-left: 220px;
}
</style>