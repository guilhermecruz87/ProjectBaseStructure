<template>
  <aside class="main-sidebar">
    <!-- sidebar: style can be found in sidebar.less -->
    <div>
      <section class="sidebar">
        <!-- /.search form -->
        <!-- Sidebar user panel -->
        <div class="user-panel" style="padding: 0;">
          <div class="image"> <img src="static/img/avatar2.png" class="img-circle" alt="User Image"> </div>
          <div class="info">
            <p>Good Job, Matirasa</p>
            <p><small>You haven,t miss any task this week!</small></p>
          </div> <img class="bg-user" src="static/img/avatar-bg.png" alt="User Image">
        </div>
        <!-- sidebar menu: : style can be found in sidebar.less -->
        <ul class="sidebar-menu">
          <li class="header">FILAS</li>
          <li v-for="fila in Filas">
            <router-link :to="{ path: '/citacao/' + fila.id }">
              <span>
                {{fila.nome}}
              </span>
            </router-link>
          </li>
          <li>
            <br>
            <br>
            <br>
          </li>
        </ul>
      </section>
      <!-- /.sidebar -->
    </div>
  </aside>
</template>
<script>
  export default {
    name: 'DashboardSidebar',
    mounted: function () {
      $(document).ready(function ($) {
        $('.main-sidebar > div').slimScroll({
          width: '230px',
          position: 'left',
          size: '5px',
          height: '95vh'
        })
      })
    },
    data: function () {
      return { Filas: [] }
    },
    created: function () {
      this.getFilas()
    },
    methods: {
      getFilas: function () {
        this.$http.get('http://localhost/WebApiClassificacao/api/fila')
          .then(response => {
            this.Filas = response.data
          })
          .catch(error => {
            console.log(JSON.stringify(error))
          })
      }
    }
  }
</script>
