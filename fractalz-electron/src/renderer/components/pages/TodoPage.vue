<template>
  <div class="todo-wrap" id="todoSpace">
    <div class="todo-filter">
      <div class="todo-filter-left">
        <div class="filter-left-date">
          <svg width="15" height="15" viewBox="0 0 9 9" fill="none" xmlns="http://www.w3.org/2000/svg">
            <g clip-path="url(#clip0_33_212)">
              <path d="M3.62531 7.137V4.13663H3.26925C3.01424 4.27256 2.76778 4.42397 2.53125 4.59V4.98094C2.74219 4.83637 3.07631 4.63219 3.23887 4.54388H3.24563V7.137H3.62531ZM4.29356 6.40294C4.32 6.76294 4.62769 7.19381 5.2515 7.19381C5.95913 7.19381 6.3765 6.59419 6.3765 5.57888C6.3765 4.491 5.93719 4.07812 5.27794 4.07812C4.75706 4.07812 4.26713 4.45613 4.26713 5.09569C4.26713 5.74819 4.73063 6.09131 5.20988 6.09131C5.6295 6.09131 5.90175 5.87981 5.98781 5.64694H6.003C6.00075 6.38719 5.74369 6.86419 5.26894 6.86419C4.89544 6.86419 4.70194 6.61106 4.67831 6.40294H4.29356ZM5.95463 5.09962C5.95463 5.49112 5.64019 5.76338 5.28863 5.76338C4.95056 5.76338 4.64513 5.54794 4.64513 5.08837C4.64513 4.62544 4.9725 4.40775 5.30212 4.40775C5.65819 4.40775 5.95463 4.63162 5.95463 5.09962Z" fill="#00627A"/>
              <path d="M1.96875 0C2.04334 0 2.11488 0.0296316 2.16762 0.0823762C2.22037 0.135121 2.25 0.206658 2.25 0.28125V0.5625H6.75V0.28125C6.75 0.206658 6.77963 0.135121 6.83238 0.0823762C6.88512 0.0296316 6.95666 0 7.03125 0C7.10584 0 7.17738 0.0296316 7.23012 0.0823762C7.28287 0.135121 7.3125 0.206658 7.3125 0.28125V0.5625H7.875C8.17337 0.5625 8.45952 0.681026 8.6705 0.892005C8.88147 1.10298 9 1.38913 9 1.6875V7.875C9 8.17337 8.88147 8.45952 8.6705 8.6705C8.45952 8.88147 8.17337 9 7.875 9H1.125C0.826631 9 0.540483 8.88147 0.329505 8.6705C0.118526 8.45952 0 8.17337 0 7.875V1.6875C0 1.38913 0.118526 1.10298 0.329505 0.892005C0.540483 0.681026 0.826631 0.5625 1.125 0.5625H1.6875V0.28125C1.6875 0.206658 1.71713 0.135121 1.76988 0.0823762C1.82262 0.0296316 1.89416 0 1.96875 0V0ZM1.125 1.125C0.975816 1.125 0.832742 1.18426 0.727252 1.28975C0.621763 1.39524 0.5625 1.53832 0.5625 1.6875V7.875C0.5625 8.02418 0.621763 8.16726 0.727252 8.27275C0.832742 8.37824 0.975816 8.4375 1.125 8.4375H7.875C8.02418 8.4375 8.16726 8.37824 8.27275 8.27275C8.37824 8.16726 8.4375 8.02418 8.4375 7.875V1.6875C8.4375 1.53832 8.37824 1.39524 8.27275 1.28975C8.16726 1.18426 8.02418 1.125 7.875 1.125H1.125Z" fill="#00627A"/>
              <path d="M1.40625 2.25C1.40625 2.17541 1.43588 2.10387 1.48863 2.05113C1.54137 1.99838 1.61291 1.96875 1.6875 1.96875H7.3125C7.38709 1.96875 7.45863 1.99838 7.51137 2.05113C7.56412 2.10387 7.59375 2.17541 7.59375 2.25V2.8125C7.59375 2.88709 7.56412 2.95863 7.51137 3.01137C7.45863 3.06412 7.38709 3.09375 7.3125 3.09375H1.6875C1.61291 3.09375 1.54137 3.06412 1.48863 3.01137C1.43588 2.95863 1.40625 2.88709 1.40625 2.8125V2.25Z" fill="#00627A"/>
            </g>
            <defs>
              <clipPath id="clip0_33_212">
                <rect width="9" height="9" fill="white"/>
              </clipPath>
            </defs>
          </svg>
          <div class="filter-date-label">Выбрать день:</div>
          <input class="filter-date-input" type="date"/>
        </div>
        <div class="filter-left-done">
          <div style="margin-right: 5px;">Показать только не выполненные</div>
          <div class="WW">
          <input type="checkbox" id="switch" /><label for="switch">Toggle</label>
          </div>
        </div>
      </div>
      <div class="todo-filter-right">
        <button class="todo-filter-buttonadd">Добавить задачу</button>
      </div>
    </div>
    <div class="todo-body-wrapper">
      <div class="todo-task-wrapper">
         <div class="todo-task-info purple">
      
          <div class="todo-task-info-trash">
            <svg width="15" height="15" viewBox="0 0 9 10" xmlns="http://www.w3.org/2000/svg">
              <path d="M7.11169 10C7.86319 10 8.4375 9.175 8.4375 8.21429V2.85714H0.5625V8.21429C0.5625 9.175 1.13681 10 1.88831 10H7.11169ZM3.09375 4.28571H5.90625C5.98084 4.28571 6.05238 4.32334 6.10512 4.39032C6.15787 4.4573 6.1875 4.54814 6.1875 4.64286C6.1875 4.73758 6.15787 4.82842 6.10512 4.8954C6.05238 4.96237 5.98084 5 5.90625 5H3.09375C3.01916 5 2.94762 4.96237 2.89488 4.8954C2.84213 4.82842 2.8125 4.73758 2.8125 4.64286C2.8125 4.54814 2.84213 4.4573 2.89488 4.39032C2.94762 4.32334 3.01916 4.28571 3.09375 4.28571ZM0.45 0C0.330653 0 0.216193 0.0602039 0.131802 0.167368C0.0474106 0.274531 0 0.419876 0 0.571429L0 1.42857C0 1.58012 0.0474106 1.72547 0.131802 1.83263C0.216193 1.9398 0.330653 2 0.45 2H8.55C8.66935 2 8.78381 1.9398 8.8682 1.83263C8.95259 1.72547 9 1.58012 9 1.42857V0.571429C9 0.419876 8.95259 0.274531 8.8682 0.167368C8.78381 0.0602039 8.66935 0 8.55 0H0.45Z"/>
            </svg>
          </div>
          <div class="todo-task-info-header">
            <div>Заголовок задачи</div>
            <div class="task-circle">
              <div class="container">
               <div class="round">
                <input type="checkbox" checked id="checkbox" />
                <label for="checkbox"></label>
              </div>
            </div>
            </div>
          </div>
          <div class="todo-task-info-description">
            С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации.
          </div>
          <div class="todo-task-period">13:30 - 14:00</div>
        </div>
        <div class="todo-task-time">
          <div class="todo-task-time-circle purple">13:30</div>
          <div class="todo-task-time-line"></div>
        </div>
      </div>
      <div class="todo-task-wrapper">
        <div class="todo-task-info blue">
          <div class="todo-task-info-trash">
            <svg width="15" height="15" viewBox="0 0 9 10" xmlns="http://www.w3.org/2000/svg">
              <path d="M7.11169 10C7.86319 10 8.4375 9.175 8.4375 8.21429V2.85714H0.5625V8.21429C0.5625 9.175 1.13681 10 1.88831 10H7.11169ZM3.09375 4.28571H5.90625C5.98084 4.28571 6.05238 4.32334 6.10512 4.39032C6.15787 4.4573 6.1875 4.54814 6.1875 4.64286C6.1875 4.73758 6.15787 4.82842 6.10512 4.8954C6.05238 4.96237 5.98084 5 5.90625 5H3.09375C3.01916 5 2.94762 4.96237 2.89488 4.8954C2.84213 4.82842 2.8125 4.73758 2.8125 4.64286C2.8125 4.54814 2.84213 4.4573 2.89488 4.39032C2.94762 4.32334 3.01916 4.28571 3.09375 4.28571ZM0.45 0C0.330653 0 0.216193 0.0602039 0.131802 0.167368C0.0474106 0.274531 0 0.419876 0 0.571429L0 1.42857C0 1.58012 0.0474106 1.72547 0.131802 1.83263C0.216193 1.9398 0.330653 2 0.45 2H8.55C8.66935 2 8.78381 1.9398 8.8682 1.83263C8.95259 1.72547 9 1.58012 9 1.42857V0.571429C9 0.419876 8.95259 0.274531 8.8682 0.167368C8.78381 0.0602039 8.66935 0 8.55 0H0.45Z"/>
            </svg>
          </div>
          <div class="todo-task-info-header">
            <div>Заголовок задачи</div>
            <div class="task-circle">
            </div>
          </div>
          <div class="todo-task-info-description">
            С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации.
          </div>
          <div class="todo-task-period">13:30 - 14:00</div>

        </div>
        <div class="todo-task-time">
          <div class="todo-task-time-circle blue">13:30</div>
          <div class="todo-task-time-line"></div>
        </div>
      </div>
      <div class="todo-task-wrapper">
        <div class="todo-task-info teal">
          <div class="todo-task-info-trash">
            <svg width="15" height="15" viewBox="0 0 9 10" xmlns="http://www.w3.org/2000/svg">
              <path d="M7.11169 10C7.86319 10 8.4375 9.175 8.4375 8.21429V2.85714H0.5625V8.21429C0.5625 9.175 1.13681 10 1.88831 10H7.11169ZM3.09375 4.28571H5.90625C5.98084 4.28571 6.05238 4.32334 6.10512 4.39032C6.15787 4.4573 6.1875 4.54814 6.1875 4.64286C6.1875 4.73758 6.15787 4.82842 6.10512 4.8954C6.05238 4.96237 5.98084 5 5.90625 5H3.09375C3.01916 5 2.94762 4.96237 2.89488 4.8954C2.84213 4.82842 2.8125 4.73758 2.8125 4.64286C2.8125 4.54814 2.84213 4.4573 2.89488 4.39032C2.94762 4.32334 3.01916 4.28571 3.09375 4.28571ZM0.45 0C0.330653 0 0.216193 0.0602039 0.131802 0.167368C0.0474106 0.274531 0 0.419876 0 0.571429L0 1.42857C0 1.58012 0.0474106 1.72547 0.131802 1.83263C0.216193 1.9398 0.330653 2 0.45 2H8.55C8.66935 2 8.78381 1.9398 8.8682 1.83263C8.95259 1.72547 9 1.58012 9 1.42857V0.571429C9 0.419876 8.95259 0.274531 8.8682 0.167368C8.78381 0.0602039 8.66935 0 8.55 0H0.45Z"/>
            </svg>
          </div>
          <div class="todo-task-info-header">
            <div>Заголовок задачи</div>
            <div class="task-circle">
            </div>
          </div>
          <div class="todo-task-info-description">
            С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации.
          </div>
          <div class="todo-task-period">13:30 - 14:00</div>
        </div>
        <div class="todo-task-time">
          <div class="todo-task-time-circle teal">13:30</div>
          <div class="todo-task-time-line"></div>
        </div>
      </div>
    </div>
    <!-- For Page
    <div class="page">
      <div class="card">
        Card Header
        <div class="card-header">
            <todo-task-manager :todo-total-tasks="todoTasksContents.length"
                               :todo-today-tasks="this.countedTask"
                               :todo-total-open-tasks="0">

            </todo-task-manager>
          <span class="float-right mt-2">
            <button class="mr-4 navTask dark-teal" @click="showModal = true">Добавить задачу</button>

              <todo-modal v-if="showModal" @close="showModal = false"></todo-modal>

            <button class="mr-4 border-0 bg-transparent navTask text-dark" >Архив задач</button>
            <i class="fa fa-search" aria-hidden="true"></i>
          </span>
        </div>
       Card Body
        <div class="card-body">
          <p class="heading1">
            <span class="today">Сегодня</span>
            <span class="float-right headingright">7h 15min</span>
          </p>
          <div v-for="todoTaskContent in todoTasksContents" :key="todoTaskContent.$id">
            <todo-task-element :todo-name="todoTaskContent.header"
                               :todo-time-created="todoTaskContent.dateCreate"
                               :todo-time-to-take="todoTaskContent.durationInMinute"
                               :todo-id="todoTaskContent.id" :complete="todoTaskContent.isCompleted">
            </todo-task-element>
          </div>
          <p class="heading2">
            <span class="tomorrow">Вчера</span>
            <span class="float-right headingright">6h 30min</span>
          </p>
        </div>
      </div>
    </div> -->
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
      showModal: false,
      countedTask:0,
    }
  },
  date() {
    return {
      todoTasksContents: [],
    }
  },
  props:{
    api: Object,
    todoTasksContents: [],
    noty: Object,

  },
  mounted: async function () {
    this.todoTasksContents = [];
    this.api = new ToDoPart(this.$http);
    this.todoTasksContents.isCompleted = todoTaskElement.complete;
    await this.taskReq();
    await this.completedTaskCount()
    console.log(this.todoTasksContents)
  },
  methods: {
    taskReq: async function(){
      var request = await this.api.GetTask( this.$cookies.get("UserInfo").id, '')
          .catch(response=>{this.noty.Show({title: "Task add", message:"task not added"})})
      if(request.data.success)
      {
        var arr =[];
        arr = request.data.todoList.tasks.$values;
        for (let j in arr)
        {
            this.$set(this.todoTasksContents, j , arr[j])
        }
        this.$forceUpdate();
        console.log(arr)

      }
      else{this.noty.Show({title:"123", message:"123"})}
    },
    showModal: function (){
      this.showModal = true;
    },
    completedTaskCount: async function()
    {
      for(let i = 0; i < this.todoTasksContents.length; i++)
      {
        console.log(this.todoTasksContents[i])
        if(this.todoTasksContents[i].isCompleted === false)
        {
          this.countedTask+=1;
        }
      }
    }


  }
}
</script>

<style scoped>
.todo-wrap {
  display: flex;
  flex-direction: column;
  width: 100%;
  height: 100%;
}
.todo-filter {
  display: flex;
  flex-direction: row;
  justify-content: start;
  align-items: center;
  background-color: var(--color-white);
  height: 90px;
  box-shadow: var(--shadow-down-4);
  border-radius: 0 0 45px 45px;
}
.todo-filter-left {
  width: 60%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.filter-left-done {
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  color: var(--color-dark-blue);
  font-size: 12px;
  margin-top: 10px;
}
.filter-left-date {
  display: flex;
  flex-direction: row;
  font-weight: 300;
  color: var(--color-dark-blue);
  fill: var(--color-dark-blue);
  font-size: 13px;
  justify-content: space-between;
  align-items: center;
}
.filter-date-label {
  margin-left: 10px;
}
.filter-date-input {
  margin-left: 10px;
  border-bottom: 1px solid var(--color-dark-blue);
  border-top: none;
  border-left: none;
  border-right: none;
  width: 120px;
  padding: 0;
  color: var(--color-dark-blue);
  text-align: right;
}
.todo-filter-right {
  width: 40%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.todo-filter-buttonadd{
  font-style: normal;
  font-weight: 300;
  border: none;
  border-radius: 10px;
  box-shadow: var(--shadow-down-2);
  font-size: 12px;
  padding: 7px 20px 7px 20px;
  color: var(--color-white);
  background-color: var(--color-dark-blue);
  transition: .3s;
}
.todo-filter-buttonadd:hover {
  box-shadow: none;
}
.todo-body-wrapper {
  height: calc(100% - 90px);
  display: flex;
  flex-direction: column;
  align-items: center;
}
.todo-task-wrapper {
  cursor: pointer;
  display: flex;
  width: 90%;
  margin-top: 20px;
}
.todo-task-wrapper:hover .todo-task-info-trash {
  opacity: 1;
}
.todo-task-period {
  font-size: 11px;
  font-weight: 500;
  margin-left: auto;
  margin-right: 25px;
  z-index: 9999999;
  margin-top: -12px;
  color: var(--color-white);
}
.todo-task-info {

  display: flex;
  flex-direction: column;
  height: 90px;
  width: 85%;
  border-radius: 15px;
  box-shadow: var(--shadow-down-2);
}
.todo-task-info-trash {
  display: flex;
  flex-direction: row;
  transition: .3s;
  cursor: pointer;
  fill: var(--color-orange);
  opacity: 0;
  margin-left: -5px;
  margin-top: -10px;
}
.todo-task-info-header {
  display: flex;
  flex-direction: row;
  font-size: 14px;
  font-weight: 500;
  color: var(--color-white);
  margin-left: 20px;
  margin-top: 10px;
  width: 100%;
  height: 40px;
}
.task-circle {
  cursor: pointer;
  width: 15px;
  height: 15px;
  margin-left: auto;
  margin-right: 20px;
}
.todo-task-info-description {
  font-style: normal;
  font-weight: 300;
  line-height: 13px;
  margin-left: 20px;
  margin-right: 20px;
  margin-top: 0px;
  font-size: 11px;
  color: var(--color-white);
  margin-top: 5px;
  margin-bottom: 10px;
}
.todo-task-time {
  margin-left: auto;
  flex-direction: column;
  display: flex;
  align-items: center;
}
.todo-task-time-circle {
  width: 50px; height: 50px;
  border-radius: 50%;
  box-shadow: var(--shadow-down-2);
  display: flex;
  justify-content: center;
  align-items: center;
  color: white;
  font-size: 13px;
  font-weight: 300;
}
.todo-task-time-line {
  margin-top: 20px;
  height: 30px;
  border-left: 1px solid var(--color-dark-blue);
}
.purple{
  background-color: var(--color-purple);
}
.blue{
  background-color: var(--color-blue);
}
.teal{
  background-color: var(--color-teal);
}
.round {
  position: relative;
}

.container{
  display: flex;
  Justify-content: flex-end;
  margin-left: -10px;
  margin-top: -17px;
  width: 10%;
}
.round label{
    width: 1.7em;
    height: 1.7em;
    background-color: transparent;
    border-radius: 50%;
    border: 2px solid #ffffff;
    appearance: none;
    -webkit-appearance: none;
    outline: none;
    cursor: pointer;
}
.round label:after {
  border: 2px solid #05FF00;
  border-top: none;
  border-right: none;
  content: "";
  height: 6px;
  left: 7px;
  opacity: 0;
  position: absolute;
  top: 8px;
  transform: rotate(-45deg);
  width: 12px;
  margin-top: 21px;
  margin-left: -1px;
}
.round input[type="checkbox"] {
  visibility: hidden;
}
.round input[type="checkbox"]:checked + label {
  background-color: transparent;
  border-color: #05FF00;
}
.todo-1{
  width: 70%;
  height: 100%;
}
.round input[type="checkbox"]:checked + label:after {
  opacity: 1;
}

/*Чек бокс вкл-выкл*/
.WW input[type=checkbox]{
	height: 0;
	width: 0;
	visibility: hidden;
}
.WW label {
	cursor: pointer;
	text-indent: -9999px;
	width: 35px;
	height: 20px;
	background: grey;
	display: block;
	border-radius: 100px;
	position: relative;
}
.WW label:after {
	content: '';
	position: absolute;
	top: 5px;
	left: 7px;
	width: 17px;
	height: 17px;
	background: #fff;
	border-radius: 90px;
	transition: 0.3s;
  margin-top: -3px;
  margin-left: -3px;
}
.WW input[type="checkbox"]:checked + label {
	background: #00627A;
}
.WW input[type="checkbox"]:checked + label:after {
	left: calc(100% - 0px);
	transform: translateX(-100%);
}
.WW label:active:after {
	width: 25px;
}
body {
	display: flex;
	justify-content: center;
	align-items: center;
	height: 100vh;
}
</style>