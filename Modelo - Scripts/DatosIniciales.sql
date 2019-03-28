use DB_Biblioteca;
go

insert into ventanas values (1,'Prestamos');
insert into ventanas values (2,'Libros');
insert into ventanas values (3,'Clientes');
insert into ventanas values (4,'Roles');
insert into ventanas values (5,'Usuarios');
insert into ventanas values (6,'Administración de Permisos');
insert into ventanas values (7,'Ventanas');


insert into usuarios values ('Admin', '123');
insert into roles values('Administrador');
insert into permisosDeRol values (1,1,1,1,1,1);
insert into permisosDeRol values (1,2,1,1,1,1);
insert into permisosDeRol values (1,3,1,1,1,1);
insert into permisosDeRol values (1,4,1,1,1,1);
insert into permisosDeRol values (1,5,1,1,1,1);
insert into permisosDeRol values (1,6,1,1,1,1);
insert into permisosDeRol values (1,7,1,1,1,1);

insert into rolAsignadoAUsuario values(1,1);