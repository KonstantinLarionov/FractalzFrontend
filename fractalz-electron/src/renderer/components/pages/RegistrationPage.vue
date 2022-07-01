<template>
  <div class="login-page">
    <div class="form">
      <form v-if="isLogin == false" class="register-form">
        <input type="text" id="login" placeholder="Логин"/>
        <input type="password" id="password" placeholder="Пароль"/>
        <input type="text" id="email" placeholder="Почта"/>
        <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="singIn()">Зарегистрироваться</button>
        <p class="message">Уже зарегистрированы? <a v-on:click="toSingIn()">Войти</a></p>
      </form>
      <form v-else-if="isLogin == true" class="login-form">
        <input type="text" id="userLogin" placeholder="Логин/Почта"/>
        <input type="password" id="userPassword" placeholder="Пароль"/>
        <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="logIn()">Войти</button>
        <p class="message">Нет аккаута? <a v-on:click="toCreateAccount()">Создать аккаунт</a></p>
      </form>
    </div>
  </div>
</template>

<script>
import Vue from 'vue'

export default {
  name: "RegistrationPage",
  data() {
    return{
      isLogin: true
    }
  },
  methods: {
    toCreateAccount : function () {
      this.isLogin = false;
    },
    toSingIn : function () {
      this.isLogin = true;
    },
    singIn : function () {
      console.log("хуй")
      var singInRequest = Vue.http
      singInRequest.Registration(document.getElementById("login").value, document.getElementById("email").value, document.getElementById("password").value)
    },
    logIn : function () {
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
</style>