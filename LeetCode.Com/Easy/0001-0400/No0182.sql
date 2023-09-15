--mysql
select Email FROM person
Group by Email
HAVING count(Email) > 1