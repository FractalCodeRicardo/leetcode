
delete 
from
Person
where id not in(
    select
    Min(id)
    from Person
    group by email

)

