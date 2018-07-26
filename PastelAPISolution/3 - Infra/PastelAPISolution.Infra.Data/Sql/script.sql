create database Pastel
GO 
USE Pastel

GO
create table Cliente(
Id int,
Nome varchar(max)
constraint PK_Cliente primary key(Id)
)

GO
create table Produto(
Id int, 
Nome varchar(max),
Valor money
constraint PK_Produto primary key(Id)
)


GO
create table Pedido(
Id int,
ClienteId int,
Quantidade int,
Data DateTime,
constraint PK_Pedido primary key(Id),
constraint FK_Pedido_Cliente foreign key (ClienteId) references Cliente(Id)
)

GO
create table PedidoItem(
Id int,
PedidoId int,
ProdutoId int,
constraint PK_PedidoItem primary key (Id),
constraint FK_PedidoItem_Pedido foreign key (PedidoId) references Pedido(Id),
constraint FK_PedidoItem_Produto foreign key (ProdutoId) references Produto(Id)
)

