select P.Name, C.Name from Products AS P
left join ProductsAndCategories AS PC
	ON P.ID = PC.ProductID
left join Categories as C
	ON PC.CategoriesID = c.ID