-- 1581.Customer Who Visited but Did Not Make Any Transactions
-- Write your MySQL query statement below
select
customer_id,
count(*) as count_no_trans
from Visits
where Visits.visit_id not in(
    select distinct v.visit_id
    from Visits v 
        inner join Transactions t on
        v.visit_id = t.visit_id
)
group by customer_id