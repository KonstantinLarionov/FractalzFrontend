<template>
  <div class="book-container">
    <div class="element-top-container" >
      <div class="element-top" v-on:click="toChooseSection">
      </div>
      <svg xmlns="http://www.w3.org/2000/svg" style="display: table-cell" v-on:click="toDeleteSection" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
        <path d="M0 0h24v24H0z" fill="none"/>
        <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
      </svg>
    </div>
    <div class="element-middle-sect"  v-on:click="toChooseSection">
      <label type="text" id="sect-label" class="text-sect-name" contenteditable="true" v-model="this.SectionName" @keyup.enter="toUpdateName">{{SectionNameImp}}</label>
    </div>

    <div class="element-bottom-sect"  v-on:click="toChooseSection">
      <input type="color" class="text-sect-about" contenteditable="true">{{DataTime}}
    </div>
  </div>
</template>

<script>


import BooksPart from "../../../api/BooksPart";
import Vue from "vue";

export default {
  name: "SectionElement",
  props:
      {
        OwnerId:null,
        SectionNameImp:null,
        Id:null,
        DataTime:null,
        BookId:null,
      },
  data()
      {
        return{
          SectionName:null,
          api:Object,
          ChosenSectInf:null
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
          this.ChosenSectInf = {"SectionNameImp": this.SectionNameImp, "Id": this.Id}
          document.getElementById('sect-label').textContent = this.SectionNameImp;
          this.$emit(`chooseSect`, this.ChosenSectInf)
          console.log(this.Id, this.SectionName)
        },

        toUpdateName:async function()
        {
          this.SectionName = document.getElementById('sect-label').textContent
          let update = await this.api.UpdateSection(this.Id, this.SectionName).catch(response=> {response.response.data})
          console.log(update.data)
        },

        toDeleteSection: async function()
        {
          let del = await this.api.DeleteSection(this.Id).catch(response=>{response.response.data})
          if(del.data.success)
          {
            await this.toGetSection()
            return "Success Delete Section"
          }
        },
        toGetSection:async function()
        {
          let get = await this.api.GetSection(Vue.$cookies.get('UserInfo').id, this.BookId).catch(response => {console.log(response.response.data)})
          if(get.data.success)
          {
            for(let i=0;i < get.data.bookSectionsList.$values.length; i++)
            {
              this.SectionContent.push(get.data.bookSectionsList.$values[i])
            }
            this.$emit('toGetSectionModal',this.SectionContent)
            this.SectionContent = []
          }
        }
      }
}
</script>

<style scoped>
.element-top-container
{
  margin:2px ;
  display: table;
  width: max-content;
  height:max-content;
  border-width: 2px;
  border-color: transparent;
  border-style:solid;
}
.element-top
{
  cursor: pointer;
  margin:2px;
  height: 25px;
  border-color: transparent;
  display: table-cell;
  width:200px
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
  width:100%;
  cursor: pointer;
  overflow-scrolling:auto ;
  height: 30px;
}
.element-middle-sect
{
  margin:2px;
  height:30px;
  cursor: pointer;
}
.element-bottom-sect
{
  margin:2px;
  text-align: right;
  cursor: pointer;
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