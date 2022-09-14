<template>
  <div class="page-container">
    <div class="books-route-book" id="book-route"></div>

      <section class="box-container">

      <section class="book-card">
        <div class="button-add-book" v-on:click="showModal">
          <label class="book-label" > BookAdd</label>
        </div>

        <div class="books-listing "  style="margin-top: 4px">
          <books-modal @getBook="togetBooksModal($event)" v-if="booksModal" @close= "booksModal = false"></books-modal>

          <section>
            <div v-for="content in ShelfContent"  :key="content.$id" >
              <div>
                <book-element
                    @chosenBookInf="ChooseBook($event)"
                    name="book-element"
                    class="book-element"
                    :about="content.about"
                    :book-name="content.bookName"
                    :date-time="content.dateTime"
                    :color="content.color"
                    :id="content.id">
                </book-element>
              </div>
            </div>
          </section>
        </div>

      </section>
      <div class="section-card">
        <button class="button-add-section" v-on:click="showSectModal">
          Добавить новый раздел
        </button>
        <section-modal
            :book-id="this.BookId"
            v-if="sectModal"
            @close-sect="sectModal=false"
            @toGetSectionModal="toGetSectionModal($event)">
        </section-modal>

        <div class="books-listing" >
          <div class="sect-list" v-for="content in SectionContent" :key="content.$id">
            <section-element
                :data-time="content.date"
                :id="content.id"
                :book-id="BookId"
                @toGetSectionModal="toGetSectionModal($event)"
                @chooseSect="toChooseSection($event)"
                :section-name-imp="content.sectionName">
            </section-element>
          </div>
        </div>
      </div>

      <div class="sheet-card">
        <section class="element-top-sheet">
        </section>
        <section class="element-middle-sheet">
          <div class="tools-bar" v-for="content in CreatedSheetInf" :key="content.$id">
            <sheet-element id="text-section" :id="content.id" :text="content.text"></sheet-element>
          </div>
        </section>
      </div>

    </section>
  </div>
</template>

<script>
import BookElement from "../elements/books/BookElement";
import Vue from "vue";
import BooksModal from "../modals/Books/BooksModal";
import BooksPart from "../../api/BooksPart";
import SectionElement from "../elements/books/SectionElement";
import SectionModal from "../modals/Books/SectionModal";
import SheetElement from "../elements/books/SheetElement";

Vue.component("section-modal", SectionModal)
Vue.component("book-element", BookElement);
Vue.component("books-modal", BooksModal);
Vue.component("sheet-element", SheetElement)


export default {
  name: "BookPage",
  components: {SheetElement, SectionModal, SectionElement, BookElement},
  props:
      {
        BookName: null,
      },
  data() {
    return {
      ShelfContent: [],
      SectionContent: [],
      booksModal: false,
      api: Object,
      ChosenBook: [],
      bookName: null,
      BookId: null,
      SectName: [],
      sectModal: false,
      ChosenSection: null,
      SelectedText:null,
      content: "<h1>Some initial content</h1>",
      CreatedSheetInf:[]
    }
  },
  mounted() {
    this.api = new BooksPart(this.$http)
    this.toGetBooks();
  },
  methods:
      {
        showModal: async function () {
          this.booksModal = true;
        },

        showSectModal: async function () {
          console.log(this.ChosenBook)
          if (this.ChosenBook.length != 0)
            this.sectModal = true;
          if (this.ChosenBook.length == 0) {
            this.sectModal = false;
            let route = document.getElementById("book-route");
            route.textContent = " ПЕРЕД СОЗДАНИЕМ РАЗДЕЛА ВЫБЕРИТЕ КНИГУ!"
          }

        },

        toGetBooks: async function () {
          let get = await this.api.GetBook(Vue.$cookies.get('UserInfo').id).catch(response => {
            console.log(response.response.data)
          })
          if (get.data.success) {
            this.ShelfContent = get.data.book.$values;
            console.log(this.ShelfContent)
          }
        },

        togetBooksModal: async function (CreatedBookInf) {
          this.ShelfContent = CreatedBookInf
        },

        ChooseBook: async function (ChosenBook) {
          this.ChosenBook = ChosenBook
          for (let i in this.ChosenBook) {
            this.bookName = this.ChosenBook[i].bookName
            this.BookId = this.ChosenBook[i].id
          }

          var route = document.getElementById("book-route");
          route.textContent = "BookName: " + this.bookName

          await this.toGetSection()

        },

        toGetSection: async function () {
          if (this.SectionContent != null) {
            this.SectionContent = []
          }
          let get = await this.api.GetSection(Vue.$cookies.get('UserInfo').id, this.BookId).catch(response => {
            response.response.data
          })

          if (get.data.success) {
            for (let i = 0; i < get.data.bookSectionsList.$values.length; i++) {
              this.SectionContent.push(get.data.bookSectionsList.$values[i])
            }
            console.log(this.SectName)
          }
        },
        toGetSectionModal: async function (sectModalCont) {
          if (this.SectionContent != null) {
            this.SectionContent = []
          }
          this.SectionContent = sectModalCont;
        },
        toChooseSection: async function (ChosenSection) {
          this.ChosenSection = ChosenSection
          var route = document.getElementById("book-route");
          route.textContent = "BookName: " + this.bookName + " / SectionName: " + this.ChosenSection.SectionNameImp
          this.CreatedSheetInf = []
          await this.toCreateSheet()
          //await this.toGetSheet()
        },
        toCreateSheet: async function()
        {
          let create = await this.api.CreateSheet(this.ChosenSection.Id).catch(response => {response.response.data})
          if(create.data.success)
          {
            this.CreatedSheetInf.push(create.data.bookSheets)
          }
        },
        toGetSheet:async function()
        {
          let get = await this.api.GetSheet(Id).catch(response=>{response.response.data})
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
.book-label
{
  cursor: pointer;
  width: max-content;
  margin-top: 11px;
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
  padding-top:-5px ;
}
.books-listing
{
  overflow: auto;
  border-style: solid;
  border-color: #0b0d0f;
  border-width: 2px;
  border-radius: 8px;
  width: 264px;

  height: 925px;
  background-color: #adadad;
}

.section-card
{
  width: 260px;
  height: 150px;
  border-width: 2px;
  border-color: #868686;
  border-style: solid;
  border-radius: 8px;
  display: table-cell;
  background-color: #e8e8e8;
}
.element-middle-sheet
{}
.book-element
{
  width: 240px;
  horiz-align: center;
  cursor: pointer;
  margin-left: 6px;
  margin-top: 6px
}
.sheet-card
{
  height: 150px;
  border-width: 2px;
  border-radius: 8px;
  border-color: #868686;
  border-style: solid;
  display: table-cell;
  max-width: 990px;
  background-color: #e8e8e8;
}

.books-route-book
{
  height: 30px;
  border-width: 3px;
  border-radius: 8px;
  border-color: #009688;
  border-style: solid;
  font-size: 16px;
  font-weight: bold;
  color: #009688;
}


.button-add-book
{
  width: 240px;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  height:50px;
  margin-top: 6px;
  margin-left: 10px;
  text-align: center;
  margin-bottom: 3px;
  cursor: pointer;
}
.button-add-section
{
  width: 240px;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  height:50px;
  margin-top: 6px;
  margin-left: 10px;
  text-align: center;
  margin-bottom: 4px;
}




</style>