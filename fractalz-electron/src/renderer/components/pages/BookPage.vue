<template>
  <div class="page-container">
    <div class="books-route">Books>"Filtred">Section>"Non_critical"></div>
      <div class="box-container">

        <div class="book-card">

        </div>

        <div class="section-card">

        </div>

        <div class="sheet-card">

        </div>

      </div>
  </div>
</template>

<script>
export default {
  name: "BookPage"
}
</script>

<style scoped>
.page-container
{
  width: 100%;
  height: 100%;
}
.box-container
{
  display: table;
  width: 100%;
  height: 100%;
}
.book-card
{
  width: 250px;
  height: 150px;
  border-width: 2px;
  border-color: #868686;
  border-style: solid;
  border-radius: 8px;
  display: table-cell;
  margin:1px ;
}
.section-card
{
  width: 250px;
  height: 150px;
  border-width: 2px;
  border-color: #868686;
  border-style: solid;
  border-radius: 8px;
  display: table-cell;
}
.sheet-card
{
  width: available;
  height: 150px;
  border-width: 2px;
  border-radius: 8px;
  border-color: #868686;
  border-style: solid;
  display: table-cell;
  background-color: #e8e8e8;
}

</style>