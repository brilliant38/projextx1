-- �Խ��� ��� ���̺� / ������ ��ü ����
DROP TABLE tbl_reply CASCADE CONSTRAINTS;
DROP SEQUENCE seq_reply;

-- �Խ��� ��� ���̺� / ������ ��ü ����
CREATE TABLE tbl_reply(
  rno NUMBER(10,0), -- PK
  bno NUMBER(10,0) NOT NULL, -- ���� �ִ� �۹�ȣ(FK)
  reply VARCHAR2(1000) NOT NULL, -- content - ��� ����
  replyer VARCHAR2(50)  NOT NULL, -- �ۼ���
  replyDate DATE DEFAULT sysdate,
  updateDate DATE DEFAULT sysdate
);

CREATE SEQUENCE seq_reply;

-- ���� ���� �߰� ����
-- table_col_const -> tbl_reply_rno_pk
ALTER TABLE tbl_reply
ADD CONSTRAINT pk_reply PRIMARY KEY (rno);

ALTER TABLE tbl_reply
ADD CONSTRAINT fk_reply_board
FOREIGN KEY (bno) REFERENCES tbl_board(bno);
