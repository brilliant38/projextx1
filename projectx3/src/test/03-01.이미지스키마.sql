-- �̹��� ��Ű��
-- 1. ����
--�ö󰡴� ������ �ؽ�Ʈ ������ �����ϴ� ��ü
drop table multi_image CASCADE CONSTRAINTS;
drop SEQUENCE multi_image_seq;
--�ö󰡴� ���Ͽ� ���� �����ϴ� ��ü.,
drop table multi_image_file cascade constraints;
drop sequence multi_image_file_seq;

-- 2. ����
create table multi_image(
    no number primary key,
    title varchar2(300) not null,
    content varchar2(2000) not null,
    id varchar2(20) not null references member(id) on DELETE CASCADE,
    writeDate date default sysdate
);

create SEQUENCE multi_image_seq;

--�ö󰡴� ���� ��ü�� �����ϴ� ��ü
create table multi_image_file(
    fno number primary key,
    no number references multi_image(no) on DELETE CASCADE,
    fileName varchar2(100) not null,
    president number(1) not null
);

create SEQUENCE multi_image_file_seq;

commit;

-- 3. ���õ�����
---3-1 multi image �����͸� �Է� �޴´�.
insert into multi_image(no, title, content, id)
    values(multi_image_seq.nextval, '������ �̹���2','������ �̹���2','test');

commit;

--no�� Ȯ���ؼ� �̹��� ���� ������ ����� �� ��� -> 1���� �����.
select max(no) no from multi_image;

-- 3-2. �������� ������ ���� �Է� president - 1 : ��ǥ�̹��� (list�� ǥ��) �Ѱ��� ó�� �������� 0
insert into multi_image_file(fno, no, fileName, president)
values(multi_image_file_seq.nextval, 2, '/upload/image2/dog01.jpg', 1);
insert into multi_image_file(fno, no, fileName, president)
values(multi_image_file_seq.nextval, 2, '/upload/image2/dog02.jpg', 0);

commit;

select * from multi_image_file;


