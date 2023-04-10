<template>
  <div id="app" class="container">
    <h1 class="text-center">Todo App</h1>
    <CompletedTodo :todos="todos" />
    <AddTodo @add-todo="addTodo"/>
    <hr>
    <TodoList :todos="todos"
    @toggle-checkbox="toggleCheckBox"
    @click-delete="deleteTodo"
     />

    {{todos}}
  </div>
</template>

<script>
import TodoList from '@/components/TodoList';
import AddTodo from '@/components/AddTodo';
import CompletedTodo from '@/components/CompletedTodo';

export default{
  components: {
    TodoList,
    AddTodo,
    CompletedTodo
  },
  data() {
    return {
      todoText: '',
      todos: [
        {id : 1, text: 'buy a car', checked: false},
        {id : 2, text: 'play game', checked: false},
      ]
    }
  },
  methods:{
    deleteTodo(id){
      /* const index = this.todos.findIndex(todo => {
        return todo.id === id;
      });
      this.todos.splice(index , 1); */
      //Delete 버튼 대상 id가 아닌 것들만 추려서 다시 todos에 넣어줌.
      this.todos = this.todos.filter(todo => todo.id !== id);
    },
    addTodo(value){
      this.todos.push({
        id: Math.random(),
        text: value,
        checked: false
      });
      this.todoText = '';
    },
    toggleCheckBox({id,checked}){
      const index = this.todos.findIndex(todo => {
        return todo.id === id;
      });
      this.todos[index].checked = checked;
    }
  }
}
</script>