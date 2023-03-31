--. �̹��� �Խ��� � ����

-- 1. ����Ʈ
select i.no, i.title, i.id, m.name, i.writeDate, i.fileName 
from image i, member m
where i.id = m.id
order by no desc;

-- 2. ���� : ��ȣ�� 2���� ������
select i.no, i.title, i.content, i.id, m.name, i.writeDate, i.fileName 
from image i, member m
where (no = 2) and (i.id = m.id);

-- 3. ��� - id�� member�� �ִ� id�� ��밡��
insert into image(no, title, content, id, fileName)
values(image_seq.nextval, 'ddd','ddd','admin','ddd.jpg');
commit;

-- 4. ���� - ����, ����, �̹��� : ���� �̹����� �ٲ� �� �ִ�. 2������ �ۼ��� id : test -> Ȯ�� �� �ۼ�
update image set title = 'b1b1', content = 'b1b1', filename = 'b1b1.jpg'
where no = 2 and id = 'test';
commit;

-- 5. ���� - 3�� �̹���
delete from image where no = 3;
commit;

-- 6. ���ϸ� ����
update image set fileName = 'big.jpg'
where no = 2 and id = 'test';
commit;
