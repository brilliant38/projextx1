<template>
  <!-- return 시킨 변수는 {{ 이 안에 넣음 }}-->
  <div class="name">
    {{greet}}
  </div>
</template>

<script>
export default{
  //Composition API만 사용한다고 함.
  //사용할 함수 정의
  setup(){
    const name = 'Manlu coder1';

    const greeting = (name) =>{
      return 'Hell O, ' + name;
    };
    const greet = greeting(name);

    return {
      greet,
    }
  }
}
</script>

<style>
 .name {
  color:red;
}
</style>