<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container">

          <div class="modal-header">
            <slot name="header">
              <p class="modal-header-title">Название</p>
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
              <input class="modal-body-input" type="text">
              <input class="modal-body-input" type="text">
              <input class="modal-body-input" type="date">
              <input class="modal-body-input" type="text">
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
export default {
  name: "TodoModal",
  props: {},
  data() {
    return{}
  },
  computed:{}
}
</script>

<style lang="css">
.modal-body-input{
  width: 100%;
  padding: 0 0 0 0;
  margin: 10px 0px 0px 0px;
}
.modal-mask {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: rgba(0, 0, 0, 0.2);
  display: table;
  transition: opacity 0.3s ease;
}

.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}

.modal-container {
  width: 300px;
  margin: 0px auto;
  background-color: #fff;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
}
.modal-header{
  display: flex;
}
.modal-header-title{
  position: relative;
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
  width: 100%;
  margin: 0;
  padding: 0 0 1.25rem;
}
.modal-header-close{
  cursor: pointer;
}
</style>