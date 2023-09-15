﻿--mysql
select w1.id from weather w1
				join weather w2
				on w1.recordDate = DATE_ADD(w2.recordDate,interval 1 day)
WHERE w1.temperature > w2.temperature