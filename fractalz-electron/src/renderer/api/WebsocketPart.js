import Vue from "vue";
import VueCookies from 'vue-cookies'
Vue.use(VueCookies)

export default class WebsocketPart {
    static _instance = new WebsocketPart;
    UsersUpdatedInfo = {};
    DialogsUpdatedInfo = {};
    MessageUpdatedInfo = {};
    _baseUrl = "";
    socket = {};
    constructor() {
        if (WebsocketPart._instance) {
            throw new Error("Instantiation failed: use Singleton.getInstance() instead of new.");
        }
    }

    Connect(){
        if (Vue.$cookies && Vue.$cookies.get("UserInfo") ) {
            let id = Vue.$cookies.get("UserInfo") != null ? Vue.$cookies.get("UserInfo").id : "";
            WebsocketPart._instance._baseUrl = "ws://192.168.89.18:5200/ws/subscribe?idUser=" + id;
            WebsocketPart._instance.socket = new WebSocket(this._baseUrl.replace('http', 'ws'));
            WebsocketPart._instance.socket.onopen = WebsocketPart._instance.onopen;
            WebsocketPart._instance.socket.onclose = WebsocketPart._instance.onclose;
            WebsocketPart._instance.socket.onmessage = WebsocketPart._instance.onmessage;
            WebsocketPart._instance.socket.onerror = WebsocketPart._instance.onerror;
        }
    }

    static getInstance()  {
        return WebsocketPart._instance;
    }

    onopen = function() {
        console.log("Соединение установлено.");

        WebsocketPart._instance.socket.send("message");
    };

    onclose = function(event) {
        if (event.wasClean) {
            console.log('Соединение закрыто чисто');
        } else {
            console.log('Обрыв соединения'); // например, "убит" процесс сервера
        }
        console.log('Код: ' + event.code + ' причина: ' + event.reason);
    };

    onmessage = function(event) {
        event = JSON.parse(event.data);
        if(event.Type === 0)//Users
        {
            WebsocketPart._instance.UsersUpdatedInfo = event.Data
            console.log(WebsocketPart._instance.UsersUpdatedInfo)
        }
        if(event.Type === 1)//Dialogs
        {
            WebsocketPart._instance.DialogsUpdatedInfo = event.Data
            console.log(WebsocketPart._instance.DialogsUpdatedInfo)
        }
        if(event.Type === 2)//Message
        {
            WebsocketPart._instance.MessageUpdatedInfo = event.Data
            console.log(WebsocketPart._instance.MessageUpdatedInfo)

        }
    };

    onerror = function(error) {
        console.log("Ошибка " + error.message);
    };
}
