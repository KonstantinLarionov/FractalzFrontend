import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class BooksPart extends BasePart {
    //#region [ApiData]
    _partPath = "/books/"
    _createBook = this._partPath + "CreateBook"
    _getBook = this._partPath + "GetBook"
    _updateBook = this._partPath + "UpdateBook"
    _deleteBook = this._partPath + "DeleteBook"
    _getBookSection = this._partPath + "GetBookSection"
    _createBookSection = this._partPath + "CreateBookSection"
    _updateBookSection = this._partPath + "UpdateBookSection"
    _deleteBookSection = this._partPath + "DeleteBookSection"
    _createBookSheets = this._partPath + "CreateBookSheets"
    _updateBookSheets = this._partPath + "UpdateBookSheets"


    _createBookModel = function (BookName, About, Color, OwnerId) {
        return {
            "BookName": BookName,
            "About": About,
            "Color": Color,
            "OwnerId": OwnerId,
        };
    }
    _createBookSectionModel = function (bookName, BookId, OwnerId)
    {
        return {
            "bookName":bookName,
            "BookId": BookId,
            "OwnerId":OwnerId
        }
    }
    _getBookModel = function (OwnerId) {
        return "?OwnerId=" + OwnerId
    }
    _getBookSectionModel = function(OwnerId, BookId) {
        return "?OwnerId=" + OwnerId + "&BookId="+BookId
    }

    _deleteBookModel = function (id) {
        return "?id=" + id

    }




    //#endregion

    async CreateBook(BookName, About, Color, OwnerId) {
        console.log(BookName, About, Color,OwnerId)
        return await this.instant.post(this._createBook, this._createBookModel(BookName, About, Color,OwnerId))
    }
    async CreateSection(bookName, BookId, OwnerId){
        return await this.instant.post(this._createBookSection, this._createBookSectionModel(bookName, BookId, OwnerId))
    }
    async GetBook(OwnerId) {
        console.log(OwnerId)
        return await this.instant.get(this._getBook + this._getBookModel(OwnerId))
    }
    async GetSection(OwnerId, BookId) {
        return await this.instant.get(this._getBookSection + this._getBookSectionModel(OwnerId, BookId))
    }
    async DeleteBook(id)
    {
        console.log(this._deleteBook, this._deleteBookModel(id))
        return await this.instant.delete(this._deleteBook + this._deleteBookModel(id))
    }
}
