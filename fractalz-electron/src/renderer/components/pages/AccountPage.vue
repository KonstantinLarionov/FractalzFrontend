<template>
  <div class="container-fluid" id="accountSpace">
    <div class="row">
      <div class="background-profile">
        <button class="background-edit-button">
          <svg class="edit-button-icon" width="20" height="20" viewBox="0 0 10 9" xmlns="http://www.w3.org/2000/svg">
            <g clip-path="url(#clip0_11_114)">
              <path d="M9.68875 1.09126C9.74714 1.14398 9.77993 1.21538 9.77993 1.28982C9.77993 1.36426 9.74714 1.43566 9.68875 1.48838L9.03687 2.07563L7.78687 0.950633L8.43875 0.363383C8.49735 0.310656 8.57682 0.281036 8.65969 0.281036C8.74255 0.281036 8.82202 0.310656 8.88062 0.363383L9.68875 1.0907V1.09126ZM8.595 2.47276L7.345 1.34776L3.08687 5.18063C3.05248 5.21158 3.02658 5.24934 3.01125 5.29088L2.50812 6.64876C2.499 6.67351 2.4977 6.70006 2.50438 6.72544C2.51106 6.75082 2.52545 6.77403 2.54594 6.79247C2.56643 6.81091 2.59222 6.82386 2.62042 6.82987C2.64862 6.83589 2.67812 6.83472 2.70562 6.82651L4.21437 6.37369C4.26048 6.36006 4.30242 6.33695 4.33687 6.3062L8.595 2.47332V2.47276Z" />
              <path fill-rule="evenodd" clip-rule="evenodd" d="M0.625 7.59375C0.625 7.81753 0.723772 8.03214 0.899587 8.19037C1.0754 8.34861 1.31386 8.4375 1.5625 8.4375H8.4375C8.68614 8.4375 8.9246 8.34861 9.10041 8.19037C9.27623 8.03214 9.375 7.81753 9.375 7.59375V4.21875C9.375 4.14416 9.34208 4.07262 9.28347 4.01988C9.22487 3.96713 9.14538 3.9375 9.0625 3.9375C8.97962 3.9375 8.90013 3.96713 8.84153 4.01988C8.78292 4.07262 8.75 4.14416 8.75 4.21875V7.59375C8.75 7.66834 8.71708 7.73988 8.65847 7.79262C8.59987 7.84537 8.52038 7.875 8.4375 7.875H1.5625C1.47962 7.875 1.40013 7.84537 1.34153 7.79262C1.28292 7.73988 1.25 7.66834 1.25 7.59375V1.40625C1.25 1.33166 1.28292 1.26012 1.34153 1.20738C1.40013 1.15463 1.47962 1.125 1.5625 1.125H5.625C5.70788 1.125 5.78737 1.09537 5.84597 1.04262C5.90458 0.989879 5.9375 0.918342 5.9375 0.84375C5.9375 0.769158 5.90458 0.697621 5.84597 0.644876C5.78737 0.592132 5.70788 0.5625 5.625 0.5625H1.5625C1.31386 0.5625 1.0754 0.651395 0.899587 0.809629C0.723772 0.967862 0.625 1.18247 0.625 1.40625V7.59375Z"/>
            </g>
            <defs>
              <clipPath id="clip0_11_114">
                <rect width="10" height="9" fill="white"/>
              </clipPath>
            </defs>
          </svg>
        </button>
      </div>
    </div>
    <div class="row">
      <div class="profile-wrapper">
        <div class="profile-logo-wrapper">
          <div class="profile-logo">
            <button class="profile-edit-logo">
              <svg class="edit-button-icon" width="20" height="20" viewBox="0 0 10 9" xmlns="http://www.w3.org/2000/svg">
                <g clip-path="url(#clip0_11_114)">
                  <path d="M9.68875 1.09126C9.74714 1.14398 9.77993 1.21538 9.77993 1.28982C9.77993 1.36426 9.74714 1.43566 9.68875 1.48838L9.03687 2.07563L7.78687 0.950633L8.43875 0.363383C8.49735 0.310656 8.57682 0.281036 8.65969 0.281036C8.74255 0.281036 8.82202 0.310656 8.88062 0.363383L9.68875 1.0907V1.09126ZM8.595 2.47276L7.345 1.34776L3.08687 5.18063C3.05248 5.21158 3.02658 5.24934 3.01125 5.29088L2.50812 6.64876C2.499 6.67351 2.4977 6.70006 2.50438 6.72544C2.51106 6.75082 2.52545 6.77403 2.54594 6.79247C2.56643 6.81091 2.59222 6.82386 2.62042 6.82987C2.64862 6.83589 2.67812 6.83472 2.70562 6.82651L4.21437 6.37369C4.26048 6.36006 4.30242 6.33695 4.33687 6.3062L8.595 2.47332V2.47276Z" />
                  <path fill-rule="evenodd" clip-rule="evenodd" d="M0.625 7.59375C0.625 7.81753 0.723772 8.03214 0.899587 8.19037C1.0754 8.34861 1.31386 8.4375 1.5625 8.4375H8.4375C8.68614 8.4375 8.9246 8.34861 9.10041 8.19037C9.27623 8.03214 9.375 7.81753 9.375 7.59375V4.21875C9.375 4.14416 9.34208 4.07262 9.28347 4.01988C9.22487 3.96713 9.14538 3.9375 9.0625 3.9375C8.97962 3.9375 8.90013 3.96713 8.84153 4.01988C8.78292 4.07262 8.75 4.14416 8.75 4.21875V7.59375C8.75 7.66834 8.71708 7.73988 8.65847 7.79262C8.59987 7.84537 8.52038 7.875 8.4375 7.875H1.5625C1.47962 7.875 1.40013 7.84537 1.34153 7.79262C1.28292 7.73988 1.25 7.66834 1.25 7.59375V1.40625C1.25 1.33166 1.28292 1.26012 1.34153 1.20738C1.40013 1.15463 1.47962 1.125 1.5625 1.125H5.625C5.70788 1.125 5.78737 1.09537 5.84597 1.04262C5.90458 0.989879 5.9375 0.918342 5.9375 0.84375C5.9375 0.769158 5.90458 0.697621 5.84597 0.644876C5.78737 0.592132 5.70788 0.5625 5.625 0.5625H1.5625C1.31386 0.5625 1.0754 0.651395 0.899587 0.809629C0.723772 0.967862 0.625 1.18247 0.625 1.40625V7.59375Z"/>
                </g>
                <defs>
                  <clipPath id="clip0_11_114">
                    <rect width="10" height="9" fill="white"/>
                  </clipPath>
                </defs>
              </svg>
            </button>
          </div>
        </div>
        <div class="profile-info-wrapper">
          <div class="info-fio" >
              <input placeholder="ФИО"
                     style="border-radius:
                     8px;border-style:solid;
                     border-color: #FFFFFF;
                     text-align: center;
                     max-width: max-content"
                     v-model="model.name">
          </div>
          <div class="info-login" >
            <input placeholder="Логин"  v-model="model.login" style="border-bottom:solid; border-bottom-color: #0b0d0f; text-align: center; max-width: max-content">
          </div>
          <div class="info-status">
            <svg id="info-status-icon" width="16" height="16" viewBox="0 0 16 16" fill="var(--color-light-green)" xmlns="http://www.w3.org/2000/svg">
              <g clip-path="url(#clip0_11_132)">
                <path d="M3.05 3.05002C2.39992 3.70004 1.88424 4.47175 1.53241 5.32108C1.18058 6.1704 0.999497 7.08071 0.999497 8.00002C0.999497 8.91934 1.18058 9.82965 1.53241 10.679C1.88424 11.5283 2.39992 12.3 3.05 12.95C3.14108 13.0443 3.19148 13.1706 3.19034 13.3017C3.1892 13.4328 3.13662 13.5582 3.04391 13.6509C2.95121 13.7436 2.8258 13.7962 2.6947 13.7974C2.5636 13.7985 2.4373 13.7481 2.343 13.657C1.60009 12.9142 1.01078 12.0322 0.608713 11.0616C0.20665 10.091 -0.000289917 9.05063 -0.000289917 8.00002C-0.000289917 6.94942 0.20665 5.90909 0.608713 4.93846C1.01078 3.96783 1.60009 3.0859 2.343 2.34302C2.4373 2.25195 2.5636 2.20155 2.6947 2.20269C2.8258 2.20383 2.95121 2.25641 3.04391 2.34912C3.13662 2.44182 3.1892 2.56723 3.19034 2.69832C3.19148 2.82942 3.14108 2.95572 3.05 3.05002ZM5.172 5.17202C4.42212 5.92214 4.00086 6.93937 4.00086 8.00002C4.00086 9.06068 4.42212 10.0779 5.172 10.828C5.21849 10.8745 5.25537 10.9297 5.28052 10.9904C5.30568 11.0512 5.31863 11.1163 5.31863 11.182C5.31863 11.2478 5.30568 11.3129 5.28052 11.3736C5.25537 11.4343 5.21849 11.4895 5.172 11.536C5.12551 11.5825 5.07032 11.6194 5.00958 11.6445C4.94885 11.6697 4.88375 11.6827 4.818 11.6827C4.75226 11.6827 4.68716 11.6697 4.62642 11.6445C4.56568 11.6194 4.51049 11.5825 4.464 11.536C3.99957 11.0717 3.63115 10.5205 3.3798 9.91375C3.12844 9.30703 2.99907 8.65674 2.99907 8.00002C2.99907 7.3433 3.12844 6.69302 3.3798 6.0863C3.63115 5.47959 3.99957 4.92834 4.464 4.46403C4.55789 4.37014 4.68523 4.31739 4.818 4.31739C4.95078 4.31739 5.07811 4.37014 5.172 4.46403C5.26589 4.55791 5.31863 4.68525 5.31863 4.81802C5.31863 4.9508 5.26589 5.07814 5.172 5.17202ZM10.828 4.46403C10.8744 4.41746 10.9296 4.38052 10.9904 4.35531C11.0511 4.33011 11.1162 4.31713 11.182 4.31713C11.2478 4.31713 11.3129 4.33011 11.3736 4.35531C11.4344 4.38052 11.4896 4.41746 11.536 4.46403C12.0004 4.92834 12.3688 5.47959 12.6202 6.0863C12.8716 6.69302 13.0009 7.3433 13.0009 8.00002C13.0009 8.65674 12.8716 9.30703 12.6202 9.91375C12.3688 10.5205 12.0004 11.0717 11.536 11.536C11.4895 11.5825 11.4343 11.6194 11.3736 11.6445C11.3128 11.6697 11.2477 11.6827 11.182 11.6827C11.1163 11.6827 11.0512 11.6697 10.9904 11.6445C10.9297 11.6194 10.8745 11.5825 10.828 11.536C10.7815 11.4895 10.7446 11.4343 10.7195 11.3736C10.6943 11.3129 10.6814 11.2478 10.6814 11.182C10.6814 11.1163 10.6943 11.0512 10.7195 10.9904C10.7446 10.9297 10.7815 10.8745 10.828 10.828C11.5779 10.0779 11.9991 9.06068 11.9991 8.00002C11.9991 6.93937 11.5779 5.92214 10.828 5.17202C10.7814 5.12558 10.7445 5.0704 10.7193 5.00966C10.6941 4.94891 10.6811 4.88379 10.6811 4.81802C10.6811 4.75226 10.6941 4.68714 10.7193 4.62639C10.7445 4.56565 10.7814 4.51047 10.828 4.46403ZM12.95 2.34403C13.0438 2.25029 13.1709 2.19763 13.3035 2.19763C13.4361 2.19763 13.5632 2.25029 13.657 2.34403C15.1571 3.84429 15.9998 5.87897 15.9998 8.00052C15.9998 10.1221 15.1571 12.1568 13.657 13.657C13.5627 13.7481 13.4364 13.7985 13.3053 13.7974C13.1742 13.7962 13.0488 13.7436 12.9561 13.6509C12.8634 13.5582 12.8108 13.4328 12.8097 13.3017C12.8085 13.1706 12.8589 13.0443 12.95 12.95C13.6001 12.3 14.1158 11.5283 14.4676 10.679C14.8194 9.82965 15.0005 8.91934 15.0005 8.00002C15.0005 7.08071 14.8194 6.1704 14.4676 5.32108C14.1158 4.47175 13.6001 3.70004 12.95 3.05002C12.8563 2.95626 12.8036 2.82911 12.8036 2.69653C12.8036 2.56394 12.8563 2.43679 12.95 2.34302V2.34403ZM10 8.00002C10 8.53046 9.78929 9.03917 9.41422 9.41424C9.03914 9.78931 8.53043 10 8 10C7.46957 10 6.96086 9.78931 6.58579 9.41424C6.21071 9.03917 6 8.53046 6 8.00002C6 7.46959 6.21071 6.96088 6.58579 6.58581C6.96086 6.21074 7.46957 6.00003 8 6.00003C8.53043 6.00003 9.03914 6.21074 9.41422 6.58581C9.78929 6.96088 10 7.46959 10 8.00002Z"/>
              </g>
              <defs>
                <clipPath id="clip0_11_132">
                  <rect width="16" height="16" fill="white"/>
                </clipPath>
              </defs>
            </svg>
            <label>В сети</label>
          </div>
          <div class="info-contacts-wrapper row">
            <div class="col"></div>
            <div class="col"></div>
          </div>
        </div>
        <div class="profile-adress-wrapper">
          <div class="adress">
            <svg class="roof" width="24" height="21" viewBox="0 0 16 8" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path fill-rule="evenodd" clip-rule="evenodd" d="M7.29301 0.500001C7.48053 0.31253 7.73484 0.207214 8.00001 0.207214C8.26517 0.207214 8.51948 0.31253 8.70701 0.500001L15.354 7.146C15.4479 7.23989 15.5006 7.36723 15.5006 7.5C15.5006 7.63278 15.4479 7.76011 15.354 7.854C15.2601 7.94789 15.1328 8.00063 15 8.00063C14.8672 8.00063 14.7399 7.94789 14.646 7.854L8.00001 1.207L1.35401 7.854C1.26012 7.94789 1.13278 8.00063 1.00001 8.00063C0.86723 8.00063 0.739893 7.94789 0.646006 7.854C0.552119 7.76011 0.499374 7.63278 0.499374 7.5C0.499374 7.36723 0.552119 7.23989 0.646006 7.146L7.29301 0.500001Z" fill="black"/>
            </svg>
            <svg class="homes" width="20" height="35" viewBox="0 0 12 13" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path fill-rule="evenodd" clip-rule="evenodd" d="M6 1.293L12 7.293V11.5C12 11.8978 11.842 12.2794 11.5607 12.5607C11.2794 12.842 10.8978 13 10.5 13H1.5C1.10218 13 0.720644 12.842 0.43934 12.5607C0.158035 12.2794 0 11.8978 0 11.5V7.293L6 1.293ZM11 0.5V4L9 2V0.5C9 0.367392 9.05268 0.240215 9.14645 0.146447C9.24021 0.0526785 9.36739 0 9.5 0H10.5C10.6326 0 10.7598 0.0526785 10.8536 0.146447C10.9473 0.240215 11 0.367392 11 0.5Z" fill="black"/>
            </svg>
            <p class="p_adress">Адрес:<label></label></p>
          </div>
          <div class="numder">
            <svg class="phone" width="20" height="26" viewBox="0 0 10 16" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M0 2C0 1.46957 0.210714 0.960859 0.585786 0.585786C0.960859 0.210714 1.46957 0 2 0L8 0C8.53043 0 9.03914 0.210714 9.41421 0.585786C9.78929 0.960859 10 1.46957 10 2V14C10 14.5304 9.78929 15.0391 9.41421 15.4142C9.03914 15.7893 8.53043 16 8 16H2C1.46957 16 0.960859 15.7893 0.585786 15.4142C0.210714 15.0391 0 14.5304 0 14V2ZM6 13C6 12.7348 5.89464 12.4804 5.70711 12.2929C5.51957 12.1054 5.26522 12 5 12C4.73478 12 4.48043 12.1054 4.29289 12.2929C4.10536 12.4804 4 12.7348 4 13C4 13.2652 4.10536 13.5196 4.29289 13.7071C4.48043 13.8946 4.73478 14 5 14C5.26522 14 5.51957 13.8946 5.70711 13.7071C5.89464 13.5196 6 13.2652 6 13Z" fill="black"/>
            </svg>
            <p class="numder1">Телефон: +7 (996) 571-85-93</p>
          </div>
          <div class="mail">
            <svg class="mail_pic" width="24" height="20" viewBox="0 0 16 12" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path d="M0.05 1.555C0.150818 1.11324 0.398655 0.718813 0.752922 0.436308C1.10719 0.153804 1.54688 -3.04944e-05 2 4.53414e-09H14C14.4531 -3.04944e-05 14.8928 0.153804 15.2471 0.436308C15.6013 0.718813 15.8492 1.11324 15.95 1.555L8 6.414L0.05 1.555ZM0 2.697V9.801L5.803 6.243L0 2.697ZM6.761 6.83L0.191 10.857C0.353327 11.1993 0.609527 11.4884 0.929782 11.6908C1.25004 11.8931 1.62117 12.0004 2 12H14C14.3788 12.0001 14.7498 11.8926 15.0698 11.6901C15.3899 11.4876 15.6459 11.1983 15.808 10.856L9.238 6.829L8 7.586L6.761 6.829V6.83ZM10.197 6.244L16 9.801V2.697L10.197 6.243V6.244Z" fill="black"/>
            </svg>
            <p class="mail_p">Почта: kostya12277@yandex.ru</p>
          </div>
          <button style="  border-radius: 40px; background-color: transparent; border-color: transparent"><img class="vk-img" src="https://cdn-icons-png.flaticon.com/512/5968/5968835.png"/></button>
          <button style=" border-radius:50px; background-color:transparent; border-color:transparent"><img class="tg-img" src="https://cdn-icons-png.flaticon.com/512/5968/5968804.png"/></button>
        </div>
          <div class="info-photos">
          <div class ="down">
            <svg class="Arrow" width="13" height="13" viewBox="0 0 6 6" fill="none" xmlns="http://www.w3.org/2000/svg">
              <path fill-rule="evenodd" clip-rule="evenodd" d="M3 0C3.09946 0 3.19484 0.0395089 3.26517 0.109835C3.33549 0.180161 3.375 0.275544 3.375 0.375V4.71975L4.9845 3.1095C5.01937 3.07463 5.06076 3.04698 5.10631 3.02811C5.15187 3.00924 5.20069 2.99953 5.25 2.99953C5.29931 2.99953 5.34813 3.00924 5.39369 3.02811C5.43924 3.04698 5.48063 3.07463 5.5155 3.1095C5.55037 3.14437 5.57802 3.18576 5.59689 3.23131C5.61576 3.27687 5.62547 3.32569 5.62547 3.375C5.62547 3.42431 5.61576 3.47313 5.59689 3.51869C5.57802 3.56424 5.55037 3.60563 5.5155 3.6405L3.2655 5.8905C3.23067 5.92542 3.18928 5.95313 3.14372 5.97203C3.09817 5.99094 3.04933 6.00067 3 6.00067C2.95067 6.00067 2.90183 5.99094 2.85627 5.97203C2.81072 5.95313 2.76933 5.92542 2.7345 5.8905L0.4845 3.6405C0.449634 3.60563 0.421977 3.56424 0.403107 3.51869C0.384238 3.47313 0.374526 3.42431 0.374526 3.375C0.374526 3.32569 0.384238 3.27687 0.403107 3.23131C0.421977 3.18576 0.449634 3.14437 0.4845 3.1095C0.554915 3.03908 0.650418 2.99953 0.75 2.99953C0.799308 2.99953 0.848133 3.00924 0.893688 3.02811C0.939242 3.04698 0.980634 3.07463 1.0155 3.1095L2.625 4.71975V0.375C2.625 0.275544 2.66451 0.180161 2.73483 0.109835C2.80516 0.0395089 2.90054 0 3 0Z" fill="#00627A"/>
            </svg>
          </div>
          <div class="info">
            <div class="p_photos">
              <p class="p4">Фотографии</p>
              <p class="p5">150</p>
              <svg class="plus_photo" width="19" height="19" viewBox="0 0 11 10" fill="none" xmlns="http://www.w3.org/2000/svg">
                <path d="M1.375 0C1.01033 0 0.660591 0.131696 0.402728 0.366117C0.144866 0.600537 0 0.918479 0 1.25L0 8.75C0 9.08152 0.144866 9.39946 0.402728 9.63388C0.660591 9.8683 1.01033 10 1.375 10H9.625C9.98967 10 10.3394 9.8683 10.5973 9.63388C10.8551 9.39946 11 9.08152 11 8.75V1.25C11 0.918479 10.8551 0.600537 10.5973 0.366117C10.3394 0.131696 9.98967 0 9.625 0L1.375 0ZM5.84375 2.8125V4.6875H7.90625C7.99742 4.6875 8.08485 4.72042 8.14932 4.77903C8.21378 4.83763 8.25 4.91712 8.25 5C8.25 5.08288 8.21378 5.16237 8.14932 5.22097C8.08485 5.27958 7.99742 5.3125 7.90625 5.3125H5.84375V7.1875C5.84375 7.27038 5.80753 7.34987 5.74307 7.40847C5.6786 7.46708 5.59117 7.5 5.5 7.5C5.40883 7.5 5.3214 7.46708 5.25693 7.40847C5.19247 7.34987 5.15625 7.27038 5.15625 7.1875V5.3125H3.09375C3.00258 5.3125 2.91515 5.27958 2.85068 5.22097C2.78622 5.16237 2.75 5.08288 2.75 5C2.75 4.91712 2.78622 4.83763 2.85068 4.77903C2.91515 4.72042 3.00258 4.6875 3.09375 4.6875H5.15625V2.8125C5.15625 2.72962 5.19247 2.65013 5.25693 2.59153C5.3214 2.53292 5.40883 2.5 5.5 2.5C5.59117 2.5 5.6786 2.53292 5.74307 2.59153C5.80753 2.65013 5.84375 2.72962 5.84375 2.8125Z" fill="#00627A"/>
              </svg>
            </div>
          </div>
          <div class="photos">
            <div class ="photos_osnov">
              <div class="First_row">
               <div class ="photosgrey">
                <div class="trash-photo">
                <svg class ="trash" width="12" height="12" viewBox="0 0 6 6" fill="none" xmlns="http://www.w3.org/2000/svg">
                  <path d="M0.9375 0.375C0.838044 0.375 0.742661 0.414509 0.672335 0.484835C0.602009 0.555161 0.5625 0.650544 0.5625 0.75V1.125C0.5625 1.22446 0.602009 1.31984 0.672335 1.39017C0.742661 1.46049 0.838044 1.5 0.9375 1.5H1.125V4.875C1.125 5.07391 1.20402 5.26468 1.34467 5.40533C1.48532 5.54598 1.67609 5.625 1.875 5.625H4.125C4.32391 5.625 4.51468 5.54598 4.65533 5.40533C4.79598 5.26468 4.875 5.07391 4.875 4.875V1.5H5.0625C5.16196 1.5 5.25734 1.46049 5.32766 1.39017C5.39799 1.31984 5.4375 1.22446 5.4375 1.125V0.75C5.4375 0.650544 5.39799 0.555161 5.32766 0.484835C5.25734 0.414509 5.16196 0.375 5.0625 0.375H3.75C3.75 0.275544 3.71049 0.180161 3.64016 0.109835C3.56984 0.0395088 3.47446 0 3.375 0L2.625 0C2.52554 0 2.43016 0.0395088 2.35984 0.109835C2.28951 0.180161 2.25 0.275544 2.25 0.375H0.9375ZM2.0625 1.875C2.11223 1.875 2.15992 1.89475 2.19508 1.92992C2.23025 1.96508 2.25 2.01277 2.25 2.0625V4.6875C2.25 4.73723 2.23025 4.78492 2.19508 4.82008C2.15992 4.85525 2.11223 4.875 2.0625 4.875C2.01277 4.875 1.96508 4.85525 1.92992 4.82008C1.89475 4.78492 1.875 4.73723 1.875 4.6875V2.0625C1.875 2.01277 1.89475 1.96508 1.92992 1.92992C1.96508 1.89475 2.01277 1.875 2.0625 1.875ZM3 1.875C3.04973 1.875 3.09742 1.89475 3.13258 1.92992C3.16775 1.96508 3.1875 2.01277 3.1875 2.0625V4.6875C3.1875 4.73723 3.16775 4.78492 3.13258 4.82008C3.09742 4.85525 3.04973 4.875 3 4.875C2.95027 4.875 2.90258 4.85525 2.86742 4.82008C2.83225 4.78492 2.8125 4.73723 2.8125 4.6875V2.0625C2.8125 2.01277 2.83225 1.96508 2.86742 1.92992C2.90258 1.89475 2.95027 1.875 3 1.875ZM4.125 2.0625V4.6875C4.125 4.73723 4.10525 4.78492 4.07008 4.82008C4.03492 4.85525 3.98723 4.875 3.9375 4.875C3.88777 4.875 3.84008 4.85525 3.80492 4.82008C3.76975 4.78492 3.75 4.73723 3.75 4.6875V2.0625C3.75 2.01277 3.76975 1.96508 3.80492 1.92992C3.84008 1.89475 3.88777 1.875 3.9375 1.875C3.98723 1.875 4.03492 1.89475 4.07008 1.92992C4.10525 1.96508 4.125 2.01277 4.125 2.0625Z" fill="#D7415C"/>
                </svg>
                </div>
               </div>
              </div>
              <div class="second_row"> 
              </div>
            </div>
          </div>
      </div>
      </div>
    </div>

<!--    <div class="container-fluid">-->
<!--      <div class="col">-->
<!--    <div class="row  w-100 d-flex flex-column"><div style="display: flex; justify-content: center"><img  width="200" height="200" src="https://via.placeholder.com/200"/></div></div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <div class="input__wrapper">-->
<!--        <input name="file" type="file" id="input__file" class="input input__file" multiple>-->
<!--        <label for="input__file" class="input__file-button">-->
<!--          <span class="input__file-icon-wrapper">-->
<!--            <svg xmlns="http://www.w3.org/2000/svg" width="20" height="20" fill="currentColor" class="bi bi-download" viewBox="0 0 16 16">-->
<!--              <path d="M.5 9.9a.5.5 0 0 1 .5.5v2.5a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-2.5a.5.5 0 0 1 1 0v2.5a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2v-2.5a.5.5 0 0 1 .5-.5z"/>-->
<!--              <path d="M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"/>-->
<!--            </svg>-->
<!--          </span>-->
<!--          <span class="input__file-button-text">Выберите файл</span>-->
<!--        </label>-->
<!--      </div>-->
<!--    </div>-->
<!--      </div>-->
<!--    </div>-->
<!--    <div class="container-fluid " style="overflow-y: scroll;">-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Ваш Email: </label>-->
<!--      <input v-model="model.email" type="text" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Имя: </label>-->
<!--      <input type="text" v-model="model.name" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Фамилия: </label>-->
<!--      <input type="text" v-model="model.surname" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold" >Отчество: </label>-->
<!--      <input type="text" v-model="model.patro" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Логин: </label>-->
<!--      <input type="text" v-model="model.login" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Телефон: </label>-->
<!--      <input  v-model="model.number" type="text" class="account-input-text">-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <label style="font-weight: bold">Файл подписи: </label>-->
<!--      <input type="text" class="account-input-text"/>-->

<!--      <small class="text-muted">(нужен только для внутренних серверов)</small>-->
<!--    </div>-->
<!--    <div class="row w-100 d-flex flex-column">-->
<!--      <button class="btn btn-success account-input-btn" v-on:click="updateProfile()">Сохранить</button>-->
<!--    </div>-->
<!--    </div>-->
  </div>
</template>

<script>
import UserPart from "../../api/UserPart";
import NotifyCenter from "../../services/NotifyCenter";

export default {
  name: "AccountPage",
  props: {
    api: Object,
    noty: Object
  },
  data()
  {
    return {
      model : {
        userId: this.$cookies.get("UserInfo").id,
        login: this.$cookies.get("UserInfo").login,
        name: this.$cookies.get("UserInfo").name,
        surname: this.$cookies.get("UserInfo").surname,
        patro: this.$cookies.get("UserInfo").patro,
        number: this.$cookies.get("UserInfo").number,
        email: this.$cookies.get("UserInfo").email,
        logo: this.$cookies.get("UserInfo").logo,
      },
      notyHeader: "Профиль Fractalz"
    };
  },

  mounted() {
    this.api = new UserPart(this.$http);
    this.noty = new NotifyCenter();
    this.getUser();
  },
  methods:{
    getUser:async function()
    {
      var getUser = await this.api.GetUser(this.$cookies.get("UserInfo").id)
      if(getUser.data.success)
      {
        console.log(getUser.data.userEntity)
        this.model.email = getUser.data.userEntity.email;
        this.model.login = getUser.data.userEntity.login;
        this.model.name = getUser.data.userEntity.name;
        this.model.surname = getUser.data.userEntity.surname;
        this.model.number = getUser.data.userEntity.number;
        this.model.logo = getUser.data.userEntity.logo;
        this.model.patro = getUser.data.userEntity.patro;
        this.model.userId = getUser.data.userEntity.userId;
      }
    },
    updateProfile : async function() {
      var result = await this.api.UpdateProfile(this.model);
      if(result.success)
      {
        this.noty.Show({title : notyHeader, message : "Профиль успешно обновлен!"});
      }
      else {
        this.noty.Show({title : notyHeader, message : "Произошла ошибка. Проверьте правильность данных!"});
      }
    },
  },
}
</script>

<style scoped>
.info-status{
  color: black;
  font-weight: 300;
  font-size: 15px;
}
.info-fio{
  margin-top: 18px;
  font-weight: 600;
  font-size: 18px;
  max-width: 100%;
}
.info-login{
  font-weight: 500;
  font-size: 13px;
}
.profile-info-wrapper{
  width: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  flex-direction: column;
}
.profile-edit-logo{
  width: 100%;
  background-color: transparent;
  border: none;
  transition: .2s;
  height: 33px;
}
.profile-edit-logo:hover{
  background-color: var(--color-gray)
}
.profile-edit-logo:hover .edit-button-icon{
  fill: var(--color-white)
}
.background-edit-button{
  background-color: transparent;
  border: none;
}
.edit-button-icon{
  fill: var(--color-gray);
  transition: .2s;
}
.edit-button-icon:hover{
  fill: var(--color-white);
}
.background-profile{
  height: 230px;
  width: 100%;
  background-image: url(../../assets/images/defaultback.jpg);
  background-size: cover;
  display: flex;
  justify-content: flex-end;
  align-items: flex-end;
  padding-bottom: 70px;
  padding-right: 20px;
}
.profile-wrapper{
  display: flex;
  justify-content: flex-start;
  flex-direction: column;
  align-items: center;
  box-shadow: var(--shadow-up-4);
  background-color: var(--color-white);
  height: calc(100vh - 180px);
  margin-top: -50px;
  border-radius: 40px 40px 0 0 ;
  width: 100%;
}
.profile-logo-wrapper{
  background-color: var(--color-white);
  margin-top: -107px;
  display: flex;
  justify-content: center;
  align-items:center;
  box-shadow: var(--shadow-down-4);
  background-size: cover;
  height: 215px;
  width: 215px;
  border-radius: 50%;
  padding: 5px;
  overflow: hidden;
}
.profile-adress-wrapper{
  height: 120px;
  width: 100%;
}
.profile-logo{
  background-image: url(../../assets/images/defaultlogo.jpg);
  background-size: cover;
  height: 200px;
  width: 200px;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: flex-end;
  overflow: hidden;
}
.info-photos{
  background-color: var(--color-white);
  width: 100%;
  height: 220px;
  margin-top: auto;
  box-shadow: var(--shadow-up-2);
  border-radius: 40px 40px 0 0;
}
.info{
  display: flex;
  flex-direction: row;
  height: 50px;
  width: 100%;
}
.roof{
position: absolute;
  left: 50px;
  top: 387px;
}
.homes{
position: absolute;
  left: 52px;
  top: 386px;
}
.p_adress{
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 9px;
  position: absolute;
  left: 80px;
  top: 400px;
}
.numder1{
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 9px;
  position: absolute;
  left: 80px;
  top: 440px;
}
.phone{
  position: absolute;
  left: 52px;
  top: 433px;
}
.mail_p{
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 9px;
  position: absolute;
  left: 80px;
  top: 480px;
}
.mail_pic{
  position: absolute;
  left: 50px;
  top: 475px;
}
.vk-img{
  height: 30px;
  width: 30px;
  position: absolute;
  left: 390px;
  top: 410px;
}
.tg-img{
  width: 30px;
  width: 30px;
  position: absolute;
  left: 390px;
  top: 450px;
}
.photos{
  height: 100%;
  width: 100%;
}
.p_photos{
  display: flex;
  justify-content: flex-start;
  flex-direction: row;
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 500;
  font-size: 14px;
  line-height: 12px;
  text-align: left;
  margin-top: 5px;
  margin-left: 30px;
}
.p4{
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 500;
  font-size: 16px;
  line-height: 12px;
  text-align: center;
  margin-top: 15px;
}
.p5{
  font-family: 'Roboto';
  font-style: normal;
  font-weight: 300;
  font-size: 16px;
  line-height: 13px;
  text-align: center;
  margin-top: 15px;
  margin-left: 5px;
}
.plus_photo{
  position: fixed;
  bottom: 185px;
  right: 30px;
}
.photos_osnov{
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
}
.First_row{
  display: flex;
  flex-direction: row;
  width: 100%;
  height: 110px;
}
.second_row{
  display: flex;
  flex-direction: row;
  width: 100%;
  height: 110px;
}
.photosgrey{
  width: 112px;
  height: 90px;
  background-color: #D9D9D9;
  margin-left: 25px;
}
.trash{
  height: 12px;
  width: 12px;
}
.trash-photo{
width: 20px;
margin-top: 4px;
margin-left: 95px;
display: flex;
flex-direction: row;
transition: .3s;
cursor: pointer;
fill: var(--color-orange);
opacity: 0;
cursor: pointer;
display: flex;
}
.trash-photo:hover{
  opacity: 1;
}
.down{
  position: fixed;
  bottom: 10px;
  right: 20px;
  height: 35px;
  width: 35px;
  border-radius: 50px;
  background-color: #ECECEC;
  box-shadow: 0px 4px 4px rgba(0, 0, 0, 0.25);
  margin-top: 100px;
}
.Arrow{
  margin-top: 10px;
  margin-left: 10px;
}
</style>
