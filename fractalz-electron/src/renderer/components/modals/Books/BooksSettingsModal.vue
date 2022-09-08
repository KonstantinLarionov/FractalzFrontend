<template>
  <transition name="modal">
    <div class="sett-mask">
      <div class="sett-wrapper">
        <div class="sett-container">

          <div class="sett-header">
            <slot name="header">
              <label style="width: 400px">Настройки документа</label>
              <a class="sett-header-close" @click="$emit('close')">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </a>
            </slot>
          </div>

          <div class="sett-body">
            <slot name="body">
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
              <label> SAMPLE_TEXT </label>
            </slot>
          </div>

          <div class="sett-footer">
            <slot name="footer">
              <button class="btn-danger" v-on:click="toDeleteBook()" @click="$emit('close')"> Удалить документ </button>
              <button class="btn-success"> Сохранить изменения </button>
            </slot>
          </div>

        </div>
      </div>
    </div>
  </transition>
</template>

<script>
import BooksPart from "../../../api/BooksPart";

export default {
  name: "BooksSettingsModal",
  props:
      {
        api:Object,
        id:null,
      },
  mounted()
  {
    this.api= new BooksPart (this.$http)
    console.log(this.id)
  },
  methods:
      {
        toDeleteBook:async function()
        {
          var obj = {}
          let result = await this.api.DeleteBook(this.id).catch(response => {console.log(response.response.data)})
          if(result.data.success)
          {
            this.page.$forceUpdate()
          }
        }
      }
}
</script>

<style scoped>
.sett-body {
  margin: 0 0 0 0;
  padding: 0 10px 0 10px;
  width: 100%;
  height: max-content;
}
.btn-danger
{
  background-color: #e81111;
  border-color: rgb(93, 17, 17);
  margin-left: 10px;
  border-radius: 8px;
}
.btn-success
{
  border-radius: 8px;
  margin-left: 78px;

}

.sett-mask {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  display: table;
  transition: opacity 0.3s ease;
}

.sett-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.sett-container {
  height: max-content;
  max-width: 450px;
  margin: 0 auto;
  background-color: #fff;
  border-radius: 8px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 4px;
  border-color: #009688;
  border-style: solid;
  display: table;
}
.sett-header{
  display: flex;
  padding: 10px 10px 0 10px;
}
.sett-header-title{
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
.sett-header-close{
  cursor: pointer;
}
.sett-body-input
{
  background-color: #cccccc;
  border-radius: 8px;
}
.sett-footer
{
  height: 50px;
  width: 100%;
}
.sett-button
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