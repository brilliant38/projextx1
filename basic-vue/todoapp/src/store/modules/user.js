import axios from 'axios';

export default {
    namespaced: true,
    state: {
        users: []

    },
    mutations: {
        SET_USERS(state, users) {
            state.users = users;
        },

    },
    actions: {
        getUsers({ commit }) {
            axios.get('https://jsonplaceholder.typicode.com/users').then(res => {
                //console.log(res); //비동기 작업이므로 완료 되기 전에 다음 작업도 동시에 진행 됨.
                commit('SET_USERS', res.data);
            }); //promise를 리턴. promise가 무엇?
            //const a=1;
            //console.log(a);// 처리가 먼저 완료 되어 1이 먼저 찍힘.
        },

    }
}