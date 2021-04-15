create database Empleado;
go
use Empleado;
go 

create table Tbl_empleado (
Id_empleado int identity primary key,
Empl_nombre varchar(50),
Empl_apellido varchar(50),
Empl_DUI int,
Empl_direccion varchar(50),
Empl_tel int,
Empl_email varchar(50),
Empl_cargo varchar(50),
);
select * from Tbl_empleado