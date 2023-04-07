<template>
    <div>
        <h1>{{title}}</h1>
        <p>{{ name }}</p>
        <button @click="updateName">Change Name</button>
    </div>
</template>

<script>
export default{
    props: {
        title: {
            //title로 받을 데이터 타입 고정
            type: String,
            //title을 안 보내면 에러
            //required : false
            default: 'default title'

        },
        name: {
            type: String,
            default: 'default name'

        }
    },

    data(){
        return {
            //name: 'Manlu Coder',
        }
    },
    methods: {
        updateName(){
            this.name = 'Manlu Coder Updated'
        }
    }
}
</script>

<style scoped>

</style>