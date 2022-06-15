import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'DialogPage',
      component: require('@/components/pages/DialogPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/m',
      name: 'StartPage',
      component: require('@/components/pages/StartPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '*',
      redirect: '/'
    }
  ]
})
