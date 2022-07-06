<template>
  <div class="login-page">
    <div class="form">
      <form v-if="isLogin == false" class="register-form">
        <input type="text" v-model="login" placeholder="Логин"/>
        <input type="text" v-model="email" placeholder="Почта"/>
        <input type="password" v-model="password" placeholder="Пароль"/>
        <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="singIn()">Создать</button>
        <p class="message">Уже зарегистрированы? <a v-on:click="toSingIn()">Войти</a></p>
      </form>
      <form v-else-if="isLogin == true" class="login-form">
        <input type="text" v-model="login" placeholder="Логин/Почта" />
        <input type="password" v-model="password" placeholder="Пароль"/>
        <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Войти</button>
        <button class="modal-default-button mr-4 navTask mt-1" v-if="Auth" style="background-color: darkred" v-on:click="logOut()">Выйти</button>
        <p class= "message">Нет аккаута? <a v-on:click="toCreateAccount()">Создать аккаунт</a></p>
        <p class= "password-reset"> Забыли пароль?</p>
        <p class= "password-resetbutton"> <a v-on:click="toResetPassword()">Нажмите чтобы восстановить доступ</a></p>
      </form>
      <form v-if="passwordReset == true" class="password-reset-form">
        <p class="reset-title"> Для восстановления доступа вам необходимо сбросить старый пароль и установить новый.
          Для этого мы отправим вам на почту одноразовый код для подтверждения </p>
        <input type="text" v-model="login" placeholder="Почта(ваш зарегестрированный Email)" />
        <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Отправить код</button>
        <input type="text" placeholder="Ваш одноразовый код" />
        <input type="text" v-model="password" placeholder="Старый пароль"/>
        <input type="text" v-model="newPassword" placeholder="Новый пароль"/>
        <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Сохранить</button>
        <button class="modal-default-button mr-4 navTask mt-1" v-if="Auth" style="background-color: darkred" v-on:click="logIn()">Войти</button>
      </form>
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
      isLogin: true,
      login : 'kostya12277',
      email : 'kostya12277@yandex.ru',
      password: '4TheHorde!',
      passwordReset: false,
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
      this.isLogin = false;
    },

    toSingIn : function () {
      this.isLogin = true;
    },

    toResetPassword : function(){
      this.passwordReset = true;
    },

    singIn : async function () {
      var titleNoty = "Регистрация в системе Fractalz";
      var result = await this.api
          .Registration(this.login, this.email, this.password)
          .catch(response => {
            this.noty.Show({
              title: titleNoty,
              message: "Произошла ошибка. Возможно такой пользователь уже существует"
            });
          });

      if (result.data.success) {
        this.noty.Show({title: titleNoty, message: "Вы успешно зарегистрированы! Пожалуйста войдите в систему."});
        this.toSingIn();
      } else {
        this.noty.Show({title: titleNoty, message: "Произошла ошибка. Проверьте правильность данных!"});
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
      this.noty.Show({title : "Выход из системы Fractalz", message : "Вы успешно покинули систему! Ждем вас снова."});
    },
    logIn : async function () {
      var result = await this.api
          .Login(this.login, this.password)
          .catch(response => {
            this.noty.Show({
          title: "Вход в систему Fractalz",
          message: "Произошла ошибка! Проверьте введенные данные"
        });
      });
      if(result.data.success)
      {
        this.$cookies.set("UserToken", result.data.token);
        this.$cookies.set("UserInfo", result.data.user);
        this.noty.Show({title : "Вход в систему Fractalz", message : "Добро пожаловать!\rВы успешно вошли в систему."});
        await this.$router.push({ name: 'DialogPage' })
      }
      else {
        this.noty.Show({title : "Вход в систему Fractalz", message : "Произошла ошибка. Проверьте правильность данных!"});
      }
    },
  }

}
</script>

<style>
@import url(https://fonts.googleapis.com/css?family=Roboto:300);

.login-page {
  width: 360px;
  padding: 10% 0 0;
  margin: auto;
}
.form {
  position: relative;
  z-index: 1;
  background: #FFFFFF;
  max-width: 360px;
  margin: 0 auto 100px;
  padding: 45px;
  text-align: center;
  box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
}
.form input {
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
.form button {
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
}
.form .message {
  margin: 15px 0 0;
  color: #b3b3b3;
  font-size: 12px;
}
.form .message a {
  color: #009788;
  cursor: pointer;
  text-decoration: none;
}
.form .password-reset{
  margin: 15px 0 0;
  color: #b3b3b3;
  font-size: 12px;
}
.form .password-resetbutton{
  color: #009788;
  cursor: pointer;
  text-decoration: none;
  font-size: 12px;
}

</style>
