<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="pageNav" tagdir="/WEB-INF/tags" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>이미지 보기</title>
<style type="text/css">
.imageData img:hover{
	border: 1px solid red;
	cursor: pointer;
}
#changeFileDiv{
	display: none;
}
</style>

<script type="text/javascript">
$(function(){
	<c:if test="${msg !=null}">
		$("#messageModal").modal("show");
	</c:if>
	
	//작은 이미지를 클릭하면 큰 이미지가 변경 되도록 처리하는 이벤트
	$(".imageData").click(function(){
		//alert("작은 이미지 클릭");
		//필요한 데이터 수집
		//변경한 이미지의 fno로도 세팅해야 한다.
		var fno = $(this).data("fno");
		$("#changeFno").val(fno);
		var president = $(this).data("president");
		var alt =  $(this).find("img").attr("alt");
		var src =  $(this).find("img").attr("src");
		
		//alert("fno=" + fno + ", president=" + president + ", alt=" + alt + ", src=" + src);
		//큰 이미지에 alt, src 정보를 넣어준다.
		$("#bigImage").attr("alt",alt);
		$("#bigImage").attr("src",src);
		//fno 세팅
		$("#bigImage").data("fno",fno);
		//alert($("#bigImage").data("fno"));
	});
	
	//이미지 바꾸기 버튼 클릭 시 적용 이벤트 -> 폼이 나타나야 한다.
	$("#changeFileBtn").click(function(){
		//큰 이미지의 data-fno의 값을 가져와서 변경 대상 fno에 세팅해준다.
		$("#changeFno").val($("#bigImage").data("fno"));
		$("#deleteFileName").val($("#bigImage").attr("src"));
		$("#changeFileDiv").slideDown();
	});
	//취소 버튼 동작 지정
	$("#cancelBtn").click(function(){
		$("#changeFileDiv").slideUp();
	});
	
	
	
});
</script>
</head>
<body>
	<div class="card shadow md-4">
		<div class="card-header py-3">이미지 보기</div>
		<div class="card-body">
			<div class="row">
				<div class="col-md-2">번호</div>
				<div class="col-md-10">${vo.no }</div>
			</div>
			<div class="row">
				<div class="col-md-2">제목</div>
				<div class="col-md-10">${vo.title }</div>
			</div>
			<div class="row">
				<div class="col-md-2">내용</div>
				<div class="col-md-10">${vo.content }</div>
			</div>
			<div class="row">
				<div class="col-md-2">작성자 ID(이름)</div>
				<div class="col-md-10">${vo.id }(${vo.name })</div>
			</div>
			<div class="row">
				<div class="col-md-2">번호</div>
				<div class="col-md-10">
					<fmt:formatDate value="${vo.writeDate }" pattern="yyyy-MM-dd"/>
				</div>
			</div>
			
			<div class="row">
				<div class="col-md-12" style="padding: 10px;" >
					<a href="update.do?no=${vo.no }&page=${param.page}&perPageNum=${param.perPageNum}&key=${param.key}&word=${param.word}" class="btn btn-primary">수정(정보수정)</a>
					<a href="delete.do?no=${vo.no }" class="btn btn-primary">삭제</a>
					<a href="list.do?page=${param.page}&perPageNum=${param.perPageNum}&key=${param.key}&word=${param.word}" class="btn btn-primary">리스트</a>
				</div>
			</div>
			
			<div class="row">
				<div class="col-md-12">
					<!-- 첨부된 이미지 - 작은 이미지 리스트 만들기-->
					<div class="row">
						<c:forEach items="${list }" var="ifvo">
							<!-- 작은 이미지 클릭 시 큰 이미지 교체 하기위해 제이쿼리로 갖다 쓸 데이터 세팅 -->
							<div class="col-md-2 imageData" data-fno="${ifvo.fno }" data-president="${ifvo.president }">
								<img alt="${ifvo.fileName }" src="${ifvo.fileName }" style="width:100%;" class="img-thumbnail">
							</div>
						</c:forEach>
					</div>
					<!-- 큰 이미지 처리 버튼 -->
					<div class="row">
						<div class="col-md-12">
							<button class="btn btn-primary" id="changeFileBtn">이미지 바꾸기</button>
						</div>
					</div>
					<!-- 이미지 바꾸기 폼 -->
					<div class="row" id="changeFileDiv">
						<div class="col-md-12">
							<form action="updateFile.do" method="post" enctype="multipart/form-data">
								<input type="hidden" name="no" value="${vo.no }">
								<!-- 작은 이미지를 클릭하면 큰 이미지의 fno 세팅 -> jquery로 작업한다. -->
								<input type="hidden" name="fno" id="changeFno" >
								<input type="hidden" name="page" value="${param.page }">
								<input type="hidden" name="perPageNum" value="${param.perPageNum }">
								<input type="hidden" name="key" value="${param.key }">
								<input type="hidden" name="word" value="${param.word }">
								<input type="hidden" name="deleteFileName" >
								<div class="form-group">
									<label>변경할 이미지 선택: </label>
									<input class="form-control" name="changeFile" type="file">
								</div>
								<button class="btn btn-primary">이미지 바꾸기</button>
								<button class="btn btn-primary" type="button" id="cancelBtn">취소</button>
							</form>
						</div>
					</div>
					<!-- 큰 이미지 하나 보여주기. -->
					<div class="row">
						<div class="col-md-12 text-center">
							<c:forEach items="${list }" var ="ifvo">
								<c:if test="${ifvo.president == 1}">
									<img alt="${ifvo.fileName }" src="${ifvo.fileName }" style="width:70%; border: 1px solid #888" class="img-thumbnail" id="bigImage" data-fno="${ifvo.fno }">
								</c:if>
							</c:forEach>
						</div>
					</div>
				</div>
			</div>
		</div>
	</div>


</body>
</html>