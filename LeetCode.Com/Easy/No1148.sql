﻿-- 1148. Article Views I
-- Write your MySQL query statement below
select distinct author_id id
from Views
where viewer_id = author_id
order by author_id