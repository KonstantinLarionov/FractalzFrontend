import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class NotyPart extends BasePart {
    //#region [ApiData]
    _partPath = "/notification/"
    _sendNotificationPath = this._partPath + "sendNotification"
    _removeNotificationPath = this._partPath + "removeNotification"
    _getNotificationPath = this._partPath + "getNotificationByDateCreate"
    _sendNotificationModel = function (usersId, fromUser, title, message) {
        return {
            usersId,
            fromUser,
            title,
            message
        }
    }
    _removeNotificationModel = function (notiId) {
        return {
            notyId : notiId,
        }
    }
    _getNotificationModel = function (dateCreate, userId) {
        return {
            dateCreate,
            userId
        }
    }

    async SendNoty(usersId, fromUser, title, message) {
        console.log(this._sendNotificationPath)
        console.log( this._sendNotificationModel(usersId, fromUser, title, message))
        return await this.instant.post(this._sendNotificationPath, this._sendNotificationModel(usersId, fromUser, title, message))
    }
    async RemoveNoty(notyId) {
        console.log(this._removeNotificationPath)
        console.log( this._removeNotificationModel(notyId))
        return await this.instant.delete(this._removeNotificationPath, this._removeNotificationModel(notyId))
    }
    async GetNoty(dateCreate, userId) {
        console.log(this._getNotificationPath)
        console.log( this._getNotificationModel(dateCreate, userId))
        return await this.instant.post(this._getNotificationPath, this._getNotificationModel(dateCreate, userId))
    }
    //#endregion
}
