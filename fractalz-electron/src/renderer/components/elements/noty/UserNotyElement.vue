<template>
  <li class="list-group-item" style="border-bottom: 1px solid gainsboro;">
    <input class="form-check-input" style="cursor: pointer;" type="checkbox" v-bind:id="id" :value="isSelect" @change="changeUser($event)" >
    <label class="form-check-label stretched-link" style="cursor: pointer;" v-bind:for="id">{{this.Name}}</label>
  </li>
</template>

<script>
export default {
  name: "UserNotyElement",
  props : {
    isSelect : Boolean,
    id : String,
    Name : String
  },

  methods : {
    changeUser : function (event)
    {
      if(event.target.checked) {
        this.$emit('select', this.id)
      }
      else {
        this.$emit('unselect', this.id)
      }
    },
  }
}
</script>

<style scoped>

</style>
