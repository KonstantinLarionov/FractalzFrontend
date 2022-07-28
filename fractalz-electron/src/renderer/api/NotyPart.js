import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class NotyPart extends BasePart {
    //#region [ApiData]
    _partPath = "/notification/"
    _sendNotificationPath = this._partPath + "sendNotification"
    _sendNotificationModel = function (usersId, fromUser, title, message) {
        return {
            usersId,
            fromUser,
            title,
            message
        }
    }

    async SendNoty(usersId, fromUser, title, message) {
        console.log(this._sendNotificationPath)
        console.log( this._sendNotificationModel(usersId, fromUser, title, message))
        return await this.instant.post(this._sendNotificationPath, this._sendNotificationModel(usersId, fromUser, title, message))
    }
    //#endregion
}
