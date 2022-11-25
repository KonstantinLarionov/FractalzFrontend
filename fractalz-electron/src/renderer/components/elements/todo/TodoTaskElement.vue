<template >
<div style="
  width: 90%;">
  <div class="todo-task-wrapper">
         <div class="todo-task-info" v-bind:class="{purple: colorNumber == 1, blue: colorNumber == 2, teal: colorNumber == 3}">

          <div class="todo-task-info-trash" v-on:click="_deleteTask()">
            <svg width="15" height="15" viewBox="0 0 9 10" xmlns="http://www.w3.org/2000/svg">
              <path d="M7.11169 10C7.86319 10 8.4375 9.175 8.4375 8.21429V2.85714H0.5625V8.21429C0.5625 9.175 1.13681 10 1.88831 10H7.11169ZM3.09375 4.28571H5.90625C5.98084 4.28571 6.05238 4.32334 6.10512 4.39032C6.15787 4.4573 6.1875 4.54814 6.1875 4.64286C6.1875 4.73758 6.15787 4.82842 6.10512 4.8954C6.05238 4.96237 5.98084 5 5.90625 5H3.09375C3.01916 5 2.94762 4.96237 2.89488 4.8954C2.84213 4.82842 2.8125 4.73758 2.8125 4.64286C2.8125 4.54814 2.84213 4.4573 2.89488 4.39032C2.94762 4.32334 3.01916 4.28571 3.09375 4.28571ZM0.45 0C0.330653 0 0.216193 0.0602039 0.131802 0.167368C0.0474106 0.274531 0 0.419876 0 0.571429L0 1.42857C0 1.58012 0.0474106 1.72547 0.131802 1.83263C0.216193 1.9398 0.330653 2 0.45 2H8.55C8.66935 2 8.78381 1.9398 8.8682 1.83263C8.95259 1.72547 9 1.58012 9 1.42857V0.571429C9 0.419876 8.95259 0.274531 8.8682 0.167368C8.78381 0.0602039 8.66935 0 8.55 0H0.45Z"/>
            </svg>
          </div>
          <div class="todo-task-info-header">
            <div>{{TodoHeader}}</div>
            <div class="task-circle">
              <div class="container">
               <div class="round">
                <input type="checkbox" @click="_completeTask()" v-bind:id="TodoId" v-bind:checked="complete" />
                <label v-bind:for="TodoId"></label>
              </div>
            </div>
            </div>
          </div>
          <div class="todo-task-info-description wrapword">
            {{TodoAbout}}
          </div>
          <div class="todo-task-period">{{TodoPeriod}}</div>
        </div>
        <div class="todo-task-time">
          <div class="todo-task-time-circle" v-bind:class="{purple: colorNumber == 1, blue: colorNumber == 2, teal: colorNumber == 3}">{{TodoTimeCreatedView}}</div>
          <div class="todo-task-time-line"></div>
        </div>
      </div>
</div>
</template>

<script>
import ToDoPart from "../../../api/TodoPart";
export default {
  data: function ()
  {
    return {
      colorNumber: 1,
      TodoHeader: '',
      TodoAbout: '',
      TodoTimeCreated: null,
      TodoTimeCreatedView: "",
      TodoTimeEnd: null,
      TodoPeriod: null,
      TodoId: '',
      api: null,
      noty: null,
      complete: null
    }
  },
  props: {
    colorNumber: Number,
    TodoHeader: '',
    TodoAbout: '',
    TodoTimeCreated: null,
    TodoTimeCreatedView: "",
    TodoTimeEnd: null,
    TodoPeriod: null,
    TodoId: '',
    api: Object,
    noty: Object,
    complete: null
  },
  name: "TodoTaskElement",
  mounted() {

    this.api = new ToDoPart(this.$http);

    this.TodoTimeCreatedView = this.getTime(this.TodoTimeCreated)
    if (this.complete) {
      this.TodoPeriod = this.getTimePeriod(this.TodoTimeEnd)
    }
  },
  methods: {

    getTime: function (dateTime) {
      var d = new Date(dateTime)
      var res = [d.getHours(), d.getMinutes()].map(function (x) {
        return x < 10 ? "0" + x : x
      }).join(":")

      return res;
    },

    getTimePeriod: function (dateTime) {

      var d = new Date(this.TodoTimeCreated)

      var res = [d.getHours(), d.getMinutes()].map(function (x) {
        return x < 10 ? "0" + x : x
      }).join(":")

      var d2 = new Date(dateTime)

      var res2 = [d2.getHours(), d2.getMinutes()].map(function (x) {
        return x < 10 ? "0" + x : x
      }).join(":")

      return res + "-" + res2;
    },
    _deleteTask: async function () {
      var check = await this.api.DeleteTask(this.TodoId);

      if (check.data.success) {
        //this.$el.parentNode.removeChild(this.$el);
        this.$forceUpdate();
      }
    },

    _completeTask: async function () {
      if (!this.complete)
        this.TodoPeriod = this.getTimePeriod(Date.now());

      var result = await this.api.UpdateTask(this.TodoId, !this.complete);
      if (result.data.success) {
        this.$forceUpdate();
        this.complete = true
      }
      if (result.data.success) {
        this.$forceUpdate();
        this.complete = false
      }
    }

  }
}


</script>


<style scoped>
.wrapword {

  overflow: hidden;
  display: -webkit-box;
  -webkit-line-clamp: 3;
  -webkit-box-orient: vertical;

  white-space: -moz-pre-wrap !important;  /* Mozilla, since 1999 */
  white-space: -pre-wrap;      /* Opera 4-6 */
  white-space: -o-pre-wrap;    /* Opera 7 */
  white-space: pre-wrap;       /* css-3 */
  word-wrap: break-word;       /* Internet Explorer 5.5+ */
  white-space: -webkit-pre-wrap; /* Newer versions of Chrome/Safari*/
  word-break: break-all;
  white-space: normal;
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
  /*width: 90%;*/
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
