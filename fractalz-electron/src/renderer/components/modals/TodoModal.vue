<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Создание задачи</p>
              <a class="modal-header-close" @click="$emit('close')">
              <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                <path d="M0 0h24v24H0z" fill="none"/>
                <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
              </svg>
              </a>
            </slot>
          </div>

          <div class="modal-body">
            <slot name="body">
              <p class ="modal-heading">Заголовок задачи</p>
              <input class="modal-body-input" v-model="Header" type="text">
              <p class ="modal-heading">Описание задачи</p>
              <input class="modal-body-input" v-model="About" type="text">
              <p class ="modal-heading">Время окончания задачи</p>
              <input class="modal-body-input" v-model="duration" type="date">
            </slot>
          </div>

          <div class="modal-footer">
            <slot name="footer">
              <button class="modal-default-button mr-4 navTask dark-teal" v-on:click="toCreateTask()" @click="$emit('close')">
                Добавить
              </button>
            </slot>
          </div>

        </div>
      </div>
    </div>
  </transition>
</template>

<script>
import ToDoPart from "../../api/TodoPart";
import NotifyCenter from "../../services/NotifyCenter";

export default {
  name: "TodoModal",
  props: {
    api: Object,
    noty: Object
  },

  data() {
    return{
      Header: "",
      About:"",
      duration:5,
      TodoListId: this.$cookies.get("UserInfo").todoList.id,
    }
  },

  mounted() {
    this.api = new ToDoPart(this.$http);
    this.noty = new NotifyCenter();
  },

  methods:
    {
      toCreateTask: async function()
      {
        console.log (this.$cookies.get("UserInfo").id);
        const titleNoty = "Создание задачи"
        var result = await this.api.CreateTask(this.Header, this.About, this.duration, this.TodoListId)
            .catch(response => {this.noty.Show({
              title: titleNoty, message: response.response.data.message})});
        if (result.data.success)
          {
            this.noty.Show({title: titleNoty, message: "Вы успешно зарегистрированы!\rОсталось совсем чуть-чуть!"});
          } else
          {
            this.noty.Show({title: titleNoty, message: result.data.message});
          }
      }
    }
}

</script>

<style lang="css">

.modal-body{
  margin: 0 0 0 0;
  padding: 0 10px 0px 10px;
}
.modal-body-input{
  width: 100%;
  padding: 0 0 0 0;
  margin: 0px 0px 5px 0px;
}
.modal-heading{
  padding: 0 10px 0px 10px;
  margin: 0 0 0 0;
  font-size: 14px;
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

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.modal-container {
  width: 300px;
  margin: 0px auto;
  background-color: #fff;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
}
.modal-header{
  display: flex;
  padding: 10px 10px 0px 10px;
}
.modal-header-title{
  position: relative;
  display: flex;
  flex-direction: row;
  align-items: center;
  font-size: 16px;
  color: #0d0f12;
  justify-content: space-between;
  width: 100%;
  margin: 0;
  padding: 0 0 1.25rem;
}
.modal-header-close{
  cursor: pointer;
}
</style>