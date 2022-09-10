<template>
  <div class="book-container" v-on:click="toChooseSection">
    <div class="element-top"></div>
    <div class="element-middle">
      <label type="text" id="sect-label" class="text-sect-name" contenteditable="true" v-model="this.SectionName" @keyup.enter="toUpdateName">{{SectionNameImp}}</label>
    </div>

    <div class="element-bottom">
      <input type="color" class="text-sect-about" contenteditable="true">{{DataTime}}
    </div>
  </div>
</template>

<script>


import BooksPart from "../../../api/BooksPart";

export default {
  name: "SectionElement",
  props:
      {
        OwnerId:null,
        SectionNameImp:null,
        Id:null,
        DataTime:null
      },
  data()
      {
        return{
          SectionName:null,
          api:Object,
        }
      },
  mounted()
  {
    this.api = new BooksPart (this.$http)
  },
  methods:
      {
        toChooseSection:async function()
        {
          this.SectionName = document.getElementById('sect-label').textContent
          console.log(this.Id, this.SectionName)
        },
        toUpdateName:async function()
        {
          let update = await this.api.UpdateSection(this.Id, this.SectionName).catch(response=> {response.response.data})
          console.log(update.data)
        }
      }
}
</script>

<style scoped>
.element-top
{
  margin:2px;
  height: 10px;
  border-color: transparent;
}
.button-settings
{
  border-radius: 8px;
  width: 38px;
  height: 38px;
  background-color: #009688;
  border-color: #009688;
}
.book-container
{

  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  height: max-content;
  width: 240px;
  horiz-align: center;
  cursor: pointer;
  margin-left: 6px;
  margin-top: 6px
}

.text-sect-name
{
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
  width: 99%;
  overflow-scrolling:auto ;
}
.text-sect-about
{
  height: 25px;
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
  width: 99%;
}
</style>