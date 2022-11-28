<template>
    <div class="d1">
          <div class="avatar">
            <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
          </div>
          <div class ="cenetmasseg">
            <div class="namean">
              <p>{{Name}}</p>
              <svg class="tchk" width="3" height="3" viewBox="0 0 2 2" fill="none" xmlns="http://www.w3.org/2000/svg">
                <circle cx="1" cy="1" r="1" fill="#23BD57"/>
              </svg>
            </div>
            <p class="textLastMasseg">Текст последнего сообщения полный</p>
          </div>
          <div class="timess">
            <p>Часы:минуты</p>
          </div>
        </div>
</template>
<script>
import DialogElement from "../elements/DialogElement";
import ChatPart from "../../api/ChatPart";
import NotifyCenter from "../../services/NotifyCenter";
import Vue from "vue";

Vue.component ('dialog-element', DialogElement)
Vue.config.productionTip = false

export default {
  name: "DialogPage",
  data(){
    return{
      findStr : '',
      chatSelect: false,
      dialogId: null,
      idUserSender: Vue.$cookies.get('UserInfo').id,
      isFindUsers: false,
      notyHeader: "Диалоги Fractalz"
    }
  },
  props:{
    Name:"",
    api: Object,
    noty: Object,
    Id:null
  },
  mounted: async function () {
    this.api = new ChatPart(this.$http);
    this.noty = new NotifyCenter();
    Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
  },
  methods: {

  }
}
</script>
<style>
.d1 {
    display: flex;
    flex-direction: row;
    height: 66px;
    cursor: pointer;
    transition: .3s;
  }
  .d1:hover {
    background-color:  #DCDCDC;
  }
  .photo{
    border-radius: 50%;
  }
  .avatar {
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 50%;
    width: 60px;
    margin-top: 28px;
    margin-right: 40px;
    margin-left: 20px;
    margin-bottom: 30px;
  }
  .cenetmasseg {
    display: flex;
    flex-direction: column;
    margin-left: -20px;
    width: 85%;
    color: black;
  }
  .namean{
    margin-top: 5px;
    font-family: 'Roboto';
    font-style: normal;
    font-weight: 500;
    display: flex;
    flex-direction: row;
    font-size: 13px;
  }
  .tchk {
    margin-top: 20px;
    margin-left: 4px;
    width: 4px;
    height: 4px;
  }
  .textLastMasseg {
    font-family: 'Roboto';
    font-style: normal;
    margin-top: -6px;
    font-size: 11px;
    line-height: 7px;
    color: dimgray;
  }
  .timess {
    color: black;
    display: flex;
    flex-direction: column;
    justify-content: flex-end;
    align-items: center;
    width: 20px;
    position: fixed;
    right: 20px;
    font-size: 9px;
    margin-top: 6px;
  }
  </style>