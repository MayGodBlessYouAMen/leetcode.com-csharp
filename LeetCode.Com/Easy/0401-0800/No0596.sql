-- mysql
-- 注意student-class数据可能有重复
select class from courses 
group by class
having count(distinct student) >= 5