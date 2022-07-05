import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class ConferencePart extends BasePart {
    //#region [ApiData]
    _partPath = "/conference/"
    _getMyConferencesPath = this._partPath + "getMyConferences"
    _findConferenceByTokenPath = this._partPath + "findConferenceByToken"
    _editConferencePath = this._partPath + "editConference"
    _createConferencePath = this._partPath + "createConference"
    _addUserInConferencePath = this._partPath + "addUserInConference"
    _deleteConferencePath = this._partPath + "deleteConference"
    _deleteUserFromConferencePath = this._partPath + "deleteUserFromConference"
    //#endregion

}
