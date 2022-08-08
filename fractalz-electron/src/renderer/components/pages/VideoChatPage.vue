<template>
  <div class="container">

    <div class="input-group mb-6">
      <div class="input-group-prepend">
        <span class="input-group-text">Login</span>
      </div>
      <input id="loginText" type="text" class="form-control">

      <div class="input-group-prepend">
        <span class="input-group-text">Password</span>
      </div>
      <input id="passwordText" type="password" class="form-control">

      <button id="loginButton" type="button" class="btn btn-primary" onclick="login()">Login</button>
      <button id="logOutButton" type="button" class="btn btn-primary d-none" onclick="logout()">LogOut</button>

    </div>

    <div class="input-group mb-6 d-none" id="callPanel">
      <input id="callNumberText" type="text" class="form-control" placeholder="Call number">
      <button id="callNumberButton" type="button" class="btn btn-success" onclick="call()">Call</button>
      <button id="hangUpButton" type="button" class="btn btn-danger d-none" onclick="hangUp()">Hang Up</button>
    </div>

    <audio id="localAudio" autoPlay muted></audio>
    <audio id="remoteAudio" autoPlay></audio>
    <audio id="sounds" autoPlay></audio>

  </div>
</template>

<script>


export default {
  name: "VideoChatPage",
  props:{
  },
  mounted: async function () {
  },
  methods: {

  }
}
</script>

<style scoped>

</style>