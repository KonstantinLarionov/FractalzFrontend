import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class TodoPart extends BasePart {
    //#region [ApiData]
    _partPath = "/todoList/"
    _getListPath = this._partPath + "getList"
    _createTaskPath = this._partPath + "createTask"
    _updateStatusTaskPath = this._partPath + "updateStatusTask"
    _deleteTaskPath = this._partPath + "deleteTask"



    //#endregion

}
