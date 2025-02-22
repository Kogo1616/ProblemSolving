SELECT 
    A.actor_id, A.director_id
FROM ActorDirector A
GROUP BY A.actor_id, director_id
HAVING COUNT(*) >= 3;