<template>
  <div class="todo-wrap" id="todoSpace">
    <div class="todo-filter">
      <div class="Entering-a-search">
        <input class="input-up" name="s" placeholder="Введите заголовок уведомления">
        <input class="input-up2" name="s" placeholder="Введите основной текст уведомления">
      </div>
      <div class="Filters">
        <select class="selectvalue">
          <option class="begin-1">Выберите кому</option>
          <option>Никита Панин</option>
          <option>Константин Ларионов</option>
          <option>Мария Ларионова</option>
        </select>
        <button class="set-filtres">Отправить</button>
      </div>
      <div class="todo-filter-left">
      </div>
    </div>
    <div class="the-main-part">
      <div class="piece1">
        <div class="avatar-photo">
          <img class="" src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="43" height="43" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img class="" src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="43" height="43" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img class="" src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="43" height="43" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img class="" src=https://skesov.ru/wp-content/uploads/2020/10/img-20200925171951-659.jpg width="43" height="43" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
      <div class="piece1">
        <div class="avatar-photo">
          <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="50" height="50" class="photo">
        </div>
        <div class ="name-information">
          <div class="Name-i">Никита Панин</div>
          <div class="info-for">С учётом сложившейся международной обстановки, современная методология разработки предполагает независимые способы реализации экономической целесообразности принимаемых решений.</div>
        </div>
        <div class="time-notification">13:30</div>
      </div>
    </div>
  </div>
</template>

<script>
function NotificationPage() {

}

export default {
  name: "Notification",
  components: {NotificationPage}
}
</script>

<style scoped>
.todo-filter {
 width: 100%;
  height: 90px;
  box-shadow: var(--shadow-down-4);
  border-radius: 0 0 45px 45px;
  background-color: white;
  display: flex;
  flex-direction: row;
}
.Entering-a-search{
  display: flex;
  flex-direction: column;
  width: 60%;
  height: 100%;
}
.Filters{
  display: flex;
  flex-direction: column;
  width: 40%;
  height: 100%;
}
.input-up{
  margin-left: 30px;
  margin-top: 10px;
  font-size: 12px;
  font-weight: 300;
  border-top: transparent;
  border-right: transparent;
  border-bottom: #00627AA1;
  border-left: transparent;
}
.input-up2{
  margin-left: 30px;
  margin-top: 15px;
  font-size: 12px;
  font-weight: 300;
  border-top: transparent;
  border-right: transparent;
  border-bottom: #00627AA1;
  border-left: transparent;
}
.selectvalue{
  margin-left: 20px;
  margin-right: 25px;
  margin-top: 14px;
  font-size: 13px;
  border-top: transparent;
  border-right: transparent;
  border-left: transparent;
}
.begin-1{
  color:#00627AA1;
}
option:hover
{
  background: white;
  color: #00627AA1;
}
.set-filtres{
  width: 140px;
  height: 25px;
  margin-left: 25px;
  margin-top: 15px;
  font-size: 10px;
  font-weight: 200;
  border-radius: 40px 40px 40px 40px;
  background-color: #FF5722;
  color: white;
}
.the-main-part{
  height: 5000px;
  width: 100%;
  display: flex;
  flex-direction: column;
}
.piece1{
  display: flex;
  flex-direction: row;
  width: auto;
  height: 95px;
  margin-left: 20px;
  margin-right: 20px;
  margin-top: 20px;
  background-color: white;
  border-radius: 10px 10px 10px 10px;
  box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.25);
}
.avatar-photo{
  margin-top: 25px;
  margin-left: 25px;
}
.name-information{
  height: 100%;
  width: 93%;
  display: flex;
  flex-direction: column;
}
.Name-i{
  color:#00627A;
  margin-left: 25px;
  margin-top: 10px;
  font-weight: 500;
}
.info-for{
  margin-left: 25px;
  color:black;
  font-size: 10px;
  line-height: 12px;
}
.time-notification{
  height: 20px;
  width: 30px;
  font-size: 11px;
  margin-top: 40px;
  margin-right: 15px;
}
</style>