<template>
  <div class="book-container">

    <div class="element-top">
      <label>Название документа</label>
      <button class="button-settings">X</button>
    </div>

    <div class="element-middle">
      <label>Краткое описание</label>
    </div>

    <div class="element-bottom">
      <label>CreationTime</label>
    </div>

  </div>
</template>

<script>
export default {
  name: "BookElement",
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
  width: 28px;
  height: 28px;
  margin-left: 31px;
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
.element-middle
{
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
}
.element-bottom
{

  height: 25px;
  background-color: whitesmoke;
  border-radius:8px ;
  border-color: #0b0d0f;
  border-style: solid;
  border-width: 2px;
  margin:2px;
  text-align: right;
}
</style>