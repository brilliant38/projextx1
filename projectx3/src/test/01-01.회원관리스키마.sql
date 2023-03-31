-- 회원관리 스키마
-- 1. 제거(FK -> PK)
drop table member CASCADE CONSTRAINTS;
drop table grade CASCADE CONSTRAINTS;

-- 2. 생성(PK -> FK)
create table grade(
    gradeNo number(2) PRIMARY key,
    gradeName VARCHAR2(30) not null
);

create table member(
  id VARCHAR2(20) PRIMARY key, -- 아이디 4~ 20
  pw VARCHAR2(20) not null,
  name VARCHAR2(30) not null,
  -- check 제약 조건 gender in('남자', '여자') => gender = '남자' or gender = '여자'
  gender VARCHAR2(6) not null CHECK (gender in('남자', '여자')),
  birth date not null,
  tel VARCHAR2(13),
  email VARCHAR2(50) not null,
  regDate date default sysdate,
  conDate date default sysdate,
  -- default를 먼저 작성, 제약 조건 default 뒤에 작성한다.
  status VARCHAR2(6) default '정상' CHECK (status in('정상', '탈퇴', '강퇴', '휴면')),
   -- 1:일반회원, 9:관리자 - grade table로 연결 또는 select case when 조건 then 바꿀 데이터 end
  gradeNo number(2) default 1 REFERENCES grade(gradeNo)
);

-- 3. 샘플데이터 - 일반회원(1), 관리자(9)
--   PK -> FK
--   테이블의 모든 항목의 데이터를 순서대로 입력할 때 컬럼이름을 생략할 수 있다.
insert into grade(gradeNo, gradeName)
values(1, '일반회원');
insert into grade
values(9, '관리자');
commit;

-- 아아디, 비밀번호, 이름, 성별, 생년월일, 연락처, 이메일 + 등급(관리자:9)
-- 일반회원(등급이 1 - 기본)의 회원가입
insert into member(id, pw, name, gender, birth, tel, email)
values('test', '1111', '홍길동', '남자', '1995-03-01', '010-4444-8888', 'hong@naver.com');
-- 관리자(등급이 9 - 입력 필)
insert into member(id, pw, name, gender, birth, tel, email, gradeNo)
values('admin', '1111', '관리자', '남자', '1990-11-01', '010-1111-2222', 'admin@naver.com', 9);
commit;

-- 4. 확인
select * from grade;
select * from member;