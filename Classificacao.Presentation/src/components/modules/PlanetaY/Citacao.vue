<template>
  <transition name="el-zoom-in-top">
    <div class="content-wrapper">
      <!-- HEADER -->
      <section class="content-header">
        <ol class="breadcrumb">
          <li><router-link to="/"> <i class="ti-home"></i></router-link></li>
          <li class="active"><span class="active-breadcrumb">Citações</span></li>
        </ol>
      </section>
      <!-- BODY -->
      <section class="content">
        <div class="box">
          <div class="box-header">
            <h3>CLASSIFICAR CITAÇÕES</h3>
          </div>
          <div class="box-body" style="min-height:500px; padding: 10px !important;">
            <!--ACAO EM MASSA-->
            <div>
              <span>BARRA DE AÇÃO EM MASSA</span>
            </div>

            <div class="citacao-content" v-for="citacao in Citacoes" style="background-color: #CCF5FF;">
              <!--CHECKBOX-->
              <div class="citacao-checkbox">
                <input type="checkbox" value="false" />
              </div>
              <div class="citacao-header">
                <!--IMG PROFILE-->
                <div style="float: left;">
                  <img v-bind:src="citacao.urlProfile" width="30" height="30" />
                </div>
                <!--TITLE-->
                <div style="float: left;">
                  <span class="citacao-title">
                    {{ citacao.autor }}
                  </span>
                </div>
              </div>

              <div class="citacao-body">
                <!--TEXTO-->
                <div>
                  <span v-html="citacao.texto"></span>
                </div>
                <!--IDM's-->
                <div>
                  <br />
                  <br />
                  <div style="display: block">
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">captação</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">empregabilidade</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">localização</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">atuação etica</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">corpo docente</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">credenciamento mec</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">preço</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">qualidade ensino</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">infraestrutura</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">relacionamento</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;"></span>
                      <div style="width: 80px;">
                        <br />
                        <br />
                        <br />
                      </div>
                    </div>
                    <div class="btn-group-vertical" role="group" style="width: 90px;">
                      <span style="word-break: break-word;">classificação</span>
                      <div style="width: 80px;">
                        <button type="button" class="btn btn-default" style="width: 100%">positivo</button>
                        <button type="button" class="btn btn-default" style="width: 100%">neutro</button>
                        <button type="button" class="btn btn-default" style="width: 100%">negativo</button>
                      </div>
                    </div>
                  </div>
                </div>
              </div>

            </div>
          </div>
        </div>
      </section>
    </div>
  </transition>
</template>

<style>
  .active-breadcrumb {
    color: black;
    font-weight: bold;
  }

  .citacao-content {
    display: block;
    width: 100%;
    padding: 5px 0 0 10px;
    margin-bottom: 6px;
  }

  .citacao-checkbox {
    margin: -3px 0px 0px -6px;
  }

  .citacao-header {
    display: inline-block;
    width: 100%;
  }

  .citacao-body {
    display: inline-block;
    width: 100%;
    line-height: normal;
  }

  .citacao-title {
    padding-left: 10px;
    line-height: 30px;
    font-weight: bold;
  }
</style>
<script>
  export default {
    name: 'citacao',
    data: function () {
      return { Citacoes: [] }
    },
    created: function () {
      this.getCitacoes()
    },
    updated: function () {
      this.$nextTick(function () {
        // Código que irá rodar apenas após toda
        // a árvore do componente ter sido re-renderizada

        console.log('updated')
        // this.getCitacoes()
      })
    },
    methods: {
      getCitacoes: function () {
        var url = 'http://localhost/WebApiClassificacao/api/citacao/' + this.$route.params.id

        this.$http.get(url)
          .then(response => {
            this.Citacoes = response.data
          })
          .catch(error => {
            console.log(JSON.stringify(error))
          })
      }
    }
  }
</script>
