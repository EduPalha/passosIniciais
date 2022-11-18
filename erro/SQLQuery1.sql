create database aula2;

create table teste2
(
	id integer primary key identity,
	nome varchar(50)
)

create table pessoas2
(
	id integer primary key identity,
	nome varchar(50),
	idade integer,
	altura integer
)

create login usuario with password='senha1234';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

select database_id, name, create_date from sys.databases where database_id > 4;


begin transaction

insert into teste values ('teste');
insert into teste values (1,2);

if(@@error > 0)
	begin
		rollback transaction;
	end
else
	begin
		commit transaction;
	end
