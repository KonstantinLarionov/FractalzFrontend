<template>
  <div class="login-page-vertical">
      <div class="form">
        <div v-if="type === 'A'" class="register-form">
          <p class="registration-title">Регистрация нового пользователя в системе Fractalz!</p>
          <input type="text" v-model="login" placeholder="Логин"/>
          <input type="text" v-model="email" placeholder="Почта"/>
          <input type="password" v-model="password" placeholder="Пароль"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="singIn()">Создать</button>
          <p class="message">Уже зарегистрированы? <a v-on:click="toSingIn()">Войти</a></p>
        </div>
        <div v-if="type === 'B'" class="login-form">
          <input type="text" v-model="login" placeholder="Логин/Почта" />
          <input type="password" v-model="password" placeholder="Пароль" @keyup.enter="logIn"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Войти</button>
          <p class= "message">Нет аккаута? <a v-on:click="toCreateAccount()">Создать аккаунт</a></p>
          <p class= "password-reset-text"> Забыли пароль?</p>
          <p class= "password-resetbutton"> <a v-on:click="toResetPassword()">Нажмите чтобы восстановить доступ</a></p>
          <p class= "message">Хотите зарегистрироваться с ЭЦП? <a v-on:click="toCreateDSAccount()"><br>Создать аккаунт с ЭЦП</a></p>
          <p class= "message">Войти с цифровым ключём<a v-on:click="toLogInDS()"><br>Войти с цифровым ключём</a> </p>
        </div>
        <div v-if="type === 'C'" class="password-reset-form">
          <p class="reset-title"> Для восстановления доступа вам необходимо сбросить старый пароль и установить новый.
            Для этого мы отправим вам на Email одноразовый код для подтверждения </p>
          <input type="text" v-model="existEmail" placeholder="Ваш зарегестрированный Email"
          @keyup.enter="toSendCode"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toSendCode()">Отправить код</button>
          <input type="text" v-model="Authcode" placeholder="Ваш одноразовый код" />
          <input type="password" v-model="newPassword1" placeholder="Новый пароль"/>
          <input type="password" v-model="newPassword2" placeholder="Подтверждение нового пароля"
          @keyup.enter="passReset"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="passReset()">Сохранить</button>
          <p class= "password-resetbutton-back"> <a v-on:click="toBackFromReset()">Вернуться назад</a></p>
      </div>
        <div v-if="type === 'D'" class="auth-code-form">
          <p class="code-title">Почти готово!</p>
          <p class="Code-code">Для потверждения введите код который отправлен на указанную вами почту.</p>
          <input type="text" v-model="Authcode" placeholder="Код"
          @keyup.enter="toValidateCode"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toValidateCode()">Подтвердить</button>
          <p class="message"><a v-on:click="toCreateAccount()">Вернуться назад</a></p>
        </div>
        <!-- Comment
        <div v-if="type === 'E'" class="digital-signature-registration">
          <p class="registration-title">Регистрация нового пользователя в системе с цифровым ключём</p>
          <input type="text" v-model="login" placeholder="Логин"/>
          <input type="text" v-model="email" placeholder="Почта"/>
          <input type="password" v-model="password" placeholder="Пароль"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="singInDS()">Создать</button>
          <p class="message">Уже зарегистрированы? <a v-on:click="toSingIn()">Войти</a></p>

        </div>
        <div v-if="type === 'F'" class="digital-signature-login">
          <input type="text" v-model="login" placeholder="Логин/Почта" />
          <input type="password" v-model="password" placeholder="Пароль"
                 @keyup.enter="logIn"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Войти</button>
          <button class="modal-default-button mr-4 navTask mt-1" v-if="Auth" style="background-color: darkred" v-on:click="logOut()">Выйти</button>
          <p class= "password-reset-text"> Забыли пароль?</p>
          <p class= "password-resetbutton"> <a v-on:click="toResetPassword()">Нажмите чтобы восстановить доступ</a></p>
          <button class="modal-default-button mr-4 navTask dark-teal">Прикрепить документ</button>
        </div>-->
     </div>
  </div>
</template>


<script>
import UserPart from "../../api/UserPart";
import Vue from "vue";
import NotifyCenter from "../../services/NotifyCenter";

export default {
  name: "RegistrationPage",

  data() {
    return{
      Auth : false,
      isLogin:true,
      GenRequest: true,
      type: 'B',
      password:null,
      login : null,
      email : '',
      existEmail:"",
      newPassword1: "",
      newPassword2: "",
      Authcode:"",
    }
  },

  props: {
    api: Object,
    noty: Object
  },

  mounted() {
    this.api = new UserPart(this.$http);
    this.noty = new NotifyCenter();
    this.Auth = this.isAuth();
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
    toLogInDS: function (){
      return this.type = 'F'
    },

    toSendCode: async function() {
      var result = await this.api.SendCode(this.email, this.GenRequest.true)
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
        this.login = null
        this.password = null
      }
      else
      {
        this.noty.Show({title : "Вход в систему Fractalz", message : "Произошла ошибка.\rПроверьте правильность данных!"});
      }
    },
   connectWebSocket : function (userId) {
      Vue.socket = new WebSocket(Vue.prototype.$http.defaults.baseURL.replace('http', 'ws') + "/ws/subscribe?idUser="+userId);
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
@import url(https://fonts.googleapis.com/css?family=Roboto:300);

.login-page-vertical
{
  z-index: 0;
  width:360px;
  display: table;
  margin: 0% auto;
  vertical-align: middle;
}
.form
{
  z-index: 1;
  background: #FFFFFF;
  max-width: 360px;
  margin: 10% auto auto auto;
  padding: 35px;

  text-align: center;
  box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
}
.form input
{
  font-family: "Roboto", sans-serif;
  outline: 0;
  background: #f2f2f2;
  width: 100%;
  border: 0;
  margin: 0 0 15px;
  padding: 15px;
  box-sizing: border-box;
  font-size: 14px;
}
.form button
{
  font-family: "Roboto", sans-serif;
  text-transform: uppercase;
  outline: 0;
  background: #009788;
  width: 100%;
  border: 0;
  padding: 15px;
  color: #FFFFFF;
  font-size: 14px;
  cursor: pointer;
  margin: 0px 0px 15px;
}
.form .registration-title
{
  color: #009788;
  font-size: 16px;
}
.form .code-title
{
  color: #009788;
  font-size: 18px;
}
.form .message
{
  margin: 0px 15px 15px;
  color: #b3b3b3;
  font-size: 12px;
}
.form .message a
{
  color: #009788;
  cursor: pointer;
  text-decoration: none;
}
.form .password-reset-text
{
  margin: 15px 0 0;
  color: #b3b3b3;
  font-size: 12px;
}
.form .reset-title{

  margin: 0px 15px 15px;
  color: #000000;
  font-size: 15px;
}
.form .password-resetbutton
{
  color: #009788;
  cursor: pointer;
  text-decoration: none;
  font-size: 12px;
}

.form .password-resetbutton-back
{
  color: #009788;
  cursor: pointer;
  text-decoration: none;
  font-size: 12px;
  margin: 15px 15px 15px;
}

</style>
