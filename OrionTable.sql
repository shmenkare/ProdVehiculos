create database Orion

create table usuario 
(
id_usuario int not null,
nombre varchar(50) not null,
cargo varchar(50) not null,
)

insert into usuario values (1, 'Orion Ra', 'CEO')

SELECT * FROM usuario

create table productos 
(
id_product int not null,
nombre varchar(50) not null,
precio int,
)

insert into productos values (1, 'GUITARRA IBANEZ', '1500')

select * from productos