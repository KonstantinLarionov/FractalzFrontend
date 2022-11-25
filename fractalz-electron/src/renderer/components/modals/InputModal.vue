<template>
   <div class="modal-shadow" v-if="show" @click.self="closeModal">
     <div class="modal-wrapper">
      <div class="modal-container-input">
            <slot name="header">
              <div class="header">
                <div class="question-exit">
                  <br>
                  <br>
                <p class="text">
                  Название поля для ввода 
                </p>
                </div>
                <input class="inpt"/>
              </div>
            </slot>
            <div class="footer-modal">
                <span class="buttons">
                  <button class="send-btn" @click="$emit('close')">Ввести</button>
                </span>
          </div>
          </div>
      </div>
    </div>
</template>

<script>

import Vue from "vue";
import UserNotyElement from "../elements/noty/UserNotyElement";

Vue.component ('user-element', UserNotyElement)

export default {
        name: "InputModal",
        data: function () {
            return {
            }
        },
        methods: {
            closeModal: function () {
                this.show = false
            }
        }
    }

</script>
<style lang="css">

.modal-shadow {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  display: table;
  transition: opacity 0.3s ease;
}
.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}
.modal-container-input {
  width: 350px;
  height: 250px;
  margin: 0px auto;
  background-color: #D9D9D9;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 5px;
  border-style: solid;
  border: transparent;
}
.header{
  margin-top: 10px;
  margin-left: 20px;
  width: 100%;
  height: 110px;
  color: #00627A;
  font-size: 14px;
}
.text{
  font-size: 17px;
  text-align: center;
  margin-right:120px;
}
.footer-modal{
margin-top: 50px;
margin-left: 170px;
}
.send-btn{
  border-radius: 20px;
  color: white;
  height: 35px;
  width: 120px;
  border-radius: 20px;
  background: #00627A;
  margin-left: 30px;
  border: transparent;
  font-size: 15px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.send-btn:hover{
  background: #003947;
}
.send-btn:active{
  background: #003947;
}
.send-btn:focus{
  background: #003947;
}
.inpt{
  margin-left: 10px;
  margin-top: 10px;
  height: 30px;
  width: 280px;
  border-radius: 20px;
  border: 1px transparent solid;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
</style>

