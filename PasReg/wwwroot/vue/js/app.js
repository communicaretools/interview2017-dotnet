const routes = [
    { path: '/', component: List },
    { path: '/list', component: List },
    { path: '/add', component: Add }
];

const router = new VueRouter({
    routes: routes
});

const app = new Vue({
    router: router
});

$.ajaxSetup({
    contentType: 'application/json; charset=utf-8'
});

window.addEventListener('load',
    function() {
        app.$mount("#app");
    });