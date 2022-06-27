<template>
  <div class="chat-content">

    <div class="chat-content-header" style="height: auto; padding: 10px 15px;">

    </div>

    <div class="chat-content-body">
      <div class="chat-group">
      </div>
    </div>

    <div class="chat-content-footer">
      <nav style="border-right: 1px solid rgba(72, 94, 144, 0.16);">
        <a href="#" id="addbutton" onclick="openmodal();" title="Прикрепить документ">
          <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file"><path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path><polyline points="13 2 13 9 20 9"></polyline></svg>
        </a>
      </nav>
      <textarea id="message" class="p-1" style="resize: none; width: 100%; border: none; outline: none;" placeholder="Ваше сообщение"></textarea>
      <nav style="border-left: 1px solid rgba(72, 94, 144, 0.16);">
        <a href="#" id="sendbutton" title="Отправить сообщение (Enter)" style="transform: rotate(45deg);">
          <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-send"><line x1="22" y1="2" x2="11" y2="13"/><polygon points="22 2 15 22 11 13 2 9 22 2"/></svg>
        </a>
      </nav>
    </div>

  </div>
</template>

<script>
export default {
  name: "ChatPage"
}
</script>

<style scoped>
.chat-content {
  position: absolute;
  bottom: 0px;
}
</style>