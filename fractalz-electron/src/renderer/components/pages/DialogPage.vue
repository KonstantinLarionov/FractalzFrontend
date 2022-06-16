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
    <div class="row">
      <div class="dialog">
        <div class="row">
          <div class="col-3 d-flex align-items-center justify-content-end">
            <div class="dialog-logo-wrap">
              <img  src="https://via.placeholder.com/40" alt="" class="dialog-logo" width="35" height="35"/>
            </div>
          </div>
          <div class="col-9 pl-0">
            <label class="dialog-name">Константин Ларионов</label>
            <div class="preview-dialog">
              <label class="dialog-last-message-new text-truncate" style="max-width: 258.97px;">Последнее dasdasdasddasdasdasdние...</label>
              <label class="dialog-datetime">9:30</label>
            </div>
          </div>
        </div>
      </div>
      <div class="dialog">
        <div class="row">
          <div class="col-3 d-flex align-items-center justify-content-end">
            <div class="dialog-logo-wrap">
              <img  src="https://via.placeholder.com/40" alt="" class="dialog-logo" width="35" height="35"/>
            </div>
          </div>
          <div class="col-9 pl-0">
            <label class="dialog-name">Константин Ларионов</label>
            <div class="preview-dialog">
              <label class="dialog-last-message-new text-truncate" style="max-width: 258.97px;">Последнее dasdasdasddasdasdasdние...</label>
              <label class="dialog-datetime">9:30</label>
            </div>
          </div>
        </div>
      </div>
      <div class="dialog">
        <div class="row">
          <div class="col-3 d-flex align-items-center justify-content-end">
            <div class="dialog-logo-wrap">
              <img  src="https://via.placeholder.com/40" alt="" class="dialog-logo" width="35" height="35"/>
            </div>
          </div>
          <div class="col-9 pl-0">
            <label class="dialog-name">Константин Ларионов</label>
            <div class="preview-dialog">
              <label class="dialog-last-message-new text-truncate" style="max-width: 258.97px;">Последнее dasdasdasddasdasdasdние...</label>
              <label class="dialog-datetime">9:30</label>
            </div>
          </div>
        </div>
      </div>
      <div class="dialog">
        <div class="row">
          <div class="col-3 d-flex align-items-center justify-content-end">
            <div class="dialog-logo-wrap">
              <img  src="https://via.placeholder.com/40" alt="" class="dialog-logo" width="35" height="35"/>
            </div>
          </div>
          <div class="col-9 pl-0">
            <label class="dialog-name">Константин Ларионов</label>
            <div class="preview-dialog">
              <label class="dialog-last-message text-truncate" style="max-width: 258.97px;">Последнее dasdasdasddasdasdasdние...</label>
              <label class="dialog-datetime">9:30</label>
            </div>
          </div>
        </div>
      </div>
      <div class="dialog">
        <div class="row">
          <div class="col-3 d-flex align-items-center justify-content-end">
            <div class="dialog-logo-wrap">
              <img  src="https://via.placeholder.com/40" alt="" class="dialog-logo" width="35" height="35"/>
            </div>
          </div>
          <div class="col-9 pl-0">
            <label class="dialog-name">Константин Ларионов</label>
            <div class="preview-dialog">
              <label class="dialog-last-message text-truncate" style="max-width: 258.97px;">Последнее dasdasdasddasdasdasdние...</label>
              <label class="dialog-datetime">9:30</label>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "DialogPage"
}
</script>

<style scoped>

</style>