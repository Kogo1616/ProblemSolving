SELECT COALESCE((
    SELECT 
    TOP 1 M.num
    FROM MyNumbers M
    GROUP BY M.num
    HAVING COUNT(*) = 1
    ORDER BY M.num DESC), null) AS num; 