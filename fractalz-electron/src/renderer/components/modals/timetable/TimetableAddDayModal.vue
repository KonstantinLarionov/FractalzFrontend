<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Добавление рабочего деня</p>
              <a class="modal-header-close" @click="$emit('close')">
                <svg xmlns="http://www.w3.org/2000/svg" height="24px" viewBox="0 0 24 24" width="24px" fill="#000000">
                  <path d="M0 0h24v24H0z" fill="none"/>
                  <path d="M19 6.41L17.59 5 12 10.59 6.41 5 5 6.41 10.59 12 5 17.59 6.41 19 12 13.41 17.59 19 19 17.59 13.41 12z"/>
                </svg>
              </a>
            </slot>
          </div>

          <div class="modal-body">
            <slot name="body">

            </slot>
          </div>
          <div class="modal-footer">
            <slot name="footer">
              <button class="modal-default-button mr-4 navTask dark-teal" @click="$emit('close')">
                Добавить
              </button>
            </slot>
          </div>
        </div>
      </div>
    </div>
  </transition>
</template>

<script>
import TimetablePart from "../../../api/TimetablePart";

export default {
  name: "TimetableAddDayModal",
  props: {
    api: Object,
    noty: Object
  },
  data() {
    return{

    }
  },
  mounted() {
    this.api = new TimetablePart(this.$http);
  },
}
</script>

<style scoped>

</style>