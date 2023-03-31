-- 게시판 댓글 테이블 / 시퀀스 객체 제거
DROP TABLE tbl_reply CASCADE CONSTRAINTS;
DROP SEQUENCE seq_reply;

-- 게시판 댓글 테이블 / 시퀀스 객체 생성
CREATE TABLE tbl_reply(
  rno NUMBER(10,0), -- PK
  bno NUMBER(10,0) NOT NULL, -- 보기 있는 글번호(FK)
  reply VARCHAR2(1000) NOT NULL, -- content - 댓글 내용
  replyer VARCHAR2(50)  NOT NULL, -- 작성자
  replyDate DATE DEFAULT sysdate,
  updateDate DATE DEFAULT sysdate
);

CREATE SEQUENCE seq_reply;

-- 제약 조건 추가 설정
-- table_col_const -> tbl_reply_rno_pk
ALTER TABLE tbl_reply
ADD CONSTRAINT pk_reply PRIMARY KEY (rno);

ALTER TABLE tbl_reply
ADD CONSTRAINT fk_reply_board
FOREIGN KEY (bno) REFERENCES tbl_board(bno);
