select c.name
from customers c
join legal_person lp
    on c.id = lp.id_customers
where lp.id_customers = c.id 