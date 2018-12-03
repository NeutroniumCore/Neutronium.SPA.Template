import "material-design-icons/iconfont/material-icons.css";
import "font-awesome/css/font-awesome.css";

import Vue_Router from "vue-router";
import { router } from "./route";
import VueI18n from "vue-i18n";
import messages from "./message";
import Notifications from "vue-notification";

import
  Vuetify, {
  VApp,
  VAlert,
  VCard,
  VCardMedia,
  VCardTitle,
  VCardAction,
  VCheckBox,
  VContent,
  VContainer,
  VDivider,
  VNavigationDrawer,
  VFooter,
  VFlex,
  VLayout,
  VList,
  VListTile,
  VListTileTitle,
  VListTileAction,
  VListTileContent,
  VBtn,
  VIcon,
  VGrid,
  VToolbar,
  VDialog,
  VTextField,
  VToolbarSideIcon,
  VToolbarTitle,
  VSpacer,
  transitions
} from "vuetify/lib";

function install(Vue) {
  Vue.use(Vuetify, {
    components: {
      VApp,
      VAlert,
      VCard,
      VCardMedia,
      VCardTitle,
      VCardAction,
      VCheckBox,
      VContent,
      VContainer,
      VDivider,
      VNavigationDrawer,
      VFooter,
      VFlex,
      VLayout,
      VList,
      VListTile,
      VListTileTitle,
      VListTileAction,
      VListTileContent,
      VBtn,
      VIcon,
      VGrid,
      VToolbar,
      VCard,
      VDialog,
      VTextField,
      VToolbarSideIcon,
      VToolbarTitle,
      VSpacer,
      transitions
    }
  });

  Vue.use(Vue_Router);
  Vue.use(VueI18n);
  Vue.use(Notifications);
}

function vueInstanceOption(vm) {
  const i18n = new VueI18n({
    locale: "en-US", // set locale
    messages // set locale messages
  });

  //Return vue global option here, such as vue-router, vue-i18n, mix-ins, ....
  return {
    router,
    i18n
  };
}

export { install, vueInstanceOption };
