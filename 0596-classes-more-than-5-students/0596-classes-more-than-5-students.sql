select
    c.class as class
from
    Courses c
group by c.class 
having count(c.student) >= 5
