select pd.name, pr.name, pd.price
from products pd
join providers pr
    on pd.id_providers = pr.id
join categories c
    on pd.id_categories = c.id  
where pd.price > 1000 and c.name = 'Super Luxury'