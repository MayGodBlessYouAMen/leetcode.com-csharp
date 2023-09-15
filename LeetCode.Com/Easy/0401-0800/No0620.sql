-- mysql
/* id为奇数，description不等于boring，按rating降序排*/
select * from Cinema
where id%2 = 1
and description != 'boring'
order by rating desc