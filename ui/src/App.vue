<template>
  <div id="app">
    <img alt="StaffCircle Logo" src="./assets/logo.png" class="app__logo" />
    <div id="nav">
      <router-link to="/">Send</router-link> |
      <router-link to="/list">List</router-link>
    </div>
    <router-view/>
  </div>
</template>
<style lang="stylus">
#app
  font-family 'Avenir', Helvetica, Arial, sans-serif
  -webkit-font-smoothing antialiased
  -moz-osx-font-smoothing grayscale
  text-align center
  color #2c3e50
  .app__logo
    width 10em
    height auto

  #nav
  padding 30px
  a
  font-weight bold
  color #2c3e50
  &.router-link-exact-active
      color #42b983
</style>
