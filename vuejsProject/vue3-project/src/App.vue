<template>
  <!-- return 시킨 변수는 {{ 이 안에 넣음 }}-->
  <div class="name">
    {{name}}
  </div>
  <button 
    class="btn btn-primary"
    v-on:click="updateName"
  >
    Click
    </button>
</template>

<script>
import {ref} from 'vue';
export default{
  //Composition API만 사용한다고 함.
  //사용할 함수 정의
  setup() {
    const name = ref({
      id : 1
    });

/*     const greeting = (name) =>{
      return 'Hell O, ' + name;
    };

    const greet = greeting(name); */

    const updateName = () => {
      //console.log('hello world');
      //ref -> .value 수정
      //reactive -> .key로 접근.
      name.value = 2;
      console.log(name);
    };

    return {
      name,
      updateName,
    }
  }
}
</script>

<style>
 .name {
  color:red;
}
</style>