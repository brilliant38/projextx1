-- list - 번호, 제목, 작성자, 작성일, 대표이미지
select no, title, id, writeDate, fileName
from(
    select rownum rnum, no, title, id, name, writeDate, fileName
    from(
        select mi.no, mi.title, mi.id, m.name, mi.writeDate, mif.filename
        from multi_image mi, member m, multi_image_file mif
        where (mif.president = 1) and (mi.no = mif.no and m.id = mi.id)
        order by no desc
        )
    )
where rnum between 1 and 10;

--- 2. view - 번호, 제목, 내용, 아이디, 작성자 이름, 작성일
--- + 이미지들 - fno, filename -> list
select mi.no, mi.title, mi.content, mi.id, m.name, mi.writeDate
from multi_image mi, member m
where (no = 1)and (mi.id = m.id)
;

select fno, fileName
from multi_image_file
where no = 2
;

-- 3. 샘플데이터
---3-1 multi image 데이터를 입력 받는다.
insert into multi_image(no, title, content, id)
    values(multi_image_seq.nextval, '여러개 이미지2','여러개 이미지2','test');

commit;

--no를 확인해서 이미지 파일 데이터 등록할 때 사용 -> 1번이 생겼다.
select max(no) no from multi_image;

-- 3-2. 실제적인 파일의 정보 입력 president - 1 : 대표이미지 (list에 표시) 한개만 처리 나머지는 0
insert into multi_image_file(fno, no, fileName, president)
values(multi_image_file_seq.nextval, 2, '/upload/image2/dog01.jpg', 1);
insert into multi_image_file(fno, no, fileName, president)
values(multi_image_file_seq.nextval, 2, '/upload/image2/dog02.jpg', 0);

commit;

select * from multi_image_file;


--4. 수정 - 이미지 게시판 정보 수정 - 제목, 내용 : no / 파일 정보 수정 : fno



