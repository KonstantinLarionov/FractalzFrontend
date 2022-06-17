import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'StartPage',
      component: require('@/components/pages/StartPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/dialog',
      name: 'DialogPage',
      component: require('@/components/pages/DialogPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/account',
      name: 'AccountPage',
      component: require('@/components/pages/AccountPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/news',
      name: 'NewsPage',
      component: require('@/components/pages/NewsPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/todo',
      name: 'TodoPage',
      component: require('@/components/pages/TodoPage').default,
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
