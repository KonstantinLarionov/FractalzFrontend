<template>
  <div class="book-container" >

    <div class="element-middle">
      <textarea type="text" class="text-sect-name" >{{SectionName}}</textarea>
    </div>

    <div class="element-bottom">
      <textarea type="text" class="text-sect-about" >{{About}}</textarea>
    </div>
  </div>
</template>

<script>
export default {
  name: "SectionElement",
  data()
      {
        return{
          SectionName:null,
          About:null
        }
      },
  methods:
      {
      }
}
</script>

<style scoped>
.element-top
{
  background-color: whitesmoke;
  border-radius:8px ;
  text-align: left;
  border-style: solid;
  border-width: 2px;
  margin:2px;
}
.button-settings
{
  border-radius: 8px;
  width: 38px;
  height: 38px;
  background-color: #009688;
  border-color: #009688;
}
.book-container
{
  width: 100%;
  background-color: #009688;
  border-radius: 8px;
  border-color: #0b0d0f;
  border-style: solid;
  height: max-content;
}

.text-sect-name
{
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
  width: 99%;
  overflow-scrolling:auto ;
}
.text-sect-about
{
  height: 25px;
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
  width: 99%;
}
</style>