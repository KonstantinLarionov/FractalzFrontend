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

/* W3C standard
   сейчас только для Firefox */
* {
  scrollbar-width: thin;
  scrollbar-color: #46be8a white;
}

/* для Chrome/Edge/Safari */
*::-webkit-scrollbar {
  height: 12px;
  width: 12px;
}
*::-webkit-scrollbar-track {
  background: white;
}
*::-webkit-scrollbar-thumb {
  background-color: #46be8a;
  border-radius: 5px;
  border: 3px solid white;
}
</style>
