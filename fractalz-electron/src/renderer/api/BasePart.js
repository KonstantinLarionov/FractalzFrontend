import Vue from 'vue'
import VueCookies from 'vue-cookies'
Vue.use(VueCookies)

export default class BasePart {
    /**
     * constructor
     * @param axiosInstant
     */
    constructor(axiosInstant) {
        this.instant = axiosInstant
        this.instant.defaults.headers.common['Authorization'] = "Bearer " + Vue.$cookies.get("UserToken")
    }
}
