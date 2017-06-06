const Add = {
    template: `
    <div>
        <form>
            <div class="form-group">
                This is the add registration form
            </div>
            <button type="submit" class="btn btn-primary" v-on:click="submit()">Submit</button>
            <router-link to="/list" class="btn btn-default">Cancel</router-link>
        </form>
    </div>
    `,
    data: () => {
        return {
            registration: {}
        };
    },
    methods: {
        submit: function submit() {
            console.log('Ready to submit registration', this.registration);
        }
    }
};