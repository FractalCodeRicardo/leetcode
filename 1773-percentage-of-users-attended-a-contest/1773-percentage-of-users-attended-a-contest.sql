/* Write your T-SQL query statement below */
declare @total decimal(8,2) = (select count(user_id) from Users)

select
contest_id,
Round((count/@total)* 100,  2) percentage

from (
select
contest_id,
count(user_id) count
from Register
group by contest_id
) as data

order by percentage desc, contest_id asc