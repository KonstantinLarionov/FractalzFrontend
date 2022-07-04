import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class VoicePart extends BasePart {
    //#region [ApiData]
    _partPath = "/voice/"
    _findOtherServerPath = this._partPath + "findOtherServer"
    _getOtherServersPath = this._partPath + "getOtherServers"
    _getMyServersPath = this._partPath + "getMyServers"
    _getRoomsPath = this._partPath + "getRooms"
    _getUsersRoomPath = this._partPath + "getUsersRoom"
    _createMyServerPath = this._partPath + "createMyServer"
    _createRoomPath = this._partPath + "createRoom"
    _insertUserInRoomPath = this._partPath + "insertUserInRoom"
    _addOtherServerPath = this._partPath + "addOtherServer"
    _editMyServerPath = this._partPath + "editMyServer"
    _editRoomPath = this._partPath + "editRoom"
    _deleteMyServerPath = this._partPath + "deleteMyServer"
    _deleteUserFromRoomPath = this._partPath + "deleteUserFromRoom"


    //#endregion

}
