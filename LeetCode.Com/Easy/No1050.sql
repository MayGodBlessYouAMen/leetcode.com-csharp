-- mysql
SELECT
	actor_id,
	director_id 
FROM
	actordirector 
GROUP BY
	actor_id,
	director_id 
HAVING
	count(timestamp) >= 3