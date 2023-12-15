/*select kno
from s, k 
where k.state=1 and s.sno='000000' and s.sdept = k.sdept and not exists
(select *
from sk);*/
/*select zt from qx where bh='cz1' and qno='学生选课';
update qx set zt='1' where bh='cz1' and qno='学生选课';*/
select * from sk where 学号='000000';