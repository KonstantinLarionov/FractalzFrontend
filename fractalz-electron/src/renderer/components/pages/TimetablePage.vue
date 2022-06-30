<template>
  <vue-cal class=""
           :disable-views="['years', 'year']"
           locale="ru"
           active-view="month"
           style="height: 100%"
           :time-step="30"
           :events="events">
    <template v-slot:split-label="{ split, view }">
      <i class="icon material-icons">person</i>
      <strong :style="`color: ${split.color}`">
        {{ split.label }}</strong>
    </template>
   </vue-cal>
</template>

<script>
import VueCal from 'vue-cal'
import 'vue-cal/dist/i18n/ru.js'
import 'vue-cal/dist/vuecal.css'
export default {
  name: "TimetablePage",
  components:{VueCal},
  data:()=>({
      events: [
      {
        start: '2022-06-29 11:30',
        end: '2022-06-29 12:30',
        title: 'Need to go shopping',
        content: '<i class="v-icon material-icons">shopping_cart</i>',
        class: 'leisure'
      },
      {
        start: '2022-06-29 10:30',
        end: '2022-06-29 11:30',
        title: 'Golf with John',
        content: '<i class="v-icon material-icons">shopping_cart</i>',
        class: 'leisure'
      },
      {
        start: '2022-06-28 10:30',
        end: '2022-06-28 11:30',
        title: 'Dad\'s birthday!',
        content: '<i class="v-icon material-icons">shopping_cart</i>',
        class: 'sport'
      }
    ]
  }),
  methods: {
    onEventClick(event, e) {

    }
  }
}
</script>

<style scoped>
.vuecal__menu, .vuecal__cell-events-count {
  background-color: #42b983;
}
.vuecal__title-bar {
  background-color: #e4f5ef;
}
.vuecal__cell--today, .vuecal__cell--current {
  background-color: rgba(240, 240, 255, 0.4);
}
.vuecal:not(.vuecal--day-view) .vuecal__cell--selected {
  background-color: rgba(235, 255, 245, 0.4);
}
.vuecal__cell--selected:before {
  border-color: rgba(66, 185, 131, 0.5);
}
</style>