IF DB_ID('pcstore') IS NOT NULL
DROP DATABASE pcstore
GO

CREATE DATABASE pcstore
GO

USE pcstore
go


create table categoria(
IdCategoria int identity(1,1) primary key,
descripcion varchar(50)
)
go

--insertando 

INSERT INTO categoria VALUES('Teclado');
INSERT INTO categoria VALUES('Mouses');
INSERT INTO categoria VALUES('Monitores');
INSERT INTO categoria VALUES('Tarjetas de Video');
INSERT INTO categoria VALUES('Placa Madre');

select * from categoria
go;

--tabla producto
create table producto(
IdProducto int identity(1,1) primary key,
CodProducto char(5) null,
Descripcion varchar(45)null,
Precio money null,
Stock int null,
Garantia int null,
Descuento decimal (8,2) null,
IdCategoria int not null,
foreign key (IdCategoria)references categoria(IdCategoria)
);
go

--insertando valores

insert into producto values('T0001','LOGITECH G111',100.28,97,12,0.05,1);
insert into producto values('M0001','AURICULAR MICRONICS CITRIX',20.00,17,6,0.10,2);
insert into producto values('M0002','HYPERX SURGE RGB',120.50,92,12,0.08,2)
insert into producto values('P0001','LG G123',520.10,198,18,0.07,3)
insert into producto values('P0002','SAMSUNG S312',600.00,250,18,0.04,3)
insert into producto values('V0001','NVIDIA GTX 1660',1900.00,53,24,0.09,4)
insert into producto values('V0002','AMD RANDEON RX580',1500.00,100,12,0.15,4)
insert into producto values('P0001','ASROCK B450 STEEL LEGEND',1421.00,56,16,0.20,5)

--revisando
select * from producto
go

create table tipo(
IdTipo int identity(1,1) primary key,
Descripcion varchar(10)
);
go

INSERT INTO tipo VALUES ('usuario')
GO

INSERT INTO tipo VALUES ('admin')
GO

select * from tipo
go

create table usuario(
IdUsuario int identity(1,1) primary key,
Dni varchar(12) not null,
Nombre varchar(45)not null,
Apellido varchar(45)not null,
FecNacimiento date null,
Email varchar(50) null,
Contraseña varchar(50)null,
Telefono varchar(20)null,
Direccion varchar(50)null ,
IdTipo int default 1,
FechaRegistro DateTime not null default GETDATE(),


foreign key(IdTipo)references tipo(IdTipo)
);
go

INSERT INTO usuario (Dni, Nombre,Apellido,FecNacimiento,Email,Contraseña,Telefono, Direccion,IdTipo)
VALUES('78954783', 'JESUS MARTIN' , 'VELASQUEZ ZAVALETA','1996-03-31','jesus_martim@hotmail.com','123123','918841895','Jr. el Sol 342',2)
INSERT INTO usuario (Dni, Nombre,Apellido,FecNacimiento,Email,Contraseña,Telefono, Direccion,IdTipo)
VALUES('08754872', 'Dino Jesus' , 'Chacaliaza','2001-08-12','dinojesus11@gmail.com','dino','947211598','Jr. Mercado Central 1120', 2)
INSERT INTO usuario (Dni, Nombre,Apellido,FecNacimiento,Email,Contraseña,Telefono, Direccion,IdTipo)
VALUES('79654787', 'PEPITO' , 'PICAPIEDRA','1991-08-15','pepe@gmail.com','123456','555111333','Jr. Huaraz 123', 1)

SELECT * FROM usuario


create table estado_pedido(
id_estado int primary key,
des_estado varchar(15)
)
go

INSERT INTO estado_pedido VALUES 
(0, 'En preparación'),
(1, 'En Camino'),
(2, 'Entregado')
go

select * from estado_pedido
go


create table cab_venta(
Id_Venta int identity(1,1) primary key,
NumFactura char(5) null,
Total_Fac money null,
Fecha_Fac Date null,
IdUsuario int not null,
id_estado int default 0,
foreign key (IdUsuario) references usuario(IdUsuario),
foreign key (id_estado) references estado_pedido(id_estado)
)
go

INSERT INTO cab_venta VALUES ('10000',5201.32,'2022-04-12',1,0),
('10001',3400.00,'2021-09-05',2,1),
('10001',2500.50,'2020-12-01',3,2),
('10002',622.50,'2022-04-20',3,1),
('10002',622.50,'2022-04-20',3,0),
('10003',2.00,'2022-04-20',3,1),
('10003',2.00,'2022-04-20',3,0),
('10003',120.50,'2022-04-20',3,0),
('10003',120.50,'2022-04-20',3,1),
('0',120.50,'2022-04-20',2,2),
('10004',20.00,'2022-04-20',3,2),
('10005',401.50,'2022-04-20',3,1),
('10006',421.50,'2022-04-20',3,1),
('10007',1821.30,'2022-04-20',3,2),
('10008',1720.80,'2022-04-20',2,0),
('10009',200.56,'2022-04-20',2,0),
('10009',200.56,'2022-04-20',2,0),
('10010',200.56,'2022-04-20',2,2),
('10011',1823.04,'2022-04-20',2,2)
go

select * from cab_venta
go


create table detalle_venta(
cantidad int,
precio money,
IdProducto int,
Id_Venta int,
foreign key (Id_Venta)references cab_venta(Id_Venta),
foreign key (IdProducto)references producto(IdProducto)
);
go

INSERT INTO detalle_venta VALUES (2,2500.00,3,1),(1,500.00,2,1),(3,700.00,4,1),(2,800.00,8,2),(1,1870.00,6,2),(3,4000.00,7,2),(3,200.00,3,3),(3,5000.00,6,1),(1,20.00,2,8),(1,120.50,3,9),(4,120.50,3,9),(1,20.00,2,4),(1,120.50,3,5),(4,120.50,3,7),(1,120.50,3,12),(1,120.50,3,11),(1,20.00,2,12),(1,20.00,2,16),(1,20.00,2,16),(3,120.50,3,16),(1,120.50,3,14),(1,20.00,2,14),(1,120.50,3,14),(3,520.10,4,14),(1,120.50,3,1),(3,520.10,4,12),(2,20.00,2,15),(2,100.28,1,16),(2,100.28,1,18),(3,100.28,1,19),(4,120.50,3,19),(2,520.10,4,19);

select * from detalle_venta
go

create Table garantia(
IdGarantia int identity(1,1) primary key,
Observacion varchar(1000)null,
Estado varchar(10) null,
Vigencia varchar(45)null,
IdProducto int not null,
IdFactura int not null,
NumFactura char(5) null,
foreign key (IdFactura)references cab_venta(Id_Venta)
);
go

INSERT INTO garantia VALUES ('G0001\n10001\nAMD RANDEON RX580\n2022-09-05\nABIERTO','Abierto','2022-09-05',7,2,'10001'),('G0024 MICRONICS 2022-10-12 1 ABIERTO','Abierto','2022-10-12',2,1,'10001'),('G0025 1000 LG G123 2023-10-12 1 ABIERTO','Abierto','2023-10-12',4,1,'10000'),('ID: G0026, NUMERO FACTURA : 10001, PRODUCTO: AMD RANDEON RX580, \nVIGENCIA : 2022-09-05 , FACTURA ID : 2 ;\nESTADO CERRADO','Cerrado','2022-09-05',7,2,'10001'),('PRUEBA G0008\nFACTURA 10001\nNVIDIA GTX 1660\nVIGENCIA: 2023-09-05 - ABIERTO','Abierto','2023-09-05',6,2,'10001');

Select * from garantia
go

--CREATE PROCEDURE 
-- CATEGORIA

Create Procedure usp_ListarCategoria
AS
	SELECT IdCategoria, descripcion FROM categoria
GO

CREATE PROCEDURE usp_CategoriaMerge(
@PIdCategoria int,
@Pdescripcion varchar(50)
)
AS
	MERGE categoria AS TARGET
	USING (SELECT @PIdCategoria, @Pdescripcion)
			AS SOURCE(IdCategoria, descripcion)
					ON TARGET.IdCategoria = SOURCE.IdCategoria
			WHEN MATCHED THEN
				UPDATE SET TARGET.descripcion = SOURCE.descripcion
			WHEN NOT MATCHED THEN
				INSERT (descripcion)
				VALUES(SOURCE.descripcion);
GO

CREATE PROCEDURE usp_EliminarCategoria(
@PIdCategoria int
)
AS
	delete FROM categoria WHERE IdCategoria = @PIdCategoria;
GO


-- PRODUCTO

Create Procedure usp_ListarProducto
AS
	SELECT * FROM producto
GO


CREATE PROCEDURE usp_ProductoMerge(
@PIdProducto int,
@PCodProducto char(5),
@PDescripcion varchar(45),
@PPrecio money,
@PStock int,
@PGarantia int,
@PDescuento decimal (8,2),
@PIdCategoria int
)
AS
	MERGE producto AS TARGET
	USING (SELECT @PIdProducto, @PCodProducto, @PDescripcion, @PPrecio, @PStock,
					@PGarantia, @PDescuento, @PIdCategoria)
			AS SOURCE(IdProducto, CodProducto, Descripcion, Precio, Stock,
					Garantia, Descuento, IdCategoria)
					ON TARGET.IdProducto = SOURCE.IdProducto
			WHEN MATCHED THEN
				UPDATE SET TARGET.CodProducto = SOURCE.CodProducto, TARGET.Descripcion = SOURCE.Descripcion,
							TARGET.Precio = SOURCE.Precio, TARGET.Stock = SOURCE.Stock,
							TARGET.Garantia = SOURCE.Garantia, TARGET.Descuento = SOURCE.Descuento, TARGET.IdCategoria = SOURCE.IdCategoria
			WHEN NOT MATCHED THEN
				INSERT (CodProducto, Descripcion, Precio, Stock, Garantia, Descuento, IdCategoria)
				VALUES(SOURCE.CodProducto, SOURCE.Descripcion, SOURCE.Precio, SOURCE.Stock,
					SOURCE.Garantia, SOURCE.Descuento, SOURCE.IdCategoria);
GO

SELECT * FROM producto
GO
/*
EXEC usp_ProductoMerge 10, 'A8888', 'BAANTRIX G240', '99.99', 100, 24, 0.00,2
GO*/

CREATE PROCEDURE usp_EliminarProducto(
@PIdProducto int
)
AS
	delete FROM producto WHERE IdProducto = @PIdProducto;
GO


--CREATE PROCEDURE 
-- USUARIO

Create Procedure usp_ListarUsuario
AS
	SELECT * FROM usuario
GO

CREATE PROCEDURE usp_UsuarioMerge(
@PIdUsuario int,
@PDni varchar(12),
@PNombre varchar(45),
@PApellido varchar(45),
@PFecNacimiento date,
@PEmail varchar(50),
@PContraseña varchar(50),
@PTelefono varchar(20),
@PDireccion varchar(50)
)
AS
	MERGE usuario AS TARGET
	USING (SELECT @PIdUsuario, @PDni, @PNombre, @PApellido, @PFecNacimiento, @PEmail,
					@PContraseña, @PTelefono, @PDireccion)
			AS SOURCE(IdUsuario, Dni, Nombre, Apellido, FecNacimiento, Email,
					Contraseña, Telefono, Direccion)
					ON TARGET.IdUsuario = SOURCE.IdUsuario
			WHEN MATCHED THEN
				UPDATE SET TARGET.Dni = SOURCE.Dni, TARGET.Nombre = SOURCE.Nombre,
							TARGET.Apellido = SOURCE.Apellido, TARGET.FecNacimiento = SOURCE.FecNacimiento,
							TARGET.Email = SOURCE.Email, TARGET.Contraseña = SOURCE.Contraseña, 
							TARGET.Telefono = SOURCE.Telefono, TARGET.Direccion = SOURCE.Direccion
			WHEN NOT MATCHED THEN
				INSERT (Dni, Nombre, Apellido, FecNacimiento, Email,
					Contraseña, Telefono, Direccion)
				VALUES(SOURCE.Dni, SOURCE.Nombre, SOURCE.Apellido, SOURCE.FecNacimiento,
					SOURCE.Email, SOURCE.Contraseña, SOURCE.Telefono, SOURCE.Direccion);
GO

CREATE PROCEDURE usp_EliminarUsuario(
@PIdUsuario int
)
AS
	delete FROM usuario WHERE IdUsuario = @PIdUsuario;
GO

/*
exec usp_UsuarioMerge 0, '7888888', 'testname', 'testapellido', '1991-01-01', 'test@test.com', '12345', '99365942','jr.cuzco 123';
GO*/

CREATE PROCEDURE usp_Login
@PEmail VARCHAR(50),
@PPassword VARCHAR(50)
AS
BEGIN
	SELECT Email, Contraseña FROM usuario WHERE Email = @PEmail AND Contraseña = @PPassword
END
GO

CREATE PROCEDURE usp_LoginAdmin
@PEmail VARCHAR(50),
@PPassword VARCHAR(50),
@PIdTipo int
AS
BEGIN
	SELECT Email, Contraseña FROM usuario WHERE Email = @PEmail AND Contraseña = @PPassword AND IdTipo = @PIdTipo
END
GO

CREATE PROCEDURE usp_BuscarCategoria(
@descripcion varchar(50)
)
AS
	BEGIN
	SELECT * FROM categoria C
	WHERE C.descripcion LIKE '%' + @descripcion + '%'
END
GO

CREATE PROCEDURE usp_BuscarUsuario(
@Dni varchar(12)
)
AS
	BEGIN
	SELECT * FROM usuario U
	WHERE U.Dni LIKE '%' + @Dni + '%'
END
GO

CREATE PROCEDURE usp_BuscarProducto(
@CodProducto char(5)
)
AS
	BEGIN
	SELECT * FROM producto P
	WHERE P.CodProducto LIKE @CodProducto + '%'
END
GO

CREATE PROCEDURE usp_VentasListar
AS
	BEGIN
	SELECT cv.Id_Venta, cv.NumFactura, cv.Total_Fac, cv.Fecha_Fac, usu.Nombre, epe.des_estado  FROM cab_venta cv INNER JOIN usuario usu
															ON cv.IdUsuario = usu.IdUsuario INNER JOIN estado_pedido epe
															ON cv.id_estado = epe.id_estado
END
GO



create table contactos(
idcontactos int identity(1,1) primary key,
nombre varchar(50),
apellido varchar(50),
correo varchar(45),
telefono varchar(45),
descripcion varchar(100),
motivo varchar(45)
)
go

--insertando 

INSERT INTO contactos VALUES('Roberto', 'Munoz', 'roberto@hotmail.com', '98754784', 'Necesito equipos para mi empresa', 'Reventa');
INSERT INTO contactos VALUES('Carlos', 'Zambrano', 'elpulpo@hotmail.com', '99512012', 'El servicio que me brindaron fue pésimo', 'Queja');
INSERT INTO contactos VALUES('Jhonny', 'Chero', 'Jhonny@gmail.com', '98745124', 'Necesito equipor por mayor para negocio.', 'Reventa');


select * from contactos
go;



CREATE PROCEDURE SP_CONTACTOS(
@nombre varchar(50),
@apellido varchar(50),
@correo varchar(45),
@telefono varchar(45),
@descripcion varchar(100),
@motivo varchar(45)
)
AS
	BEGIN
	INSERT INTO contactos(nombre, apellido, correo, telefono, descripcion, motivo)
	VALUES(@nombre, @apellido, @correo, @telefono, @descripcion, @motivo)
	END
GO

EXECUTE SP_CONTACTOS 'Hugo', 'Chavez', 'Hugo@peru.net', '95421477', 'Tengo un reclamo por mala atención', 'Queja'
GO



CREATE PROCEDURE usp_Transaccion(
@NumFactura char(5),
@Total_Fac money,
@IdUsuario int,
@id_estado int
)
AS
	Insert Into cab_venta (NumFactura, Total_Fac, Fecha_Fac, IdUsuario, id_estado)
	Values(@NumFactura, @Total_Fac, GETDATE(), @IdUsuario, @id_estado)
GO

EXEC usp_Transaccion '10011', 5000.00, 1, 0
GO



CREATE PROCEDURE usp_NumFactura
AS
	BEGIN
	SELECT MAX(NumFactura) NumFactura FROM cab_venta
	END
GO