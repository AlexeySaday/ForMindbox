--Есть две таблицы:
--В первой таблице (product) есть поле с названием продукта (product_name) и поле id котегории (category_id), которой принадлежит продукт
--Во второй таблице (category) есть поле c id категории и именем категории (category_name)


select 
	p.product_name,c.category_name
from product p
left join category c on p.category_id = c.id
