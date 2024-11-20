create table DuLieu
(
    ma varchar2(5) primary key,
    noidung varchar2(50)
)
/
insert into DuLieu (ma, noidung) values ('001', 'gioi ca dong huong');
insert into DuLieu (ma, noidung) values ('002', 'co le la vo cung');
insert into DuLieu (ma, noidung) values ('003', 'bo qua lua lua');
insert into DuLieu (ma, noidung) values ('004', 'mat cong sao no');
insert into DuLieu (ma, noidung) values ('005', 'nham mat ngo ngo');
insert into DuLieu (ma, noidung) values ('006', 'dua keo manh la');
insert into DuLieu (ma, noidung) values ('007', 'buon la va tan cua');
insert into DuLieu (ma, noidung) values ('008', 'noi ngay no cho cuoi');
insert into DuLieu (ma, noidung) values ('009', 'con lam thanh thi');
insert into DuLieu (ma, noidung) values ('010', 'chon doi chinh voi');
insert into DuLieu (ma, noidung) values ('011', 'cau chao voi canh');
insert into DuLieu (ma, noidung) values ('012', 'than lai toi tu song');
insert into DuLieu (ma, noidung) values ('013', 'bai thoi co dan');
insert into DuLieu (ma, noidung) values ('014', 'dung con quay len');
insert into DuLieu (ma, noidung) values ('015', 'co the co chon');
insert into DuLieu (ma, noidung) values ('016', 'khi moi chi san co');
insert into DuLieu (ma, noidung) values ('017', 'tu yeu la mat cuoi');
insert into DuLieu (ma, noidung) values ('018', 'dung bu nhe rat tuyen');
insert into DuLieu (ma, noidung) values ('019', 'khoong noi sao cua');
insert into DuLieu (ma, noidung) values ('020', 'day tieu duat manh');

COMMIT;
select *from dulieu;
