<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container-exit" style="height: 350px">
          <div class="todocreator-container-elems">
            <div class="todocreator-label">Добавление задачи</div>
            <input class="todocreator-input" v-model:value="Header" type="text" placeholder="Введите заголовок задачи"/>
            <textarea v-model:value="About" class="todocreator-input text-left" placeholder="Введите описание задачи"/>
            <input class="todocreator-input " v-model:value="DateCreate" type="date" placeholder="Введите дату задачи"/>
          </div>
          <div class="footer-exit">
                  <span class="buttons" >
                        <button class="exit-btn" v-on:click="createTask()" style="margin-left: 120px">
                          Добавить
                        </button>
                    <button  class="back-btn" @click="$emit('close')" >Закрыть</button>
                  </span>
          </div>
        </div>
      </div>
    </div>
  </transition>
</template>

<script>
import ToDoPart from "../../api/TodoPart";
import NotifyCenter from "../../services/NotifyCenter";
import TodoPage from "../pages/TodoPage";
import Vue from "vue";

export default {
  name: "TodoModalRD",
  props: {
    Header : String,
    About : String,
    DateCreate: Object,
    api: Object,
    noty: Object,
  },
  data() {
    return{
      Header: "",
      About:"",
      duration:5,
      DateCreate : new Date(),
      TodoListId: ''
    }
  },
  mounted() {
    this.TodoListId = Vue.UserInfo.todoList.id
    this.api = new ToDoPart(this.$http);
    this.noty = new NotifyCenter();
  },
  methods: {
    async createTask () {
      const titleNoty = "Создание задачи"
      var result = await this.api
          .CreateTask(this.Header, this.About, this.duration, this.TodoListId, this.DateCreate)
          .catch(response => {
            this.noty.Show({
              title: titleNoty, message: response.response.data.message
            })
          });
      if (result.data.success)
      {
        this.noty.Show({title: titleNoty, message: "Задача добавлена!"});

        this.$emit('update')
        this.$emit('close')
      } else
      {
        this.noty.Show({title: titleNoty, message: result.data.message});
      }
    }
  }
}
</script>

<style lang="css">
.lefttext{
}
.todocreator-container-elems{
  width: 100%;
  height: 75%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-content: center;
  text-align: center;
  padding: 15px;
}
.todocreator-input{
  text-align: center;
  margin-top: 10px;
  padding: 10px;
  margin-bottom: 5px;
  background: #FFFFFF;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  border-radius: 20px;
  border: none;
}
.todocreator-label{
  color: #00627A;
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 700;
  font-size: 15px;
  line-height: 12px;
  margin-bottom: 20px;
}
.exit-btn{
  color: white;
  height: 40px;
  width: 100px;
  border-radius: 20px;
  background: #00627A;
  margin-left: 30px;
  border: transparent;
  font-size: 12px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.exit-btn:hover{
  background: #003947;
}
.exit-btn:active{
  background: #003947;
}
.exit-btn:focus{
  background: #003947;
}
.back-btn{
  color: white;
  height: 40px;
  width: 100px;
  border-radius: 20px;
  background: #9B9B9B;
  margin-left: 60px;
  border: transparent;
  font-size: 12px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.back-btn:hover{
  background: #7B7B7B;
}
.back-btn:active{
  background: #7B7B7B;
}
.back-btn:focus{
  background: #7B7B7B;
}
.modal-mask {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  display: table;
  transition: opacity 0.3s ease;
}
.box-angle2{
  width: 400px;
  height: 70px;
  margin-top: -10px;
  margin-left: -10px;
}
.logo2{
  margin-top: -50px;
  margin-left: 170px;
}
.question{
  margin-left: 25px;
  font-size: 14px;
}
.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}
.modal-container-exit {
  width: 400px;
  margin: 0px auto;
  background-color: #D9D9D9;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 5px;
  border-style: solid;
  border: transparent;
}
.notification-exit{
  font-weight: 300;
  margin-left: 10px;
  line-height: 16px;
}
.modal-header{
  display: flex;
  flex-direction: column;
}
.header{
  margin-top: 10px;
  margin-left: 20px;
  width: 100%;
  height: 110px;
  color: #00627A;
  font-size: 14px;
}
.buttons
{
  border-radius: 20px;
}
.footer-exit{
  margin-top: 10px;
  margin-left: -55px;
}
</style>
