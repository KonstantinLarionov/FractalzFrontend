import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class NewsPart extends BasePart {
    //#region [ApiData]
    _partPath = "/news/"


    //#endregion
}
