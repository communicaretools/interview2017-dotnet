Vue.component('registration-list-item',
    {
        props: ['registration'],
        template: `
            <li class="list-group-item">
                <span class="pull-right">
                    <span class="btn btn-xs btn-default" v-on:click="remove()">
                        <span class="glyphicon glyphicon-remove" aria-hidden="true"></span>
                    </span>
                </span>
                {{registration.name}}
            </li>
        `,
        methods: {
            remove: function remove() {
                console.log('Removing', this.registration.name);
                $.ajax({
                    method: 'DELETE',
                    url: '/api/registrations/' + this.registration.id,
                    contentType: 'application/json',
                    success: () => this.$emit('removed')
                });
            }
        }
    });

const List = {
    template: `
        <div>
            <ul class="list-group">
                <registration-list-item
                    v-for="reg in registrations"
                    v-bind:registration="reg"
                    v-bind:key="reg.id"
                    v-on:removed="removeRegistration(reg)" />
            </ul>
            <router-link to="/add" class="btn btn-default"><span class="glyphicon glyphicon-plus"></span> Add</router-link>
        </div>
    `,
    data: () => {
        return {
            registrations: []
        }
    },
    mounted: function () {
        this.requestRegistrations();
    },
    methods: {
        requestRegistrations: function requestRegistrations() {
            console.log('Querying registrations');
            var self = this;
            $.get('/api/registrations')
                .success(data => self.registrations = data)
                .error(error => console.error('Error while requesting registrations', error));
        },
        removeRegistration: function removeRegistration(registration) {
            var index = this.registrations.indexOf(registration);
            console.log('Remove from list:', registration, 'at index', index);
            this.registrations.splice(index, 1);
        }
    }
};