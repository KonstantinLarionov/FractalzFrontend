<template>
  <div style="text-align: left">
    <span style="text-align: left">
        <span class="file-icon">
          <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" id="Capa_1" x="0px" y="0px" width="26" height="26" viewBox="0 0 266.578 266.577" style="enable-background:new 0 0 266.578 266.577;" xml:space="preserve">
<g>
	<g>
		<path d="M139.065,8.692l83.959,83.959h-55.25c-15.835,0-28.709-12.877-28.709-28.709V8.692z"/>
		<path d="M203.016,266.577H63.576c-15.829,0-28.718-12.881-28.718-28.703V28.715C34.858,12.88,47.747,0,63.576,0h63.191v63.942    c0,22.614,18.398,41.007,41.007,41.007h63.945v132.925C231.719,253.696,218.845,266.577,203.016,266.577z"/>
	</g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
</g>
<g>
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
import axios from "axios";


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
      let upload = await this.api.DownloadFile(this.FileId, this.DialogId).catch(response => {
        this.noty.Show({
          title: "File download failed",
          message: "Произошла ошибка. Проверьте соединение с интернетом!"
        });
      }).then(response => {
        console.log(response)
        const blob = new Blob([response.data])
        const link = document.createElement('a')
        link.href = URL.createObjectURL(blob)
        link.download = this.Name
        link.click()
        URL.revokeObjectURL(link.href)
      });
      console.log(upload);
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