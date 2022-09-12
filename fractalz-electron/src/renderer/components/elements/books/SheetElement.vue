<template>
  <div class="sheet-page-container">
    <div class="sheet-container-top">
      <button class="button-save-text" v-on:click="toSaveText"> Сохранить документ</button>
    </div>
    <div class="sheet-container-middle">
      <vue-editor v-model="content" ></vue-editor>
    </div>
  </div>
</template>

<script>
import { VueEditor } from "vue2-editor";
import BooksPart from "../../../api/BooksPart";


export default {
  components: {VueEditor},
  name: "SheetElement",
  props:{
    Id:null,
    Text:null,
  },
  data()
  {
    return{
      content: this.Text,
      api:Object
  }
  },
  mounted(){
    this.api = new BooksPart(this.$http)
  },
  methods:{
    toSaveText:async function()
    {
        let save = await this.api.SaveText(this.Id, this.content).catch(response=> {response.response.data})
        if(save.data.success)
        {
          console.log("Text saved succsefully")
        }
      }
    }
}
</script>

<style scoped>
.element-top-sheet
{
  width: 75%;
  display: table;
  height: max-content;
}
.button-save-text
{
  width: 230px;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  height:30px;
  margin-left: 65%;
  text-align: center;
  margin-bottom: 4px;
}

</style>