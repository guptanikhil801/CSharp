create table Carts(
CartId int primary key identity(1,1),
Email nvarchar(max) Not Null,
BookId int not null,
BookQuantity int default 1);
