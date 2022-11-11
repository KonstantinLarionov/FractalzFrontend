<template xmlns="http://www.w3.org/1999/html">
  <div id="main-wrapper" class="main-wrapper container-fluid">
    <div id="box">
      <div id="box-angle" class="row">
        <img class=" box-angle" src="src/renderer/assets/images/img.png"/>
      </div>
      <div id="box-logo" class="row justify-content-center">
        <img class="logo " src="src/renderer/assets/images/logo-img.png" height="100" width="100"/>
      </div>
    </div>
    <div v-if="type === 'A'" class="container-fluid">

      <div class="row justify-content-center">
        <label class="title-registration-form">Регистрация в Леттер</label>
      </div>
      <div class="wrapper-input-form justify-content-between">

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="text" class="input-form" placeholder="" v-model="login"/>
          <label >Введите логин</label>
        </div>

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="text" class="input-form" placeholder="" v-model="email"/>
          <label >Введите почту</label>
        </div>

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="password" class="input-form" placeholder=" " v-model="password"/>
          <label>Введите пароль</label>
        </div>

        <div class="row mt-4 justify-content-center">
          <button class="input-form button-form" v-on:click="singIn()">Создать</button>
        </div>

        <div class="row mt-4 justify-content-center">
          <label class="label-form">Уже усть аккаунт?</label>
          <label class="href-form" href=""  v-on:click="toSingIn()">Войти</label>
        </div>
      </div>
    </div>

    <div v-if="type === 'G'" style="display: flex; justify-content: space-around; width: 100%">
      <div style="display: flex; flex-direction: column">
        <p class="row mt-4 justify-content-center placeholder-container">Почти готово!</p>
        <p class="row mt-4 justify-content-center placeholder-container">Для потверждения введите код который отправлен на указанную вами почту.</p>
        <div class="row mt-4 justify-content-center placeholder-container" style="">
          <input type="password" class="input-form" style="width: 250px;" placeholder=" " v-model="Authcode"/>
          <label style="margin-left: -40px;" >Введите код доступа</label>
          <button title="Получить код на Email" class="input-form button-form" style="width: 70px; margin-left: 18px" v-on:click="toSendCode()">
            <svg width="14" height="15" viewBox="0 0 14 15" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M0.04375 3.33281C0.131966 2.91867 0.348823 2.54889 0.658806 2.28404C0.968789 2.01919 1.35352 1.87497
                 1.75 1.875H12.25C12.6465 1.87497 13.0312 2.01919 13.3412 2.28404C13.6512 2.54889 13.868 2.91867
                  13.9563 3.33281L7 7.88812L0.04375 3.33281ZM0 4.40344V11.0634L5.07762 7.72781L0 4.40344ZM5.91587
                   8.27812L0.167125 12.0534C0.309161 12.3743 0.533336 12.6454 0.813559 12.8351C1.09378 13.0248
                    1.41853 13.1253 1.75 13.125H12.25C12.5814 13.1251 12.906 13.0243 13.1861 12.8345C13.4662 12.6446 13.6902
                     12.3734 13.832 12.0525L8.08325 8.27719L7 8.98688L5.91587 8.27719V8.27812ZM8.92237 7.72875L14 11.0634V4.40344L8.92237 7.72781V7.72875Z"
                    fill="white"/>
            </svg>
          </button>
        </div>
        <button class="input-form row mt-4 button-form justify-content-center" style="margin-left: 110px" v-on:click="toValidateCode()">Подтвердить</button>
        <p class="href-form" style="margin-left: 230px; margin-top: 20px;"><a v-on:click="toCreateAccount()">Вернуться назад</a></p>
      </div>
    </div>

    <div id="login_wrapper" v-if="type === 'B'" class="container-fluid wrapper-login-form">
      <div class="row justify-content-center">
        <label class="title-login-form">Леттер</label>
      </div>
      <div class="wrapper-input-form justify-content-between">

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="text" class="input-form" placeholder=" " v-model="login"/>
          <label >Введите логин</label>
        </div>

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="password" class="input-form" placeholder=" " v-model="password"/>
          <label >Введите пароль</label>
        </div>

        <div class="row mt-4 justify-content-center">
          <button class="input-form button-form" v-on:click="logIn()">Войти</button>
        </div>

        <div class="row mt-4 justify-content-center">
          <label class="label-form">Нет аккаунта?</label>
          <label class="href-form" v-on:click="toCreateAccount()">Создать аккаунт</label>
        </div>

        <div class="row justify-content-center">
          <label class="label-form">Забыли пароль?</label>
        </div>
        <div class="row justify-content-center">
          <label class="href-form" style="margin-top: -12px" href="" v-on:click="toResetPassword()">Нажмите чтобы восстановить доступ</label>
        </div>

        <div class="row mt-2 justify-content-center">
          <label class="href-form" href="" v-on:click="toLogInDS()">Войти с цифровым ключём</label>
        </div>

      </div>

    </div>

    <div v-if="type === 'C'" class="container-fluid">

      <div class="mt-4 col justify-content-center">
        <label class="row title-recovery-form justify-content-center">
          Для восстановления доступа вам<br>необходимо сбросить старый пароль и<br>установить новый.
        </label>
        <label class="row title-recovery-form justify-content-center">
          Для этого мы отправим вам на Email<br>одноразовый код для подтверждения
        </label>
      </div>
      <div class="wrapper-input-form justify-content-between">

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="text" class="input-form" placeholder=" " v-model="existEmail"/>
          <label >Введите почту</label>
        </div>

        <div class="row mt-4 justify-content-center">
          <button class="input-form button-form" v-on:click="toSendCode()">Отправить код</button>
        </div>

        <div class="row mt-2 justify-content-center">
          <label class="href-form" href="" v-on:click="toBackFromReset()">Вернуться назад</label>
        </div>
      </div>
    </div>
    <div v-if="type === 'D'" class="container-fluid">

      <div class="row justify-content-center">
        <label class="title-recovery-account-form">Восстановление<br>аккаунта</label>
      </div>
      <div class="wrapper-input-form justify-content-between">

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="text" class="input-form" placeholder=" " v-bind="Authcode"/>
          <label >Ваш одноразовый код</label>
        </div>

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="password" class="input-form" placeholder=" " v-model="newPassword1"/>
          <label >Введите новый пароль</label>
        </div>

        <div class="row mt-4 justify-content-center placeholder-container">
          <input type="password" class="input-form" placeholder=" " v-model="newPassword2"/>
          <label >Подтвердите новый пароль</label>
        </div>

        <div class="row mt-4 justify-content-center">
          <button class="input-form button-form" v-on:click="passReset()">Сохранить</button>
        </div>

        <div class="row mt-2 justify-content-center">
          <label class="href-form" href="" v-on:click="toBackFromReset()">Вернуться назад</label>
        </div>

      </div>

    </div>
    <div v-if="type === 'F'" class="container-fluid wrapper-login-form">

      <div class="justify-content-center">

        <div class="row mt-2 justify-content-center">
          <div class="ecp-drag-n-drop-zone">
            <label class="ecp-form">Перетащите файл подписи сюда</label>
          </div>
        </div>

        <div class="row mt-4 justify-content-center">
          <label class="label-form">Или</label>
        </div>

        <div class="ecp-select-form">
          <label class="ecp-label">Выберите файл -> </label>
          <button class="button-form ecp-input-form" v-on:click="singIn()">...</button>
        </div>

        <div class="row mt-2 justify-content-center">
          <label class="href-form" href="" v-on:click="toBackFromReset()">Вернуться назад</label>
        </div>
      </div>

    </div>
  </div>
</template>


<script>
import UserPart from "../../api/UserPart";
import Vue from "vue";
import NotifyCenter from "../../services/NotifyCenter";
import fs from "fs";
import {readFile} from "copy-webpack-plugin/dist/utils/promisify";
import axios from "axios";
import path from "path";
import DigitalKeysBox from "../elements/DigitalKeysBox";

export default {
  name: "RegistrationPage",
  components: {DigitalKeysBox},
  data() {
    return{
      Auth : false,
      isLogin:true,
      GenRequest: true,
      type: 'B',
      password:null,
      login : null,
      email : '',
      Files:[],
      existEmail:"",
      newPassword1: "",
      newPassword2: "",
      Authcode:"",
      dragAndDropCapable: false,
      fileInf:null,
      dir:'C:\\Temp\\WorkProjects\\',
      fileUrlServer: null,
      fileUpload: false,
      Keys:[],
    }
  },

  props: {
    api: Object,
    noty: Object,
  },

  mounted() {
    this.api = new UserPart(this.$http);
    this.noty = new NotifyCenter();
    this.Auth = this.isAuth();
    console.log(this.api)
  },

  methods: {
    toCreateAccount : function () {
      this.type = 'A';
      return false;
    },

    toCreateDSAccount: function (){
      return this.type = 'E';
    },

    toSingIn : function () {
      return this.type = 'B';
    },

    toResetPassword : function(){
      return this.type = 'C';
    },

    toBackFromReset:function(){
      return this.type = 'B';
    },
    toProofMail: function()
    {
      return this.type = 'G'
    },
    toLogInDS:function (){
      this.type = 'F'
      if (this.type === 'F')
      {
        this.toDisplayKeys()
        setTimeout(this.toDetermine, 100)
      }
    },



    toDisplayKeys: async function()
    {
      const fs = require('fs');
      console.log(this.dir);
      let fileNames = fs.readdirSync(this.dir);
      fileNames.forEach((file) =>
      {
          this.Keys.push(file)
      },
      console.log(this.Keys)
      )
    },
    toHideKeys: async function(keys)
    {
      this.Keys.splice( keys , this.Keys.length);
      this.$forceUpdate()
    },

    toDetermine:async function()
    {
      this.dragAndDropCapable = this.determineDragAndDropCapable();
      if( this.dragAndDropCapable ){
        ['drag', 'dragstart', 'dragend', 'dragover', 'dragenter', 'dragleave', 'drop'].forEach( function( evt ) {
          this.$refs.fileform.addEventListener(evt, function(e){
            e.preventDefault();
            e.stopPropagation();
          }.bind(this), false);
        }.bind(this));
        this.$refs.fileform.addEventListener('drop', function(e){
          for( let i = 0; i < e.dataTransfer.files.length; i++ ) {
            this.Files.push(e.dataTransfer.files[i]);
            this.fileHandler();
            console.log(this.Files)
          }
        }.bind(this));

      }
    },


    determineDragAndDropCapable(){
      var div = document.createElement('div');
      return ( ( 'draggable' in div ) || ( 'ondragstart' in div && 'ondrop' in div ) )
          && 'FormData' in window
          && 'FileReader' in window;
    },


    removeFile( key ){
      this.Files.splice( key, 1 );
      console.log(this.Files)
      this.$forceUpdate()
    },
    getFile(event) {
      this.Files = this.$refs.files.files;
      console.log(this.Files);
      this.fileHandler()
    },

    fileHandler: async function()
    {
      for(let i = 0; i<this.Files.length; i++)
      {
        this.fileInf = this.Files[i]
      }
      const fs = require("fs")
      var fileBuffer = Buffer.from(this.fileInf.path)
      fs.readFile(fileBuffer, (err, data) =>
      {
        if (err) throw err;
        console.log(data.toString());
        var obj = JSON.parse(data.toString());
        console.log(obj);
        this.login = obj.Login;
        this.password = obj.Password;
        Vue.prototype.$http.defaults.baseURL = obj.Server + ":" + obj.Port
        this.fileUpload = true;
        this.directoryCreation();
        this.logIn();


      })

    },
    directoryCreation: async function()
    {
      const fs = require('fs');
      this.dir = 'C:\\Temp\\WorkProjects\\';
      try
      {
        if (!fs.existsSync(this.dir))
        {
          fs.mkdirSync(this.dir);
          console.log("Directory is created.");
          this.copyFile();
        }
        else
        {
          this.copyFile();
          fs.mkdirSync(this.dir);
          console.log("Directory already exists.");
        }
      }
      catch (err)
      {
        console.log(err);
      }
    },

     copyFile:async function ()
     {
      const path = require("path");
      const fs = require("fs");
      const sourceFilePath = path.join(this.fileInf.path);
      const destFilePath = path.join(this.dir, this.fileInf.name);
      fs.copyFile(sourceFilePath, destFilePath, function (err)
      {
        console.log(err);
        console.log(destFilePath);
        console.log(sourceFilePath);
      })
    },
    toSendCode: async function() {
      console.log(this.email)
      var result = await this.api.SendCode(this.email, this.GenRequest.true)
    },
    toValidateCode: async function()
    {
      const titleNoty = "Регистрация в системе Fractalz"
      var result = await this.api.ValidateCode(this.Authcode, this.email)
      if (result.data.success)
      {
        this.noty.Show({title: titleNoty, message: "Добро пожаловать!"});
        return this.logIn()
      } else
      {
        this.noty.Show({title: titleNoty, message: result.data.message});
      }
    },

    singIn : async function () {
      {
        const titleNoty = "Регистрация в системе Fractalz"
        var result = await this.api.Registration(this.login, this.email, this.password)
            .catch(response => {this.noty.Show({
          title: titleNoty, message: response.response.data.message
              });
            });
      }
      const titleNoty = "Регистрация в системе Fractalz"
      if (result.data.success)
      {
        this.noty.Show({title: titleNoty, message: "Вы успешно зарегистрированы!\rОсталось совсем чуть-чуть!"});
        return this.toProofMail();
      } else
      {
        this.noty.Show({title: titleNoty, message: result.data.message});
      }
    },
    logIn : async function () {
      var result = await this.api
          .Login(this.login, this.password)
          .catch(response => {
            this.noty.Show({
              title: "Вход в систему Fractalz",
              message: response.response.data.message
            });
          });
      if(result.data.success)
      {
        this.$cookies.set("UserToken", result.data.token);
        this.$cookies.set("UserInfo", result.data.user);
        this.noty.Show({title : "Вход в систему Fractalz", message : "Добро пожаловать!\rВы успешно вошли в систему."});
        this.connectWebSocket(result.data.user.id);
        await this.$router.push({ name: 'DialogPage' })
      }
      else
      {
        this.noty.Show({title : "Вход в систему Fractalz", message : "Произошла ошибка.\rПроверьте правильность данных!"});
      }

      document.getElementById("login_wrapper").className += " animate-login-wrapper";
      document.getElementById("main-wrapper").className += " animate-background-wrapper";
      document.getElementById("box").className += " animate-box-wrapper";
      setTimeout(async () => { await this.$router.push({ name: 'DialogPage' })},700);
    },

    isAuth()
    {
      var cookiesUserInfo = this.$cookies.get("UserInfo");
      console.log("Info")
      console.log(cookiesUserInfo)
      if(this.$cookies.get("UserInfo"))
      {
        this.login = this.$cookies.get("UserInfo").login
        console.log(this.$cookies.get("UserInfo"))
        return true;
      }
      return false;
    },
    logOut()
    {
      this.$cookies.set("UserInfo", null)
      this.$cookies.set("UserToken", null)
      this.Auth = false;
      location.reload()
      this.login.set(null)
      this.password.set(null)
      Vue.socket.close(1000, "UserDisconnect");

      this.noty.Show({title : "Выход из системы Fractalz", message : "Вы успешно покинули систему!\rЖдем вас снова."});
    },

   connectWebSocket : function (userId) {
      if(this.fileUpload)
      {
        Vue.socket = new WebSocket(Vue.prototype.$http.defaults.baseURL.replace('http', 'ws') + "/ws/subscribe?idUser=" + userId);
      }
      else {
        Vue.socket = new WebSocket(Vue.prototype.$http.defaults.baseURL.replace('http', 'ws') + "/ws/subscribe?idUser=" + userId);

      }
     Vue.socket.onopen = Vue.socketEvents.onopen;
     Vue.socket.onclose = Vue.socketEvents.onclose;
     Vue.socket.onmessage = Vue.socketEvents.onmessage;
     Vue.socket.onerror = Vue.socketEvents.onerror;
    },
    passReset: async function (){
      var Reg = new RegExp("^(?=.*[A-Z]).{1,18}$");
      var reg = new RegExp("^(?=.*[a-z]).{1,18}$");

      if (!(this.newPassword1 === this.newPassword2))
        return this.noty.Show({title : "Сброс пароля в системе Fractalz", message : "Произошла ошибка.\rВведенные пароли не совпадают"});

      if (!(this.newPassword2.length > 6))
        return this.noty.Show({title : "Сброс пароля в системе Fractalz", message : "Произошла ошибка.\rПароль должен быть больше 6 символов!"});

      if (!(this.newPassword2.length < 18))
        return this.noty.Show({title : "Сброс пароля в системе Fractalz", message : "Произошла ошибка.\rПароль должен быть меньше 18 символов!"});

      if (!(reg[Symbol.match](this.newPassword2)))
        return this.noty.Show({title : "Сброс пароля в системе Fractalz", message : "Произошла ошибка.\rПароль должен содержать хотябы одну прописную букву!"});

      if (!(Reg[Symbol.match](this.newPassword2)))
        return this.noty.Show({title : "Сброс пароля в системе Fractalz", message : "Произошла ошибка.\rПароль должен содержать хотябы одну заглавную букву!"});
      const valid = await this.api.ValidateCode(this.Authcode, this.email)
      if (valid.data.success)
      {
        {
          const result = await this.api.PasswordReset(this.existEmail, this.newPassword2).catch(response => {
            this.noty.Show
            ({
              title: "Сброс пароля в системе Fractalz",
              message: "Произошла ошибка!\rПроверьте введенные данные!"
            });
          });
          if (result.data.success) {
            this.noty.Show({
              title: "Смена пароля в системе Fractalz",
              message: "Пароль успешно изменен!\rТеперь вы можете войти в свою учетную запись."
            });
          }
        }
      }
    }
  }

}
</script>
<style>
.animate-login-wrapper{
  animation-name: login-wrapp-anim;
  -webkit-animation-duration: 1s;
  -webkit-animation-iteration-count: 1;
  -webkit-animation-timing-function: ease;
  -webkit-animation-fill-mode: forwards;
}
@keyframes login-wrapp-anim {
  from{
    opacity: 1;
  }
  to{
    opacity: 0;
  }
}
.animate-background-wrapper{
  animation-name: background-wrapp-anim;
  -webkit-animation-duration: 1s;
  -webkit-animation-iteration-count: 1;
  -webkit-animation-timing-function: ease;
  -webkit-animation-fill-mode: forwards;
}
@keyframes background-wrapp-anim {
  from{
    background-color: var(--color-gray);
  }
  to{
    background-color: var(--color-middle-gray);
  }
}
.animate-box-wrapper{
  -webkit-transform-origin-y: top;
  transform-origin-y: top;
  perspective: 800px;
  transform-style: preserve-3d;
  animation-name: box-wrapp-anim;
  -webkit-animation-duration: 2s;
  -webkit-animation-iteration-count: 1;
  -webkit-animation-timing-function: ease;
  -webkit-animation-fill-mode: forwards;
}
@keyframes box-wrapp-anim {
  from{

  }
  to{
    transform: rotateX(180deg);
  }
}
.placeholder-container {
  position: relative;
}
.input-form{
  padding: 10px;
  text-align: center;
  color: var(--color-dark-blue);
  background-color: var(--color-white);
  border: 0px;
  width: 340px;
  border-radius: var(--radius-max);
}
.ecp-input-form{
  padding: 10px;
  text-align: center;
  color: var(--color-dark-blue);
  background-color: var(--color-white);
  border: 0px;
  width: 140px;
  border-radius: var(--radius-max);
}

.ecp-form{
  display: table-cell;
  vertical-align: middle;
  text-align: center;
  vertical-align: middle;
  width: 100%;
  height: 100%;
  pointer-events: none;
  color: var(--color-dark-blue);
}

.ecp-label{
  padding-right: 60px;
}

.ecp-select-form{
  padding-top: 10px;
  padding-bottom: 10px;
  vertical-align: middle;
  text-align: center;
  pointer-events: none;
  color: var(--color-dark-blue);
}

.placeholder-container label {
  transition: 0.2s;
  padding: 10px;
  text-align: center;
  position: absolute;
  pointer-events: none;
  border-radius: var(--radius-max);
  color: var(--color-dark-blue);
}

.main-wrapper{
  background-color: var(--color-gray);
  width: 100vw;
  height: 100vh;
}

.box-angle {
  z-index: 0;
  width: 100%;
  pointer-events: none;
  user-select: none;
}
.logo{
  z-index: 1;
  margin-top: -65px;
  pointer-events: none;
  user-select: none;
}
.wrapper-login-form{

}

.title-login-form{
  font-family: 'Roboto', sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 52px;
  color: var(--color-dark-blue);
}

.title-registration-form{
  font-family: 'Roboto', sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 26px;
  color: var(--color-dark-blue);
}

.title-recovery-form{
  font-family: 'Roboto', sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 20px;
  color: var(--color-dark-blue);
  text-align: center;
}

.title-recovery-account-form{
  font-family: 'Roboto', sans-serif;
  font-style: normal;
  font-weight: 400;
  font-size: 26px;
  color: var(--color-dark-blue);
}

.button-form{
  background-color: var(--color-dark-blue);
  color: var(--color-white);
  border: none;
  transition: .2s;
}
.label-form{
  font-size: 13px;
  color: var(--color-ultra-dark-gray);
}
.href-form{
  margin-left: 5px;
  font-size: 13px;
  color: var(--color-dark-blue);
  cursor: pointer;
}
.button-form:hover{
  box-shadow: var(--shadow-down-4);
}

.ecp-drag-n-drop-zone
{
  display: table;
  text-align: center;
  margin-top: 15px;
  position: relative;
  height: 270px;
  width: 340px;
  border-color: var(--color-dark-blue);
  border-width: 2px;
  background-color: var(--color-gray);
  border-style: dashed;
}

.justify-content-center input:focus + label,
.justify-content-center input:not(:placeholder-shown) + label{

  top: -10px;
  border-radius: var(--radius-max);
  color: var(--color-white);
  font-size: 11px;
  background-color: var(--color-dark-blue);
  padding: 2px 10px;
}
button:active, button:focus {
  outline: none;
}
button::-moz-focus-inner {
  border: 0;
}
input:active, input:focus {
  outline: none;
}
input::-moz-focus-inner {
  border: 0;
}
::placeholder { /* Most modern browsers support this now. */
  color:   var(--color-dark-blue);
}
</style>
