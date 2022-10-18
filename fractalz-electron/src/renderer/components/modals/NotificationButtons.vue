<template>
  <transition name="modal">
    <div class="modal-mask">
      <div class="modal-wrapper">
        <div class="modal-container-notification-buttons">
          <div class ="top-of-the-notification">
            <p>Текст для уведомления в модельном окне пользователю на принятие или отклонеие действия</p>
          </div>
          <div class="bottom-of-the-notification">
            <button class="cancellation">Отмена</button> <button class="approval">Хорошо</button>
          </div>
        </div>
      </div>
    </div>
  </transition>
</template>
<script>
export default {
  name: "NotificationButtons"
}
</script>

<style scoped>
.modal-wrapper {
  display: table-cell;
  vertical-align: middle;
}
.modal-container-notification-buttons {
  width: 400px;
  height: 200px;
  margin: 0px auto;
  background-color: #D9D9D9;
  border-radius: 2px;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.33);
  transition: all 0.3s ease;
  border-width: 5px;
  border-style: solid;
  border: transparent;
}
.top-of-the-notification{
  width: 100%;
  height: 50%;
  color: #00627A;
}
.bottom-of-the-notification{
  width: 100%;
  height: 50%;
  color: white;
}
.cancellation{
  height: 30px;
  width: 100px;
  border-radius: 20px;
  background: #00627A;
  margin-left: 30px;
  border: transparent;
  font-size: 12px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.cancellation:hover{
  background: #003947;
}
.approval{
  height: 30px;
  width: 100px;
  border-radius: 20px;
  background: #9B9B9B;
  margin-left: 60px;
  border: transparent;
  font-size: 12px;
  font-weight: 300;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
}
.approval:hover{
  background: #7B7B7B;
}
</style>