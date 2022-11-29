import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
import axios from "axios";
Vue.use(VueCookies)

export default class UserPart extends BasePart {
    //#region [ApiData]
    _partPath = "/user/"
    _loginPath = this._partPath + "login"
    _registrationPath = this._partPath + "registration"
    _updateProfilePath = this._partPath + "updateProfile"
    _updateStatusPath = this._partPath + "updateStatus"
    _passwordReset = this._partPath + "passwordReset"
    _sendCode = this._partPath + "sendCode"
    _validCode = this._partPath + "validCode"
    _getUser = this._partPath + "getUser"

    _loginModel = function (login, password)
    {
        return "?login=" + login + "&password=" + password;
    }
    _getUserModel = function (id)
    {
        return "?userId=" + id;
    }

    _registrationModel = function (login, email, password)
    {
        return {
            "login": login,
            "email": email,
            "password": password
        }
    }
    _passwordResetModel = function (existEmail, newPassword)
    {
        return {
            "existEmail": existEmail,
            "password": newPassword
        }
    }
    _sendCodeModel = function (email, sendReq)
    {
        return {
            "email": email,
            "sendReq": sendReq
        }

    }
    _validCodeModel = function (Authcode, email)
    {
        return {
            "Authcode": Authcode,
            "email": email,
        }

    }
    _updateProfileModel = function (objectData)
    {
        return{
              'Patro=': objectData.Patro,
              'UserId=' : objectData.UserId,
              'Login=' : objectData.Login,
              'Number=' : objectData.Number,
              'Logo=' : objectData.Logo,
              'Name=': objectData.Name,
              'TGLink=' : objectData.Patro,
              'VKLink=': objectData.Patro,
              'Address=' : objectData.Patro,
              'Surname=' : objectData.Patro,
              'Email=': objectData.Patro
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
     *Получение пользователя
     * @param id
     * @returns {Promise<*>}
     * @constructor
     */
    async GetUser(id) {
        return await this.instant.get(this._getUser + this._getUserModel(id))
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
    async PasswordReset(newPassword,existEmail)
     { return await  this.instant.put(this._passwordReset, this._passwordResetModel( newPassword,existEmail))}

    async SendCode(email,sendReq)
    { return await  this.instant.put(this._sendCode, this._sendCodeModel( email, sendReq))}

    async ValidateCode(Authcode, email)
    { return await  this.instant.put(this._validCode, this._validCodeModel(Authcode, email ))}

    /**
     * Обновление профиля
     * @param objectData
     * @returns {Promise<*>}
     * @constructor
     */
    async UpdateProfile( objectData ) {
        console.log(objectData);
        let formData = new FormData();
        for( var i = 0; i < objectData.Logo; i++ ){
            let file = this.Files[i];
            formData.append("Files", file);
        }
        formData.append("UserId",objectData.UserId )
        formData.append("Adress", objectData.Adress)
        formData.append("VKLink", objectData.VkLink)
        formData.append("TGLink", objectData.TgLink)
        formData.append("Login",objectData.Login )
        formData.append("Name", objectData.Name)
        formData.append("Surname", objectData.Surname)
        formData.append("Patro", objectData.Patro)
        formData.append("Number", objectData.Number)
        formData.append("Email", objectData.Email)
        formData.append("Logo", objectData.Logo)
        console.log(this.formData)
        let config = {
            headers: {
                "Content-Type": "multipart/form-data"
            }
        };
        this.instant
            .post(axios.defaults.baseURL + "/user/updateProfile", formData, config)
            .then(function (response)
            {
                if (response.status === 200) {

                }
            });
    }
}
