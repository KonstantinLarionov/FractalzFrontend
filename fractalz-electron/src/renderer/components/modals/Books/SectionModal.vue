<template>
  <transition name="modal">
    <div class="modal-mask" >
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Создание нового документа</p>
              <a class="modal-close" @click="$emit('close-sect')">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </a>
            </slot>
          </div>

          <div class="modal-body">
            <slot name="body">
              <p class ="modal-heading">Название секции</p>
              <textarea class="modal-body-input"  type="text" v-model="SectName"></textarea>
            </slot>
          </div>

          <div class="modal-footer">
            <slot name="footer">
              <button class="add-button" v-on:click="toGetSection">
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
import BooksPart from "../../../api/BooksPart";
import NotifyCenter from "../../../services/NotifyCenter";

export default {
  name: "SectionModal",
  props:
      {
        BookId:null,
      },
  data() {
    return{
      api:Object,
      SectName:null,
      SectionContent:[]
    }
  },
  mounted()
  {
    this.api = new BooksPart (this.$http)
    this.noty = new NotifyCenter();
  },
  methods:{
    toGetSection:async function()
    {
      var create = await this.api.CreateSection(this.SectName,this.BookId, Vue.$cookies.get('UserInfo').id).catch(response=>{response.response.data})
      let get = await this.api.GetSection(Vue.$cookies.get('UserInfo').id, this.BookId).catch(response => {console.log(response.response.data)})
      if(get.data.success)
      {
        for(let i=0;i < get.data.bookSectionsList.$values.length; i++)
        {
          this.SectionContent.push(get.data.bookSectionsList.$values[i])
        }
        this.$emit('toGetSectionModal',this.SectionContent)
      }
      this.$emit('close-sect')
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
.modal-close{
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