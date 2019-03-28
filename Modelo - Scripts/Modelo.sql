create database DB_Biblioteca;
go

use [DB_Biblioteca];
go

create table usuarios(	idUsuario integer identity primary key,
						nombreUsuario varchar(30),
						contrasenna varchar(max));

create table rolAsignadoAUsuario(	idrolAsignadoAUsuario integer identity primary key,
									idUsuario integer,
									idRol integer);

create table roles (	idrol integer identity primary key,
						nombre varchar(50));

create table permisosDeRol (	idrol integer NOT NULL,
								idventana integer NOT NULL,
								insertar integer,
								modificar integer,
								eliminar integer,
								consultar integer);

create table permisosAUsuarios (	idpermisosAUsuarios integer identity primary key,
									idusuario integer,
									idventana integer,
									insertar integer,
									modificar integer,
									eliminar integer,
									consultar integer);

create table ventanas(	idventana integer primary key,
						nombre varchar(50));

Create table clientes (Cedula varchar(15) primary key,
						Nombre varchar (35),
						Telefono varchar(15),
						fechaNacimiento date,
						Direccion varchar(100));

create table Libros(	CodLibro int identity primary key,
						ISBN varchar(25),
						Titulo varchar(75),
						Autor varchar(35),
						FechaPublicacion date);
						
create table existencias (	CodLibro int primary key,
							cantidad int);


create table prestamoEnc(	CodPrestamo int identity primary key,
						cedula varchar(15),
						fechaPrestamo date,
						fechaDevoluvion date);

create table prestamoDet(	CodPrestamo int not null,
						CodLibro int not null,
						cantidad int);

create table Bitacora(	idBitacora int identity primary key,
						nombreUsuario varchar(25),
						fechaIngreso datetime not null default getdate());

