<template>
  <div class="page-container">
    <div class="books-route">Books>"Filtered">Section>"Non_critical"></div>

      <section class="box-container">

      <section class="book-card">
        <div class="button-add-book" v-on:click="showModal">
          <label style="width: 245px" > BookAdd</label>
        </div>

        <div class="books-listing " >
          <books-modal v-if="booksModal" @close= "booksModal = false"></books-modal>

          <section >
            <div v-for="content in ShelfContent"  :key="content.$id" >
              <book-element class="book-element" v-on:click="toGetId()" :about="content.about" :book-name="content.bookName" :date-time="content.dateTime" :color="content.color" :id="content.id"></book-element>
            </div>
          </section>
        </div>

      </section>

      <div class="section-card">
        <div class="book-name" >sfd </div>

        <button class="button-add-book">Добавить новый раздел</button>
      </div>

      <div class="sheet-card">
        <div class="tools-bar"></div>
      </div>

    </section>
  </div>
</template>

<script>
import BookElement from "../elements/books/BookElement";
import Vue from "vue";
import BooksModal from "../modals/Books/BooksModal";
import BooksPart from "../../api/BooksPart";
Vue.component("book-element", BookElement);
Vue.component("books-modal", BooksModal);
export default {
  name: "BookPage",
  components: {BookElement},
  props:
      {
        BookName:null,
      },
  data(){
    return{
      ShelfContent:[],
      booksModal: false,
      api:Object,
    }
  },
  mounted()
  {
    this.api = new BooksPart(this.$http)
    this.toGetBooks();
  },
  methods:
      {
        showModal: async function()
        {
          this.booksModal = true;
        },

        toGetBooks: async function()
        {
          let get = await this.api.GetBook(Vue.$cookies.get('UserInfo').id).catch(response => {console.log(response.response.data)})
          if(get.data.success)
          {
            this.ShelfContent = get.data.book.$values;
            console.log(this.ShelfContent)
          }
        }
      }
}
</script>

<style scoped>
.page-container
{
  width: 100%;
  height: 100%;
}
.box-container
{
  display: table;
  width: 100%;
  height: 100%;
}
.book-card
{
  width: 250px;
  height: 100%;
  border-width: 2px;
  border-color: #868686;
  border-style: solid;
  border-radius: 8px;
  display: table-cell;
  margin:1px ;
}
.books-listing
{
  overflow: auto;
  border-style: solid;
  border-color: #0b0d0f;
  border-width: 2px;
  border-radius: 8px;
  width: 100%;
  height: 100%;
  background-color: #e8e8e8;
}

.book-name
{
  width: 100%;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  height:50px;
  text-align: center;
}

.section-card
{
  width: 250px;
  height: 150px;
  border-width: 2px;
  border-color: #868686;
  border-style: solid;
  border-radius: 8px;
  display: table-cell;
  background-color: #e8e8e8;
}
.book-element
{
  cursor: pointer;
}
.sheet-card
{
  height: 150px;
  border-width: 2px;
  border-radius: 8px;
  border-color: #868686;
  border-style: solid;
  display: table-cell;
  background-color: #e8e8e8;
}
.books-route
{
  border-width: 3px;
  border-radius: 8px;
  border-color: #009688;
  border-style: solid;
}
/*.tools-bar
{
  width: available;
  height: 150px;
  border-style: solid;
  border-color: #009688;
  border-width: 3px;
  border-radius: 8px;
  background-color: white;
}*/

.button-add-book
{
  width: 100%;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  height: 50px;
}


</style>