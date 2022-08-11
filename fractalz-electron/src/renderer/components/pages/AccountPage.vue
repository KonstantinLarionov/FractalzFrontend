<template>
  <div class="account-wrap p-3" id="accountSpace">
    <div class="container-fluid">
      <div class="col">
    <div class="row  w-100 d-flex flex-column"><div style="display: flex; justify-content: center"><img  width="200" height="200" src="https://via.placeholder.com/200"/></div></div>
    <div class="row w-100 d-flex flex-column">
      <div class="input__wrapper">
        <input name="file" type="file" id="input__file" class="input input__file" multiple>
        <label for="input__file" class="input__file-button">
          <span class="input__file-icon-wrapper">
            <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-download" viewBox="0 0 16 16">
              <path d="M.5 9.9a.5.5 0 0 1 .5.5v2.5a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-2.5a.5.5 0 0 1 1 0v2.5a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2v-2.5a.5.5 0 0 1 .5-.5z"/>
              <path d="M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"/>
            </svg>
          </span>
          <span class="input__file-button-text">Выберите файл</span>
        </label>
      </div>
    </div>
      </div>
    </div>
    <div class="container-fluid " style="overflow-y: scroll;">
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold">Ваш Email: </label>
      <input v-model="model.email" type="text" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold">Имя: </label>
      <input type="text" v-model="model.name" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold">Фамилия: </label>
      <input type="text" v-model="model.surname" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold" >Отчество: </label>
      <input type="text" v-model="model.patro" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold">Логин: </label>
      <input type="text" v-model="model.login" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold">Телефон: </label>
      <input  v-model="model.number" type="text" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label style="font-weight: bold">Файл подписи: </label>
      <input type="text" class="account-input-text"/>

      <small class="text-muted">(нужен только для внутренних серверов)</small>
    </div>
    <div class="row w-100 d-flex flex-column">
      <button class="btn btn-success account-input-btn" v-on:click="updateProfile()">Сохранить</button>
    </div>
    </div>
  </div>
</template>

<script>
import UserPart from "../../api/UserPart";
import NotifyCenter from "../../services/NotifyCenter";

export default {
  name: "AccountPage",
  props: {
    api: Object,
    noty: Object
  },
  data()
  {
    return {
      model : {
        userId: this.$cookies.get("UserInfo").id,
        login: this.$cookies.get("UserInfo").login,
        name: this.$cookies.get("UserInfo").name,
        surname: this.$cookies.get("UserInfo").surname,
        patro: this.$cookies.get("UserInfo").patro,
        number: this.$cookies.get("UserInfo").number,
        email: this.$cookies.get("UserInfo").email,
        logo: this.$cookies.get("UserInfo").logo,
      },
      notyHeader: "Профиль Fractalz"
    };
  },

  mounted() {
    this.api = new UserPart(this.$http);
    this.noty = new NotifyCenter();
  },
  methods:{
    updateProfile : async function() {
      var result = await this.api.UpdateProfile(this.model);
      if(result.success)
      {
        this.noty.Show({title : notyHeader, message : "Профиль успешно обновлен!"});
      }
      else {
        this.noty.Show({title : notyHeader, message : "Произошла ошибка. Проверьте правильность данных!"});
      }
    },
  },
}
</script>

<style scoped></style>
