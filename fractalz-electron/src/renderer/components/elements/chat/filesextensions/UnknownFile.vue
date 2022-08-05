<template>
  <div>
    <span style="horiz-align: center">
        <span class="file-icon">
          <svg xmlns="http://www.w3.org/2000/svg" version="1.0" width="21.000000pt" height="21.000000pt" viewBox="0 0 21.000000 21.000000" preserveAspectRatio="xMidYMid meet">
            <g transform="translate(0.000000,21.000000) scale(0.100000,-0.100000)" fill="#000000" stroke="none">
            <path d="M30 121 c0 -113 -2 -111 90 -111 88 0 90 2 90 80 0 67 0 69 -27 72 -22 2 -29 9 -31 31 -3 26 -5 27 -63 27 l-59 0 0 -99z"/>
            <path d="M160 195 c0 -16 27 -32 37 -21 7 7 -16 36 -28 36 -5 0 -9 -7 -9 -15z"/>
            </g>
          </svg>
        </span>
        <a class="file-link" @click="downloadFile()">{{Name}}</a>
    </span>
  </div>
</template>

<script>
import ChatPart from "../../../../api/ChatPart";
import NotifyCenter from "../../../../services/NotifyCenter";
import AnswerLeft from "../AnswerLeft";

export default {
  name: "UnknownFile",
  api:Object,
  props:
      {
        Path:null,
        Name:null,
        FileId:null,
        api:Object,
        noty: Object,
        DialogId:null,
      },
  date()
  {
    return
    {
    }
  },
  mounted()
  {
    this.api = new ChatPart(this.$http);
    this.noty = new NotifyCenter();

  },
  methods:
  {

    downloadFile:async function()
    {
      console.log(this.FileId, this.dialogId)
      var upload = await this.api.DownloadFile(this.FileId, this.DialogId).catch(response => {
        this.noty.Show({
          title: "File download failed",
          message: "Произошла ошибка. Проверьте соединение с интернетом!"
        });
      });

    }
  }
}

</script>

<style scoped>
.file-container
{
  object-position: left;
}
.file-link
{
  color: #0b0d0f;
  cursor: pointer;
}
.file-icon
{
  height: 26px;
  width: 26px;
  horiz-align: left;
}
</style>