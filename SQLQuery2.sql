/*select status From master.dbo.sysdatabases where name='xsxk';*/
/*backup database xsxk to disk=
select spid from sysprocesses,sysdatabases where sysprocesses.dbid=sysdatabases.dbid and sysdatabases.Name='xsxk';*/
/*restore database xsxk from disk='D:\我的数据库\数据库备份\课程设计数据库备份\备份1\备份1.bak' with replace;*/
/*restore log xsxk from disk='D:\我的数据库\数据库备份\课程设计数据库备份\备份1\备份1log.bak' with replace;*/
/*select 账号 from 教务处 where 编号='cz';*/
/*insert into 教务处(账号,密码,编号) values('','','cz');*/
/*delete from 教务处 where 账号='                                                  ';
select 编号 from 教务处 where 账号='cz123456' and 密码='123456';*/