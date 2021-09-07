--mysql
delete from person
where id not in 
(select id from (select MIN(Id) as id from person group by Email) as p)

/*
	注意mysql恶心的地方，下面写法会报错：
	delete from person
	where id not in 
	(select MIN(Id) as id from person group by Email)

	要给子查询写个别名，再查一遍。
*/