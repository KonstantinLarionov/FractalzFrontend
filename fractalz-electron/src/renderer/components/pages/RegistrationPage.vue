<template xmlns="http://www.w3.org/1999/html">
  <div class="main-wrapper container-fluid">
    <div class="row">
      <img class=" box-angle" src="src/renderer/assets/images/img.png"/>
    </div>
    <div class="row justify-content-center">
        <img class="logo " src="src/renderer/assets/images/logo-img.png" height="100" width="100"/>
    </div>
    <div class="container-fluid wrapper-login-form">
      <div class="row justify-content-center">
        <label class="title-login-form">Леттер.</label>
      </div>
      <div class="wrapper-input-form justify-content-between">
        <div class="row mt-4 justify-content-center">
          <input type="text" class="input-form" placeholder="Введите логин"/>
        </div>
        <div class="row mt-4 justify-content-center">
          <input type="password" class="input-form" placeholder="Введите пароль"/>
        </div>
        <div class="row mt-4 justify-content-center">
          <button class="input-form button-form">Войти</button>
        </div>
        <div class="row mt-4 justify-content-center">
          <label class="label-form">Нет аккаунта?</label>
          <a class="href-form" href="">Создать аккаунт</a>
        </div>
        <div class="row justify-content-center">
          <label class="label-form">Забыли пароль?</label>
        </div>
        <div class="row justify-content-center">
          <a class="href-form" style="margin-top: -12px" href="">Нажмите чтобы восстановить доступ</a>
        </div>
        <div class="row mt-2 justify-content-center">
          <a class="href-form" href="">Войти с цифровым ключём</a>
        </div>

      </div>

    </div>

    <!--      <div class="form">-->
<!--        <div v-if="type === 'A'" class="register-form">-->
<!--          <p class="registration-title">Регистрация нового пользователя в системе Fractalz!</p>-->
<!--          <input type="text" v-model="login" placeholder="Логин"/>-->
<!--          <input type="text" v-model="email" placeholder="Почта"/>-->
<!--          <input type="password" v-model="password" placeholder="Пароль"/>-->
<!--          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="singIn()">Создать</button>-->
<!--          <p class="message">Уже зарегистрированы? <a v-on:click="toSingIn()">Войти</a></p>-->
<!--        </div>-->
<!--        <div v-if="type === 'B'" class="login-form">-->
<!--          <input type="text" v-model="login" placeholder="Логин/Почта" />-->
<!--          <input type="password" v-model="password" placeholder="Пароль" @keyup.enter="logIn"/>-->
<!--          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Войти</button>-->
<!--          <p class= "message">Нет аккаута? <a v-on:click="toCreateAccount()">Создать аккаунт</a></p>-->
<!--          <p class= "password-reset-text"> Забыли пароль?</p>-->
<!--          <p class= "password-resetbutton"> <a v-on:click="toResetPassword()">Нажмите чтобы восстановить доступ</a></p>-->
<!--&lt;!&ndash;          <p class= "message">Хотите зарегистрироваться с ЭЦП? <a v-on:click="toCreateDSAccount()"><br>Создать аккаунт с ЭЦП</a></p>&ndash;&gt;-->
<!--          <p class= "message">Войти с цифровым ключём<a v-on:click="toLogInDS()"><br>Войти с цифровым ключём</a> </p>-->
<!--        </div>-->
<!--        <div v-if="type === 'C'" class="password-reset-form">-->
<!--          <p class="reset-title"> Для восстановления доступа вам необходимо сбросить старый пароль и установить новый.-->
<!--            Для этого мы отправим вам на Email одноразовый код для подтверждения </p>-->
<!--          <input type="text" v-model="existEmail" placeholder="Ваш зарегестрированный Email"-->
<!--          @keyup.enter="toSendCode"/>-->
<!--          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toSendCode()">Отправить код</button>-->
<!--          <input type="text" v-model="Authcode" placeholder="Ваш одноразовый код" />-->
<!--          <input type="password" v-model="newPassword1" placeholder="Новый пароль"/>-->
<!--          <input type="password" v-model="newPassword2" placeholder="Подтверждение нового пароля"-->
<!--          @keyup.enter="passReset"/>-->
<!--          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="passReset()">Сохранить</button>-->
<!--          <p class= "password-resetbutton-back"> <a v-on:click="toBackFromReset()">Вернуться назад</a></p>-->
<!--      </div>-->
<!--        <div v-if="type === 'D'" class="auth-code-form">-->
<!--          <p class="code-title">Почти готово!</p>-->
<!--          <p class="Code-code">Для потверждения введите код который отправлен на указанную вами почту.</p>-->
<!--          <input type="text" v-model="Authcode" placeholder="Код"-->
<!--          @keyup.enter="toValidateCode"/>-->
<!--          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toValidateCode()">Подтвердить</button>-->
<!--          <p class="message"><a v-on:click="toCreateAccount()">Вернуться назад</a></p>-->
<!--        </div>-->
<!--&lt;!&ndash;        <div v-if="type === 'E'" class="digital-signature-registration">-->
<!--          <p class="registration-title">Регистрация нового пользователя в системе с цифровым ключём</p>-->
<!--          <input type="text" v-model="login" placeholder="Логин"/>-->
<!--          <input type="text" v-model="email" placeholder="Почта"/>-->
<!--          <input type="password" v-model="password" placeholder="Пароль"/>-->
<!--          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="singInDS()">Создать</button>-->
<!--          <p class="message">Уже зарегистрированы? <a v-on:click="toSingIn()">Войти</a></p>-->

<!--        </div>&ndash;&gt;-->
<!--        <div v-if="type === 'F'" class="digital-signature-login">-->
<!--          <p>Вход в учетную запись с использованием ЭЦП</p>-->

<!--          <div class="drag-n-drop" style="overflow: auto" id="drag-n-drop">-->
<!--            <form ref="fileform" class="space-drag-drop"  >-->
<!--                <span class="drop-files-title" >Перетащите файл сюда</span>-->
<!--              <div v-for="(file, key) in Files" class="file-listing-reg" >-->
<!--                <div class="remove-container">-->
<!--                  <a class="remove" @click="removeFile( key )">Удалить</a>-->
<!--                </div>-->
<!--                <img class="preview" v-bind:ref="'preview'+parseInt( key )"/>-->
<!--                {{ file.name }}-->
<!--              </div>-->
<!--            </form>-->
<!--          </div>-->

<!--          <p> Или </p>-->
<!--          <input type="file" content="Выберите в файловой системе" v-on:change="getFile($event)"  multiple ref="files">-->
<!--          <label> Существующие ключи доступа: </label>-->
<!--          <div class="keys-box">-->
<!--            <div class="keys-listing" v-for="keys in Keys" :key="keys.$id">-->
<!--              <DigitalKeysBox :key-name="keys" :api="api" :noty="noty"></DigitalKeysBox>-->
<!--            </div>-->
<!--          </div>-->

<!--          <p class="message" style="margin-top: 14px">-->
<!--            <a v-on:click="toSingIn(), toHideKeys()">Вернуться назад</a>-->
<!--          </p>-->
<!--        </div>-->
<!--     </div>-->
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
      return this.type = 'A';
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
    toLogInDS:function (){
      this.type = 'F'
      if (this.type === 'F')
      {
        this.toDisplayKeys()
        setTimeout(this.toDetermine, 100)
      }
    },
    toSendCode: async function() {
      var result = await this.api.SendCode(this.email, this.GenRequest.true)
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

    toValidateCode: async function()
    {
      const titleNoty = "Регистрация в системе Fractalz"
      var result = await this.api.ValidateCode(this.Authcode, this.email)
      if (result.data.success)
      {
        this.noty.Show({title: titleNoty, message: "Добро пожаловать!"});
        return this.logIn();
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
        this.type = "D"
        return this.toSendCode();
      } else
      {
        this.noty.Show({title: titleNoty, message: result.data.message});
      }
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
.main-wrapper{
  background-color: var(--color-gray);
  width: 100vw;
  height: 100vh;
}

.box-angle {
  z-index: 0;
  width: 100%;
}
.logo{
  z-index: 1;
  margin-top: -65px;
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
.input-form{
  padding: 10px;
  text-align: center;
  color: var(--color-dark-blue);
  background-color: var(--color-white);
  border: 0px;
  width: 340px;
  border-radius: var(--radius-max);
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
}
.button-form:hover{
  box-shadow: var(--shadow-down-4);
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
