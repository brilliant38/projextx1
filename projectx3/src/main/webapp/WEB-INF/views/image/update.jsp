<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>이미지 수정 폼</title>
<script type="text/javascript">
$(function(){
	$("$cancelBtn").click(function(){
		history.back();
	});
});
</script>
</head>
<body>
	<div class="card shadow md-4">
		<div class="card-header py-3">이미지 수정 폼</div>
		<div class="card-body">
			<form action="update.do" method="post">
				<!-- 페이지 정보 세팅 -->
				<input type="hidden" name="page" value="${param.page }">
				<input type="hidden" name="perPageNum" value="${param.perPageNum }">
				<input type="hidden" name="key" value="${param.key }">
				<input type="hidden" name="word" value="${param.word }">
				<div class="form-group">
					<label>글 번호</label>
					<input name="no" class="form-control" readonly="readonly" value="${vo.no }">
				</div>
				<div class="form-group">
					<label>제목</label>
					<input name="title" class="form-control" value="${vo.title }">
				</div>
				<div class="form-group">
					<label>내용</label>
					<textarea name="content" class="form-control" rows="7">${vo.content }</textarea>
				</div>
				<button class="btn btn-primary">수정</button>
				<button class="btn btn-danger" type="reset">새로 입력</button>
				<button class="btn btn-warning" type="button" id="cancelBtn">취소</button>
			</form>
		</div>
	</div>
</body>
</html>