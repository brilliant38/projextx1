/**
 * 댓글 객체 선언해서 사용해보자.
 */
 console.log("Reply Module......");
 
 var replyService = (function(){
 
 	// list(전달 데이터, 성공하면 실행할 함수, 실패하면 실행할 함수) - 전달되는 요소는 모두 생략 가능하다.
	// param = {no:10, page:1}
	function list(param, callback, error){
  		var no = param.no;
  		var page = param.page;
  		//ajax 시작 - $.getJSON(url, function).fail(function);
  		$.getJSON(
  			"boardreply/list.do?page=" + page + "&no=" + no, //url
  			function(data){ //function
  				//성공하면 실행 할 함수가 있다면 실행하자.
  				if(callback){
  					console.log("data= " + data);
  					callback(data);
  				} // end of callback
  				else {
  					alert(data);
  				}
  			} // end of function(data) - 성공 했을때 실행 함 수 끝
  		).fail(function(xhr, status, err){ //.fail 실패 했을 때의 처리 시작 - function (통신객체, 상태, 에러)
  			if(error){
  				error();
  			} else {
  				console.log("xhr= " + xhr);
  				console.log("status= " + status);
  				console.log("err= " + err);
  				alert("댓글 리스트를 가져오다가 사고 났어요.");
  			}
  		}) // 실패 했을때의 처리 끝
  		;
  	}
  	
	return {
  		// 함수 리턴
  		list:list //실행 방법 replyService.list()
	};
	
 })(); //JSON 객체 선언하는 방법.
 
 