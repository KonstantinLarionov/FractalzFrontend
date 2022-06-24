<template>
  <div class="dialogs-wrap p-3" id="dialogsSpace">
    <!-- Searcher -->
    <div class="row">
      <div class="searcher-wrap row">
        <div class="searcher-icon col-2">
          <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="gray" class="bi bi-search" viewBox="0 0 16 16">
            <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z"/>
          </svg>
        </div>
        <div class="searcher-input col-10">
          <input type="text" placeholder="Найти диалог"/>
        </div>
      </div>
    </div>
    <!-- Dialogs -->
    <div class="row" v-for="dialogContent in dialogContents" :key="dialogContent.$id">
      <dialog-element :dialog-name="dialogContent.name" :dialog-last-message="dialogContent.lastMessage" :dialog-date-send="dialogContent.dateSend"></dialog-element>
    </div>
  </div>
</template>

<script>
import DialogElement from "../elements/DialogElement";
import Vue from "vue";

Vue.component ('dialog-element', DialogElement)

export default {
  name: "DialogPage",
  date() {
    return {
      dialogContents: [],
    }
  },
  mounted: async function () {
    this.dialogContents = [];
    this.getDialogs();
  },
  methods: {
    getDialogs: function () {
      var arr =[
        {
          id: 0,
          name:'Даниил Яковлев',
          lastMessage: 'Привед',
          dateSend: '15.04.2007',
        },
        {
          id: 1,
          name:'Андрюшка',
          lastMessage: 'Привед',
          dateSend: '15.04.2007',
        }
      ];

      for (let j in arr)
      {
        this.$set(this.dialogContents, j, arr[j])
      }
      this.$forceUpdate();
    },
  }
}
</script>

<style scoped>

</style>