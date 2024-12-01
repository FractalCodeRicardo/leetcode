select
    top 1 customer_number
from
    (
        select
            customer_number,
            count(order_number) number_orders
        from
            Orders
        group by
            customer_number
    ) as data
order by number_orders desc