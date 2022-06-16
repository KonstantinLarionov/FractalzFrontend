<template>
  <div hidden class="todo-wrap" id="todoSpace">
    <!--For Page-->
    <div class="page">
      <!--Card-->
      <div class="card">
        <!--Card Header-->
        <div class="card-header">
          <p> <hb class="hb-todo"/>
          <div class="mb-1">
            <span class="task">Всего задач:</span>
            <span class="float-right">3123шт</span>
          </div>
          <div class="mb-1">
            <span class="task">Всего открытых задач:</span>
            <span class="float-right">31шт</span>
          </div>
          <div class="mb-3">
            <span class="task">Задач на сегодня:</span>
            <span class="float-right">0шт</span>
          </div>
          <ht/>
          <span class="float-right mt-2">
                                    <button class="mr-4 navTask dark-teal" data-toggle="modal" data-target="#todoAdd" >Добавить задачу</button>
                                    <button class="mr-4 border-0 bg-transparent navTask text-dark">Архив задач</button>
                                    <i class="fa fa-search" aria-hidden="true"></i>
                            </span>
          </p>
        </div>
        <!--Card Body-->
        <div class="card-body">
          <p class="heading1">
            <span class="today">Сегодня</span>
            <span class="float-right headingright">7h 15min</span>
          </p>
          <div>
            <input type="checkbox">
            <span class="task mt-4">Take kids to school</span>
            <span class="time ml-2">8:00-8:30AM</span>
            <span class="float-right">30min</span>
          </div>
          <p class="heading2">
            <span class="tomorrow">Вчера</span>
            <span class="float-right headingright">6h 30min</span>
          </p>
          <div>
            <input type="checkbox" checked>
            <span class="task mt-4" style="text-decoration: line-through;">Take kids to school</span>
            <span class="time ml-2">8:00-8:30AM</span>
            <span class="float-right">30min</span>
          </div>
        </div>
      </div>
    </div>
  </div>

</template>

<script>
export default {
  name: "TodoPage"
}
</script>

<style scoped>

</style>