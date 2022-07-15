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

    _createModel = function (Header, About, DurationInMinute,TodoListId)
    {
        return {
            "Header": Header,
            "About": About,
            "DurationInMinute": DurationInMinute,
            "TodoListId": TodoListId,
        };
    }
    async CreateTask(Header, About, DurationInMinute,TodoListId) {
        return await this.instant.post(this._createTaskPath , this._createModel(Header, About, DurationInMinute,TodoListId))
    }

    //#endregion

}
