-- 1587.Bank Account Summary II
-- Write your MySQL query statement below
select 
Users.name,
sum(Transactions.amount) as balance
from Users,Transactions
where Users.account = Transactions.account
group by Users.name
Having balance > 10000