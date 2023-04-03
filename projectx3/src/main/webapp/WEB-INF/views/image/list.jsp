<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="pageNav" tagdir="/WEB-INF/tags" %>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>이미지 리스트</title>
<style type="text/css">
	a, a:hover{
		text-decoration: none;
		color: #444;
	}
</style>
<script type="text/javascript">
$(function(){
	<c:if test="${msg !=null}">
		$("#messageModal").modal("show");
	</c:if>
	
});
</script>
</head>
<body>
	<div class="card shadow md-4">
		<div class="card-header py-3">이미지 리스트</div>
		<div class="card-body">
			<div class="row">
				<c:forEach items="${list }" var="vo" varStatus="vs">
					<c:if test="${vs.index != 0 && vs.index % 4 == 0 }">
						${"</<div><div class='row'>" }
					</c:if> <!-- 이미지 4개마다 줄 바꿈해라. -->
					<div class="col-md-4">
						<div class="img-thumbnail">
							<a href="view.do?no=${vo.no }&page=${pageObject.page}&PerpageNum=${pageObject.perPageNum}&key=${pageObject.key}&word=${pageObject.word}"> <img src="${vo.fileName }" alt="Lights" style="width: 100%">
								<div class="caption">
									<p><span>${vo.no }. ${vo.title }</span></p>
									<div>
										${vo.name }(${vo.id })
										<span class="float-right"><fmt:formatDate value="${vo.writeDate }" pattern="yyyy-MM-dd"/> </span>
									</div>
								</div>
							</a>
						</div>
					</div>
				</c:forEach>
				<!-- 단일 이미지를 for문으로 계속 추가생성 -->
			</div>
			<!-- 이미지 갤러리의 끝 -->
		</div>
		<!-- CardBody의 끝 -->
		<div class="card-footer">
			<a href="write.do" class="btn btn-primary">등록</a>
		</div>
		<div>
			<pageNav:pageNav listURI="list.do" pageObject="${pageObject }"></pageNav:pageNav>
		</div>
	</div>
	<!-- Card의 끝 -->
	
</body>
</html>