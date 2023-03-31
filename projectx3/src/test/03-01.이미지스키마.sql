-- 이미지 스키마
-- 1. 제거
--올라가는 파일의 텍스트 정보를 저장하는 객체
drop table multi_image CASCADE CONSTRAINTS;
drop SEQUENCE multi_image_seq;
--올라가는 파일에 대해 저장하는 객체.,
drop table multi_image_file cascade constraints;
drop sequence multi_image_file_seq;

-- 2. 생성
create table multi_image(
    no number primary key,
    title varchar2(300) not null,
    content varchar2(2000) not null,
    id varchar2(20) not null references member(id) on DELETE CASCADE,
    writeDate date default sysdate
);

create SEQUENCE multi_image_seq;

--올라가는 파일 자체를 저장하는 객체
create table multi_image_file(
    fno number primary key,
    no number references multi_image(no) on DELETE CASCADE,
    fileName varchar2(100) not null,
    president number(1) not null
);

create SEQUENCE multi_image_file_seq;

commit;

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


