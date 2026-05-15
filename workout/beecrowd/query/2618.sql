select pd.name, pr.name, c.name
from products pd
left join providers pr
    on pd.id_providers = pr.id
join categories c
    on pd.id_categories = c.id
where pr.name = 'Sansul SA' and c.name = 'Imported'