import Vue from 'vue';
import Vuex from 'vuex';
import axios from 'axios';

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    todos: [
      { id: 1, text: 'buy a car', checked: false },
      { id: 2, text: 'play game', checked: false },
    ],
    users: []
  },
  mutations: {
    SET_USERS(state, users) {
      state.users = users;
    },
    ADD_TODO(state, value) {
      state.todos.push({
        id: Math.random(),
        text: value,
        checked: false
      });
    },
    TOGGLE_TODO(state, { id, checked }) {
      const index = state.todos.findIndex(todo => {
        return todo.id === id;
      });
      state.todos[index].checked = checked;
    },
    DELETE_TODO(state, todoId) {
      const index = state.todos.findIndex(todo => {
        return todo.id === todoId;
      });
      state.todos.splice(index, 1);
    }

  },
  actions: {
    getUsers({commit}) {
      axios.get('https://jsonplaceholder.typicode.com/users').then(res => {
        //console.log(res); //비동기 작업이므로 완료 되기 전에 다음 작업도 동시에 진행 됨.
        commit('SET_USERS', res.data);
      }); //promise를 리턴. promise가 무엇?
      //const a=1;
      //console.log(a);// 처리가 먼저 완료 되어 1이 먼저 찍힘.
    },
    //비동기 작업을 하고, 그 다음에 state의 데이터를 변경 할 때 사용한다.
    //DB에 새로운 Todo를 반영할 때, 비동기 작업을 진행.
    addTodo({ commit }, value) {
      //왜 과정을 하나 더 추가 하느냐...? (비동기 작업 추가)
      //예시로 setTimeOut 추가.
      setTimeout(function () {
        commit('ADD_TODO', value); //state 변경
      }, 500); // 0.5초 후에 commit 실행.
    },
    toggleTodo({ commit }, payload) {
      setTimeout(function () {
        commit('TOGGLE_TODO', payload); //state 변경
      }, 500); // 0.5초 후에 commit 실행.
    },
    deleteTodo({ commit }, todoId) {
      setTimeout(function () {
        commit('DELETE_TODO', todoId); //state 변경
      }, 500); // 0.5초 후에 commit 실행.
    }

  },
  getters: {
    numberOfCompletedTodo: state => {
      return state.todos.filter(todo => todo.checked).length;
    }
  }
});
