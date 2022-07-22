import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class TimetablePart extends BasePart {
    //#region [ApiData]
    _partPath = "/timetable/"
    _getTimetablePath = this._partPath + "getTimetable"
    _getTimetableUsersPath = this._partPath + "getTimetableUsers"
    _createSchedulePath = this._partPath + "createSchedule"
    _updateSchedulePath = this._partPath + "updateSchedule"
    _deleteSchedulePath = this._partPath + "deleteSchedule"

    _getTimetableModel = function (UserId)
    {
        return "?UserId=" + UserId;
    }

    _getTimetableUsersModel = function (UsersId)
    {
        return "?UsersId=" + UsersId;
    }

    _createScheduleModel = function (userId, dateStart, dateEnd, isRepeat)
    {
        return {
            "userId": userId,
            "dateStart": dateStart,
            "dateEnd": dateEnd,
            "isRepeat": isRepeat
        }
    }

    _updateScheduleModel = function (userId, dateStart, dateEnd, isRepeat)
    {
        return {
            "userId": userId,
            "dateStart": dateStart,
            "dateEnd": dateEnd,
            "isRepeat": isRepeat
        }
    }

    _deleteScheduleModel = function (idSchedule)
    {
        return {
            "idSchedule": idSchedule
        }

    }

    //#endregion

    /**
     * Получение распсисания
     * @param UserId
     * @returns {Promise<*>}
     * @constructor
     */
    async GetTimetable(UserId) {
        return await this.instant.get(this._getTimetablePath + this._getTimetableModel(UserId))
    }

    /**
     * Получение распсисания пользователей
     * @param UsersId
     * @returns {Promise<*>}
     * @constructor
     */
    async GetTimetableUsers(UsersId) {
        return await this.instant.get(this._getTimetableUsersPath, this._getTimetableUsersModel(UsersId))
    }

    /**
     * Создание рассписания
     * @param userId
     * @param dateStart
     * @param dateEnd
     * @param isRepeat
     * @returns {Promise<*>}
     * @constructor
     */
    async CreateSchedule(userId, dateStart, dateEnd, isRepeat)
    { return await  this.instant.post(this._createSchedulePath, this._createScheduleModel(userId, dateStart, dateEnd, isRepeat))}

    /**
     * Изменение рассписания
     * @param userId
     * @param dateStart
     * @param dateEnd
     * @param isRepeat
     * @returns {Promise<*>}
     * @constructor
     */
    async UpdateSchedule(userId, dateStart, dateEnd, isRepeat)
    { return await  this.instant.put(this._updateSchedulePath, this._updateScheduleModel(userId, dateStart, dateEnd, isRepeat))}

    /**
     * Удаление рассписания
     * @param idSchedule
     * @returns {Promise<*>}
     * @constructor
     */
    async DeleteSchedule(idSchedule)
    { return await  this.instant.delete(this._deleteSchedulePath, this._deleteScheduleModel(idSchedule))}
}
