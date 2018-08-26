<template>
  <div v-loading="loading">
    <app-header></app-header>

    <!-- BARRA PRINCIPAL LADO ESQUERDO -->
    <app-sidebar></app-sidebar>

    <!-- ONDE AS PAGINAS SÃO REDERIZADAS -->
    <router-view></router-view>

    <!-- RODAPE DO SITE -->
    <app-footer></app-footer>

    <!-- ESSA É A BARRA LATERAL DIREITA -->
    <!--<control-sidebar></control-sidebar>-->
  </div>
</template>

<script>
import Sidebar from './partials/Sidebar.vue'
import Header from './partials/Header.vue'
import Footer from './partials/Footer.vue'
// import ControlSidebar from './partials/ControlSidebar.vue'

export default {
  name: 'Dashboard',
  components: {
    'app-sidebar': Sidebar,
    'app-header': Header,
    'app-footer': Footer
    // 'control-sidebar': ControlSidebar
  }
}
</script>
