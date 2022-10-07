<template>
    <div class="book-div-wrapper">
    <div class="book-filter-wrapper">
      <svg class="book-icon-find" width="20" height="20" viewBox="0 0 12 12" xmlns="http://www.w3.org/2000/svg">
          <g style="mix-blend-mode:darken" clip-path="url(#clip0_39_472)">
            <path d="M8.80629 7.75814C9.53251 6.76715 9.85778 5.5385 9.71702 4.318C9.57626 3.09749 8.97985 1.97514 8.04711 1.17548C7.11438 0.375827 5.9141 -0.0421609 4.68642 0.00514394C3.45873 0.0524488 2.29418 0.561558 1.42574 1.43062C0.557302 2.29968 0.0490263 3.46459 0.00259989 4.69231C-0.0438265 5.92003 0.37502 7.12001 1.17534 8.05217C1.97567 8.98433 3.09845 9.57994 4.31905 9.71983C5.53966 9.85971 6.76807 9.53357 7.75854 8.80664H7.75779C7.78029 8.83664 7.80429 8.86514 7.83129 8.89289L10.7188 11.7804C10.8594 11.9211 11.0502 12.0002 11.2491 12.0003C11.4481 12.0004 11.6389 11.9214 11.7797 11.7808C11.9204 11.6401 11.9995 11.4494 11.9996 11.2504C11.9996 11.0514 11.9207 10.8606 11.78 10.7199L8.89254 7.83239C8.86572 7.80524 8.83689 7.78017 8.80629 7.75739V7.75814ZM8.99979 4.87514C8.99979 5.41684 8.89309 5.95324 8.68579 6.45371C8.47849 6.95417 8.17465 7.40891 7.7916 7.79195C7.40856 8.17499 6.95383 8.47884 6.45336 8.68614C5.95289 8.89344 5.41649 9.00014 4.87479 9.00014C4.33309 9.00014 3.79669 8.89344 3.29622 8.68614C2.79575 8.47884 2.34101 8.17499 1.95797 7.79195C1.57493 7.40891 1.27109 6.95417 1.06379 6.45371C0.856485 5.95324 0.749788 5.41684 0.749788 4.87514C0.749788 3.78112 1.18439 2.73191 1.95797 1.95832C2.73156 1.18473 3.78077 0.750136 4.87479 0.750136C5.96881 0.750136 7.01802 1.18473 7.7916 1.95832C8.56519 2.73191 8.99979 3.78112 8.99979 4.87514Z"/>
          </g>
        <defs>
          <clipPath id="clip0_39_472">
            <rect width="12" height="12" fill="white"/>
          </clipPath>
        </defs>
      </svg>
      <input class="book-input-find" placeholder="Найти на сервере" type="text" />
      <button class="book-button-add">Добавить раздел</button>
    </div>
    <div class="book-listdiv-wrapper">
        <button class="book-listdiv-buttonup">
            <svg width="13" height="13" viewBox="0 0 7 7" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path fill-rule="evenodd" clip-rule="evenodd" d="M3.50063 0C3.63324 0 3.76042 0.0460886 3.85419 0.128127C3.94795 0.210165 4.00063 0.321432 4.00063 0.437451V5.50576L6.14663 3.62734C6.19312 3.58667 6.24831 3.55441 6.30905 3.5324C6.36979 3.51039 6.43489 3.49906 6.50063 3.49906C6.56638 3.49906 6.63148 3.51039 6.69222 3.5324C6.75295 3.55441 6.80814 3.58667 6.85463 3.62734C6.90112 3.66802 6.938 3.7163 6.96316 3.76944C6.98831 3.82258 7.00126 3.87954 7.00126 3.93706C7.00126 3.99458 6.98831 4.05154 6.96316 4.10468C6.938 4.15782 6.90112 4.2061 6.85463 4.24678L3.85463 6.87148C3.80819 6.91222 3.75301 6.94454 3.69227 6.96659C3.63152 6.98865 3.5664 7 3.50063 7C3.43486 7 3.36974 6.98865 3.309 6.96659C3.24825 6.94454 3.19308 6.91222 3.14663 6.87148L0.146632 4.24678C0.100144 4.2061 0.0632674 4.15782 0.0381083 4.10468C0.0129493 4.05154 0 3.99458 0 3.93706C0 3.87954 0.0129493 3.82258 0.0381083 3.76944C0.0632674 3.7163 0.100144 3.66802 0.146632 3.62734C0.240518 3.5452 0.367856 3.49906 0.500632 3.49906C0.566376 3.49906 0.631476 3.51039 0.692215 3.5324C0.752955 3.55441 0.808144 3.58667 0.854632 3.62734L3.00063 5.50576V0.437451C3.00063 0.321432 3.05331 0.210165 3.14708 0.128127C3.24085 0.0460886 3.36802 0 3.50063 0Z" fill="#00627A"/>
            </svg>
        </button>
        <div class="book-listdiv-header">
            <div class="listdiv-header-div">Разделы книги:</div>
            <div class="listdiv-header-count">145шт</div>
        </div>

        <div class="listdiv-scrollwrapp">
            <div class="listdiv-content">
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
        <div class="listdiv-row-wrapper">
            <div class="listdiv-row">
                <div class="listdiv-row-header">
                    <div class="count-orange">1.</div> <div>Дизайн приложения Letter</div>
                </div>
                <div class="listdiv-row-info">
                    <div>Предварительное описание раздела или первый текс...</div>
                </div>
            </div>
        </div>
            </div>
        </div>
    </div>
    </div>
</template>
<script>
import Vue from "vue";
export default {
  name: "BookDivisionPage",
  mounted(){}
}
</script>
<style scoped>
.listdiv-row-info {
    font-size: 14px;
    font-weight: 300;
}
.count-orange {
    color: var(--color-orange);
    margin-right: 10px;
}
.listdiv-row-header{
    display: flex;
    flex-direction: row;
    margin-top: 20px;
    font-weight: 500;
}
.listdiv-scrollwrapp {
    overflow: auto;
    height: calc(90% - 30px);
}
.listdiv-row {
    display: flex;
    flex-direction: column;
    margin-left: 40px;
    margin-right: 40px;
}
.listdiv-content {
  min-height: min-content;
}
.listdiv-row-wrapper{
    width: 100%;
    cursor: pointer;
    transition: .3s;
}
.listdiv-row-wrapper:hover {
    background-color: var(--color-ultra-light-gray);
}
.book-listdiv-buttonup {
    padding: 0;
    display: flex;
    text-align: center;
    justify-content: center;
    align-items: center;
    margin-top: -20px;
    margin-left: 80%;
    box-shadow: var(--shadow-down-4);
    height: 40px;
    width: 40px;
    border: none;
    border-radius: 50%;
    transition: .3s;
    background-color: var(--color-ultra-light-gray);
}
.book-listdiv-buttonup:hover {
    box-shadow: none;
}
.book-listdiv-header {
    margin-top: 20px;
    margin-left: 40px;
    margin-right: 40px;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    height: 20px;
}
.listdiv-header-div {
    font-weight: 500;
    font-size: 18px;
}
.listdiv-header-count {
    font-weight: 300;
    font-size: 17px;
}
.book-listdiv-wrapper {
    height: 90%;
    background-color: white;
    margin-top: 40px;
    box-shadow: var(--shadow-up-2);
    border-radius: 25px 25px 0 0 ;
    display: flex;
    flex-direction: column;
}    
.book-icon-find {
  margin-right: -20px;
  margin-bottom: 5px;
}
.book-div-wrapper {
    height: 100%;
    width: 100%;
}
.book-input-find {
  border-top: none;
  border-left: none;
  border-right: none;
  background-color: transparent;
  border-bottom: 1px solid var(--color-dark-blue);
  padding: 0 0 0 30px;
  width: 200px;
  margin-right: 5%;
}
.book-button-add {
  background-color: var(--color-dark-blue);
  border: none;
  color: var(--color-white);
  font-size: 12px;
  padding: 7px 25px;
  border-radius: 10px;
  box-shadow: var(--shadow-down-2);
  transition: .3s;
}
.book-button-add:hover {
  box-shadow: none;
}
.book-filter-wrapper {
  z-index: 99999;
  background-color: var(--color-white);
  border-radius: 0 0 25px 25px;
  box-shadow: var(--shadow-down-4);
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  height: 10%;
  fill: var(--color-dark-blue);
}
</style>