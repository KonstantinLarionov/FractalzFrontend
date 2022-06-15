<template>
  <div id="app">
    <!--Динамический компонент-->
    <component :is="layout">
      <router-view/>
    </component>
  </div>
</template>


<script>
  export default {
    name: 'fractalz-electron',

    computed: {
      //Это самое вычисляемое свойство
      layout(){
        console.log(this.$route.meta.layout)
        //Вернем имя шаблона из роута или дефолтное значение
        //(шаблон для страниц, для которых мы не указали ш аблон)
        return this.$route.meta.layout || "default-layout"
      }
    }
  }
</script>

<style>
  /* CSS */
</style>
