SELECT
name as Customers
FROM Customers c

WHERE c.id NOT IN (
    SELECT customerId from Orders
)