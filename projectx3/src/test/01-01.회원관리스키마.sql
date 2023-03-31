-- ȸ������ ��Ű��
-- 1. ����(FK -> PK)
drop table member CASCADE CONSTRAINTS;
drop table grade CASCADE CONSTRAINTS;

-- 2. ����(PK -> FK)
create table grade(
    gradeNo number(2) PRIMARY key,
    gradeName VARCHAR2(30) not null
);

create table member(
  id VARCHAR2(20) PRIMARY key, -- ���̵� 4~ 20
  pw VARCHAR2(20) not null,
  name VARCHAR2(30) not null,
  -- check ���� ���� gender in('����', '����') => gender = '����' or gender = '����'
  gender VARCHAR2(6) not null CHECK (gender in('����', '����')),
  birth date not null,
  tel VARCHAR2(13),
  email VARCHAR2(50) not null,
  regDate date default sysdate,
  conDate date default sysdate,
  -- default�� ���� �ۼ�, ���� ���� default �ڿ� �ۼ��Ѵ�.
  status VARCHAR2(6) default '����' CHECK (status in('����', 'Ż��', '����', '�޸�')),
   -- 1:�Ϲ�ȸ��, 9:������ - grade table�� ���� �Ǵ� select case when ���� then �ٲ� ������ end
  gradeNo number(2) default 1 REFERENCES grade(gradeNo)
);

-- 3. ���õ����� - �Ϲ�ȸ��(1), ������(9)
--   PK -> FK
--   ���̺��� ��� �׸��� �����͸� ������� �Է��� �� �÷��̸��� ������ �� �ִ�.
insert into grade(gradeNo, gradeName)
values(1, '�Ϲ�ȸ��');
insert into grade
values(9, '������');
commit;

-- �ƾƵ�, ��й�ȣ, �̸�, ����, �������, ����ó, �̸��� + ���(������:9)
-- �Ϲ�ȸ��(����� 1 - �⺻)�� ȸ������
insert into member(id, pw, name, gender, birth, tel, email)
values('test', '1111', 'ȫ�浿', '����', '1995-03-01', '010-4444-8888', 'hong@naver.com');
-- ������(����� 9 - �Է� ��)
insert into member(id, pw, name, gender, birth, tel, email, gradeNo)
values('admin', '1111', '������', '����', '1990-11-01', '010-1111-2222', 'admin@naver.com', 9);
commit;

-- 4. Ȯ��
select * from grade;
select * from member;