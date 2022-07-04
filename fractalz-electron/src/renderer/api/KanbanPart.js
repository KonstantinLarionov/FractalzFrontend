import Vue from 'vue'
import VueCookies from 'vue-cookies'
import BasePart from "./BasePart";
Vue.use(VueCookies)

export default class KanbanPart extends BasePart {
    //#region [ApiData]
    _partPath = "/kanban/"


    //#endregion

}
