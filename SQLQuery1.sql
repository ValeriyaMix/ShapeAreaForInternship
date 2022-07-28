Select P.Name, C.Name
from Products P
Left join Products_Categories PC
on P.Id = PC.ProductId
Left join Categories C
on PC.CategoryId = C.Id