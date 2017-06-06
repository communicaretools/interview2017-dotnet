angular.module('app')
    .controller('ListController', [
        '$http',
        function($http) {
            this.registrations = [];

            $http.get('/api/registrations')
                .then(response => {
                        console.log('Received registrations', response.data);
                        this.registrations = response.data;
                    },
                    error => console.error('Error fetching list:', error));
            
            this.remove = function remove(registration) {
                $http.delete('/api/registrations/' + registration.id)
                    .then(() => {
                        var index = this.registrations.indexOf(registration);
                        console.log('Remove from list:', registration, 'at index', index);
                        this.registrations.splice(index, 1);
                    }, error => console.error('Could not delete entry:', error));
            }
        }]);