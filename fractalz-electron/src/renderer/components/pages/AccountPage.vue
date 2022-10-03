<template>
  <div class="container-fluid" id="accountSpace">
    <div class="row">
      <div class="background-profile">
        <button class="background-edit-button">
          <svg class="edit-button-icon" width="20" height="20" viewBox="0 0 10 9" xmlns="http://www.w3.org/2000/svg">
            <g clip-path="url(#clip0_11_114)">
              <path d="M9.68875 1.09126C9.74714 1.14398 9.77993 1.21538 9.77993 1.28982C9.77993 1.36426 9.74714 1.43566 9.68875 1.48838L9.03687 2.07563L7.78687 0.950633L8.43875 0.363383C8.49735 0.310656 8.57682 0.281036 8.65969 0.281036C8.74255 0.281036 8.82202 0.310656 8.88062 0.363383L9.68875 1.0907V1.09126ZM8.595 2.47276L7.345 1.34776L3.08687 5.18063C3.05248 5.21158 3.02658 5.24934 3.01125 5.29088L2.50812 6.64876C2.499 6.67351 2.4977 6.70006 2.50438 6.72544C2.51106 6.75082 2.52545 6.77403 2.54594 6.79247C2.56643 6.81091 2.59222 6.82386 2.62042 6.82987C2.64862 6.83589 2.67812 6.83472 2.70562 6.82651L4.21437 6.37369C4.26048 6.36006 4.30242 6.33695 4.33687 6.3062L8.595 2.47332V2.47276Z" />
              <path fill-rule="evenodd" clip-rule="evenodd" d="M0.625 7.59375C0.625 7.81753 0.723772 8.03214 0.899587 8.19037C1.0754 8.34861 1.31386 8.4375 1.5625 8.4375H8.4375C8.68614 8.4375 8.9246 8.34861 9.10041 8.19037C9.27623 8.03214 9.375 7.81753 9.375 7.59375V4.21875C9.375 4.14416 9.34208 4.07262 9.28347 4.01988C9.22487 3.96713 9.14538 3.9375 9.0625 3.9375C8.97962 3.9375 8.90013 3.96713 8.84153 4.01988C8.78292 4.07262 8.75 4.14416 8.75 4.21875V7.59375C8.75 7.66834 8.71708 7.73988 8.65847 7.79262C8.59987 7.84537 8.52038 7.875 8.4375 7.875H1.5625C1.47962 7.875 1.40013 7.84537 1.34153 7.79262C1.28292 7.73988 1.25 7.66834 1.25 7.59375V1.40625C1.25 1.33166 1.28292 1.26012 1.34153 1.20738C1.40013 1.15463 1.47962 1.125 1.5625 1.125H5.625C5.70788 1.125 5.78737 1.09537 5.84597 1.04262C5.90458 0.989879 5.9375 0.918342 5.9375 0.84375C5.9375 0.769158 5.90458 0.697621 5.84597 0.644876C5.78737 0.592132 5.70788 0.5625 5.625 0.5625H1.5625C1.31386 0.5625 1.0754 0.651395 0.899587 0.809629C0.723772 0.967862 0.625 1.18247 0.625 1.40625V7.59375Z"/>
            </g>
            <defs>
              <clipPath id="clip0_11_114">
                <rect width="10" height="9" fill="white"/>
              </clipPath>
            </defs>
          </svg>
        </button>
      </div>
    </div>
    <div class="row">
      <div class="profile-wrapper">
        <div class="profile-logo-wrapper">
          <div class="profile-logo">
            <button class="profile-edit-logo">
              <svg class="edit-button-icon" width="20" height="20" viewBox="0 0 10 9" xmlns="http://www.w3.org/2000/svg">
                <g clip-path="url(#clip0_11_114)">
                  <path d="M9.68875 1.09126C9.74714 1.14398 9.77993 1.21538 9.77993 1.28982C9.77993 1.36426 9.74714 1.43566 9.68875 1.48838L9.03687 2.07563L7.78687 0.950633L8.43875 0.363383C8.49735 0.310656 8.57682 0.281036 8.65969 0.281036C8.74255 0.281036 8.82202 0.310656 8.88062 0.363383L9.68875 1.0907V1.09126ZM8.595 2.47276L7.345 1.34776L3.08687 5.18063C3.05248 5.21158 3.02658 5.24934 3.01125 5.29088L2.50812 6.64876C2.499 6.67351 2.4977 6.70006 2.50438 6.72544C2.51106 6.75082 2.52545 6.77403 2.54594 6.79247C2.56643 6.81091 2.59222 6.82386 2.62042 6.82987C2.64862 6.83589 2.67812 6.83472 2.70562 6.82651L4.21437 6.37369C4.26048 6.36006 4.30242 6.33695 4.33687 6.3062L8.595 2.47332V2.47276Z" />
                  <path fill-rule="evenodd" clip-rule="evenodd" d="M0.625 7.59375C0.625 7.81753 0.723772 8.03214 0.899587 8.19037C1.0754 8.34861 1.31386 8.4375 1.5625 8.4375H8.4375C8.68614 8.4375 8.9246 8.34861 9.10041 8.19037C9.27623 8.03214 9.375 7.81753 9.375 7.59375V4.21875C9.375 4.14416 9.34208 4.07262 9.28347 4.01988C9.22487 3.96713 9.14538 3.9375 9.0625 3.9375C8.97962 3.9375 8.90013 3.96713 8.84153 4.01988C8.78292 4.07262 8.75 4.14416 8.75 4.21875V7.59375C8.75 7.66834 8.71708 7.73988 8.65847 7.79262C8.59987 7.84537 8.52038 7.875 8.4375 7.875H1.5625C1.47962 7.875 1.40013 7.84537 1.34153 7.79262C1.28292 7.73988 1.25 7.66834 1.25 7.59375V1.40625C1.25 1.33166 1.28292 1.26012 1.34153 1.20738C1.40013 1.15463 1.47962 1.125 1.5625 1.125H5.625C5.70788 1.125 5.78737 1.09537 5.84597 1.04262C5.90458 0.989879 5.9375 0.918342 5.9375 0.84375C5.9375 0.769158 5.90458 0.697621 5.84597 0.644876C5.78737 0.592132 5.70788 0.5625 5.625 0.5625H1.5625C1.31386 0.5625 1.0754 0.651395 0.899587 0.809629C0.723772 0.967862 0.625 1.18247 0.625 1.40625V7.59375Z"/>
                </g>
                <defs>
                  <clipPath id="clip0_11_114">
                    <rect width="10" height="9" fill="white"/>
                  </clipPath>
                </defs>
              </svg>
            </button>
          </div>
        </div>
        <div class="profile-info-wrapper">
          <div class="info-fio">Ларионов Константин Олегович</div>
          <div class="info-login">kostya12277</div>
          <div class="info-status">
            <svg id="info-status-icon" width="16" height="16" viewBox="0 0 16 16" fill="var(--color-light-green)" xmlns="http://www.w3.org/2000/svg">
              <g clip-path="url(#clip0_11_132)">
                <path d="M3.05 3.05002C2.39992 3.70004 1.88424 4.47175 1.53241 5.32108C1.18058 6.1704 0.999497 7.08071 0.999497 8.00002C0.999497 8.91934 1.18058 9.82965 1.53241 10.679C1.88424 11.5283 2.39992 12.3 3.05 12.95C3.14108 13.0443 3.19148 13.1706 3.19034 13.3017C3.1892 13.4328 3.13662 13.5582 3.04391 13.6509C2.95121 13.7436 2.8258 13.7962 2.6947 13.7974C2.5636 13.7985 2.4373 13.7481 2.343 13.657C1.60009 12.9142 1.01078 12.0322 0.608713 11.0616C0.20665 10.091 -0.000289917 9.05063 -0.000289917 8.00002C-0.000289917 6.94942 0.20665 5.90909 0.608713 4.93846C1.01078 3.96783 1.60009 3.0859 2.343 2.34302C2.4373 2.25195 2.5636 2.20155 2.6947 2.20269C2.8258 2.20383 2.95121 2.25641 3.04391 2.34912C3.13662 2.44182 3.1892 2.56723 3.19034 2.69832C3.19148 2.82942 3.14108 2.95572 3.05 3.05002ZM5.172 5.17202C4.42212 5.92214 4.00086 6.93937 4.00086 8.00002C4.00086 9.06068 4.42212 10.0779 5.172 10.828C5.21849 10.8745 5.25537 10.9297 5.28052 10.9904C5.30568 11.0512 5.31863 11.1163 5.31863 11.182C5.31863 11.2478 5.30568 11.3129 5.28052 11.3736C5.25537 11.4343 5.21849 11.4895 5.172 11.536C5.12551 11.5825 5.07032 11.6194 5.00958 11.6445C4.94885 11.6697 4.88375 11.6827 4.818 11.6827C4.75226 11.6827 4.68716 11.6697 4.62642 11.6445C4.56568 11.6194 4.51049 11.5825 4.464 11.536C3.99957 11.0717 3.63115 10.5205 3.3798 9.91375C3.12844 9.30703 2.99907 8.65674 2.99907 8.00002C2.99907 7.3433 3.12844 6.69302 3.3798 6.0863C3.63115 5.47959 3.99957 4.92834 4.464 4.46403C4.55789 4.37014 4.68523 4.31739 4.818 4.31739C4.95078 4.31739 5.07811 4.37014 5.172 4.46403C5.26589 4.55791 5.31863 4.68525 5.31863 4.81802C5.31863 4.9508 5.26589 5.07814 5.172 5.17202ZM10.828 4.46403C10.8744 4.41746 10.9296 4.38052 10.9904 4.35531C11.0511 4.33011 11.1162 4.31713 11.182 4.31713C11.2478 4.31713 11.3129 4.33011 11.3736 4.35531C11.4344 4.38052 11.4896 4.41746 11.536 4.46403C12.0004 4.92834 12.3688 5.47959 12.6202 6.0863C12.8716 6.69302 13.0009 7.3433 13.0009 8.00002C13.0009 8.65674 12.8716 9.30703 12.6202 9.91375C12.3688 10.5205 12.0004 11.0717 11.536 11.536C11.4895 11.5825 11.4343 11.6194 11.3736 11.6445C11.3128 11.6697 11.2477 11.6827 11.182 11.6827C11.1163 11.6827 11.0512 11.6697 10.9904 11.6445C10.9297 11.6194 10.8745 11.5825 10.828 11.536C10.7815 11.4895 10.7446 11.4343 10.7195 11.3736C10.6943 11.3129 10.6814 11.2478 10.6814 11.182C10.6814 11.1163 10.6943 11.0512 10.7195 10.9904C10.7446 10.9297 10.7815 10.8745 10.828 10.828C11.5779 10.0779 11.9991 9.06068 11.9991 8.00002C11.9991 6.93937 11.5779 5.92214 10.828 5.17202C10.7814 5.12558 10.7445 5.0704 10.7193 5.00966C10.6941 4.94891 10.6811 4.88379 10.6811 4.81802C10.6811 4.75226 10.6941 4.68714 10.7193 4.62639C10.7445 4.56565 10.7814 4.51047 10.828 4.46403ZM12.95 2.34403C13.0438 2.25029 13.1709 2.19763 13.3035 2.19763C13.4361 2.19763 13.5632 2.25029 13.657 2.34403C15.1571 3.84429 15.9998 5.87897 15.9998 8.00052C15.9998 10.1221 15.1571 12.1568 13.657 13.657C13.5627 13.7481 13.4364 13.7985 13.3053 13.7974C13.1742 13.7962 13.0488 13.7436 12.9561 13.6509C12.8634 13.5582 12.8108 13.4328 12.8097 13.3017C12.8085 13.1706 12.8589 13.0443 12.95 12.95C13.6001 12.3 14.1158 11.5283 14.4676 10.679C14.8194 9.82965 15.0005 8.91934 15.0005 8.00002C15.0005 7.08071 14.8194 6.1704 14.4676 5.32108C14.1158 4.47175 13.6001 3.70004 12.95 3.05002C12.8563 2.95626 12.8036 2.82911 12.8036 2.69653C12.8036 2.56394 12.8563 2.43679 12.95 2.34302V2.34403ZM10 8.00002C10 8.53046 9.78929 9.03917 9.41422 9.41424C9.03914 9.78931 8.53043 10 8 10C7.46957 10 6.96086 9.78931 6.58579 9.41424C6.21071 9.03917 6 8.53046 6 8.00002C6 7.46959 6.21071 6.96088 6.58579 6.58581C6.96086 6.21074 7.46957 6.00003 8 6.00003C8.53043 6.00003 9.03914 6.21074 9.41422 6.58581C9.78929 6.96088 10 7.46959 10 8.00002Z"/>
              </g>
              <defs>
                <clipPath id="clip0_11_132">
                  <rect width="16" height="16" fill="white"/>
                </clipPath>
              </defs>
            </svg>
            <label>В сети</label>
          </div>
          <div class="info-contacts-wrapper row">
            <div class="col"></div>
            <div class="col"></div>
          </div>
        </div>
        <div class="info-photos"></div>
      </div>
    </div>

<!--    <div class="container-fluid">-->
<!--      <div class="col">-->
<!--    <div class="row  w-100 d-flex flex-column"><div style="display: flex; justify-content: center"><img  width="200" height="200" src="https://via.placeholder.com/200"/></div></div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <div class="input__wrapper">-->
<!--        <input name="file" type="file" id="input__file" class="input input__file" multiple>-->
<!--        <label for="input__file" class="input__file-button">-->
<!--          <span class="input__file-icon-wrapper">-->
<!--            <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-download" viewBox="0 0 16 16">-->
<!--              <path d="M.5 9.9a.5.5 0 0 1 .5.5v2.5a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-2.5a.5.5 0 0 1 1 0v2.5a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2v-2.5a.5.5 0 0 1 .5-.5z"/>-->
<!--              <path d="M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"/>-->
<!--            </svg>-->
<!--          </span>-->
<!--          <span class="input__file-button-text">Выберите файл</span>-->
<!--        </label>-->
<!--      </div>-->
<!--    </div>-->
<!--      </div>-->
<!--    </div>-->
<!--    <div class="container-fluid " style="overflow-y: scroll;">-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Ваш Email: </label>-->
<!--      <input v-model="model.email" type="text" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Имя: </label>-->
<!--      <input type="text" v-model="model.name" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Фамилия: </label>-->
<!--      <input type="text" v-model="model.surname" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold" >Отчество: </label>-->
<!--      <input type="text" v-model="model.patro" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Логин: </label>-->
<!--      <input type="text" v-model="model.login" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Телефон: </label>-->
<!--      <input  v-model="model.number" type="text" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Файл подписи: </label>-->
<!--      <input type="text" class="account-input-text"/>-->

<!--      <small class="text-muted">(нужен только для внутренних серверов)</small>-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <button class="btn btn-success account-input-btn" v-on:click="updateProfile()">Сохранить</button>-->
<!--    </div>-->
<!--    </div>-->
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

<style scoped>
.info-status{
  color: black;
  font-weight: 300;
  font-size: 15px;
}
.info-fio{
  margin-top: 18px;
  font-weight: 600;
  font-size: 18px;
}
.info-login{
  font-weight: 200;
  font-size: 13px;
}
.profile-info-wrapper{
  width: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  flex-direction: column;
}
.profile-edit-logo{
  width: 100%;
  background-color: transparent;
  border: none;
  transition: .2s;
  height: 33px;
}
.profile-edit-logo:hover{
  background-color: var(--color-gray)
}
.profile-edit-logo:hover .edit-button-icon{
  fill: var(--color-white)
}
.background-edit-button{
  background-color: transparent;
  border: none;
}
.edit-button-icon{
  fill: var(--color-gray);
  transition: .2s;
}
.edit-button-icon:hover{
  fill: var(--color-white);
}
.background-profile{
  height: 230px;
  width: 100%;
  background-image: url(../../assets/images/defaultback.jpg);
  background-size: cover;
  display: flex;
  justify-content: flex-end;
  align-items: flex-end;
  padding-bottom: 70px;
  padding-right: 20px;
}
.profile-wrapper{
  display: flex;
  justify-content: flex-start;
  flex-direction: column;
  align-items: center;
  box-shadow: var(--shadow-up-4);
  background-color: var(--color-white);
  height: calc(100vh - 180px);
  margin-top: -50px;
  border-radius: 40px 40px 0 0 ;
  width: 100%;
}
.profile-logo-wrapper{
  background-color: var(--color-white);
  margin-top: -107px;
  display: flex;
  justify-content: center;
  align-items:center;
  box-shadow: var(--shadow-down-4);
  background-size: cover;
  height: 215px;
  width: 215px;
  border-radius: 50%;
  padding: 5px;
  overflow: hidden;
}
.profile-logo{
  background-image: url(../../assets/images/defaultlogo.jpg);
  background-size: cover;
  height: 200px;
  width: 200px;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: flex-end;
  overflow: hidden;
}
.info-photos{
  background-color: var(--color-white);
  width: 100%;
  height: 220px;
  margin-top: auto;
  box-shadow: var(--shadow-up-2);
  border-radius: 40px 40px 0 0;
}
</style>
