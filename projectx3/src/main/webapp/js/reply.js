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
  			"/boardreply/list.do?page=" + page + "&no=" + no, //url
  			function(data){ //function
  				//성공하면 실행 할 함수가 있다면 실행하자.
  				if(callback){
  					console.log("data= " + JSON.stringify(data));
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
  	
  	//write()
  	//reply = {no:284, reply:"~~~"}
  	function write(reply, callback, error){
  		console.log("write Reply...................");
  		console.log("reply = " + JSON.stringify(reply));
  		
  		//서버로 데이터를 보내서 댓글 등록 시킨다.
  		$.ajax({
  			url : "/boardreply/write.do",
  			type : "post",
  			data : JSON.stringify(reply),
  			contentType : "application/json; charset=utf-8",
  			success : function(result, status, xhr){
  				//아래 3가지 처리를 전달 받은 함수에 넣어서 처리하자.
  				//사용자에게 메시지 전달.
  				//모달 창을 닫기
  				//댓글 리스트를 다시 불러와야 한다.
  				if(callback){
  					callback(result);
  				}else{
  					alert("성공적으로 댓글 등록이 되었습니다.")
  					console.log(result);
  				}
			},
			//서버에 오류가 있을 때 실행 되는 함수.
			error : function(xhr, status, er){
				console.log(xhr);
				console.log(status);
				console.log(er);
				if(error){
					error();
				}else{
					alert("댓글 등록에 실패했습니다.");
				}
			}
  		});
  	}
  	
	//update()
  	//reply = {rno:10, reply:"~~~"}
  	function update(reply, callback, error){
  		console.log("update Reply...................");
  		console.log("reply = " + JSON.stringify(reply));
  		
  		//서버로 데이터를 보내서 댓글 수정 시킨다.
  		$.ajax({
  			url : "/boardreply/update.do",
  			type : "post",
  			data : JSON.stringify(reply),
  			contentType : "application/json; charset=utf-8",
  			success : function(result, status, xhr){
  				//아래 3가지 처리를 전달 받은 함수에 넣어서 처리하자.
  				//사용자에게 메시지 전달.
  				//모달 창을 닫기
  				//댓글 리스트를 다시 불러와야 한다.
  				if(callback){
  					callback(result);
  				}else{
  					alert("성공적으로 댓글 수정이 되었습니다.")
  					console.log(result);
  				}
			},
			//서버에 오류가 있을 때 실행 되는 함수.
			error : function(xhr, status, er){
				console.log(xhr);
				console.log(status);
				console.log(er);
				if(error){
					error();
				}else{
					alert("댓글 수정이 실패했습니다.");
				}
			}
  		});
  	} // function update()의 끝
  	
	//delete()
  	//reply = {rno:10}
  	function deleteFunction(rno, callback, error){
  		console.log("delete Reply...................");
  		console.log("rno = " + rno);
  		
  		//서버로 데이터를 보내서 댓글 수정 시킨다.
  		$.ajax({
  			url : "/boardreply/delete.do?rno=" + rno,
  			type : "delete",
  			success : function(result, status, xhr){
  				//아래 3가지 처리를 전달 받은 함수에 넣어서 처리하자.
  				//사용자에게 메시지 전달.
  				//모달 창을 닫기
  				//댓글 리스트를 다시 불러와야 한다.
  				if(callback){
  					callback(result);
  				}else{
  					alert("성공적으로 댓글 삭제가 되었습니다.")
  					console.log(result);
  				}
			},
			//서버에 오류가 있을 때 실행 되는 함수.
			error : function(xhr, status, er){
				console.log(xhr);
				console.log(status);
				console.log(er);
				if(error){
					error();
				}else{
					alert("댓글 삭제에 실패했습니다.");
				}
			}
  		});
  	} // function update()의 끝
  	
	return {
  		// 함수 리턴
  		list:list, //실행 방법 replyService.list()
  		write:write, //실행 방법 replyService.write()
		update:update, //replyService.update()
		delete:deleteFunction //replyService.delete()
	};
	
 })(); //JSON 객체 선언하는 방법.
 
 