import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class BooksPart extends BasePart {
    //#region [ApiData]
    _partPath = "/books/"
    _createBook = this._partPath + "CreateBook"
    _updateBook = this._partPath + "UpdateBook"
    _deleteBook = this._partPath + "DeleteBook"
    _createBookSection = this._partPath + "CreateBookSection"
    _updateBookSection = this._partPath + "UpdateBookSection"
    _deleteBookSection = this._partPath + "DeleteBookSection"
    _createBookSheets = this._partPath + "CreateBookSheets"
    _updateBookSheets = this._partPath + "UpdateBookSheets"


    _createBookModel = function (bookName, about, color) {
        return {
            "bookName": bookName,
            "about": about,
            "color": color,
        };
    }


    //#endregion

    async CreateBook(bookName, about, color) {
        console.log(bookName, about, color)
        return await this.instant.post(this._createBook, this._createBookModel(bookName, about, color))
    }
}
