import Dashboard from './components/Dashboard.vue'
import DashboardIndex from './components/modules/dashboard/Index.vue'
import DashboardSecond from './components/modules/dashboard/DashboardSecond.vue'
import Citacao from './components/modules/PlanetaY/Citacao.vue'
// import NotFound from './components/modules/dashboard/404.vue'
// import WidgetsIndex from './components/modules/widgets/Index.vue'
// import UIButtons from './components/modules/ui/Buttons.vue'
// import UIGeneral from './components/modules/ui/General.vue'
// import UIIcons from './components/modules/ui/Icons.vue'
// import UIModals from './components/modules/ui/Modals.vue'
// import UISliders from './components/modules/ui/Sliders.vue'
// import UITimeline from './components/modules/ui/Timeline.vue'
// Form
// import FormRadio from './components/modules/form/FormRadio.vue'
// import FormCheckbox from './components/modules/form/FormCheckbox.vue'
// import FormInput from './components/modules/form/FormInput.vue'
// import FormSelect from './components/modules/form/FormSelect.vue'
// import FormCascader from './components/modules/form/FormCascader.vue'
// import FormSwitch from './components/modules/form/FormSwitch.vue'
// import VueBar from './components/modules/chart/VueBar.vue'
// import ChartJs from './components/modules/chart/ChartJs.vue'
// import ChartBar from './components/modules/chart/ChartBar.vue'
// import ChartPie from './components/modules/chart/ChartPie.vue'
// import FormSlider from './components/modules/form/FormSlider.vue'
// import FormTimePicker from './components/modules/form/FormTimePicker.vue'
// import Mail from './components/modules/Mail.vue'

// import Chat from './components/modules/Chat.vue'
// import Calendar from './components/modules/Calendar.vue'
// import ToDo from './components/modules/ToDo.vue'
// import BlogList from './components/modules/BlogList.vue'
// import BlogDetails from './components/modules/BlogDetails.vue'
// import BlogMansory from './components/modules/BlogMansory.vue'
// import ShopHome from './components/modules/ShopHome.vue'
// import ShopItem from './components/modules/ShopItem.vue'
// import BlankPage from './components/modules/common-page/BlankPage.vue'
// import InvoicePage from './components/modules/common-page/Invoice.vue'
// import Profile from './components/modules/common-page/Profile.vue'
// import Login from './components/Login.vue'
// import NotFoundSecond from './components/modules/dashboard/500.vue'
// import SimpleTable from './components/modules/tables/SimpleTable.vue'
// import SelectTable from './components/modules/tables/SelectTable.vue'
// import ExpandableTable from './components/modules/tables/ExpandableTable.vue'
// import Editor from './components/modules/ui/Editor.vue'
// import Upload from './components/modules/ui/Upload.vue'
// import Gmap from './components/modules/Gmap.vue'
// import ChartMap from './components/modules/chart/ChartMap.vue'
// import OpenLayer from './components/modules/OpenLayer.vue'

// Routes
const routes = [
  {
    path: '/',
    component: Dashboard,
    meta: { requiresAuth: true },
    beforeEnter: (to, from, next) => {
      document.body.className += 'skin-dark sidebar-mini'
      next()
    },
    activate: function () {
      this.$nextTick(function () {
        // => 'DOM loaded and ready'
        alert('test')
      })
    },
    children: [
      {
        path: '',
        name: 'dashboard',
        component: DashboardIndex
      },
      {
        path: '/dashboard',
        name: 'dashboard-first',
        component: DashboardIndex
      },
      {
        path: '/dashboard-second',
        name: 'dashboard-second',
        component: DashboardSecond
      },
      {
        path: '/citacao',
        name: 'citacao',
        component: Citacao
      }
    ]
  }
]

export default routes
