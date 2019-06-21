/* Procedimientos Almacenados */  

/*---------------------------------------------Procedimiento Ingreso de Nuevo Cliente------------------------------------------------*/
create procedure NuevoCliente
@Codigo_Cliente varchar(50),
@Nombre_Cliente varchar(100),
@Direccion_Cliente varchar(200),
@Telefono_Cliente varchar(20), 
@Correo_Cliente varchar(100)
as 
begin
	insert into Cliente (Codigo_Cliente, Nombre_Cliente, Direccion_Cliente, Telefono_Cliente, Correo_Cliente)
	values (@Codigo_Cliente, @Nombre_Cliente, @Direccion_Cliente, @Telefono_Cliente, @Correo_Cliente)
end
GO

/*---------------------------------------------Procedimiento Llenar ComboBox de Contrato------------------------------------------------*/
create procedure ComboboxContratos
as
begin
	select Codigo_Contrato from Contratos  
end
GO  

/*---------------------------------------------Procedimiento Llenar ComboBox Tipo de Contrato------------------------------------------------*/
create procedure ComboboxTipoContrato
as
begin
	select Tipo_Contrato from TipoContrato 
end
GO

/*---------------------------------------------Procedimiento Llenar ComboBox de Vehiculos------------------------------------------------*/
create procedure ComboboxVehiculos
as
begin
	select Codigo_Vehiculo from Vehiculos
end
GO 

/*---------------------------------------------Procedimiento Ingreso de Nuevo Contrato------------------------------------------------*/
create procedure NuevoContrato
@Codigo_Contrato varchar(50),
@Cliente_Contrato varchar(50),
@Tipo_Contrato int,
@Fecha_Inicio_Contrato date,
@Monto_Contrato money,
@Fecha_Vencimiento date  
as
begin
	insert into Contratos (Codigo_Contrato, Cliente_Contrato, Tipo_Contrato, Fecha_Inicio_Contrato, Monto_Contrato, Fecha_Vencimiento, Estado_Contrato, Cod_Documento)
	values (@Codigo_Contrato, @Cliente_Contrato, @Tipo_Contrato, @Fecha_Inicio_Contrato, @Monto_Contrato, @Fecha_Vencimiento, '1', 'CTr')
end
GO

/*--------------------------------------Procedimiento para Crear una nueva Ruta---------------------------------------------------*/
create procedure NuevaRuta
	@Codigo_ruta varchar(50),
	@Nombre_Ruta varchar(100),
	@Descripcion_Ruta varchar(200),
	@Codigo_Contrato varchar(50)
as
begin
	insert into Rutas (Codigo_Ruta, Nombre_Ruta, Descripcion_Ruta, Codigo_Contrato)
	values (@Codigo_ruta, @Nombre_Ruta, @Descripcion_Ruta, @Codigo_Contrato) 
end
GO

/*--------------------------------------Procedimiento para Asignar Horarios y Vehiculos a una Ruta---------------------------------------------------*/
create procedure AsignarHoraVeh
	@Codigo_ruta varchar(50),
	@Codigo_Vehiculo varchar(50),
	@Horario_Salida time(7),
	@Horario_Entrada time(7)
as
begin
	insert into Vehiculos_Rutas (Codigo_Ruta, Codigo_Vehiculo, Horario_Salida, Horario_Entrada)
	values (@Codigo_ruta, @Codigo_Vehiculo, @Horario_Salida, @Horario_Entrada)
end
GO


/*---------------------------------------------Procedimiento Llenar ComboBox Rutas------------------------------------------------*/
create procedure  ComboboxRutas
as 
begin
	select Codigo_Ruta from Rutas
	group by Codigo_Ruta
end 
GO 
 

