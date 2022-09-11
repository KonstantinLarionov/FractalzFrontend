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
        <div class="tools-bar">
          <section class="">
            <h1 class="shadow-sm">TEXT EDITOR</h1>
            <div class="flex-box">
              <div class="row">
                <div class="col">
                  <button type="button"
                          v-on:click="f1()"
                          class=" shadow-sm btn btn-outline-secondary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Bold Text">
                    Bold</button>
                  <button type="button"
                          v-on:click="f2()"
                          class="shadow-sm btn btn-outline-success"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Italic Text">
                    Italic</button>
                  <button type="button"
                          v-on:click="f3()"
                          class=" shadow-sm btn btn-outline-primary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Left Align">
                    <i class="fas fa-align-left"></i></button>
                  <button type="button"
                          v-on:click="f4()"
                          class="btn shadow-sm btn-outline-secondary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Center Align">
                    <i class="fas fa-align-center"></i></button>
                  <button type="button"
                          v-on:click="f5()"
                          class="btn shadow-sm btn-outline-primary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Right Align">
                    <i class="fas fa-align-right"></i></button>
                  <button type="button"
                          v-on:click="f6()"
                          class="btn shadow-sm btn-outline-secondary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Uppercase Text">
                    Upper Case</button>
                  <button type="button"
                          v-on:click="f7()"
                          class="btn shadow-sm btn-outline-primary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Lowercase Text">
                    Lower Case</button>
                  <button type="button"
                          v-on:click="f8()"
                          class="btn shadow-sm btn-outline-primary"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Capitalize Text">
                    Capitalize</button>
                  <button type="button"
                          v-on:click="f9()"
                          class="btn shadow-sm btn-outline-primary side"
                          data-toggle="tooltip"
                          data-placement="top"
                          title="Tooltip on top">
                    Clear Text</button>
                </div>
              </div>
            </div>
            <br>
            <div class="row">
              <div class="col-md-3 col-sm-3">
              </div>
              <div class="col-md-6 col-sm-9">
                <div class="flex-box">
                    <textarea id="textarea1"
                              class="input shadow"
                              name="name"
                              rows="15"
                              cols="100"
                              placeholder="Your text here ">
                    </textarea>
                  <div hidden id="selectedText"></div>
                </div>
              </div>
              <div class="col-md-3">
              </div>
            </div>
          </section>
          <br>
          <br>

        </div>
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
Vue.component("section-modal", SectionModal)
Vue.component("book-element", BookElement);
Vue.component("books-modal", BooksModal);


export default {
  name: "BookPage",
  components: {SectionModal, SectionElement, BookElement},
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
      SelectedText:null
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
          route.textContent = "BookName: " + this.bookName + " / SectionName: " + this.ChosenSection

        },
        f1:async function () {
          //function to make the text bold using DOM method
          this.SelectedText = document.getSelection().toString()
          document.getElementById('selectedText').style.fontStyle = "bold";
        },
        f2:async function () {
            //function to make the text italic using DOM method
            document.getElementById("textarea1").style.fontStyle = "italic";
          },
        f3:async function () {
            //function to make the text alignment left using DOM method
            document.getElementById("textarea1").style.textAlign = "left";
          },
        f4:async function () {
            //function to make the text alignment center using DOM method
            document.getElementById("textarea1").style.textAlign = "center";
          },
        f5:async function () {
            //function to make the text alignment right using DOM method
            document.getElementById("textarea1").style.textAlign = "right";
          },
        f6:async function () {
            //function to make the text in Uppercase using DOM method
            document.getElementById("textarea1").style.textTransform = "uppercase";
          },
        f7:async function () {
            //function to make the text in Lowercase using DOM method
            document.getElementById("textarea1").style.textTransform = "lowercase";
          },
        f8:async function () {
            //function to make the text capitalize using DOM method
            document.getElementById("textarea1").style.textTransform = "capitalize";
          },
        f9:async function () {
            //function to make the text back to normal by removing all the methods applied
            //using DOM method
            document.getElementById("textarea1").style.fontWeight = "normal";
            document.getElementById("textarea1").style.textAlign = "left";
            document.getElementById("textarea1").style.fontStyle = "normal";
            document.getElementById("textarea1").style.textTransform = "capitalize";
            document.getElementById("textarea1").value = " ";
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
.h1 {
  padding-top: 40px;
  padding-bottom: 40px;
  text-align: center;
  color: #957dad;
  font-family: 'Montserrat', sans-serif;
}

.section {
  padding: 5%;
  padding-top: 0;
  height: 100vh;
}

.side {
  margin-left: 0;
}

.button {
  margin: 10px;
  border-color: #957dad !important;
  color: #888888 !important;
  margin-bottom: 25px;
}

.button:hover {
  background-color: #fec8d8 !important;
}

.textarea {
  padding: 3%;
  border-color: #957dad;
  border-width: thick;
}

.flex-box {
  display: flex;
  justify-content: center;
}


</style>