angular
    .module('app')
    .config(['$locationProvider', '$routeProvider',
        function config($locationProvider, $routeProvider) {
            $locationProvider.hashPrefix('!');
            
            console.log('Configuring routes');
            $routeProvider
                .when('/add', {
                    templateUrl: 'templates/add.html'
                })
                .when('/list', {
                    templateUrl: 'templates/list.html'
                })
                .otherwise('/list');
        }
    ]);