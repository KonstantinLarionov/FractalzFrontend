<template>
  <div class="row news">
    <div class="col-4 w-100 h-100 p-0 m-0">
      <img src="https://via.placeholder.com/100" style="width: 100%; height: 100%"/>
    </div>
    <div class="col-8" >
      <div class="container" >
        <div class="row mb-2"><p class="text-dark text-truncate font-weight-bold m-0" style="font-size: 14px;">{{NewsName}}</p></div>
        <div class="row mb-2"> <span class="badge bg-success">{{NewsType}}</span></div>
        <div class="row"> <p class="text-truncate text-wrap font-monospace" style="font-size: 14px;">{{NewsText}}</p></div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props : {
    NewsName : null,
    NewsType : null,
    NewsText: null,
  },
  name: "NewsElement"
}
</script>

<style scoped>

</style>