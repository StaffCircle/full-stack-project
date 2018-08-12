import Vue from 'vue'
import Router from 'vue-router'
import Send from './views/Send.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'send',
      component: Send
    },
    {
      path: '/list',
      name: 'list',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import(/* webpackChunkName: "about" */ './views/List.vue')
    }
  ]
})
