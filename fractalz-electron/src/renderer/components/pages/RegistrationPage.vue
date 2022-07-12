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
          <input type="password" v-model="password" placeholder="Пароль"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Войти</button>
          <button class="modal-default-button mr-4 navTask mt-1" v-if="Auth" style="background-color: darkred" v-on:click="logOut()">Выйти</button>
          <p class= "message">Нет аккаута? <a v-on:click="toCreateAccount()">Создать аккаунт</a></p>
          <p class= "password-reset-text"> Забыли пароль?</p>
          <p class= "password-resetbutton"> <a v-on:click="toResetPassword()">Нажмите чтобы восстановить доступ</a></p>
        </div>
        <div v-if="type === 'C'" class="password-reset-form">
          <p class="reset-title"> Для восстановления доступа вам необходимо сбросить старый пароль и установить новый.
            Для этого мы отправим вам на Email одноразовый код для подтверждения </p>
          <input type="text" v-model="existEmail" placeholder="Ваш зарегестрированный Email" />
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toSendCode()">Отправить код</button>
          <input type="text" v-model="Authcode" placeholder="Ваш одноразовый код" />
          <input type="text" v-model="newPassword1" placeholder="Новый пароль"/>
          <input type="text" v-model="newPassword2" placeholder="Подтверждение нового пароля"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="passReset()">Сохранить</button>
          <p class= "password-resetbutton-back"> <a v-on:click="toBackFromReset()">Вернуться назад</a></p>
      </div>
        <div v-if="type === 'D'" class="auth-code-form">
          <p class="code-title">Почти готово!</p>
          <p class="Code-code">Для потверждения введите код который отправлен на указанную вами почту.</p>
          <input type="text" v-model="Authcode" placeholder="Код"/>
          <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toValidateCode()">Подтвердить</button>
          <p class="message"><a v-on:click="toCreateAccount()">Вернуться назад</a></p>
        </div>
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
      password:"",
      login : '',
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
    this.Auth = this.isAuth();
    this.api = new UserPart(this.$http);
    this.noty = new NotifyCenter();
  },

  methods: {
    toCreateAccount : function () {
      return this.type = 'A';
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

    toSendCode: async function()
    {
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
        var Reg = new RegExp("^(?=.*[A-Z]).{1,18}$");
        var reg = new RegExp("^(?=.*[a-z]).{1,18}$");

        if (!(this.password.length > 6))
          return this.noty.Show({title : "Регистрация в системе Fractalz", message : "Произошла ошибка.\rПароль должен быть больше 6 символов!"});

        if (!(this.password.length < 18))
          return this.noty.Show({title : "Регистрация в системе Fractalz", message : "Произошла ошибка.\rПароль должен быть меньше 18 символов!"});

        if (!(reg[Symbol.match](this.password)))
          return this.noty.Show({title : "Регистрация в системе Fractalz", message : "Произошла ошибка.\rПароль должен содержать хотябы одну прописную букву!"});

        if (!(Reg[Symbol.match](this.password)))
          return this.noty.Show({title : "Регистрация в системе Fractalz", message : "Произошла ошибка.\rПароль должен содержать хотябы одну заглавную букву!"});

        const titleNoty = "Регистрация в системе Fractalz"
        var result = await this.api.Registration(this.login, this.email, this.password)
            .catch(response => {this.noty.Show({
          title: titleNoty, message: "Произошла ошибка.\rВозможно такой пользователь уже существует"
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
      if(this.$cookies.get("UserInfo"))
      {
        this.login = this.$cookies.get("UserInfo").login
        this.password = this.$cookies.get("UserInfo").password
        this.email = this.$cookies.get("UserInfo").email
        return true;
      }
      return false;
    },
    logOut()
    {
      this.$cookies.set("UserInfo", null)
      this.$cookies.set("UserToken", null)
      this.Auth = false;
      Vue.socket.close(1000, "UserDisconnect");
      this.noty.Show({title : "Выход из системы Fractalz", message : "Вы успешно покинули систему!\rЖдем вас снова."});
    },
    logIn : async function () {
      var result = await this.api
          .Login(this.login, this.password)
          .catch(response => {
            this.noty.Show({
          title: "Вход в систему Fractalz",
          message: "Произошла ошибка!\rПроверьте введенные данные"
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
      else {
        this.noty.Show({title : "Вход в систему Fractalz", message : "Произошла ошибка.\rПроверьте правильность данных!"});
      }
    },
    connectWebSocket : function (userId) {
      Vue.socket = new WebSocket(Vue.prototype.$http.defaults.baseURL.replace('http', 'ws') + "/ws/subscribe?idUser="+userId);
      Vue.socket.onopen = Vue.socketEvents.onopen;
      Vue.socket.onclose = Vue.socketEvents.onclose;
      Vue.socket.onmessage = Vue.socketEvents.onmessage;
      Vue.socket.onerror = Vue.socketEvents.onerror;
    }
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
