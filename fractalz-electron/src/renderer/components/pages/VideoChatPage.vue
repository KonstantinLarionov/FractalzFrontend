<template>
  <div>
  <div class="fp-Video">
    <div id="participant1Display" class="display"></div>
  </div>
  <br />
  <div class="fp-Video">
    <div id="local" class="display"></div>
  </div>
  <br />
  <label>Login</label>
  <input type="text" style="border: 1px solid;" id="login" />
  <br />
  <br />
  <button id="joinBtn" v-on:click="connected()">Join</button>
  <br />
  <br />
  <div id="inviteAddress" style="border: 1px solid;">Not connected</div>
  </div>
</template>

<script>

import * as RoomApi from "@flashphoner/websdk/src/room-module";
import {STREAM_STATUS} from "@flashphoner/websdk/src/constants";

var Flashphoner = RoomApi.sdk;
var SESSION_STATUS = Flashphoner.constants.SESSION_STATUS;
var ROOM_EVENT = RoomApi.events;
var participants = 2
var connection;
var url = "wss://demo.flashphoner.com:8443";
const id = `f${(~~(Math.random()*1e8)).toString(16)}`;
var PRELOADER_URL = "https://github.com/flashphoner/flashphoner_client/raw/wcs_api-2.0/examples/demo/dependencies/media/preloader.mp4";

var Browser = {
  isSafari: function() {
    return /^((?!chrome|android).)*safari/i.test(navigator.userAgent);
  },
}

export default {
  name: "VideoChatPage",
  mounted() {
    let recaptchaScript = document.createElement('script')
    recaptchaScript.setAttribute('src', 'https://flashphoner.com/downloads/builds/flashphoner_client/wcs_api-2.0/current/flashphoner.js')
    document.head.appendChild(recaptchaScript)
  },
  methods: {
    connected() {
      Flashphoner.init({});
      var ref = this;
      connection = RoomApi.connect({
        urlServer: url,
        username: document.getElementById("login").value
      }).on(SESSION_STATUS.ESTABLISHED, function (session) {
        ref.getBrowser();
      });
    },

    getBrowser : function () {
      var ref = this;

      if (Browser.isSafari()) {
        Flashphoner.playFirstVideo(document.getElementById("local"), true, PRELOADER_URL).then(function () {
          ref.joinRoom();
        });
      } else {
        this.joinRoom();
      }
    },

    joinRoom() {
      var ref = this;

      connection.join({name: this.getRoomName()})
          .on(ROOM_EVENT.STATE, function (room) {
            var participants = room.getParticipants();
            ref.setInviteAddress(room.name());
            if (participants.length > 0) {
              for (var i = 0; i < participants.length; i++) {
                this.playParticipantsStream(participants[i]);
              }
            }
            ref.publishLocalMedia(room);
          }).on(ROOM_EVENT.JOINED, function (participant) {
        ref.playParticipantsStream(participant);
        console.log(participant.name(), "joined");
      }).on(ROOM_EVENT.PUBLISHED, function (participant) {
        ref.playParticipantsStream(participant);
      });
    },

    playParticipantsStream(participant) {
      if (participant.getStreams().length > 0) {
        participant.getStreams()[0].play(document.getElementById("participant1Display"))
            .on(STREAM_STATUS.PLAYING, function (playingStream) {
            });
      }
    },

    getParamUrl(name, url) {
      url = url.match(new RegExp(name + '=([^&=]+)'));
      return url ? url[1] : false;
    },

    getRoomName() {
      var name = window.location.search;
      if (name != "") {
        return this.getParamUrl("roomName", name);
      }
      return "room-" + id;
    },

    setInviteAddress(name) {
      var inviteURL = window.location.href;
      document.getElementById("inviteAddress").textContent = (inviteURL.split("?")[0] + "?roomName=" + name);
    },

//publish local video
    publishLocalMedia(room) {
      var constraints = {
        audio: true,
        video: true
      };
      var display = document.getElementById("local");
      room.publish({
        display: display,
        constraints: constraints,
      }).on(STREAM_STATUS.PUBLISHING, function (stream) {
      });
    }
  }
}
</script>

<style>
.fp-Video {
  border: 1px double black;
  width: 322px;
  height: 242px;
}
.display {
  width: 100%;
  height: 100%;
  display: inline-block;
}
.display > video,
object {
  width: 100%;
  height: 100%;
}
</style>
