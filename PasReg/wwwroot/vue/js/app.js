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

window.addEventListener('load',
    function() {
        app.$mount("#app");
    });