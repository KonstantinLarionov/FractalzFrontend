<template>
  <div class="dialog">
    <div class="row">
      <div class="col-3 d-flex align-items-center justify-content-end">
        <div class="dialog-logo-wrap">
          <img  src="https://via.placeholder.com/40" alt="" class="dialog-logo" width="35" height="35"/>
        </div>
      </div>
      <div class="col-9 pl-0">
        <label class="dialog-name">{{DialogName}}</label>
        <div class="preview-dialog ">
          <label class="dialog-last-message-new text-truncate" style="max-width: 258.97px;">{{DialogLastMessage}}</label>
          <label class="dialog-datetime">{{DialogDateSend}}</label>
          <span v-if="DialogUnreadMessage!= 0 || null" class="badge badge-pill position-relative rounded-pill" style=" margin-top: -8px; font-size: 15px; border: 2px solid rgb(0, 151, 136)"> {{ DialogUnreadMessage }}</span>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props : {
    DialogUnreadMessage: null,
    DialogName : null,
    DialogLastMessage : null,
    DialogDateSend: null,
  },
  name: "DialogElement"
}
</script>

<style scoped>

</style>