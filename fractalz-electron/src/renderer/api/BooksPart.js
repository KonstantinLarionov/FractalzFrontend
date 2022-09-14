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
    _getBookSheets = this._partPath + "GetBookSheets"


    _createBookModel = function (BookName, About, Color, OwnerId) {
        return {
            "BookName": BookName,
            "About": About,
            "Color": Color,
            "OwnerId": OwnerId,
        };
    }
    _createBookSectionModel = function (SectionName, BookId, OwnerId)
    {
        return {
            "sectionName":SectionName,
            "bookId": BookId,
            "ownerId":OwnerId
        }
    }
    _createBookSheetsModel = function(SectionId){
        return{
            "SectionId": SectionId
        }
    }
    _getBookModel = function (OwnerId) {
        return "?OwnerId=" + OwnerId
    }
    _getBookSectionModel = function(OwnerId, BookId) {
        return "?OwnerId=" + OwnerId + "&BookId="+BookId
    }
    _getBookSheetsModel = function(Id){
        return "?Id="+Id
    }
    _updateBookSectionModel = function (SectionId, SectionName){
        return {
            "SectionId":SectionId,
            "SectionName":SectionName
        }
    }
    _updateBookSheetsModel = function (Id, Text){
        return {
            "Id":Id,
            "Text":Text
        }
    }
    _deleteBookSectionModel(Id) {
        return "?Id=" + Id
    }

    _deleteBookModel = function (id) {
        return "?BookId=" + id

    }




    //#endregion

    async CreateBook(BookName, About, Color, OwnerId) {
        console.log(BookName, About, Color,OwnerId)
        return await this.instant.post(this._createBook, this._createBookModel(BookName, About, Color,OwnerId))
    }
    async CreateSection(SectionName, BookId, OwnerId){
        return await this.instant.post(this._createBookSection, this._createBookSectionModel(SectionName, BookId, OwnerId))
    }
    async CreateSheet(SectionId){
        return await this.instant.post(this._createBookSheets, this._createBookSheetsModel(SectionId))
    }
    async GetBook(OwnerId) {
        console.log(OwnerId)
        return await this.instant.get(this._getBook + this._getBookModel(OwnerId))
    }
    async GetSection(OwnerId, BookId) {
        return await this.instant.get(this._getBookSection + this._getBookSectionModel(OwnerId, BookId))
    }
    async GetSheet(Id){
        return await this.instant.get(this._getBookSheets + this._getBookSheetsModel(Id))
    }
    async UpdateSection (SectionId, SectionName){
        return await this.instant.put(this._updateBookSection, this._updateBookSectionModel(SectionId, SectionName))
    }
    async SaveText (Id, Text){
        return await this.instant.put(this._updateBookSheets, this._updateBookSheetsModel(Id, Text))
    }

    async DeleteSection(Id){
        return await this.instant.delete(this._deleteBookSection + this._deleteBookSectionModel(Id))
    }
    async DeleteBook(id)
    {
        console.log(this._deleteBook, this._deleteBookModel(id))
        return await this.instant.delete(this._deleteBook + this._deleteBookModel(id))
    }
}
