select pd.name, pr.name
from products pd
left join providers pr
    on pd.id_providers = pr.id
where pr.name = 'Ajax SA';