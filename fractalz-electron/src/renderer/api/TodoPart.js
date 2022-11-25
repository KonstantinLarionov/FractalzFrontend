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
/////////////////////////////////////////////////////////
    _getListModel = function (UserId, DateFrom)
    {
        return "?UserId=" + UserId + "&DateFrom=" + DateFrom;
    }

    async GetTask (UserId, DateFrom)
    {
        return await this.instant.get(this._getListPath + this._getListModel(UserId, DateFrom))
    }
//////////////////////////////////////////////////////
    _createModel = function (Header, About, DurationInMinute,TodoListId, dateCreate)
    {
        return {
            "Header": Header,
            "About": About,
            "DurationInMinute": DurationInMinute,
            "TodoListId": TodoListId,
            "DateCreate": dateCreate
        };
    }

    async CreateTask(Header, About, DurationInMinute,TodoListId, datecreate) {
        let model = this._createModel(Header, About, DurationInMinute,TodoListId,datecreate);
        console.log(model);
        return await this.instant.post(this._createTaskPath, model)
    }
////////////////////////////////////////////////////////
    _deleteModel = function (IdTask)
    {
        return "?IdTask=" + IdTask
    }

    async DeleteTask(IdTask) {
        return await this.instant.delete(this._deleteTaskPath + this._deleteModel(IdTask))
    }

    /**
     *
     * @param IdTask
     * @param completed
     * @returns {{IdTask, completed}}
     * @private
     */
    _updateModel = function (TodoId, completed)
    {
        return {
            "TodoId": TodoId,
            "completed": completed

        };
    }

    async UpdateTask(TodoId, completed) {
        return await this.instant.put(this._updateStatusTaskPath , this._updateModel(TodoId, completed))
    }
    //#endregion

}
