<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>게시판 글 보기</title>
<style type="text/css">
#deleteDiv {
	display: none;
}
</style>
<!-- reply 객체를 가져오기 -->
<script type="text/javascript" src="/js/reply.js"></script>

<script type="text/javascript">
	$(function(){

		/* <c:if test="${msg !=null}">
			$("#messageModal").modal("show");
		</c:if> */
		
		console.log(replyService);

		var no = ${vo.no};
		var replyUL = $(".chat");
		
		showList(1)

		//사용 시점 - 게시판 글 보기 보여주는 처음 시점, 댓글 등록 후, 댓글 수정 후, 댓글 삭제 후 계속 리스트 새로 고침해야 신규 댓글 목록이 나옴. -> 함수로 만들어서 호출 시키는게 편함
		function showList(page){
			//replyService.list() 테스트
			replyService.list(
				//넘어가는 데이터
				{page:1, no:no},
				//성공했을때의 함수 - callback 함수
				function(data){
					//alert(data);
					var list = data.list;

					//추가 해야할 li 태그들을 저장하는 변수 선언
					var str = "";

					//댓글이 없는 경우의 처리
					if(list == null || list.length == 0){
						replyUL.html("<li> 댓글이 존재하지 않습니다.</li>"); //데이터가 없는경우 출력
						return; //돌아간다. 다음것을 실행하지 않음
					}
						
					//댓글이 있는 경우의 처리
					for(var i=0,len=list.length; i<len; i++){
						//console.log(list[i]);
						str+="<li class='left clearfix' data-rno='"+list[i].rno+"'>";
						str+="<div>";
						str+="<div class='header'>";
						str+="<strong class='primary-font'>"+list[i].replyer+"</strong>";
						str+="<small class='pull-right text-muted'>"+list[i].replyDate+"</small>";
						str+="</div>";
						str+="<p>"+list[i].reply+"</p>";
						str+="</div>";
						str+="</li>";
					}

					replyUL.html(str);
				}
			);
		};

		//게시판 글보기 이벤트 처리
		$('#deleteBtn').click(function(){
				//alert("삭제 버튼 클릭");
				$('#deleteDiv').slideDown();
		});
		
		$("#cancelBtn").click(function(){
				$('#deleteDiv').slideUp();
		});

		//모달 창을 보이게 - 댓글 등록 버튼 : 댓글 제목 오른쪽 버튼
		$("#replyWriteBtn").click(function(){
			//댓글 모달창 제목 바꾸기
			$("replyModalTitle").text("댓글 등록 모달");

			//댓글 번호 숨김
			$("#rnoDiv").hide();

			//필요 없는 버튼
			$("#modalUpdateBtn,#modalDeleteBtn").hide();

			//필요한 버튼 - 등록 표시
			$("#modalWriteBtn").show();
				alert("댓글 등록 처리")
				
				//데이터 수집해서 replyService.write()에 보낸다.
				var reply = {no : no, reply : $("#reply").val()};

				//replyService.write(JSON, function(), function())로 보낸다.
				replyService.write(
					reply,
					function(result){
						//1. 사용자에게 메시지 전달
						if(result) alert(decodeURI(result.replaceAll("+"," ")));
						else alert("댓글 등록이 되었습니다.");
						//2. 모달 창을 닫는다.
						$("#replyModal").modal("hide");
						//3. 댓글 리스트를 갱신한다.
						showList(1);
					}
				);

			//모달 창을 보이게 하자.
			$("#replyModal").modal("show");
		});
	});

	//댓글 등록의 처리 버튼 - 모달 창에 있는 버튼
	$("#modalWriteBtn").click(function(){
		alert("댓글 등록 처리");

		//모달 창을 안 보이게 하자.
		$("#replyModal").modal("hide");
	
	});
  </script>
</head>
<body>
	<div class="card shadow md-4">
		<div class="card-header py-3">게시판 글 보기</div>
		<div class="card-body">
			<table class="table">
				<tbody>
					<tr>
						<th>글번호</th>
						<td>${vo.no }</td>
					</tr>
					<tr>
						<th>제목</th>
						<td>${vo.title }</td>
					</tr>
					<tr>
						<th>내용</th>
						<td>${vo.content }</td>
					</tr>
					<tr>
						<th>작성자</th>
						<td>${vo.writer }</td>
					</tr>
					<tr>
						<th>작성일</th>
						<td><fmt:formatDate pattern="yyyy-MM-dd"
								value="${vo.writeDate }" /></td>
					</tr>
					<tr>
						<th>조회수</th>
						<td><fmt:formatNumber pattern="#,###" value="${vo.hit }" /></td>
					</tr>
				</tbody>
			</table>

			<a href="update.do?no=${vo.no }" class="btn btn-default">수정</a> <a
				href="#" class="btn btn-default" onclick="return false"
				id="deleteBtn">삭제</a> <a href="list.do" class="btn btn-default">리스트</a>
			<div id="deleteDiv">
				<form action="delete.do" method="post">
					<input name="no" value="${vo.no }" type="hidden">
					<div class="form-group">
						<label>본인 확인용 비밀번호 입력 :</label> <input name="pw"
							class="form-control" type="password">
					</div>
					<button class="btn btn-danger btn-sm">삭제</button>
					<button class="btn btn-warning btn-sm" type="button" id="cancelBtn">취소</button>
				</form>
			</div>
		</div>
	</div>
	
	<div class="row">
		<div class="col-lg-12">
			<div class="card">
				<div class="card-header">
					<i class="fa fa-comments fa-fw"></i> Reply
					<button id="replyWriteBtn" class="btn btn-primary btn-sm float-right">댓글 입력</button>
				</div>
				<div class="card-body">
					<!-- 댓글을 출력하는 UL - 데이터 한 개당 li태그 한개 -->
					<ul class="chat">
						<li class="left clearfix" data-rno="12">
							<div>
								<div class="header">
									<strong class="primary-font">작성자</strong> <small
										class="pull-right text-muted">2023-03-22</small>
								</div>
								<p>댓글 내용 출력</p>
							</div>
						</li>
					</ul>
					<!-- 댓글을 출력하는 UL 끝-->
				</div>
			</div>
		</div>
	</div>
	
	
	<div class="modal" id="replyModal">
		<div class="modal-dialog">
			<div class="modal-content">

				<!-- Modal Header -->
				<div class="modal-header">
					<h4 class="modal-title" id="replyModalTitle">Reply Modal</h4>
					<button type="button" class="close" data-dismiss="modal">&times;</button>
				</div>

				<!-- Modal body form tag는 만들지 않고 데이터 수집용으로만 input, textarea, select 태그 사용
					 - 등록 : 댓글 내용. 수정 댓글 번호(보이게), 댓글 내용 -->
				<div class="modal-body">
					<div class="form-group" id="rnoDiv">
						<label>댓글 번호</label>
						<input name="rno" id="rno" class="form-control" readonly="readonly" >
					</div>
					<div class="form-group">
						<label>댓글 내용</label>
						<textarea rows="5" class="form-control" name="reply" id="reply"></textarea>
					</div>
				</div>
				
				<!-- Modal footer -->
				<div class="modal-footer">
					<button type="button" class="btn btn-primary" id="modalWriteBtn">등록</button>
					<button type="button" class="btn btn-primary" id="modalUpdateBtn">수정</button>
					<button type="button" class="btn btn-primary" id="modalDeleteBtn">삭제</button>
					<button type="button" class="btn btn-danger" data-dismiss="modal">취소</button>
				</div>

			</div>
		</div>
	</div>
	
	<%-- <c:if test="${msg != null }">
		<%@ include file="../common/message.jspf" %>
	</c:if> --%>

</body>
</html>