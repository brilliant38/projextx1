--. 이미지 게시판 운영 쿼리

-- 1. 리스트
select i.no, i.title, i.id, m.name, i.writeDate, i.fileName 
from image i, member m
where i.id = m.id
order by no desc;

-- 2. 보기 : 번호가 2번인 데이터
select i.no, i.title, i.content, i.id, m.name, i.writeDate, i.fileName 
from image i, member m
where (no = 2) and (i.id = m.id);

-- 3. 등록 - id는 member에 있는 id만 사용가능
insert into image(no, title, content, id, fileName)
values(image_seq.nextval, 'ddd','ddd','admin','ddd.jpg');
commit;

-- 4. 수정 - 제목, 내용, 이미지 : 본인 이미지만 바꿀 수 있다. 2번글의 작성자 id : test -> 확인 후 작성
update image set title = 'b1b1', content = 'b1b1', filename = 'b1b1.jpg'
where no = 2 and id = 'test';
commit;

-- 5. 삭제 - 3번 이미지
delete from image where no = 3;
commit;

-- 6. 파일명 변경
update image set fileName = 'big.jpg'
where no = 2 and id = 'test';
commit;
