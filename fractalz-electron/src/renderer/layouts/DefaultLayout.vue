<template>

  <div class="container-fluid" style="overflow-y: hidden; overflow-x: hidden; background-color: var(--color-middle-gray)">
    <div class="row" style="height: 100vh; ">
      <div id="leftbar-wrapper" class="p-0 wrapper-leftbar">
        <div class="container d-flex flex-column" style="height: 100%;">
          <button id="burger" v-on:click="collapsLeftbar()" class="row mt-2 flex-column align-items-center" style="background-color: transparent; border: none; height: 30px; cursor: pointer">
            <div class="mt-2" style="border-bottom: 2px solid var(--color-white); width: 30px;"></div>
            <div class="mt-1" style="border-bottom: 2px solid var(--color-white); width: 30px;"></div>
            <div class="mt-1" style="border-bottom: 2px solid var(--color-white); width: 30px;"></div>
          </button>
          <button id="arrow" v-on:click="restoreLeftbar()" class="row mt-2 flex-column align-items-center" style="display: none; z-index: 99999; background-color: transparent; border: none; margin-left: 70px; position: absolute; height: 30px; cursor: pointer">
            <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="var(--color-dark-blue)" class="bi bi-arrow-right-square" viewBox="0 0 16 16">
              <path fill-rule="evenodd" d="M15 2a1 1 0 0 0-1-1H2a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V2zM0 2a2 2 0 0 1 2-2h12a2 2 0 0 1 2 2v12a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V2zm4.5 5.5a.5.5 0 0 0 0 1h5.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3a.5.5 0 0 0 0-.708l-3-3a.5.5 0 1 0-.708.708L10.293 7.5H4.5z"/>
            </svg>
          </button>
          <div class="row mt-2">
            <router-link :to="{ name: 'AccountPage' }" style="height: 60px; text-decoration: none !important;" id="accountLeftButton" class=" flex-column button-left col d-flex justify-content-center align-items-center mt-2 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="var(--color-light-blue)" class="bi bi-person-circle" viewBox="0 0 16 16">
                <path d="M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"/>
                <path fill-rule="evenodd" d="M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"/>
              </svg>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Профиль</label>
            </router-link>
          </div>
          <div class="row">
            <router-link :to="{ name: 'DialogPage' }" style="height: 60px;text-decoration: none !important;"  id="dialogsLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <path d="M2.678 11.894C2.7818 11.9982 2.86133 12.124 2.91094 12.2625C2.96055 12.4009 2.97901 12.5486 2.965 12.695C2.89472 13.3726 2.76148 14.0421 2.567 14.695C3.962 14.372 4.814 13.998 5.201 13.802C5.4205 13.6908 5.67329 13.6645 5.911 13.728C6.59243 13.9097 7.29477 14.0011 8 14C11.996 14 15 11.193 15 8C15 4.808 11.996 2 8 2C4.004 2 1 4.808 1 8C1 9.468 1.617 10.83 2.678 11.894ZM2.185 15.799C1.94807 15.846 1.71037 15.889 1.472 15.928C1.272 15.96 1.12 15.752 1.199 15.566C1.28779 15.3566 1.36918 15.1441 1.443 14.929L1.446 14.919C1.694 14.199 1.896 13.371 1.97 12.6C0.743 11.37 0 9.76 0 8C0 4.134 3.582 1 8 1C12.418 1 16 4.134 16 8C16 11.866 12.418 15 8 15C7.20765 15.0011 6.41859 14.8982 5.653 14.694C5.133 14.957 4.014 15.436 2.185 15.799Z"/>
                <path d="M4 5.5C4 5.36739 4.05268 5.24021 4.14645 5.14645C4.24021 5.05268 4.36739 5 4.5 5H11.5C11.6326 5 11.7598 5.05268 11.8536 5.14645C11.9473 5.24021 12 5.36739 12 5.5C12 5.63261 11.9473 5.75979 11.8536 5.85355C11.7598 5.94732 11.6326 6 11.5 6H4.5C4.36739 6 4.24021 5.94732 4.14645 5.85355C4.05268 5.75979 4 5.63261 4 5.5ZM4 8C4 7.86739 4.05268 7.74021 4.14645 7.64645C4.24021 7.55268 4.36739 7.5 4.5 7.5H11.5C11.6326 7.5 11.7598 7.55268 11.8536 7.64645C11.9473 7.74021 12 7.86739 12 8C12 8.13261 11.9473 8.25979 11.8536 8.35355C11.7598 8.44732 11.6326 8.5 11.5 8.5H4.5C4.36739 8.5 4.24021 8.44732 4.14645 8.35355C4.05268 8.25979 4 8.13261 4 8ZM4 10.5C4 10.3674 4.05268 10.2402 4.14645 10.1464C4.24021 10.0527 4.36739 10 4.5 10H8.5C8.63261 10 8.75979 10.0527 8.85355 10.1464C8.94732 10.2402 9 10.3674 9 10.5C9 10.6326 8.94732 10.7598 8.85355 10.8536C8.75979 10.9473 8.63261 11 8.5 11H4.5C4.36739 11 4.24021 10.9473 4.14645 10.8536C4.05268 10.7598 4 10.6326 4 10.5Z" />
              </svg>

              <span v-if="CountDialogsNoty!= 0" class="position-absolute ml-3 badge rounded-pill bg-danger" style="margin-top: -25px; font-size: 10px; ">{{ CountDialogsNoty }}</span>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Сообщения</label>

            </router-link>
          </div>
          <div class="row">
            <router-link :to="{ name: 'VideoChatPage' }" style="height: 60px;text-decoration: none !important;" id="videoChatLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="30" height="30" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <path d="M0 6C0 5.46957 0.210714 4.96086 0.585786 4.58579C0.960859 4.21071 1.46957 4 2 4H14C14.5304 4 15.0391 4.21071 15.4142 4.58579C15.7893 4.96086 16 5.46957 16 6V9C16 9.53043 15.7893 10.0391 15.4142 10.4142C15.0391 10.7893 14.5304 11 14 11H9.269C9.413 11.162 9.599 11.324 9.8 11.475C10.0868 11.6886 10.3901 11.8792 10.707 12.045L10.721 12.051L10.724 12.053C10.8247 12.1034 10.9053 12.1864 10.953 12.2884C11.0006 12.3904 11.0125 12.5055 10.9865 12.6151C10.9606 12.7247 10.8985 12.8223 10.8102 12.8921C10.7219 12.962 10.6126 13 10.5 13H5.5C5.38741 13 5.27812 12.962 5.18982 12.8921C5.10152 12.8223 5.03938 12.7247 5.01346 12.6151C4.98754 12.5055 4.99937 12.3904 5.04701 12.2884C5.09466 12.1864 5.17534 12.1034 5.276 12.053L5.279 12.051L5.293 12.044C5.384 11.9977 5.47338 11.9484 5.561 11.896C5.78179 11.7679 5.99513 11.6273 6.2 11.475C6.4 11.325 6.587 11.162 6.731 11H2C1.46957 11 0.960859 10.7893 0.585786 10.4142C0.210714 10.0391 0 9.53043 0 9V6ZM2 5C1.73478 5 1.48043 5.10536 1.29289 5.29289C1.10536 5.48043 1 5.73478 1 6V9C1 9.26522 1.10536 9.51957 1.29289 9.70711C1.48043 9.89464 1.73478 10 2 10H14C14.2652 10 14.5196 9.89464 14.7071 9.70711C14.8946 9.51957 15 9.26522 15 9V6C15 5.73478 14.8946 5.48043 14.7071 5.29289C14.5196 5.10536 14.2652 5 14 5H2Z"/>
                <path d="M8 6.5C7.73478 6.5 7.48043 6.60536 7.29289 6.79289C7.10536 6.98043 7 7.23478 7 7.5C7 7.76522 7.10536 8.01957 7.29289 8.20711C7.48043 8.39464 7.73478 8.5 8 8.5C8.26522 8.5 8.51957 8.39464 8.70711 8.20711C8.89464 8.01957 9 7.76522 9 7.5C9 7.23478 8.89464 6.98043 8.70711 6.79289C8.51957 6.60536 8.26522 6.5 8 6.5ZM6 7.5C6 6.96957 6.21071 6.46086 6.58579 6.08579C6.96086 5.71071 7.46957 5.5 8 5.5C8.53043 5.5 9.03914 5.71071 9.41421 6.08579C9.78929 6.46086 10 6.96957 10 7.5C10 8.03043 9.78929 8.53914 9.41421 8.91421C9.03914 9.28929 8.53043 9.5 8 9.5C7.46957 9.5 6.96086 9.28929 6.58579 8.91421C6.21071 8.53914 6 8.03043 6 7.5ZM13 7.5C13 7.63261 12.9473 7.75979 12.8536 7.85355C12.7598 7.94732 12.6326 8 12.5 8C12.3674 8 12.2402 7.94732 12.1464 7.85355C12.0527 7.75979 12 7.63261 12 7.5C12 7.36739 12.0527 7.24021 12.1464 7.14645C12.2402 7.05268 12.3674 7 12.5 7C12.6326 7 12.7598 7.05268 12.8536 7.14645C12.9473 7.24021 13 7.36739 13 7.5Z" />
              </svg>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Конференции</label>
            </router-link>
          </div>
          <div class="row mt-1">
            <router-link :to="{ name: 'TimetablePage' }" style="height: 60px;text-decoration: none !important;" id="timetableLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <g clip-path="url(#clip0_39_24)">
                  <path d="M3.5 0C3.63261 0 3.75979 0.0526784 3.85355 0.146447C3.94732 0.240215 4 0.367392 4 0.5V1H12V0.5C12 0.367392 12.0527 0.240215 12.1464 0.146447C12.2402 0.0526784 12.3674 0 12.5 0C12.6326 0 12.7598 0.0526784 12.8536 0.146447C12.9473 0.240215 13 0.367392 13 0.5V1H14C14.5304 1 15.0391 1.21071 15.4142 1.58579C15.7893 1.96086 16 2.46957 16 3V14C16 14.5304 15.7893 15.0391 15.4142 15.4142C15.0391 15.7893 14.5304 16 14 16H2C1.46957 16 0.960859 15.7893 0.585786 15.4142C0.210714 15.0391 0 14.5304 0 14V3C0 2.46957 0.210714 1.96086 0.585786 1.58579C0.960859 1.21071 1.46957 1 2 1H3V0.5C3 0.367392 3.05268 0.240215 3.14645 0.146447C3.24021 0.0526784 3.36739 0 3.5 0V0ZM2 2C1.73478 2 1.48043 2.10536 1.29289 2.29289C1.10536 2.48043 1 2.73478 1 3V4H15V3C15 2.73478 14.8946 2.48043 14.7071 2.29289C14.5196 2.10536 14.2652 2 14 2H2ZM15 5H1V14C1 14.2652 1.10536 14.5196 1.29289 14.7071C1.48043 14.8946 1.73478 15 2 15H14C14.2652 15 14.5196 14.8946 14.7071 14.7071C14.8946 14.5196 15 14.2652 15 14V5Z"/>
                  <path d="M9 7.5C9 7.36739 9.05268 7.24021 9.14645 7.14645C9.24021 7.05268 9.36739 7 9.5 7H15V9H9.5C9.36739 9 9.24021 8.94732 9.14645 8.85355C9.05268 8.75979 9 8.63261 9 8.5V7.5ZM7 10.5V11.5C7 11.6326 6.94732 11.7598 6.85355 11.8536C6.75979 11.9473 6.63261 12 6.5 12H1V10H6.5C6.63261 10 6.75979 10.0527 6.85355 10.1464C6.94732 10.2402 7 10.3674 7 10.5Z"/>
                </g>
                <defs>
                  <clipPath id="clip0_39_24">
                    <rect width="16" height="16" fill="white"/>
                  </clipPath>
                </defs>
              </svg>
              <label style="font-size: 10px; font-weight: 200" class="mt-1">Расписание</label>
            </router-link>
          </div>
          <div class="row">
            <router-link :to="{ name: 'TodoPage' }" style="height: 60px; text-decoration: none !important;"  id="todosLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <path d="M2.50001 7.99999C2.49986 7.03446 2.75388 6.08591 3.23655 5.24969C3.71921 4.41346 4.41351 3.71903 5.24964 3.2362C6.08577 2.75338 7.03427 2.49917 7.99979 2.49913C8.96532 2.49909 9.91384 2.75323 10.75 3.23599C10.8648 3.30125 11.0007 3.31846 11.1281 3.28386C11.2556 3.24927 11.3641 3.16568 11.4301 3.05134C11.4962 2.93699 11.5143 2.80118 11.4805 2.67353C11.4468 2.54588 11.3639 2.43676 11.25 2.36999C10.0109 1.65457 8.57029 1.36801 7.15169 1.55475C5.73309 1.74149 4.41575 2.39109 3.40396 3.40281C2.39218 4.41453 1.74249 5.73184 1.55566 7.15042C1.36883 8.56901 1.6553 10.0096 2.37064 11.2488C3.08597 12.488 4.19021 13.4565 5.51208 14.0042C6.83396 14.5518 8.29961 14.648 9.68173 14.2778C11.0638 13.9076 12.2852 13.0917 13.1564 11.9567C14.0275 10.8216 14.4998 9.43083 14.5 7.99999C14.5 7.86738 14.4473 7.7402 14.3536 7.64644C14.2598 7.55267 14.1326 7.49999 14 7.49999C13.8674 7.49999 13.7402 7.55267 13.6465 7.64644C13.5527 7.7402 13.5 7.86738 13.5 7.99999C13.5 9.45868 12.9205 10.8576 11.8891 11.8891C10.8576 12.9205 9.4587 13.5 8.00001 13.5C6.54132 13.5 5.14237 12.9205 4.11092 11.8891C3.07947 10.8576 2.50001 9.45868 2.50001 7.99999Z" />
                <path d="M15.354 3.35402C15.4005 3.30753 15.4374 3.25234 15.4625 3.1916C15.4877 3.13087 15.5007 3.06577 15.5007 3.00002C15.5007 2.93428 15.4877 2.86918 15.4625 2.80844C15.4374 2.7477 15.4005 2.69251 15.354 2.64602C15.3075 2.59953 15.2523 2.56266 15.1916 2.5375C15.1309 2.51234 15.0658 2.49939 15 2.49939C14.9343 2.49939 14.8692 2.51234 14.8084 2.5375C14.7477 2.56266 14.6925 2.59953 14.646 2.64602L8.00002 9.29302L5.35402 6.64602C5.30753 6.59953 5.25234 6.56266 5.19161 6.5375C5.13087 6.51234 5.06577 6.49939 5.00002 6.49939C4.93428 6.49939 4.86918 6.51234 4.80844 6.5375C4.7477 6.56266 4.69251 6.59953 4.64602 6.64602C4.59953 6.69251 4.56266 6.7477 4.5375 6.80844C4.51234 6.86918 4.49939 6.93428 4.49939 7.00002C4.49939 7.06576 4.51234 7.13087 4.5375 7.1916C4.56266 7.25234 4.59953 7.30753 4.64602 7.35402L7.64602 10.354C7.69247 10.4006 7.74764 10.4375 7.80839 10.4627C7.86913 10.4879 7.93425 10.5009 8.00002 10.5009C8.06579 10.5009 8.13091 10.4879 8.19165 10.4627C8.2524 10.4375 8.30758 10.4006 8.35402 10.354L15.354 3.35402Z" />
              </svg>
              <label style="font-size: 10px; font-weight: 200;" class="mt-1">Задачи</label>
            </router-link>
          </div>
          <div class="row" >
            <books-modal hidden :api="this.api"></books-modal>
            <router-link :to="{name: 'BookPage'}" style="height: 60px; text-decoration: none !important;" id="documentsLeftButtone" class="flex-column mt-2 button-left col d-flex justify-content-center align-items-center bg-transparent icon-left">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <path fill-rule="evenodd" clip-rule="evenodd" d="M6 1H12V8C12 8.08847 11.9766 8.17535 11.932 8.25179C11.8875 8.32823 11.8235 8.39149 11.7465 8.43511C11.6696 8.47873 11.5824 8.50114 11.4939 8.50007C11.4055 8.49899 11.3189 8.47447 11.243 8.429L9 7.083L6.757 8.43C6.68104 8.47552 6.59436 8.50004 6.50582 8.50107C6.41727 8.5021 6.33004 8.4796 6.25304 8.43586C6.17605 8.39213 6.11205 8.32873 6.06759 8.25215C6.02313 8.17557 5.99981 8.08855 6 8V1Z"/>
                <path d="M3 0H13C13.5304 0 14.0391 0.210714 14.4142 0.585786C14.7893 0.960859 15 1.46957 15 2V14C15 14.5304 14.7893 15.0391 14.4142 15.4142C14.0391 15.7893 13.5304 16 13 16H3C2.46957 16 1.96086 15.7893 1.58579 15.4142C1.21071 15.0391 1 14.5304 1 14V13H2V14C2 14.2652 2.10536 14.5196 2.29289 14.7071C2.48043 14.8946 2.73478 15 3 15H13C13.2652 15 13.5196 14.8946 13.7071 14.7071C13.8946 14.5196 14 14.2652 14 14V2C14 1.73478 13.8946 1.48043 13.7071 1.29289C13.5196 1.10536 13.2652 1 13 1H3C2.73478 1 2.48043 1.10536 2.29289 1.29289C2.10536 1.48043 2 1.73478 2 2V3H1V2C1 1.46957 1.21071 0.960859 1.58579 0.585786C1.96086 0.210714 2.46957 0 3 0V0Z"/>
                <path d="M1 5V4.5C1 4.36739 1.05268 4.24021 1.14645 4.14645C1.24021 4.05268 1.36739 4 1.5 4C1.63261 4 1.75979 4.05268 1.85355 4.14645C1.94732 4.24021 2 4.36739 2 4.5V5H2.5C2.63261 5 2.75979 5.05268 2.85355 5.14645C2.94732 5.24021 3 5.36739 3 5.5C3 5.63261 2.94732 5.75979 2.85355 5.85355C2.75979 5.94732 2.63261 6 2.5 6H0.5C0.367392 6 0.240215 5.94732 0.146447 5.85355C0.0526784 5.75979 0 5.63261 0 5.5C0 5.36739 0.0526784 5.24021 0.146447 5.14645C0.240215 5.05268 0.367392 5 0.5 5H1ZM1 8V7.5C1 7.36739 1.05268 7.24021 1.14645 7.14645C1.24021 7.05268 1.36739 7 1.5 7C1.63261 7 1.75979 7.05268 1.85355 7.14645C1.94732 7.24021 2 7.36739 2 7.5V8H2.5C2.63261 8 2.75979 8.05268 2.85355 8.14645C2.94732 8.24021 3 8.36739 3 8.5C3 8.63261 2.94732 8.75979 2.85355 8.85355C2.75979 8.94732 2.63261 9 2.5 9H0.5C0.367392 9 0.240215 8.94732 0.146447 8.85355C0.0526784 8.75979 0 8.63261 0 8.5C0 8.36739 0.0526784 8.24021 0.146447 8.14645C0.240215 8.05268 0.367392 8 0.5 8H1ZM1 11V10.5C1 10.3674 1.05268 10.2402 1.14645 10.1464C1.24021 10.0527 1.36739 10 1.5 10C1.63261 10 1.75979 10.0527 1.85355 10.1464C1.94732 10.2402 2 10.3674 2 10.5V11H2.5C2.63261 11 2.75979 11.0527 2.85355 11.1464C2.94732 11.2402 3 11.3674 3 11.5C3 11.6326 2.94732 11.7598 2.85355 11.8536C2.75979 11.9473 2.63261 12 2.5 12H0.5C0.367392 12 0.240215 11.9473 0.146447 11.8536C0.0526784 11.7598 0 11.6326 0 11.5C0 11.3674 0.0526784 11.2402 0.146447 11.1464C0.240215 11.0527 0.367392 11 0.5 11H1Z"/>
              </svg>
              <label style="font-size: 10px; font-weight: 200;" class="mt-1">Документация</label>
            </router-link>
          </div>
          <div class="row">
            <router-link :to="{name: 'NotificationPage'}" style="height: 60px; text-decoration: none !important;" id="natificationLeftButtone" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left ">
              <svg width="25" height="25" viewBox="0 0 16 16" fill="var(--color-light-blue)" xmlns="http://www.w3.org/2000/svg">
                <g clip-path="url(#clip0_39_30)">
                  <path d="M8 16C8.53043 16 9.03914 15.7893 9.41421 15.4142C9.78929 15.0392 10 14.5305 10 14H6C6 14.5305 6.21071 15.0392 6.58579 15.4142C6.96086 15.7893 7.46957 16 8 16ZM8 1.91802L7.203 2.07902C6.29896 2.26322 5.48633 2.75412 4.90265 3.46864C4.31897 4.18316 4.0001 5.07741 4 6.00002C4 6.62802 3.866 8.19702 3.541 9.74202C3.381 10.509 3.165 11.308 2.878 12H13.122C12.835 11.308 12.62 10.51 12.459 9.74202C12.134 8.19702 12 6.62802 12 6.00002C11.9997 5.07758 11.6807 4.18357 11.097 3.46926C10.5134 2.75494 9.70087 2.26419 8.797 2.08002L8 1.91702V1.91802ZM14.22 12C14.443 12.447 14.701 12.801 15 13H1C1.299 12.801 1.557 12.447 1.78 12C2.68 10.2 3 6.88002 3 6.00002C3 3.58002 4.72 1.56002 7.005 1.09902C6.99104 0.959974 7.00638 0.819547 7.05003 0.686794C7.09368 0.554041 7.16467 0.43191 7.25842 0.328279C7.35217 0.224647 7.4666 0.141815 7.59433 0.085125C7.72206 0.028435 7.86026 -0.000854492 8 -0.000854492C8.13974 -0.000854492 8.27794 0.028435 8.40567 0.085125C8.5334 0.141815 8.64783 0.224647 8.74158 0.328279C8.83533 0.43191 8.90632 0.554041 8.94997 0.686794C8.99362 0.819547 9.00896 0.959974 8.995 1.09902C10.1253 1.32892 11.1414 1.94238 11.8712 2.83552C12.6011 3.72866 12.9999 4.84659 13 6.00002C13 6.88002 13.32 10.2 14.22 12Z"/>
                </g>
                <defs>
                  <clipPath id="clip0_39_30">
                    <rect width="16" height="16" fill="white"/>
                  </clipPath>
                </defs>
              </svg>
              <label style="font-size: 10px; font-weight: 200;" class="mt-1">Уведомления</label>
            </router-link>
          </div>
          <div class="row" style="margin-top: auto; ">
            <a v-on:click="showModal = true" style="cursor:pointer;height: 60px; text-decoration: none !important; color: white" id="registrationLeftButton" class="flex-column button-left col d-flex justify-content-center align-items-center mt-1 bg-transparent icon-left">
              <svg xmlns="http://www.w3.org/2000/svg" width="25" height="25" fill="var(--color-light-blue)" class="bi bi-box-arrow-right" viewBox="0 0 16 16">
                <path fill-rule="evenodd" d="M10 12.5a.5.5 0 0 1-.5.5h-8a.5.5 0 0 1-.5-.5v-9a.5.5 0 0 1 .5-.5h8a.5.5 0 0 1 .5.5v2a.5.5 0 0 0 1 0v-2A1.5 1.5 0 0 0 9.5 2h-8A1.5 1.5 0 0 0 0 3.5v9A1.5 1.5 0 0 0 1.5 14h8a1.5 1.5 0 0 0 1.5-1.5v-2a.5.5 0 0 0-1 0v2z"/>
                <path fill-rule="evenodd" d="M15.854 8.354a.5.5 0 0 0 0-.708l-3-3a.5.5 0 0 0-.708.708L14.293 7.5H5.5a.5.5 0 0 0 0 1h8.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3z"/>
              </svg>
              <label style="font-size: 10px; font-weight: 200;" class="mt-1">Выйти</label>
            </a>
          </div>
        </div>
      </div>
      <div class="col p-0" >
        <section class="content">
          <slot/>
        </section>
      </div>
    </div>
    <CreateNotyModal v-if="CreateNotyModal" @close="CreateNotyModal = false"></CreateNotyModal>
    <exit-modal v-if="showModal" @close="showModal = false" ></exit-modal>
  </div>
</template>

<script>
import Vue from "vue";
import NotifyCenter from "../services/NotifyCenter";
import CreateNotyModal from "../components/modals/CreateNotyModal";
import ChatPart from "../api/ChatPart";
import ExitModal from "../components/modals/ExitModal";

Vue.component ('CreateNotyModal', CreateNotyModal)


export default {
  name: "DefaultLayout",
  components: {ExitModal},

  data(){
    return {
      CountDialogsNoty: 0,
      CreateNotyModal: false,
      showModal:false,
    }
  },
  props:{
    api: Object,
    noty: Object,
    exitNotyModel:null
  },
  mounted() {
    // this.api = new ChatPart(this.$http);
    // this.noty = new NotifyCenter();
    // //Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
    // Vue.socketEvents.notyReceive = this.onNotyGlobal;
    // //Vue.socketEvents.dialogsReceive = this.onDialogsUpdate;
    // Vue.socketEvents.messageReceive = this.onMessageUpdate;
    // this.getDialogsInfo();
  },
  methods: {
    collapsLeftbar : function ()
    {
      document.getElementById("leftbar-wrapper").className += " collaps-leftbar"
      document.getElementById("arrow").style.display = "block"
    },
    restoreLeftbar : function ()
    {
      document.getElementById("leftbar-wrapper").classList.remove("collaps-leftbar");
      document.getElementById("arrow").style.display = "none"
    },
    onMessageUpdate : function (message){
      console.log(message)
      if (message.idSender != Vue.$cookies.get('UserInfo').id)
      {
        this.noty.Show({title: "Новое сообщение от " + message.nameSender , message : message.text});
        require('electron').ipcRenderer.send('flash-noty', function (){});
        if(this.CountDialogsNoty >= 100) {
          this.CountDialogsNoty = "99+";
        }
        else {
          this.CountDialogsNoty++;
        }
      }
      //TODO :  + Подсветить жирным диалог который пришел
    },
    onNotyGlobal : function (message) {
      console.log(message);
      this.noty.Show({title: message.Title.toString() , message : message.Message})
      require('electron').ipcRenderer.send('flash-noty', function (){});
    },
/*    onDialogsUpdate : function (message) {
      console.log(message)
      if (message.idSender != Vue.$cookies.get('UserInfo').id)
      {
        this.noty.Show({title: "Новое сообщение" + message.nameSender , message : "DialogId: " + message.text});
        require('electron').ipcRenderer.send('flash-noty', function (){});
        if(this.CountDialogsNoty >= 100) {
          this.CountDialogsNoty = "99+";
        }
        else {
          this.CountDialogsNoty++;
        }
      }
      //TODO :  + Подсветить жирным диалог который пришел
    },*/
    getDialogsInfo : async function () {
      var result = await this.api
          .GetDialogs(Vue.$cookies.get('UserInfo').id)
          .catch(response => {
            this.noty.Show({
              title: this.notyHeader,
              message: "Произошла ошибка. Проверьте соединение с интернетом!"
            });
          });
      if (result.data.success) {
        if (result.data.dialogs != null) {
          for (let j in result.data.dialogs) {
            if (result.data.dialogs[j].countUnReadMessage != 0) {
              this.CountDialogsNoty++;
            }
          }
        }
      }
    },
  }
}
</script>

<style scoped>

.collaps-leftbar{
  transition: .6s;
  /*transform: translate(-100%,0);*/
  margin-left: -80px;
}

.content{
  width: 100%;
  height: 100%;
}


.wrapper-leftbar {
  background-color: var(--color-dark-blue);
  width: 80px;
}
</style>
