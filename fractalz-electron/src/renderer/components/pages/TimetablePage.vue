<template>
  <vue-cal class="" style="height: 100%"
           :disable-views="['years', 'year']" active-view="week" :time-step="30"
           locale="ru"
           :special-hours="specialHours"
           :split-days="splitDays"
           :sticky-split-labels="stickySplitLabels"
           :events="events"
           >
   </vue-cal>
</template>

<script>
import VueCal from 'vue-cal'
import 'vue-cal/dist/i18n/ru.js'
import 'vue-cal/dist/vuecal.css'
const dailyHours = { from: 9 * 60, to: 18 * 60, class: 'business-hours', split: 1 }
export default {
  name: "TimetablePage",
  components:{VueCal},
  data:()=>({
    stickySplitLabels: false,
    splitDays: [
      // The id property is added automatically if none (starting from 1), but you can set a custom one.
      // If you need to toggle the splits, you must set the id explicitly.
      { id: 1, class: 'mom', label: 'Mom' },
      { id: 2, class: 'dad', label: 'Dad'},
    ],
    specialHours: {
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
    },
      events: [
      {
        start: '2022-06-29 11:30',
        end: '2022-06-29 12:30',
        title: 'Need to go shopping',
        content: '<i class="v-icon material-icons">shopping_cart</i>',
        class: 'leisure',
        split: 1
        },
      {
        start: '2022-06-29 10:30',
        end: '2022-06-29 11:30',
        title: 'Golf with John',
        content: '<i class="v-icon material-icons">shopping_cart</i>',
        class: 'leisure',
        split: 2
      },
      {
        start: '2022-06-28 10:30',
        end: '2022-06-28 11:30',
        title: 'Dad\'s birthday!',
        content: '<i class="v-icon material-icons">shopping_cart</i>',
        class: 'sport',
        split: 1
      }
    ]
  }),
  methods: {
    onEventClick(event, e) {

    }
  }
}
</script>

<style>
.vuecal__cell-split.dad {background-color: rgba(221, 238, 255, 0.5);}
.vuecal__cell-split.mom {background-color: rgba(255, 232, 251, 0.5);}
.business-hours {
  background-color: rgba(0, 150, 135, 0.2);
  border: solid rgb(0, 150, 135);
  border-width: 2px 0;
}
</style>