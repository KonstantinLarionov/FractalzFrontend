<template>
  <div class="chat-content-main d-flex flex-column">
    <div class="HeaderDialogs">
      <div class="avatar_in_dialog">
        <img src="https://pp.userapi.com/c628428/v628428477/3829c/0tfJPfMUvZY.jpg" width="45" height="45" class="photo">
      </div>
      <div class="NameInDial">
      <p>Никита Панин</p>
      <p class="online">В сети</p>
    </div>
      <div class="additional">
        <svg width="35" height="19" viewBox="0 0 12 12" fill="none" xmlns="http://www.w3.org/2000/svg">
          <path d="M4.24186 8.80629C5.23285 9.53251 6.4615 9.85778 7.682 9.71702C8.90251 9.57626 10.0249 8.97985 10.8245 8.04711C11.6242 7.11438 12.0422 5.9141 11.9949 4.68642C11.9476 3.45873 11.4384 2.29418 10.5694 1.42574C9.70032 0.557302 8.53541 0.0490263 7.30769 0.00259989C6.07997 -0.0438265 4.87999 0.37502 3.94783 1.17534C3.01567 1.97567 2.42006 3.09845 2.28017 4.31905C2.14029 5.53966 2.46643 6.76807 3.19336 7.75854V7.75779C3.16336 7.78029 3.13486 7.80429 3.10711 7.83129L0.219614 10.7188C0.0788832 10.8594 -0.000217438 11.0502 -0.00028801 11.2491C-0.000357628 11.4481 0.0786076 11.6389 0.219238 11.7797C0.35987 11.9204 0.550646 11.9995 0.749599 11.9996C0.948551 11.9996 1.13938 11.9207 1.28011 11.78L4.16761 8.89254C4.19476 8.86572 4.21983 8.83689 4.24261 8.80629H4.24186ZM7.12486 8.99979C6.58316 8.99979 6.04676 8.89309 5.54629 8.68579C5.04583 8.47849 4.59109 8.17465 4.20805 7.7916C3.82501 7.40856 3.52116 6.95383 3.31386 6.45336C3.10656 5.95289 2.99986 5.41649 2.99986 4.87479C2.99986 4.33309 3.10656 3.79669 3.31386 3.29622C3.52116 2.79575 3.82501 2.34101 4.20805 1.95797C4.59109 1.57493 5.04583 1.27109 5.54629 1.06379C6.04676 0.856485 6.58316 0.749788 7.12486 0.749788C8.21888 0.749788 9.26809 1.18439 10.0417 1.95797C10.8153 2.73156 11.2499 3.78077 11.2499 4.87479C11.2499 5.96881 10.8153 7.01802 10.0417 7.7916C9.26809 8.56519 8.21888 8.99979 7.12486 8.99979Z" fill="#00627A"/>
        </svg>
        <svg width="35" height="19" viewBox="0 0 12 12" fill="none" xmlns="http://www.w3.org/2000/svg">
          <path fill-rule="evenodd" clip-rule="evenodd" d="M0.383482 10.5864C0.252449 10.4551 0.150801 10.2975 0.0852747 10.1241C0.0197485 9.95057 -0.00815975 9.76514 0.0033994 9.58005C0.0149586 9.39496 0.0657212 9.21444 0.152323 9.05046C0.238925 8.88647 0.359389 8.74276 0.505732 8.62885L2.23523 7.2826C2.55248 7.03585 2.96573 6.94885 3.35573 7.04635L4.99823 7.4566C5.0833 7.47782 5.17242 7.47667 5.25691 7.45328C5.34141 7.42989 5.41843 7.38504 5.48048 7.3231L7.32323 5.48035C7.3853 5.41823 7.43021 5.34108 7.45361 5.25644C7.47701 5.1718 7.47808 5.08254 7.45673 4.99735L7.04648 3.3556C6.99836 3.16314 6.99462 2.96226 7.03555 2.76814C7.07648 2.57403 7.161 2.39175 7.28273 2.2351L8.62823 0.505604C9.11198 -0.116146 10.0307 -0.173146 10.5865 0.383354L11.362 1.15885C11.917 1.71385 12.1607 2.54335 11.8885 3.3166C11.1921 5.29572 10.0591 7.09265 8.57348 8.5741C7.09224 10.0596 5.29558 11.1926 3.31673 11.8891C2.54423 12.1606 1.71398 11.9169 1.15898 11.3619L0.383482 10.5864Z" fill="#00627A"/>
        </svg>
        <svg width="35" height="19" viewBox="0 0 4 10" fill="none" xmlns="http://www.w3.org/2000/svg">
          <path d="M3.125 8.75C3.125 9.04837 3.00647 9.33452 2.7955 9.5455C2.58452 9.75647 2.29837 9.875 2 9.875C1.70163 9.875 1.41548 9.75647 1.2045 9.5455C0.993526 9.33452 0.875 9.04837 0.875 8.75C0.875 8.45163 0.993526 8.16548 1.2045 7.9545C1.41548 7.74353 1.70163 7.625 2 7.625C2.29837 7.625 2.58452 7.74353 2.7955 7.9545C3.00647 8.16548 3.125 8.45163 3.125 8.75ZM3.125 5C3.125 5.29837 3.00647 5.58452 2.7955 5.7955C2.58452 6.00647 2.29837 6.125 2 6.125C1.70163 6.125 1.41548 6.00647 1.2045 5.7955C0.993526 5.58452 0.875 5.29837 0.875 5C0.875 4.70163 0.993526 4.41548 1.2045 4.2045C1.41548 3.99353 1.70163 3.875 2 3.875C2.29837 3.875 2.58452 3.99353 2.7955 4.2045C3.00647 4.41548 3.125 4.70163 3.125 5ZM3.125 1.25C3.125 1.54837 3.00647 1.83452 2.7955 2.0455C2.58452 2.25647 2.29837 2.375 2 2.375C1.70163 2.375 1.41548 2.25647 1.2045 2.0455C0.993526 1.83452 0.875 1.54837 0.875 1.25C0.875 0.951631 0.993526 0.665483 1.2045 0.454505C1.41548 0.243526 1.70163 0.125 2 0.125C2.29837 0.125 2.58452 0.243526 2.7955 0.454505C3.00647 0.665483 3.125 0.951631 3.125 1.25Z" fill="#00627A"/>
        </svg>
      </div>
    </div>
    <div class="keyboard">
      <div class="Paper_clip">
        <svg width="25" height="25" viewBox="0 0 10 12" fill="none" xmlns="http://www.w3.org/2000/svg">
          <path d="M5.63518 11.0098C5.35882 11.4045 4.85593 11.6164 4.23714 11.5991C3.61836 11.5817 2.93436 11.3364 2.33562 10.9172C1.73687 10.4979 1.27244 9.93907 1.04448 9.36354C0.816521 8.78801 0.843711 8.24295 1.12007 7.84827L4.8713 2.49096C5.03711 2.25415 5.33885 2.12697 5.71012 2.13739C6.08139 2.14781 6.49179 2.29498 6.85104 2.54653C7.21028 2.79807 7.48894 3.13339 7.62572 3.47871C7.76249 3.82402 7.74618 4.15106 7.58036 4.38787L4.66274 8.55466C4.60747 8.6336 4.50689 8.67599 4.38313 8.67252C4.25938 8.66905 4.12258 8.61999 4.00283 8.53614C3.88308 8.45229 3.79019 8.34052 3.7446 8.22541C3.69901 8.11031 3.70445 8.0013 3.75972 7.92236L6.67734 3.75556C6.73261 3.67663 6.73805 3.56762 6.69246 3.45251C6.64687 3.3374 6.55398 3.22563 6.43423 3.14178C6.31448 3.05794 6.17768 3.00888 6.05393 3.0054C5.93017 3.00193 5.82959 3.04433 5.77432 3.12326L2.02309 8.48057C1.94099 8.59783 1.89472 8.73847 1.88694 8.89446C1.87916 9.05046 1.91001 9.21875 1.97774 9.38973C2.04546 9.56072 2.14873 9.73104 2.28165 9.89099C2.41457 10.0509 2.57454 10.1974 2.75242 10.3219C2.9303 10.4465 3.12261 10.5467 3.31837 10.6169C3.51413 10.6871 3.7095 10.7259 3.89334 10.731C4.07717 10.7362 4.24587 10.7076 4.38979 10.647C4.53372 10.5863 4.65005 10.4947 4.73216 10.3775L8.48339 5.02017C8.75974 4.62549 8.78693 4.08043 8.55897 3.5049C8.33102 2.92937 7.86658 2.37051 7.26784 1.95127C6.6691 1.53203 5.9851 1.28674 5.36631 1.26937C4.74752 1.25201 4.24463 1.46398 3.96828 1.85866L1.05065 6.02545C0.995382 6.10439 0.894805 6.14678 0.771047 6.14331C0.64729 6.13984 0.510489 6.09078 0.390741 6.00693C0.270993 5.92308 0.178106 5.81131 0.132514 5.6962C0.0869218 5.5811 0.0923602 5.47209 0.147632 5.39315L3.06525 1.22635C3.45216 0.673802 4.1562 0.377043 5.0225 0.401359C5.8888 0.425675 6.84641 0.769074 7.68464 1.35601C8.52288 1.94295 9.17309 2.72535 9.49223 3.5311C9.81137 4.33684 9.77331 5.09992 9.38641 5.65247L5.63518 11.0098Z" fill="#00627A"/>
        </svg>
      </div>
      <div class="Input">
        <input class="INN" type="text" placeholder="Напишите сообщение">
      </div>
      <div class="emoji_and">
        <svg class="tochki" width="16" height="10" viewBox="0 0 10 4" fill="#00627A" xmlns="http://www.w3.org/2000/svg">
          <path d="M1.25 3.125C0.951631 3.125 0.665483 3.00647 0.454505 2.7955C0.243526 2.58452 0.125 2.29837 0.125 2C0.125 1.70163 0.243526 1.41548 0.454505 1.2045C0.665483 0.993526 0.951631 0.875 1.25 0.875C1.54837 0.875 1.83452 0.993526 2.0455 1.2045C2.25647 1.41548 2.375 1.70163 2.375 2C2.375 2.29837 2.25647 2.58452 2.0455 2.7955C1.83452 3.00647 1.54837 3.125 1.25 3.125ZM5 3.125C4.70163 3.125 4.41548 3.00647 4.2045 2.7955C3.99353 2.58452 3.875 2.29837 3.875 2C3.875 1.70163 3.99353 1.41548 4.2045 1.2045C4.41548 0.993526 4.70163 0.875 5 0.875C5.29837 0.875 5.58452 0.993526 5.7955 1.2045C6.00647 1.41548 6.125 1.70163 6.125 2C6.125 2.29837 6.00647 2.58452 5.7955 2.7955C5.58452 3.00647 5.29837 3.125 5 3.125ZM8.75 3.125C8.45163 3.125 8.16548 3.00647 7.9545 2.7955C7.74353 2.58452 7.625 2.29837 7.625 2C7.625 1.70163 7.74353 1.41548 7.9545 1.2045C8.16548 0.993526 8.45163 0.875 8.75 0.875C9.04837 0.875 9.33452 0.993526 9.5455 1.2045C9.75647 1.41548 9.875 1.70163 9.875 2C9.875 2.29837 9.75647 2.58452 9.5455 2.7955C9.33452 3.00647 9.04837 3.125 8.75 3.125Z"/>
        </svg>
        <div class="emojj">
          <svg class="eface" width="50" height="30" viewBox="0 0 12 12" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M6 11.25C4.60761 11.25 3.27226 10.6969 2.28769 9.71231C1.30312 8.72774 0.75 7.39239 0.75 6C0.75 4.60761 1.30312 3.27226 2.28769 2.28769C3.27226 1.30312 4.60761 0.75 6 0.75C7.39239 0.75 8.72774 1.30312 9.71231 2.28769C10.6969 3.27226 11.25 4.60761 11.25 6C11.25 7.39239 10.6969 8.72774 9.71231 9.71231C8.72774 10.6969 7.39239 11.25 6 11.25ZM6 12C7.5913 12 9.11742 11.3679 10.2426 10.2426C11.3679 9.11742 12 7.5913 12 6C12 4.4087 11.3679 2.88258 10.2426 1.75736C9.11742 0.632141 7.5913 0 6 0C4.4087 0 2.88258 0.632141 1.75736 1.75736C0.632141 2.88258 0 4.4087 0 6C0 7.5913 0.632141 9.11742 1.75736 10.2426C2.88258 11.3679 4.4087 12 6 12V12Z" fill="#00627A"/>
          </svg>
          <svg class="face" width="50" height="18" viewBox="0 0 6 7" fill="#00627A" xmlns="http://www.w3.org/2000/svg">
            <path d="M0.213735 4.17525C0.299864 4.12552 0.402219 4.11205 0.498284 4.13779C0.594349 4.16353 0.676255 4.22637 0.725985 4.3125C0.956318 4.71175 1.28777 5.04328 1.68698 5.27369C2.08619 5.5041 2.53905 5.62527 2.99998 5.625C3.46091 5.62527 3.91378 5.5041 4.31299 5.27369C4.7122 5.04328 5.04365 4.71175 5.27398 4.3125C5.29843 4.26951 5.33113 4.23178 5.37022 4.20147C5.4093 4.17117 5.454 4.1489 5.50173 4.13595C5.54945 4.12299 5.59927 4.1196 5.64831 4.12597C5.69736 4.13235 5.74465 4.14836 5.78748 4.17309C5.83031 4.19782 5.86783 4.23077 5.89787 4.27006C5.92791 4.30934 5.94988 4.35418 5.96252 4.40199C5.97516 4.44981 5.97822 4.49965 5.97152 4.54865C5.96482 4.59765 5.9485 4.64484 5.92348 4.6875C5.62733 5.20076 5.2012 5.62696 4.68798 5.9232C4.17476 6.21944 3.59256 6.37527 2.99998 6.375C2.40741 6.37527 1.82521 6.21944 1.31199 5.9232C0.798774 5.62696 0.372643 5.20076 0.0764849 4.6875C0.026759 4.60137 0.0132834 4.49902 0.0390226 4.40295C0.0647618 4.30689 0.127607 4.22498 0.213735 4.17525ZM2.24998 1.875C2.24998 2.496 1.91398 3 1.49998 3C1.08598 3 0.749985 2.496 0.749985 1.875C0.749985 1.254 1.08598 0.75 1.49998 0.75C1.91398 0.75 2.24998 1.254 2.24998 1.875ZM3.56773 1.54725C3.61078 1.52331 3.65811 1.50809 3.70703 1.50245C3.75596 1.49681 3.80551 1.50086 3.85287 1.51437C3.90023 1.52788 3.94446 1.55059 3.98304 1.58119C4.02163 1.6118 4.0538 1.64971 4.07774 1.69275C4.13695 1.80333 4.22478 1.89598 4.33204 1.96102C4.4393 2.02606 4.56205 2.06111 4.68748 2.0625C4.94173 2.0625 5.17123 1.92 5.29723 1.69275C5.34557 1.60583 5.42646 1.54166 5.5221 1.51438C5.61774 1.48709 5.72031 1.49891 5.80723 1.54725C5.89416 1.59559 5.95832 1.67647 5.98561 1.77212C6.0129 1.86776 6.00107 1.97033 5.95274 2.05725C5.82853 2.28468 5.64566 2.47468 5.42316 2.6075C5.20065 2.74032 4.94662 2.81111 4.68748 2.8125C4.13998 2.8125 3.67048 2.5035 3.42223 2.05725C3.3983 2.01421 3.38308 1.96688 3.37744 1.91795C3.37179 1.86903 3.37584 1.81947 3.38936 1.77211C3.40287 1.72476 3.42557 1.68052 3.45618 1.64194C3.48679 1.60336 3.52469 1.57118 3.56773 1.54725V1.54725Z" fill=""/>
          </svg>
        </div>
      </div>
    </div>
      </div>
<!--    <div class="row">-->
<!--      <div class="searcher-wrap row justify-content-start">-->
<!--        <div class="pl-3" @click="$emit('back')">-->
<!--          <svg xmlns="http://www.w3.org/2000/svg" width="40" height="40" fill="currentColor" class="bi bi-arrow-left" viewBox="0 0 16 16" color="009687FF">-->
<!--            <path fill-rule="evenodd" d="M15 8a.5.5 0 0 0-.5-.5H2.707l3.147-3.146a.5.5 0 1 0-.708-.708l-4 4a.5.5 0 0 0 0 .708l4 4a.5.5 0 0 0 .708-.708L2.707 8.5H14.5A.5.5 0 0 0 15 8z"/>-->
<!--          </svg>-->
<!--        </div>-->
<!--      </div>-->
<!--    </div>-->
<!--    <div id="chat" class="chat col-inside-lg decor-default">-->
<!--        <div class="chat-body">-->

<!--          <div v-for="messageContent in messageContents" :key="messageContent.$id">-->

<!--            <answer-left-element v-if="messageContent.idSender !== idUserSender"-->
<!--                                 :message="messageContent.text"-->
<!--                                 :date-send="messageContent.dateCreated"-->
<!--                                 :name="messageContent.nameSender"-->
<!--                                 :avatar="messageContent.avatar"-->
<!--                                 :status="messageContent.status"-->
<!--                                 :file="messageContent.file.$values"-->
<!--                                 :dialog-id="messageContent.dialogId">-->

<!--            </answer-left-element>-->

<!--            <answer-right-element v-if="messageContent.idSender === idUserSender"-->
<!--                                  :message="messageContent.text"-->
<!--                                  :date-send="messageContent.dateCreated"-->
<!--                                  :name="messageContent.nameSender"-->
<!--                                  :avatar="messageContent.avatar"-->
<!--                                  :status="messageContent.status"-->
<!--                                  :file="messageContent.file.$values"-->
<!--                                  :dialog-id="messageContent.dialogId">-->
<!--            </answer-right-element>-->
<!--          </div>-->

<!--      </div>-->
<!--    </div>-->

<!--    <div v-on="" id="emojiblock" class="emoji_block" v-on:mouseout="emojiHidden('hidden')" v-on:mouseover="emojiHidden('visible')" style="background: #009687" >-->
<!--      <VEmojiPicker @select="selectEmoji"/>-->
<!--    </div>-->

<!--    <div class="d-flex align-items-center chat-content-footer" multiple>-->

<!--      <label class="document" >-->
<!--        <transfer-modal v-if="showModal" @close="showModal = false" :dialog-id="dialogId" :files="this.FileInfoChat"></transfer-modal>-->
<!--        <input class="p-2 select" style="display: none" @click="showModal = true">-->
<!--        <svg width="24" height="24" viewBox="0 0 24 24" color="#000000" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-file" >-->
<!--          <path d="M13 2H6a2 2 0 0 0-2 2v16a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V9z"></path>-->
<!--          <polyline points="13 2 13 9 20 9"></polyline>-->
<!--        </svg>-->
<!--      </label>-->

<!--      <textarea v-model="message" id="message" class="p-2 textarea" placeholder="Ваше сообщение"></textarea>-->
<!--      <a v-on:click="emojiHidden('visible')" class="p-2 select" title="Emoji" style="transform: rotate(0deg); right: 0">-->
<!--        <svg width="25" height="25" fill="none" xmlns="http://www.w3.org/2000/svg"><path fill-rule="evenodd" clip-rule="evenodd" d="M12 4a8 8 0 1 0 0 16 8 8 0 0 0 0-16zM2 12C2 6.477 6.477 2 12 2s10 4.477 10 10-4.477 10-10 10S2 17.523 2 12z" fill="#000"/><path d="M11 9.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0zM16 9.5a1.5 1.5 0 1 1-3 0 1.5 1.5 0 0 1 3 0z" fill="#000"/><path fill-rule="evenodd" clip-rule="evenodd" d="M9 15a1 1 0 0 1 1-1h4a1 1 0 1 1 0 2h-4a1 1 0 0 1-1-1z" fill="#000"/></svg>-->
<!--      </a>-->

<!--      <a v-on:click="sendMessage()" class="p-2 select" title="Отправить сообщение" style="transform: rotate(45deg); right: 0">-->
<!--          <svg width="24" height="24" color="#000000" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-send">-->
<!--            <line x1="22" y1="2" x2="11" y2="13"/>-->
<!--            <polygon points="22 2 15 22 11 13 2 9 22 2"/>-->
<!--          </svg>-->
<!--        </a>-->

<!--    </div>-->
<!--  </div>-->
</template>

<script>
import AnswerLeft from "../elements/chat/AnswerLeft";
import AnswerRight from "../elements/chat/AnswerRight";
import Vue from "vue";
import { VEmojiPicker } from 'v-emoji-picker';
import FileTransferModal from "../modals/FileTransferModal";
import ChatPart from "../../api/ChatPart";
import UnknownFile from "../elements/chat/filesextensions/UnknownFile";

Vue.component ('answer-left-element', AnswerLeft)
Vue.component ('answer-right-element', AnswerRight)
Vue.component('transfer-modal', FileTransferModal)
Vue.component('unknown-file' , UnknownFile)
Vue.config.productionTip = false

export default {
  name: "ChatPage",
  emoji: 'Demo',

  components: {
    FileTransferModal,
    VEmojiPicker
  },

  date() {
    return {
      messageContents: [],
      showModal:false,
    }
  },
  data() {
    return {
      showModal:false,
      message: '',
      notyHeader: "Диалог Fractalz",

    }
  },
  props: {
    idUserSender: null,
    dialogId: null,
    FileInfoChat:[],
    api: Object,
    noty: Object,
  },
  mounted: async function () {
    this.api = new ChatPart(this.$http);
    this.messageContents = [];
    console.log(this.dialogId)
    await this.getMessage();
    Vue.socketEvents.messageReceive = this.onMessageReceive;
    this.scroll();
  },
  methods: {
    selectEmoji: function(emoji) {
      this.message += emoji.data;
    },
    scroll: function () {
      var block = document.getElementById("chat");
      block.scrollTop = block.scrollHeight;
    },
    onMessageReceive: function (message) {
      if (message.dialogId == this.dialogId) {
        if (message != null )
        {
          var arr = [];
          arr = message;
          arr.file.$values = message.file;
          this.messageContents.push(arr)
          console.log(this.messageContents)
        }
        this.$forceUpdate();
      }
      //TODO :  + Подсветить жирным диалог который пришел
    },


    getMessage: async function () {
      var result = await this.api
          .GetMessages(this.dialogId, '', 100, Vue.$cookies.get('UserInfo').id)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        var arr = [];
        if (result.data.messages != null) {
          arr = result.data.messages.$values;
          for (let j in arr) {
            this.$set(this.messageContents, j, arr[j])
            console.log(this.messageContents.file)
            this.messageContents.file = []
          }
          console.log(this.messageContents)
        }
        this.$forceUpdate();
      } else {
        this.noty.Show({title: this.notyHeader, message: "У вас нет сообщений начните диалог"});
      }
    },


    sendMessage: async function () {
      var obj = {
        userId: Vue.$cookies.get('UserInfo').id,
        dialogId: this.dialogId,
        message: this.message,
      }
      var result = await this.api
          .CreateMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        this.scroll();
        console.log(result)
        this.message = ''
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка отправки сообщения"});
      }
      this.onMessageReceive
    },



    updateMessage: async function (obj) {
      var result = await this.api
          .UpdateMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка изменения сообщения"});
      }
    },
    sendReaction: async function () {
      var result = await this.api
          .ReactionMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка изменения сообщения"});
      }
    },
    emojiHidden: function (newVisibility) {
      var emoji = document.getElementById("emojiblock");
      emoji.style.visibility = newVisibility;
    },
    deleteMessage: async function () {
      var result = await this.api
          .DeleteMessage(obj)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        console.log(result)
      } else {
        this.noty.Show({title: this.notyHeader, message: "Ошибка удаления сообщения"});
      }
    },
    }
}
</script>

<style scoped>

.chat-content-body{
  width: 100%;
  height: 100%;
  position: absolute;
}
.HeaderDialogs {
  display: flex;
  flex-direction: row;
  background-color: var(--color-white);
  height: 60px;
  width: 100%;
  border-radius: 0 0 30px 30px;
  box-shadow: var(--shadow-down-4)
}
.photo{
  margin-left: 20px;
}
.avatar_in_dialog{
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 50%;
  width: 50px;
  margin-top: 15px;
  margin-right: 50px;
  margin-left: 25px;
  margin-bottom: 30px;
}
.NameInDial{
  display: flex;
  justify-content: center;
  flex-direction: column;
  width: 85%;
  color: #00627A;
  line-height: 1.5px;
  margin-bottom: 20px;
  margin-top: 20px;
  margin-left: -30px;
}
.online{
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 200;
  font-size: 13px;
  line-height: 9px;
}
.additional{
  display: flex;
  flex-direction: row;
  margin-right: 5px;
  margin-top: 10px;
}
.chat-content-main {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
}

.keyboard{
display: flex;
flex-direction: row;
justify-content: start;
align-items: center;
background-color: var(--color-white);
height: 60px;
width: 100%;
border-radius: 30px 30px 0px 0px;
box-shadow: var(--shadow-up-2)
}
.Paper_clip {
  margin-left: 25px;
}
.Input{
  width: 68%;
  margin-left: 10px;
  border: none;
}
.INN{
  border: 0px;
  color: #00627A;
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 500;
  font-size: 15px;
  line-height: 9px;
  width: 100%;
}
.emoji_and{
  display: flex;
  flex-direction: row-reverse;
  justify-content: flex-end;
}
.tochki{
  position: absolute;
  right: 4%;
  bottom: 25px;
}
.emojj{
  display: flex;
  flex-direction: row-reverse;
}
.face{
  position: absolute;
  right: 8%;
  bottom: 20px;
}
.eface{
  position: absolute;
  right: 8%;
  bottom: 15px;
}
.textarea{
  resize: initial;
  border: none;
  outline: none;
  width: 100%;
  border-right: 1px solid #009788;
  border-left: 1px solid #009788;
}
.emoji_block{
  position: absolute;
  visibility: hidden;
  height: 437px;
  width: 327px;
  right: 0px;
  bottom: 60px;
  border-right-color: #0b0d0f;
  border-right-style: solid;
  border-right-width: 1px;
  border-bottom-color: #0b0d0f;
  border-bottom-style: solid;
  border-bottom-width: 1px;
  border-top-color: #0b0d0f;
  border-top-style: solid;
  border-top-width: 1px;
  border-left-color: #0b0d0f;
  border-left-style: solid;
  border-left-width: 1px;
}
.select{
  height: 100%;
  cursor: pointer;
}
.document{
  border: 10px solid transparent;
  background: transparent;
}
.chat-content-footer {
  background-color: white;
  bottom: 0;
  border-top: 2px solid #009788;
  border-radius: 2px;
}

body{
  margin-top:20px;
  background:#eee;
}
.col-inside-lg {
  padding: 20px;
}
.chat {
  position: revert;
  outline: none;
  overflow: auto;
  height: 100%;
}
.decor-default {
  background-color: #ffffff;
}
.chat-users h6 {
  font-size: 20px;
  margin: 0 0 20px;
}
.chat-users .user {
  position: relative;
  padding: 0 0 0 50px;
  display: block;
  cursor: pointer;
  margin: 0 0 20px;
}
.chat-users .user .avatar {
  top: 0;
  left: 0;
}
.chat .avatar {
  width: 40px;
  height: 40px;
  position: absolute;
}
.chat .avatar img {
  display: block;
  border-radius: 20px;
  height: 100%;
}
.chat .avatar .status.off {
  border: 1px solid #5a5a5a;
  background: #ffffff;
}
.chat .avatar .status.online {
  background: #4caf50;
}
.chat .avatar .status.busy {
  background: #ffc107;
}
.chat .avatar .status.offline {
  background: #ed4e6e;
}
.chat-users .user .status {
  bottom: 0;
  left: 28px;
}
.chat .avatar .status {
  width: 10px;
  height: 10px;
  border-radius: 5px;
  position: absolute;
}
.chat-users .user .name {
  font-size: 14px;
  font-weight: bold;
  line-height: 20px;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}
.chat-users .user .mood {
  font: 200 14px/20px "Raleway", sans-serif;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}
/*****************CHAT BODY *******************/
.chat-body h6 {
  font-size: 20px;
  margin: 0 0 20px;
}
.chat-body .answer.left {
  padding: 0 0 0 58px;
  text-align: left;
  float: left;
}
.chat-body .answer {
  position: relative;
  max-width: 600px;
  overflow: hidden;
  clear: both;
}
.chat-body .answer.left .avatar {
  left: 0;
}
.chat-body .answer .avatar {
  bottom: 36px;
}
.chat .avatar {
  width: 40px;
  height: 40px;
  position: absolute;
}
.chat .avatar img {
  display: block;
  border-radius: 20px;
  height: 100%;
}
.chat-body .answer .name {
  font-size: 14px;
  line-height: 36px;
}
.chat-body .answer.left .avatar .status {
  right: 4px;
}
.chat-body .answer .avatar .status {
  bottom: 0;
}
.chat-body .answer.left .text {
  background: #ebebeb;
  color: #333333;
  border-radius: 8px 8px 8px 0;
}
.chat-body .answer .text {
  padding: 12px;
  font-size: 16px;
  line-height: 26px;
  position: relative;
}
.chat-body .answer.left .text:before {
  left: -30px;
  border-right-color: #ebebeb;
  border-right-width: 12px;
}
.chat-body .answer .text:before {
  content: '';
  display: block;
  position: absolute;
  bottom: 0;
  border: 18px solid transparent;
  border-bottom-width: 0;
}
.chat-body .answer.left .time {
  padding-left: 12px;
  color: #333333;
}
.chat-body .answer .time {
  font-size: 16px;
  line-height: 36px;
  position: relative;
  padding-bottom: 1px;
}
/*RIGHT*/
.chat-body .answer.right {
  padding: 0 58px 0 0;
  text-align: right;
  float: right;
}
.chat-body .answer.right .avatar {
  right: 0;
}
.chat-body .answer.right .avatar .status {
  left: 4px;
}
.chat-body .answer.right .text {
  background: #009788;
  color: #ffffff;
  border-radius: 8px 8px 0 8px;
}
.chat-body .answer.right .text:before {
  right: -30px;
  border-left-color: #009788;
  border-left-width: 12px;
}
.chat-body .answer.right .time {
  padding-right: 12px;
  color: #333333;
}
/**************ADD FORM ***************/
.chat-body .answer-add {
  clear: both;
  position: relative;
  margin: 20px -20px -20px;
  padding: 20px;
  background: #46be8a;
}
.chat-body .answer-add input {
  border: none;
  background: none;
  display: block;
  width: 100%;
  font-size: 16px;
  line-height: 20px;
  padding: 0;
  color: #ffffff;
}
.chat input {
  -webkit-appearance: none;
  border-radius: 0;
}
.chat-body .answer-add .answer-btn-1 {
  background: url("http://91.234.35.26/iwiki-admin/v1.0.0/admin/img/icon-40.png") 50% 50% no-repeat;
  right: 56px;
}
.chat-body .answer-add .answer-btn {
  display: block;
  cursor: pointer;
  width: 36px;
  height: 36px;
  position: absolute;
  top: 50%;
  margin-top: -18px;
}
.chat-body .answer-add .answer-btn-2 {
  background: url("http://91.234.35.26/iwiki-admin/v1.0.0/admin/img/icon-41.png") 50% 50% no-repeat;
  right: 20px;
}
.chat input::-webkit-input-placeholder {
  color: #fff;
}

.chat input:-moz-placeholder { /* Firefox 18- */
  color: #fff;
}

.chat input::-moz-placeholder {  /* Firefox 19+ */
  color: #fff;
}

.chat input:-ms-input-placeholder {
  color: #fff;
}
.chat input {
  -webkit-appearance: none;
  border-radius: 0;
}
</style>