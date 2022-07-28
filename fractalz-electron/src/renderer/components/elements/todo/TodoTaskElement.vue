<template>
  <div>
    <a class="task-delete" v-on:click="_deleteTask()">
      <svg xmlns="http://www.w3.org/2000/svg" height="20px" viewBox="0 0 24 24"  width="20px" fill="#000000">
        <path d="M0 0h24v24H0z" fill="none"/>
        <path d="M6 19c0 1.1.9 2 2 2h8c1.1 0 2-.9 2-2V7H6v12zM19 4h-3.5l-1-1h-5l-1 1H5v2h14V4z"/>
      </svg>
    </a>
  <input type="checkbox" @click="_completeTask()" class="checkBox" v-model:value="complete">
  <span class="task mt-4">{{TodoName}}</span>
  <span class="time ml-2">{{TodoTimeCreated}}</span>
  <span class="float-right">{{TodoTimeToTake}}</span>
  </div>
</template>

<script>
import TodoPage from "../../pages/TodoPage";
import ToDoPart from "../../../api/TodoPart";
export default {
  props : {
    TodoName : '',
    TodoTimeCreated : null,
    TodoTimeToTake : null,
    TodoId:'',
    api: Object,
    noty: Object,
    Check:'',
    complete:''
  },
  name: "TodoTaskElement",
 mounted() {
   this.api = new ToDoPart(this.$http);
 },
  methods: {

    _deleteTask: async function()
    {
      console.log(this.TodoId)
      var check = await this.api.DeleteTask(this.TodoId);

      if(check.data.success)
        {
          this.$forceUpdate();
        }
    },

    _completeTask: async function()
    {
      if (this.complete !== true)
        {
          var check = await this.api.UpdateTask(this.TodoId, true);
        }
        else
        {
          var result = await this.api.UpdateTask(this.TodoId, false);
        }
      if(check.data.success)
        {
          this.$forceUpdate();
          this.complete.save(true)
        }
      if(result.data.success)
        {
          this.$forceUpdate();
          this.complete.save(false)
        }
    }

  }
}


</script>


<style scoped>

.task-delete{
  cursor: pointer;
}
</style>