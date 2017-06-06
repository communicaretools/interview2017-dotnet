Vue.component('registration-list-item',
    {
        props: ['registration'],
        template: `
            <li class="list-group-item">
                {{registration.name}}
            </li>
        `
    });

const List = {
    template: `
        <div>
            <ul class="list-group">
                <registration-list-item
                    v-for="reg in registrations"
                    v-bind:registration="reg"
                    v-bind:key="reg.id" />
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
        }
    }
};