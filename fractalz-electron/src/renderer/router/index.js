import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/Start',
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
      path: '/videochat',
      name: 'VideoChatPage',
      component: require('@/components/pages/VideoChatPage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/dialog/chat',
      name: 'ChatPage',
      component: require('@/components/pages/ChatPage').default,
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
      path: '/timetable',
      name: 'TimetablePage',
      component: require('@/components/pages/TimetablePage').default,
      meta:{
        layout: "default-layout"
      }
    },
    {
      path: '/',
      name: 'RegistrationPage',
      component: require('@/components/pages/RegistrationPage').default,
      meta:{
        layout: "non-layout"
      }
    },
    {
      path: '/books',
      name: 'BookPage',
      component: require('@/components/pages/BookPage').default,
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
