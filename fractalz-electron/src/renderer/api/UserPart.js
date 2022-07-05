import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class UserPart extends BasePart {
    //#region [ApiData]
    _partPath = "/user/"
    _loginPath = this._partPath + "login"
    _registrationPath = this._partPath + "registration"
    _updateProfilePath = this._partPath + "updateProfile"
    _updateStatusPath = this._partPath + "updateStatus"

    _loginModel = function (login, password) {
        return "?login=" + login + "&password=" + password;
    }

    _registrationModel = function (login, email, password) {
        return {
            "login": login,
            "email": email,
            "password": password
        }
    }
    //#endregion

    /**
     * Логирование пользователя
     * @param login
     * @param password
     * @returns {Promise<*>}
     * @constructor
     */
    async Login(login, password) {
        return await this.instant.get(this._loginPath + this._loginModel(login, password))
    }

    /**
     * Регистрация пользователя
     * @param login
     * @param email
     * @param password
     * @returns {Promise<*>}
     * @constructor
     */
    async Registration(login, email, password) {
        return await this.instant.post(this._registrationPath, this._registrationModel(login, email, password))
    }

    /**
     * Обновление профиля
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async UpdateProfile( objectData ) {
        console.log(objectData);
        return await this.instant.post(this._updateProfilePath, objectData)
    }
}
