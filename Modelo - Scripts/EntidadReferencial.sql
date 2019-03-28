use DB_Biblioteca;
go


alter table rolAsignadoAUsuario add foreign key (idrol) references roles(idrol);
alter table rolAsignadoAUsuario add foreign key (idusuario) references usuarios(idusuario);		


alter table permisosDeRol add primary key (idventana, idrol);
alter table permisosDeRol add foreign key (idrol) references roles(idrol);	
alter table permisosDeRol add foreign key (idventana) references ventanas(idventana);	

alter table permisosAUsuarios add foreign key (idusuario) references usuarios(idusuario);
alter table permisosAUsuarios add foreign key (idventana) references ventanas(idventana);

alter table existencias add foreign key (codLibro) references libros(codLibro);


alter table prestamoENC add foreign key (cedula) references clientes(Cedula);

alter table prestamoDet add primary key (codprestamo, codLibro);
alter table prestamoDet add foreign key (CodPrestamo) references prestamoENC(codprestamo);
alter table prestamoDet add foreign key (codLibro) references libros(codLibro);	