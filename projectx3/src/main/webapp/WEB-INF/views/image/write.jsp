<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>이미지 등록 폼</title>
</head>
<body>
	<div class="card shadow md-4">
		<div class="card-header py-3">이미지 등록 폼</div>
		<div class="card-body">
			<form action="write.do" method="post" enctype="multipart/form-data">
				<div class="form-group">
					<label>제목</label>
					<input name="title" class="form-control">
				</div>
				<div class="form-group">
					<label>내용</label>
					<textarea name="content" class="form-control"></textarea>
				</div>
				<div class="form-group">
					<label>사진 올리기</label>
					<div class="form-check row">
						<input type="radio" name="president" value="0" class="form-check-input" checked>
						<input name="imageFile" type="file">
					</div>
					<div class="form-check row">
						<input type="radio" name="president" value="1" class="form-check-input" checked>
						<input name="imageFile"  type="file">
					</div>
					<div class="form-check row">
						<input type="radio" name="president" value="2" class="form-check-input" checked>
						<input name="imageFile" type="file">
					</div>
					<div class="form-check row">
						<input type="radio" name="president" value="3" class="form-check-input" checked>
						<input name="imageFile"  type="file">
					</div>
					<div class="form-check row">
						<input type="radio" name="president" value="4" class="form-check-input" checked>
						<input name="imageFile"  type="file">
					</div>
				</div>
				<button class="btn btn-primary">등록</button>
			</form>
		</div>
	</div>
</body>
</html>