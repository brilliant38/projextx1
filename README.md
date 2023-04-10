1.Spring MVC 강의

2.JavaScript 강의 추가

3.Vue.js 2 강의 내용 추가
- component의 multi-word 사용 관련 예외가 뜨는 경우 #1

Component name "Todo" should always be multi-word

프로젝트의 Root에 있는 .eslintrc.js 파일에

rules: {
'vue/multi-word-component-names': 0
}

를 추가 하면 더 이상 예외가 나타나지 않는다.
- :checked="todo.checked" 와 같이 조건에 바인딩 하는 경우 :를 붙여서 써야한다. (띄워써서 에러 생기는 경우 빈번)




