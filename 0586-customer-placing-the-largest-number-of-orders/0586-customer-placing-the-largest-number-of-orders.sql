SELECT TOP 1 MAX(customer_number) as customer_number FROM Orders A
GROUP BY A.customer_number
ORDER BY COUNT(customer_number) DESC;