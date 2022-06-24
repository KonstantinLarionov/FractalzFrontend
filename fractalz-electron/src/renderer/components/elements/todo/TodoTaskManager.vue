<template>
  <div>
  <hb class="hb-todo"/>
  <div class="mb-1">
    <span class="task">Всего задач:</span>
    <span class="float-right">{{TodoTotalTasks}} шт</span>
  </div>
  <div class="mb-1">
    <span class="task">Всего открытых задач:</span>
    <span class="float-right">{{TodoTotalOpenTasks}} шт</span>
  </div>
  <div class="mb-3">
    <span class="task">Задач на сегодня:</span>
    <span class="float-right">{{TodoTodayTasks}} шт</span>
  </div>
  <ht/>
  </div>
</template>

<script>
export default {
  name: "TodoTaskManager",
  props : {
    TodoTotalTasks : null,
    TodoTotalOpenTasks : null,
    TodoTodayTasks : null,
  },
}
</script>

<style scoped>

</style>