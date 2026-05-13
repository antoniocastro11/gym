SELECT p.name, pr.name
FROM products p
JOIN providers pr
ON p.id_providers = pr.id
JOIN categories c
ON p.id_categories = c.id
WHERE c.id = 6;