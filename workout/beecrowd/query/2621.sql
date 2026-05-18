select p.name
from products p
join providers pr
    on p.id_providers = pr.id
where p.amount between 10 and 20 and pr.name like 'P%'