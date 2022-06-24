create database vendas_db;

use vendas_db;

create table Cliente (
id_cliente int not null primary key identity,
nome varchar(45) not null,
cpf varchar(14),
telefone varchar(15),
email varchar(45));

create table Produto(
id_produto int not null primary key identity,
codEAN int not null,
nome varchar(45) not null,
preco float,
estoque int,
);

select * from sys.tables;

select * from Venda;

create table Venda(
id_Venda int not null primary key identity,
id_Cliente int not null,
ValorTotal float not null

INDEX fk_Cliente_Venda_idx (id_Cliente ASC),

  CONSTRAINT fk_Cliente_Venda
    FOREIGN KEY (id_Cliente)
    REFERENCES Cliente (id_Cliente)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
);

create table ItemVenda(
id_Item int not null primary key identity,
id_Venda int not null,
id_Produto int not null,
ValorUnitario float not null,
Quantidade int not null,
ValorTotal float not null

INDEX fk_Venda_ItemVenda_idx (id_Venda ASC),

  CONSTRAINT fk_Venda_ItemVenda
    FOREIGN KEY (id_Venda)
    REFERENCES Venda (id_Venda)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,

INDEX fk_Produto_ItemVenda_idx (id_Produto ASC),

  CONSTRAINT fk_Produto_ItemVenda
    FOREIGN KEY (id_Produto)
    REFERENCES Produto (id_Produto)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
);

select * from sys.tables;