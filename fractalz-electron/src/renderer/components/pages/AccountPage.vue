<template>
  <div class="account-wrap p-3" id="accountSpace">
    <div class="row"><img width="200" height="200" src="https://via.placeholder.com/200"/></div>
    <div class="row w-100 d-flex flex-column">
      <div class="input__wrapper">
        <input name="file" type="file" id="input__file" class="input input__file" multiple>
        <label for="input__file" class="input__file-button">
                        <span class="input__file-icon-wrapper">
                            <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-download" viewBox="0 0 16 16">
                                <path d="M.5 9.9a.5.5 0 0 1 .5.5v2.5a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-2.5a.5.5 0 0 1 1 0v2.5a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2v-2.5a.5.5 0 0 1 .5-.5z"/>
                                <path d="M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"/>
                            </svg>
                        </span>
          <span class="input__file-button-text">Выберите файл</span>
        </label>
      </div>
    </div>
    <div class="row w-100 d-flex flex-column">
      <label>Ваш Email: </label>
      <input type="text" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label>ФИО/Никнейм: </label>
      <input type="text" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label>Телефон: </label>
      <input type="text" class="account-input-text">
    </div>
    <div class="row w-100 d-flex flex-column">
      <label>Файл подписи: </label>
      <input type="text" class="account-input-text"/>

      <small class="text-muted">(нужен только для внутренних серверов)</small>
    </div>
    <div class="row w-100 d-flex flex-column">
      <button class="btn btn-success account-input-btn">Сохранить</button>
    </div>
  </div>

</template>

<script>
export default {
name: "AccountPage"
}
</script>

<style scoped>

</style>