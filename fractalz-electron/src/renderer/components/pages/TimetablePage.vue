<template>
  <div class="todo-wrap" id="todoSpace">
    <div class="todo-filter">
      <div class="Entering-a-search">
        <div class="eye">
          <img class="eye-img" src="https://sun9-west.userapi.com/sun9-10/s/v1/ig2/laqT6gkcivf2-sVCGMaoWgzfT2GW5hJkxjf2J1jO1UJd3BEldvFrdFiChoqMG0s-WJo5QYffCGxHkJJh4xsR_eff.jpg?size=20x15&quality=96&type=album"/>
          <p style="margin-left: 3px;">Показать только:</p>
        </div>
        <div class="Dates">
          <svg class ="box" width="16" height="16" viewBox="0 0 9 9" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M1.96875 0C2.04334 0 2.11488 0.0296316 2.16762 0.0823762C2.22037 0.135121 2.25 0.206658 2.25 0.28125V0.5625H6.75V0.28125C6.75 0.206658 6.77963 0.135121 6.83238 0.0823762C6.88512 0.0296316 6.95666 0 7.03125 0C7.10584 0 7.17738 0.0296316 7.23012 0.0823762C7.28287 0.135121 7.3125 0.206658 7.3125 0.28125V0.5625H7.875C8.17337 0.5625 8.45952 0.681026 8.6705 0.892005C8.88147 1.10298 9 1.38913 9 1.6875V7.875C9 8.17337 8.88147 8.45952 8.6705 8.6705C8.45952 8.88147 8.17337 9 7.875 9H1.125C0.826631 9 0.540483 8.88147 0.329505 8.6705C0.118526 8.45952 0 8.17337 0 7.875V1.6875C0 1.38913 0.118526 1.10298 0.329505 0.892005C0.540483 0.681026 0.826631 0.5625 1.125 0.5625H1.6875V0.28125C1.6875 0.206658 1.71713 0.135121 1.76988 0.0823762C1.82262 0.0296316 1.89416 0 1.96875 0V0ZM1.125 1.125C0.975816 1.125 0.832742 1.18426 0.727252 1.28975C0.621763 1.39524 0.5625 1.53832 0.5625 1.6875V7.875C0.5625 8.02418 0.621763 8.16726 0.727252 8.27275C0.832742 8.37824 0.975816 8.4375 1.125 8.4375H7.875C8.02418 8.4375 8.16726 8.37824 8.27275 8.27275C8.37824 8.16726 8.4375 8.02418 8.4375 7.875V1.6875C8.4375 1.53832 8.37824 1.39524 8.27275 1.28975C8.16726 1.18426 8.02418 1.125 7.875 1.125H1.125Z" fill="#00627A"/>
          </svg>
          <svg class="stik-in-data" width="12" height="8" viewBox="0 0 7 3" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M0.40625 1.25C0.40625 1.17541 0.435882 1.10387 0.488626 1.05113C0.541371 0.998382 0.612908 0.96875 0.6875 0.96875H6.3125C6.38709 0.96875 6.45863 0.998382 6.51137 1.05113C6.56412 1.10387 6.59375 1.17541 6.59375 1.25V1.8125C6.59375 1.88709 6.56412 1.95863 6.51137 2.01137C6.45863 2.06412 6.38709 2.09375 6.3125 2.09375H0.6875C0.612908 2.09375 0.541371 2.06412 0.488626 2.01137C0.435882 1.95863 0.40625 1.88709 0.40625 1.8125V1.25Z" fill="#00627A"/>
          </svg>
          <svg class="numbers" width="10" height="9" viewBox="0 0 5 4" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M1.62531 3.137V0.136625H1.26925C1.01424 0.272563 0.767777 0.423971 0.53125 0.59V0.980937C0.742188 0.836375 1.07631 0.632188 1.23887 0.543875H1.24563V3.137H1.62531ZM2.29356 2.40294C2.32 2.76294 2.62769 3.19381 3.2515 3.19381C3.95913 3.19381 4.3765 2.59419 4.3765 1.57888C4.3765 0.491 3.93719 0.078125 3.27794 0.078125C2.75706 0.078125 2.26713 0.456125 2.26713 1.09569C2.26713 1.74819 2.73063 2.09131 3.20988 2.09131C3.6295 2.09131 3.90175 1.87981 3.98781 1.64694H4.003C4.00075 2.38719 3.74369 2.86419 3.26894 2.86419C2.89544 2.86419 2.70194 2.61106 2.67831 2.40294H2.29356ZM3.95463 1.09962C3.95463 1.49112 3.64019 1.76338 3.28863 1.76338C2.95056 1.76338 2.64513 1.54794 2.64513 1.08837C2.64513 0.625437 2.9725 0.40775 3.30212 0.40775C3.65819 0.40775 3.95463 0.631625 3.95463 1.09962Z" fill="#00627A"/>
          </svg>
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
          <svg class="clock" width="18" height="18" viewBox="0 0 9 9" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M3.37501 0.28125C3.37501 0.206658 3.40464 0.135121 3.45738 0.0823762C3.51013 0.0296316 3.58166 0 3.65626 0L5.34376 0C5.41835 0 5.48988 0.0296316 5.54263 0.0823762C5.59537 0.135121 5.62501 0.206658 5.62501 0.28125C5.62501 0.355842 5.59537 0.427379 5.54263 0.480124C5.48988 0.532868 5.41835 0.5625 5.34376 0.5625H5.06251V1.16437C5.82852 1.27495 6.54497 1.60879 7.12235 2.12419C7.69973 2.63959 8.11245 3.3137 8.30893 4.06229C8.50541 4.81089 8.47695 5.60079 8.2271 6.33331C7.97726 7.06583 7.51711 7.70849 6.90413 8.181L7.24219 8.51962C7.295 8.57236 7.3247 8.64392 7.32476 8.71855C7.32481 8.79318 7.29521 8.86478 7.24247 8.91759C7.18974 8.97041 7.11818 9.0001 7.04355 9.00016C6.96891 9.00021 6.89732 8.97061 6.84451 8.91788L6.42488 8.49825C5.83706 8.82819 5.1741 9.00101 4.50001 9C3.82592 9.00101 3.16295 8.82819 2.57513 8.49825L2.15551 8.91788C2.12936 8.94399 2.09832 8.96469 2.06417 8.97881C2.03002 8.99293 1.99342 9.00018 1.95646 9.00016C1.91951 9.00013 1.88292 8.99283 1.84879 8.97866C1.81466 8.96449 1.78365 8.94374 1.75754 8.91759C1.73142 8.89144 1.71072 8.86041 1.6966 8.82626C1.68248 8.7921 1.67523 8.75551 1.67526 8.71855C1.67531 8.64392 1.70501 8.57236 1.75782 8.51962L2.09644 8.181C1.48348 7.70852 1.02332 7.06591 0.773446 6.33344C0.523573 5.60096 0.495065 4.8111 0.691482 4.06251C0.8879 3.31393 1.30054 2.63981 1.87784 2.12438C2.45515 1.60894 3.17154 1.27504 3.93751 1.16437V0.5625H3.65626C3.58166 0.5625 3.51013 0.532868 3.45738 0.480124C3.40464 0.427379 3.37501 0.355842 3.37501 0.28125ZM4.78126 3.09375C4.78126 3.01916 4.75162 2.94762 4.69888 2.89488C4.64613 2.84213 4.5746 2.8125 4.50001 2.8125C4.42541 2.8125 4.35388 2.84213 4.30113 2.89488C4.24839 2.94762 4.21876 3.01916 4.21876 3.09375V4.98488L3.41494 6.32362C3.37653 6.38762 3.36511 6.46426 3.3832 6.53668C3.40129 6.6091 3.44741 6.67137 3.51141 6.70978C3.57541 6.7482 3.65205 6.75961 3.72447 6.74152C3.79689 6.72343 3.85915 6.67731 3.89757 6.61331L4.74132 5.20706C4.76747 5.16338 4.78127 5.11341 4.78126 5.0625V3.09375ZM0.483756 3.03019C0.338214 2.90359 0.220275 2.7484 0.137272 2.57427C0.054269 2.40015 0.00797744 2.21081 0.00127614 2.01802C-0.00542515 1.82524 0.0276071 1.63314 0.0983187 1.45367C0.16903 1.2742 0.275909 1.1112 0.412308 0.974803C0.548708 0.838403 0.711711 0.731524 0.891181 0.660813C1.07065 0.590101 1.26275 0.557069 1.45553 0.56377C1.64831 0.570472 1.83765 0.616763 2.01178 0.699766C2.18591 0.782769 2.34109 0.900709 2.46769 1.04625C1.61266 1.48036 0.917863 2.17516 0.483756 3.03019ZM6.53232 1.04625C6.65892 0.900709 6.8141 0.782769 6.98823 0.699766C7.16236 0.616763 7.3517 0.570472 7.54448 0.56377C7.73726 0.557069 7.92936 0.590101 8.10883 0.660813C8.2883 0.731524 8.4513 0.838403 8.5877 0.974803C8.7241 1.1112 8.83098 1.2742 8.90169 1.45367C8.9724 1.63314 9.00544 1.82524 8.99874 2.01802C8.99203 2.21081 8.94574 2.40015 8.86274 2.57427C8.77974 2.7484 8.6618 2.90359 8.51626 3.03019C8.08215 2.17516 7.38735 1.48036 6.53232 1.04625Z" fill="#00627A"/>
          </svg>
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
  width: 50%;
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
height: 40px;
width: 50%;
}
.box{
position: fixed;
  top: 15px;
  right: 217px;
}
.stik-in-data{
position: fixed;
  top: 15px;
  right: 219px;
}
.numbers{
  position: fixed;
  top: 21px;
  right: 220px;
}
.up-p{
  font-size: 12px;
  font-weight: 300;
  position: fixed;
  top: 15px;
  right: 130px;
}
.input-data{
  position: fixed;
  right: 5px;
  top: 15px;
  font-weight: 300;
  font-size: 12px;
  width: 120px;
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
  width: 270px;
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
  width: 100%;
  height: 100%;
  font-size: 13px;
  line-height: 5px;
  font-weight: 300;
}
.clock{
  position: fixed;
  top: 65px;
  right: 217px;
}
.from-time{
  position: fixed;
  top: 70px;
  right: 195px;
}
.midnight{
  width: 80px;
  position: fixed;
  top: 63px;
  right: 110px;
  border-top: transparent;
  border-right: transparent;
  border-bottom: #00627AA1;
  border-left: transparent;
  text-align: center;
  font-weight: 400;
  font-size: 12px;
}
.before-p{
  position: fixed;
  top: 70px;
  right: 85px;
}
.midnight2{
  width: 70px;
  position: fixed;
  top: 63px;
  right: 10px;
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
  height: 12px;
  width: 12px;
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