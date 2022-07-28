import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class ChatPart extends BasePart {
    //#region [ApiData]
    _partPath = "/chat/"
    _getDialogsPath = this._partPath + "getDialogs"
    _findUsersPath = this._partPath + "findUsers"
    _getMessagesPath = this._partPath + "getMessages"
    _downloadFilePath = this._partPath + "downloadFile"
    _createDialogPath = this._partPath + "createDialog"
    _createMessagePath = this._partPath + "createMessage"
    _reactionMessagePath = this._partPath + "reactionMessage"
    _updateMessagePath = this._partPath + "updateMessage"
    _deleteDialogPath = this._partPath + "deleteDialog"
    _deleteMessagePath = this._partPath + "deleteMessage"
    _fileTransferPath = this._partPath + "fileTransfer"

    _getDialogsModel = function (userid) {
        return "?UserId=" + userid;
    }

    _findUsersModel = function (findStr) {
        return "?FindStr=" + findStr;
    }

    _getMessagesModel = function (idDialog, dateFrom, countMessage, idUser) {
        var res = "?IdDialog=" + idDialog;
        if (dateFrom != ''){
            res+="&DateFrom=" + dateFrom;
        }
        if (countMessage != ''){
            res+= "&CountMessage=" + countMessage;
        }
        if (idUser != ''){
            res+= "&IdUser=" + idUser;
        }
        return res;
    }

    _createDialogModel = function (UsersId) {
        return {
            UsersId
        }
    }
    _fileTransferModel = function (DialogId) {
        return {
            DialogId
        }
    }

    _downloadFilesModel = function(Files){
        return{}
    }
    //#endregion

    /**
     * Получение диалогов
     * @param userid
     * @returns {Promise<*>}
     * @constructor
     */
    async GetDialogs(userid) {
        return await this.instant.get(this._getDialogsPath + this._getDialogsModel(userid))
    }

    /**
     * Поиск пользователя
     * @param findStr
     * @returns {Promise<*>}
     */
    async FindUsers(findStr) {
        return await this.instant.get(this._findUsersPath + this._findUsersModel(findStr))
    }

    /**
     * Получить сообщения
     * @param idDialog
     * @param dateFrom
     * @param countMessage
     * @returns {Promise<*>}
     * @constructor
     */
    async GetMessages(idDialog, dateFrom, countMessage, idUser) {
        return await this.instant.get(this._getMessagesPath + this._getMessagesModel(idDialog, dateFrom, countMessage, idUser))
    }

    /**
     * Загрузить файл
     * @returns {Promise<*>}
     * @constructor
     */
    async DownloadFile(Files) {
        return await this.instant.get(this._downloadFilePath)
    }

    /**
     * Создание диалога
     * @param usersId
     * @returns {Promise<*>}
     * @constructor
     */
    async CreateDialog(objectData) {
        console.log(this._createDialogModel(objectData))
        return await this.instant.post(this._createDialogPath, this._createDialogModel(objectData))
    }

    /**
     * Отправить сообщение
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async CreateMessage(objectData) {
        console.log(objectData)
        return await this.instant.post(this._createMessagePath, objectData )
    }

    async FileTransfer(DialogId) {
        console.log(DialogId)
        return await this.instant.post(this._fileTransferPath, this._fileTransferModel(DialogId) )
    }

    /**
     * Отправка реакции
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async ReactionMessage(objectData) {
        return await this.instant.post(this._reactionMessagePath, objectData)
    }

    /**
     * Изменить сообщение
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async UpdateMessage(objectData) {
        return await this.instant.put(this._updateMessagePath, objectData)
    }

    /**
     * Удаленеи диалога
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async DeleteDialog(objectData) {
        return await this.instant.delete(this._deleteDialogPath, objectData)
    }

    /**
     * Удалить сообщение
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async DeleteMessage(objectData) {
        return await this.instant.delete(this._deleteMessagePath, objectData)
    }
}
