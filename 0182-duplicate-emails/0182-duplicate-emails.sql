# Write your MySQL query statement below
SELECT
email
FROM Person
WHERE email IS NOT NULL
Group By email
HAVING Count(id)>1