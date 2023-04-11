<template>
    <div>
        User List
        <div v-for="user in people" :key="user.id">
            {{user.name}}
        </div>
    </div>

</template>

<script>
import { mapState, mapActions } from 'vuex'; //vuex에서 자동 객체 생성 기능.

export default {

    created(){
        this.getUsers();
    },
    computed:{
        /* ...mapState({
            users: state => state.user.users
        }) */
        ...mapState('user', ['users'])
        /* users(){
            return this.$store.state.users;
        } */

    },
    methods:{
        ...mapActions('user', ['getUsers'])
    }

}
</script>

<style>

</style>