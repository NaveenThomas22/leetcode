# Write your MySQL query statement below

SELECT name AS Customers
from Customers
where Id NOT IN (
    SELECT customerId from Orders
)