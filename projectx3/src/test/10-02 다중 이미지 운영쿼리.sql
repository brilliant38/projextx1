-- list - ��ȣ, ����, �ۼ���, �ۼ���, ��ǥ�̹���
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

--- 2. view - ��ȣ, ����, ����, ���̵�, �ۼ��� �̸�, �ۼ���
--- + �̹����� - fno, filename -> list
select mi.no, mi.title, mi.content, mi.id, m.name, mi.writeDate
from multi_image mi, member m
where (no = 1)and (mi.id = m.id)
;

select fno, fileName
from multi_image_file
where no = 2
;

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


--4. ���� - �̹��� �Խ��� ���� ���� - ����, ���� : no / ���� ���� ���� : fno



