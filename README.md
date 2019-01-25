<p align="center"><img width="100" src="https://raw.githubusercontent.com/NeutroniumCore/neutronium-vue/master/template/src/assets/logo.png"></p>
<h1 align="center">Neutronium.SPA.Template</h1>

[![Build status](https://img.shields.io/appveyor/ci/David-Desmaisons/neutronium-spa-template.svg?maxAge=2592000)](https://ci.appveyor.com/project/David-Desmaisons/neutronium-spa-template)
[![MIT License](https://img.shields.io/github/license/NeutroniumCore/Neutronium.SPA.Template.svg)](https://github.com/NeutroniumCore/Neutronium.SPA.Template/blob/master/LICENSE)

## Description

This project is a template application for Neutronium Vue project.<br>
It is built on the top of [Vuetifyjs](https://vuetifyjs.com) material component framework.<br>
See [Neutronium.SPA.Demo](https://github.com/NeutroniumCore/Neutronium.SPA.Demo) as reference application built with this template.

## Features

### npm script

* `npm run serve`

    Serve files for Neutronium for debug in local browser using `.cjson` files as view-model.

* `npm run live`

    Serve files for Neutronium hot-reload.

* `npm run build`

    Build files to be used in Neutronium application.

### Command line argument

        Usage:
            --mode=live
            -m=dev --url=http://localhost:9090/index.html
            -u=http://localhost:9091/index.html

        Options:
            -m --mode=(live|dev|prod)    Set application mode.
            -u --url=<uri>   Set view url

![Screen shot](./__doc__/Configuration.png)
### Application mode

* Live:

        Debug mode with hot-reload activated using file served by `npm run live` scripts.

* Dev:

        Debug mode using local files.

* Prod:

        No debug, using local files.

Note: when running in live mode, it is not needed to run manually `npm run live` this will be called automatically by the application.

### Injected context command

#### To Live

* Only available in `dev` mode.
* Switch to `live` mode by running `npm run live` and reloading the page using the served files.

![Screen shot](./__doc__/screen-3.png)
![Screen shot](./__doc__/screen-4.png)

#### Reload

* Only available in `live` mode.
* Reload the page. Maybe useful on some scenario when page does not automatically reload.

![Screen shot](./__doc__/screen-2.png)



### Routing

Neutronium.SPA.Demo illustrates how to integrate with [vue-router](https://router.vuejs.org/en/).<br>
See more details [here](./Documentation/Routing.md)

### Internalization

Integration with [vue-i18n](https://kazupon.github.io/vue-i18n/en/) is provided.<br>
See more details [here](./Documentation/Internalization.md)

### Chromeless Window

See more details [here](./Documentation/Chromeless.md)

## Developing 

See more details [here](./Documentation/Developing.md)

## Built with

<p style="margin-left:100px;">
<a href="https://vuetifyjs.com">
<img src="https://seeklogo.com/images/V/vuetify-logo-3BCF73C928-seeklogo.com.png" height="50px">
</a>
<a href="https://github.com/NeutroniumCore/Neutronium">
<img src="https://raw.githubusercontent.com/NeutroniumCore/neutronium-vue/master/template/src/assets/logo.png" height="50px">
</a>
<a href="https://vuejs.org">
<img src="https://vuejs.org/images/logo.png" height="50px">
</a>
</p>




