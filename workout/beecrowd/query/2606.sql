select p.id, p.name
from products p 
join categories g  
    on p.id_categories = g.id
where g.name like 'super%'