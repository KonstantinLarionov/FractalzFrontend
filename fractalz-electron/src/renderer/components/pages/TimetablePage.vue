<template>
<!--  <div style="overflow-x:auto; overflow-y: auto" >
    <div class="btn-group btn-group p-1 align-content-lg-center col">
      <button type="button" @click="showAddDayModal = true" class="btn btn-success account-input-btn">Добавить рабочий день</button>
      <button type="button" class="btn btn-success account-input-btn">Изменить рабочие часы</button>
      <button type="button" class="btn btn-success account-input-btn">Удалить рабочий день</button>
      <button type="button" class="btn btn-success account-input-btn">Получить рабочее время пользователя</button>
    </div>-->
      <vue-cal class="" style="height: 100%"
               :disable-views="['years', 'year']" active-view="day" :time-step="30"

               locale="ru"
               :split-days="splitDays"
               :sticky-split-labels="true"
               :events="events">
      </vue-cal>
<!--    <timetable-add-day-modal v-if="showAddDayModal" @close="showAddDayModal = false">
    </timetable-add-day-modal>
  </div>-->
</template>

<script>
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
</style>