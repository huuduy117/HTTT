create user TranQuangDat_QLSV identified by 123
grant create session to TranQuangDat_QLSV
grant create table to TranQuangDat_QLSV
alter user TranQuangDat_QLSV quota 100M on users

GRANT CREATE PROCEDURE TO TranQuangDat_QLSV

grant select on TranQuangDat_QLSV.hocvien to TranQuangDat_QLSV;
grant select on TranQuangDat_QLSV.hocvien to public;