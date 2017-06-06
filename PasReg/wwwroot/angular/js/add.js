angular.module('app')
    .controller('AddController', [
        '$http',
        function($http) {
            this.registration = {};
            
            this.submit = function(registration) {
                console.log('Ready to submit registration', this.registration);
                // TODO: Submit data via POST to /api/registrations (NB: As JSON!)
            };
        }]);