<template>
  <div>
    <h1>This is Home Page</h1>
    <ManluCoder title="home title" name="Manlu Coder"/>
    <!-- <form action=""> -->
      <InputField v-model="name"/>
      <br><button @click="updateName">Submit</button>
    <!-- </form> -->
    {{ name }}
  </div>
</template>

<script>
import InputField from '@/components/InputField.vue';

export default{
  components: {
    InputField
  },
  data() {
    return {
      name: 'Manlu Coder'
    }
  },
  beforeCreate(){
    console.log('beforeCreate',this.name);
  },
  created(){
    console.log('created',this.name);
  },
  beforeMount(){
    alert('beforeMount');
  },
  mounted(){
    alert('mounted');
  },
  beforeUpdate(){
    alert('beforeUpdate');
  },
  updated(){
    alert('updated');
  },
  beforeDestroy(){
    alert('beforeDestroy');
  },
  destroyed(){
    alert('destroyed');
  },
  methods: {
        updateName(){
            this.name = 'hello';
        }
  }
}
//import는 vue file명으로 동일하게 해야함.
// import ManluCoder from '@/components/ManluCoder.vue';

// export default {
//   components:{
//     ManluCoder
//   },
//   data(){
//     return {
//       name: 'Manlu Coder'
//     }
//   }

// }

</script>

<style scoped>
h1{
  color: red;
}

</style>