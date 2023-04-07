<template>
    <div>
        <p>Header</p>
        <slot name="header" :manlu="manlu"></slot>
        <p>body</p>
        <slot></slot>
        <p>footer
        </p>
    </div>
</template>

<script>
export default{
    props: { //props로 부모 컴포넌트로부터 받은 값은 자식컴포넌트에서 직접적으로 변경해서는 안된다.
        title: {
            type: String,
            default: 'default title'

        },
        name: {
            type: String,
            default: 'default name'

        },
        
    },

    data(){
        return {
            manlu: 'coder'
            // name: 'Manlu Coder', //props로 받는 변수는 다른 곳에서 사용 금지.
        }
    },
    methods: {
        updateName(){
            this.name = 'Manlu Coder updated'
        }
    }
    
}
</script>

<style scoped>

</style>