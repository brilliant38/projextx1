<template>
  <div class="about">
    <h1>This is an about page</h1>
    <ManluCoder >
      <template #header="{manlu}">
        <p>header11 {{manlu}}</p>
      </template>
      <template #default>
        hello~
      </template>
    </ManluCoder>
  </div>
</template>

<script>
import ManluCoder from '@/components/ManluCoder.vue';

export default {
  
  components: {
    ManluCoder
  },
  
}
</script>