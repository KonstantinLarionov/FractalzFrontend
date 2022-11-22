<template>
  <div class="todo-wrap" id="todoSpace">
    <div class="todo-filter">
      <div class="Entering-a-search">
        <div class="eye">
          <img class="eye-img" src="https://sun9-west.userapi.com/sun9-10/s/v1/ig2/laqT6gkcivf2-sVCGMaoWgzfT2GW5hJkxjf2J1jO1UJd3BEldvFrdFiChoqMG0s-WJo5QYffCGxHkJJh4xsR_eff.jpg?size=20x15&quality=96&type=album"/>
          <p style="margin-left: 3px;">Показать только:</p>
        </div>
        <div class="Dates">
          <img class="box" src="https://sun9-east.userapi.com/sun9-36/s/v1/ig2/qQYs4kBLeQg16AaQlC8W_2-Ydo_z1lb_mC--Eu8uG28YvOs5ddLIEB0L71nFymp0olnfkB9sikAosk2iJmAAOigj.jpg?size=17x16&quality=96&type=album"/>
          <p class="up-p">Выбрать день:</p>
          <input class="input-data" type="date">
        </div>
      </div>
      <div class="center-time">
        <div class="left-center">
          <div class="meetings-conference">
            <div class="first-row">
            <label class="checkbox style-a">
              <input type="checkbox"/>
              <div class="checkbox__checkmark"></div>
              <div class="checkbox__body"> <p class="p-meet" style="color:#0288D1;">Втречи</p></div>
            </label>
            <label class="checkbox style-c">
              <input type="checkbox"/>
              <div class="checkbox__checkmark"></div>
              <div class="checkbox__body"><p class="conference-p" style="color:#9575CD;">Конференции</p></div>
            </label>
          </div>
          <div class="second-row">
            <label class="checkbox style-b">
              <input type="checkbox"/>
              <div class="checkbox__checkmark"></div>
              <div class="checkbox__body"><p class="notification-p">Уведомления</p></div>
            </label>
          </div>
          </div>
        </div>
        <div class="right-center">
          <img class="clock" src="https://sun9-west.userapi.com/sun9-9/s/v1/ig2/lOxTsFlzVec3v6cyveWpzNVIeRTd2XZ-v7i1v39RZu6Lm6QHfvCTP9jcNUs8F20Gy-MQmkxz2kZS9iRwazv8tKgS.jpg?size=21x21&quality=96&type=album"/>
          <p class="from-time">С:</p> <input class="midnight" type="text" alt="00:00"> <p class="before-p">По:</p> <input class="midnight2" type="text" alt="00:00">
        </div>
      </div>
      <div class="down-buttone">
        <button class="bt-1">Добавить <br> встречу</button>
        <button class="bt-2">Добавить <br> конфиренцию</button>
        <button class="bt-3">Добавить <br> уведомления</button>
      </div>
    </div>
    <div class="the-main-part">
      <div class="schedule-menu">
        <div class ="time-task">
          <p class="p-time">00:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">01:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">02:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">03:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">04:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">05:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">06:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">07:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">08:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">09:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">10:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">11:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">12:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">13:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">14:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">15:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">16:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">17:00</p>
        </div>
        <div class ="time-task">
        <p class="p-time">18:00</p>
      </div>
        <div class ="time-task">
          <p class="p-time">19:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">20:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">21:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">22:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">23:00</p>
        </div>
        <div class ="time-task">
          <p class="p-time">00:00</p>
        </div>
        <div class="meeting"><p class="time-in-the-windows">7:00-8:00</p><p class="text-in-the-windows">Встреча: с руководителем отдела CEO. пр.Победы 157</p></div>
        <div class="meeting2"><p class="time-in-the-windows2">8:00-9:30</p><p class="text-in-the-windows2">Конференция: с разработчиками продукта Letter. На тему <br> дизайн приложения и разработка UIUX</p> </div>
        <div class="meeting3"><p class="time-in-the-windows3">12:00</p><p class="text-in-the-windows3">Уведомление: Начать делать задачу Cav-734</p></div>
        <div class="meeting4"><p class="time-in-the-windows4">15:00</p><p class="text-in-the-windows4">Уведомление: Начать делать задачу Cav-734</p></div>
        <div class="meeting5"><p class="time-in-the-windows5">17:00</p><p class="text-in-the-windows5">Уведомление: Начать делать задачу Cav-734</p></div>
      </div>
    </div>
  </div>
</template>
<script>
function TimetablePage() {

}
import VueCal from 'vue-cal'
import 'vue-cal/dist/i18n/ru.js'
import 'vue-cal/dist/vuecal.css'
import Vue from "vue";
import TimetableAddDayModal from "../modals/timetable/TimetableAddDayModal";

Vue.component ('timetable-add-day-modal', TimetableAddDayModal)

const dailyHours = { from: 9 * 60, to: 18 * 60, class: 'business-hours', split: 1 }
export default {
  name: "TimetablePage",
  components:{VueCal},
  data(){
    return {
      showAddDayModal: false,
      showChangeDay: false,
      showDeleteDayModal: false,
      showGetUsersDayModal: false,
      splitDays: [
        // The id property is added automatically if none (starting from 1), but you can set a custom one.
        // If you need to toggle the splits, you must set the id explicitly.
        { id: 1, class: 'mom', label: 'Mom' },
        { id: 2, class: 'dad', label: 'Dad'},
      ],
      /*specialHours: {
        1: dailyHours,
        2: dailyHours,
        3: [
          { from: 9 * 60, to: 12 * 60, class: 'business-hours' },
          { from: 14 * 60, to: 18 * 60, class: 'business-hours' }
        ],
        4: dailyHours,
        5: dailyHours,
        6: dailyHours,
        7: dailyHours,
      },*/
      events: [
        {
          start: '2022-06-29 8:30',
          end: '2022-06-29 17:30',
          title: 'Рабочий день',
          class: 'working-day',
          split: 1
        },
        {
          start: '2022-06-29 8:30',
          end: '2022-06-29 17:30',
          title: 'Рабочий день',
          class: 'working-day',
          split: 2
        }
      ]
    }

  },
  methods: {

  }
}
</script>

<style>
.todo-filter {
  width: 100%;
  height: 170px;
  box-shadow: var(--shadow-down-4);
  border-radius: 0 0 45px 45px;
  background-color: white;
  display: flex;
  flex-direction: column;
}
.Entering-a-search{
  display: flex;
  flex-direction: row;
  width: 100%;
  height: 40px;
}
.eye{
display: flex;
  flex-direction: row;
  width: 190px;
  height: 20px;
  margin-left: 40px;
  margin-top: 17px;
  font-size: 12px;
  font-weight: 300;
}
.eye-img{
  width: 23px;
  height: 18px;
}
.Dates{
margin-top: 15px;
height: 20px;
width: 200px;
display: flex;
flex-direction: row;
}
.box{
width: 18px;
height: 19px;
margin-top: -1px;
}
.up-p{
  font-size: 12px;
  font-weight: 300;
  margin-left: 5px;
}
.input-data{
  width: 90px;
  font-weight: 300;
  font-size: 12px;
  margin-left: 2px;
  border-top: transparent;
  border-right: transparent;
  border-bottom: #00627AA1;
  border-left: transparent;
  text-align: center
}
.center-time{
  height: 50px;
  width: 100%;
  display: flex;
  flex-direction: row;
}
.left-center{
  display: flex;
  flex-direction: column;
  width: 200px;
  height: 100%;
  margin-left: 10px;
}
.meetings-conference{
  width: 100%;
  height: 100px;
  display: flex;
  flex-direction: column;
  font-size: 12px;
  margin-left: 10px;
}
.center-box1{
  position: fixed;
  top: 45px;
  left: 95px;
}
.check-mark1{
  position: fixed;
  top: 47px;
  left: 97px;
}
.center-box2{
  position: fixed;
  top: 45px;
  left: 165px;
}
.check-mark2{
  position: fixed;
  top: 47px;
  left: 167px;
}
.center-box3{
  position: fixed;
  top: 70px;
  left: 122px;
}
.check-mark3{
  position: fixed;
  top: 72px;
  left: 124px;
}
.p-meet{
  margin-left: -7px;
  margin-top: 3px;
}
.notification-p{
  color:#FF5722;
  font-size:12px;
  margin-left: -9px;
  margin-top: 2px;
}
.right-center{
  display: flex;
  flex-direction: row;
  width: 20%;
  height: 20px;
  font-size: 13px;
  line-height: 5px;
  font-weight: 300;
}
.clock{
  margin-left:20px;
}
.from-time{
  margin-left: 5px;
  margin-top: 9px;
}
.midnight{
  width: 60px;
  
  border-top: transparent;
  border-right: transparent;
  border-bottom: #00627AA1;
  border-left: transparent;
  text-align: center;
  font-weight: 400;
  font-size: 12px;
}
.before-p{
  margin-left: 10px;
  margin-top: 8px;
}
.midnight2{
  width: 70px;
  margin-left: 5px;
  margin-bottom: 1px;
  border-top: transparent;
  border-right: transparent;
  border-bottom: #00627AA1;
  border-left: transparent;
  text-align: center;
  font-weight: 400;
  font-size: 12px;
}
.down-buttone{
  width: 100%;
  height: 50px;
  display: flex;
  flex-direction: row;
  font-style: normal;
  font-weight: 200;
  font-size: 11px;
  line-height: 13px;
  text-align: center;
}
.bt-1{
  background: #0288D1;
  border-radius: 10px;
  margin-left: 20px;
  margin-top: 20px;
  width: 115px;
  height: 40px;
  color: white;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.bt-2{
  background:#9575CD;
  border-radius: 10px;
  margin-left: 25px;
  margin-top: 20px;
  width: 115px;
  height: 40px;
  color: white;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.bt-3{
background: #FF5722;
  border-radius: 10px;
  margin-left: 25px;
  margin-top: 20px;
  width: 115px;
  height: 40px;
  color: white;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.the-main-part{
  width: 100%;
  height: 1000px;
}
.schedule-menu{
  width: 95%;
  height: 525px;
  background:#ECECEC;
  margin-top: 20px;
  margin-left: 10px;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.time-task{
  border: 1px solid lightgrey;
  width: 100%;
  height: 21px;
  font-size: 10px;
  font-weight: 300;
  line-height: 7px;
}
.conference-p{
font-size: 12px;
margin-left: 19px;
margin-top: 2px;
}
.p-time{
  margin-top: 5px;
  margin-left: 4px;
}
.meeting{
  position: fixed;
  top: 338px;
  left: 130px;
  height: 21px;
  width: 380px;
  background: #0288D1;
  border-radius: 5px;
  color: white;
}
.meeting2{
  position: fixed;
  top: 358px;
  left: 130px;
  height: 31px;
  width: 380px;
  background: #9575CD;
  border-radius: 5px;
  color: white;
}
.meeting3{
  position: fixed;
  top: 400px;
  left: 130px;
  height: 21px;
  width: 380px;
  background: #FF5722;
  border-radius: 5px;
  color: white;
}
.meeting4{
  position: fixed;
  top: 505px;
  left: 130px;
  height: 21px;
  width: 380px;
  background: #FF5722;
  border-radius: 5px;
  color: white;
}
.meeting5{
  position: fixed;
  top: 547px;
  left: 130px;
  height: 21px;
  width: 380px;
  background: #FF5722;
  border-radius: 5px;
  color: white;
}
.time-in-the-windows{
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 300;
  line-height: 7px;
}
.time-in-the-windows2{
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 300;
  line-height: 7px;
}
.time-in-the-windows3{
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 300;
  line-height: 7px;
}
.time-in-the-windows4{
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 300;
  line-height: 7px;
}
.time-in-the-windows5{
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 300;
  line-height: 7px;
}
.text-in-the-windows{
  position: fixed;
  top: 338px;
  left: 175px;
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 200;
  line-height: 7px;
}
.text-in-the-windows2{
  position: fixed;
  top: 356px;
  left: 175px;
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 200;
  line-height: 10px;
}
.text-in-the-windows3{
  position: fixed;
  top: 400px;
  left: 165px;
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 200;
  line-height: 7px;
}
.text-in-the-windows4{
  position: fixed;
  top: 505px;
  left: 165px;
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 200;
  line-height: 7px;
}
.text-in-the-windows5{
  position: fixed;
  top: 547px;
  left: 165px;
  margin-top: 6px;
  margin-left: 5px;
  font-size: 10px;
  font-weight: 200;
  line-height: 7px;
}
.vuecal__event.working-day
{
  background-color: rgb(253, 211, 173);
  border: solid rgb(246, 201, 160);
  border-width: 0 0 0 4px ;
}
.vuecal__event.weekend
{
  background-color: rgba(0, 150, 135, 0.2);
  border: solid rgb(0, 150, 135);
  border-width: 2px 0;
}
.vuecal__cell-split.dad {background-color: rgba(221, 238, 255, 0.5);}
.vuecal__cell-split.mom {background-color: rgba(255, 232, 251, 0.5);}
.business-hours {
  background-color: rgba(0, 150, 135, 0.2);
  border: solid rgb(0, 150, 135);
  border-width: 2px 0;
}
.checkbox.style-a {
  display: inline-block;
  position: relative;
  padding-left: 25px;
  cursor: pointer;
  user-select: none;
  border-color: #0288D1;
}
.checkbox.style-a input {
  position: absolute;
  opacity: 0;
  cursor: pointer;
  height: 0;
  width: 0;
}
.checkbox.style-a input:checked ~ .checkbox__checkmark {
  background-color: #fff;
}
.checkbox.style-a input:checked ~ .checkbox__checkmark:after {
  opacity: 1;
  color: #0288D1;
}
.checkbox.style-a .checkbox__checkmark {
  position: absolute;
  top: 4px;
  left: 0;
  height: 13px;
  width: 13px;
  background-color: #fff;
  border: 1px solid #0288D1;
  transition: background-color 0.25s ease;
  border-radius: 3px;
}
.checkbox.style-a .checkbox__checkmark:after {
  content: "";
  position: absolute;
  left: 3px;
  top: 0px;
  width: 4px; 
  height: 8px;
  border: solid #0288D1;
  border-width: 0 1px 1px 0; 
  transform: rotate(45deg); 
  opacity: 0; 
  transition: opacity 0.25s ease; 
}
.checkbox.style-a .checkbox__body {
  color: #0288D1;
  line-height: 1.4;
  font-size: 12px;
}
.checkbox.style-b {
  display: inline-block;
  position: relative;
  padding-left: 25px;
  cursor: pointer;
  user-select: none;
  border-color: #FF5722;
}
.checkbox.style-b input {
  position: absolute;
  opacity: 0;
  cursor: pointer;
  height: 0;
  width: 0;
}
.checkbox.style-b input:checked ~ .checkbox__checkmark {
  background-color: #fff;
}
.checkbox.style-b input:checked ~ .checkbox__checkmark:after {
  opacity: 1;
  color: #FF5722;
}
.checkbox.style-b .checkbox__checkmark {
  position: absolute;
  top: 4px;
  left: 0;
  height: 12px;
  width: 13px;
  background-color: #fff;
  border: 1px solid #FF5722;
  transition: background-color 0.25s ease;
  border-radius: 3px;
}
.checkbox.style-b .checkbox__checkmark:after {
  content: "";
  position: absolute;
  left: 4px;
  top: 0px;
  width: 4px; 
  height: 8px;
  border: solid #FF5722;
  border-width: 0 1px 1px 0; 
  transform: rotate(45deg); 
  opacity: 0; 
  transition: opacity 0.25s ease; 
}
.checkbox.style-b .checkbox__body {
  color: #FF5722;
  line-height: 1.4;
  font-size: 16px;
}
.checkbox.style-c {
  display: inline-block;
  position: relative;
  margin-left: 10px;
  margin-top: -1px;
  cursor: pointer;
  user-select: none;
  border-color: #9575CD;
}
.checkbox.style-c input {
  position: absolute;
  opacity: 0;
  cursor: pointer;
  height: 0;
  width: 0;
}
.checkbox.style-c input:checked ~ .checkbox__checkmark {
  background-color: #fff;
}
.checkbox.style-c input:checked ~ .checkbox__checkmark:after {
  opacity: 1;
  color: #9575CD;
}
.checkbox.style-c .checkbox__checkmark {
  position: absolute;
  top: 4px;
  left: 0;
  height: 12px;
  width: 13px;
  background-color: #fff;
  border: 1px solid #9575CD;
  transition: background-color 0.25s ease;
  border-radius: 3px;
}
.checkbox.style-c .checkbox__checkmark:after {
  content: "";
  position: absolute;
  left: 4px;
  top: 0px;
  width: 4px; 
  height: 8px;
  border: solid #9575CD;
  border-width: 0 1px 1px 0; 
  transform: rotate(45deg); 
  opacity: 0; 
  transition: opacity 0.25s ease; 
}
.checkbox.style-c .checkbox__body {
  color: #9575CD;
  line-height: 1.4;
  font-size: 16px;
}
.first-row{
  width: 100%;
  height: 20px;
}
.second-row{
  width: 100%;
  height: 20px;
  margin-left: 30px;
}
</style>