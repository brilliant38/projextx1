<template>
  <div>
    <h1>This is Home Page</h1>
    <ManluCoder title="home title"/>
  </div>
</template>

<script>
//import는 vue file명으로 동일하게 해야함.
import ManluCoder from '@/components/ManluCoder.vue';

export default {
  components:{
    ManluCoder
  },
  data(){
    return {
      name: 'Manlu Coder'
    }
  }

}
</script>

<style scoped>
h1{
  color: red;
}

</style>