<template>
  <div class="todo-wrap" id="todoSpace">
    <!--For Page-->
    <div class="page">
      <!--Card-->
      <div class="card">
        <!--Card Header-->
        <div class="card-header">
          <todo-task-manager todo-total-tasks="0" todo-today-tasks="0" todo-total-open-tasks="0"></todo-task-manager>
          <span class="float-right mt-2">
            <button class="mr-4 navTask dark-teal" @click="showModal = true">Добавить задачу</button>
              <todo-modal v-if="showModal" @close="showModal = false">
                <template v-slot:body>

                </template>
              </todo-modal>

            <button class="mr-4 border-0 bg-transparent navTask text-dark" >Архив задач</button>
            <i class="fa fa-search" aria-hidden="true"></i>
          </span>
        </div>
        <!--Card Body-->
        <div class="card-body">
          <p class="heading1">
            <span class="today">Сегодня</span>
            <span class="float-right headingright">7h 15min</span>
          </p>
          <div v-for="todoTaskContent in todoTasksContents" :key="todoTaskContent.$id">
            <todo-task-element :todo-name="todoTaskContent.header"
                               :todo-time-created="todoTaskContent.dateCreate"
                               :todo-time-to-take="todoTaskContent.durationInMinute"
                               :todo-id="todoTaskContent.id" :complete="todoTaskContent.isCompleted"  >
            </todo-task-element>
          </div>
          <p class="heading2">
            <span class="tomorrow">Вчера</span>
            <span class="float-right headingright">6h 30min</span>
          </p>
        </div>
      </div>
    </div>
  </div>

</template>

<script>
import TodoTaskElement from "../elements/todo/TodoTaskElement";
import TodoTaskManager from "../elements/todo/TodoTaskManager";
import TodoModal from "../modals/TodoModal";
import UserPart from "../../api/UserPart";
import NotifyCenter from "../../services/NotifyCenter";
import Vue from "vue";
import ToDoPart from "../../api/TodoPart";
import todoTaskElement from "../elements/todo/TodoTaskElement";

Vue.component ('todo-task-element', TodoTaskElement)
Vue.component ('todo-task-manager', TodoTaskManager)
Vue.component ('todo-modal', TodoModal)


export default {
  name: "TodoPage",
  data(){
    return{
      showModal: false
    }
  },
  date() {
    return {
      todoTasksContents: [],
    }
  },
  props:{
    api: Object,
    noty: Object
  },
  mounted: async function () {
    this.todoTasksContents = [];
    this.getTasks();
  },
  methods: {
    getTasks: function () {
      var arr =[
        {
          id: 0,
          name:'Take kids to school',
          timeCreated: '8:00-8:30AM',
          timeToTake: '30min',
        },
        {
          id: 1,
          name:'Take kids to school',
          timeCreated: '8:00-8:30AM',
          timeToTake: '30min',
        },
        {
          id: 2,
          name:'Take kids to school',
          timeCreated: '8:00-8:30AM',
          timeToTake: '30min',
        }
      ];

      for (let j in arr)
      {
        this.$set(this.todoTasksContents, j, arr[j])
      }
      this.$forceUpdate();
    },
    showModal: function (){
      this.showModal = true;
    }
  }
}
</script>

<style scoped>

</style>
