<template>

  <div class="book-container" >
    <booksSettingsModal v-if="booksSettingsModal" :id="this.Id" @close= "booksSettingsModal = false"></booksSettingsModal>
    <div class="element-grab">
      <div class="document-grip" @click="toChooseBook" ></div>
      <button class="button-settings" v-on:click="showModalSett">
        <svg xmlns="http://www.w3.org/2000/svg" width="38" height="38" viewBox="0 -100 900 900" style="fill:black" xml:space="preserve" color="#0b0d0f">
          <path d="m295.2,501h-78.3c-11.3,0-20.4-9.1-20.4-20.4v-29.5c-12.5-3.8-24.6-8.9-36.2-15.1l-20.9,20.9c-7.7,7.7-21.2,7.7-28.9,0l-55.4-55.4c-8-8-8-20.9 0-28.9l21-21c-6.1-11.5-11.1-23.6-14.9-36.1h-29.8c-11.3,0-20.4-9.1-20.4-20.4v-78.3c0-11.3 9.1-20.4 20.4-20.4h30.1c3.8-12.4 8.8-24.3 14.9-35.8l-21.3-21.3c-3.8-3.8-6-9-6-14.4 0-5.4 2.2-10.6 6-14.4l55.4-55.4c7.7-7.7 21.2-7.7 28.9,0l21.5,21.5c11.4-6.1 23.3-11 35.6-14.7v-30.5c0-11.3 9.1-20.4 20.4-20.4h78.3c11.3,0 20.4,9.1 20.4,20.4v30.4c12.3,3.8 24.2,8.7 35.6,14.7l21.5-21.5c8-8 20.9-8 28.9,0l55.4,55.4c3.8,3.8 6,9 6,14.4 0,5.4-2.2,10.6-6,14.4l-21.3,21.3c6.1,11.4 11.1,23.4 14.9,35.8h30.1c11.3,0 20.4,9.1 20.4,20.4v78.3c0,11.3-9.1,20.4-20.4,20.4h-29.8c-3.8,12.5-8.8,24.5-14.9,36.1l21,21c3.8,3.8 6,9 6,14.4 0,5.4-2.2,10.6-6,14.4l-55.4,55.4c-8,8-20.9,8-28.9,0l-20.9-20.9c-11.6,6.2-23.7,11.2-36.2,15.1v29.5c0,11.5-9.2,20.6-20.4,20.6zm-57.9-40.8h37.5v-24.8c0-9.6 6.7-17.9 16.1-19.9 18.9-4.1 36.8-11.6 53.2-22.1 8.1-5.2 18.7-4.1 25.5,2.7l17.6,17.6 26.5-26.5-17.7-17.7c-6.8-6.8-7.9-17.4-2.8-25.4 10.5-16.4 17.8-34.2 21.9-53.1 2-9.4 10.3-16.1 20-16.1h25.1v-37.5h-25.4c-9.6,0-17.9-6.7-19.9-16-4.1-18.8-11.5-36.6-22-52.8-5.2-8.1-4.1-18.7 2.7-25.5l18-18-26.5-26.5-18.1,17.9c-6.8,6.8-17.4,7.9-25.4,2.8-16.2-10.4-34-17.7-52.7-21.8-9.4-2-16.1-10.3-16.1-19.9v-25.8h-37.5v25.7c0,9.6-6.7,17.9-16.1,19.9-18.7,4.1-36.5,11.4-52.7,21.8-8.1,5.2-18.7,4-25.4-2.8l-18.1-18.1-26.5,26.5 18,18c6.8,6.8 7.9,17.4 2.7,25.5-10.5,16.2-17.9,34-22,52.8-2.1,9.4-10.4,16-19.9,16h-25.5v37.5h25.2c9.6,0 17.9,6.7 20,16.1 4.1,18.9 11.4,36.7 21.9,53.1 5.2,8.1 4,18.7-2.8,25.4l-17.7,17.7 26.5,26.5 17.6-17.6c6.8-6.8 17.4-7.9 25.5-2.7 16.4,10.5 34.2,18 53.2,22.1 9.4,2 16.1,10.3 16.1,19.9v25.1z"/>
          <path d="m256,377.1c-66.8,0-121.1-54.3-121.1-121.1 0-66.8 54.3-121.1 121.1-121.1 66.8,0 121.1,54.3 121.1,121.1 0,66.8-54.3,121.1-121.1,121.1zm0-201.4c-44.3,0-80.3,36-80.3,80.3 0,44.3 36,80.3 80.3,80.3 44.3,0 80.3-36 80.3-80.3 0-44.3-36-80.3-80.3-80.3z"/>
        </svg>
      </button>
    </div>

    <div @click="toChooseBook" >

      <div class="element-top" >
        <label style="width: 180px">{{ BookName }}</label>
      </div>

      <div class="element-middle">
        <label>{{ About }}</label>
      </div>

      <div class="element-bottom">
        <label>{{ DateTime }}</label>
      </div>

    </div>
  </div>
</template>

<script>
import Vue from "vue";
import booksSettingsModal from "../../modals/Books/BooksSettingsModal";
import BookPage from "../../pages/BookPage";
Vue.component("booksSettingsModal", booksSettingsModal)
export default {
  name: "BookElement",
  components: {BookPage},
  props:
      {
        BookName: null,
        About:null,
        DateTime:null,
        Color:null,
        Id:null,
        booksSettingsModal:false,

      },
  data(){
    return{
     ChosenBookInf:[],

    }
  },
  methods:
      {
        showModalSett: async function()
        {
          this.booksSettingsModal = true
        },
        toChooseBook: async function()
        {
         this.ChosenBookInf.push(
             {"bookName":this.BookName , "id":this.Id}
        )
          this.$emit(`chosenBookInf`, this.ChosenBookInf )
          if(this.ChosenBookInf != null)
          {
            return this.ChosenBookInf = []
          }

        }
      }
}

</script>

<style scoped>
.element-grab
{
  height: 40px;
  display: table;
  margin-top: 2px;
  margin-left: 2px;
}
.document-grip
{
  border-width: 2px;
  border-style: solid;
  border-color: #0b0d0f;
  width: 185px;
  height: 45px;
  display: table-cell;
  border-radius:8px ;

}
.element-top
{
  background-color: whitesmoke;
  border-radius:8px ;
  text-align: left;
  border-style: solid;
  border-width: 2px;
  margin:2px;
}
.button-settings
{
  border-radius: 8px;
  width: 38px;
  height: 38px;
  background-color: #009688;
  border-color: #000000;
  margin-left:5px;
  margin-top: 3px;
  display: table-cell;
}
.book-container
{
  width: 100%;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  height: max-content;
}
.element-middle
{
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
}
.element-bottom
{

  height: 25px;
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
  text-align: right;
}
</style>