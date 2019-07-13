USE Transporte_Bonilla
GO
/* Procedimientos Almacenados NUEVO CLIENTE */  

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
	--Se agrega el Nombre de Cliente para mejor visualizaci�n
	select con.Codigo_Contrato+' - '+cli.Nombre_Cliente 'Contratos' from Contratos con
	inner join Cliente cli on con.Cliente_Contrato = cli.Codigo_Cliente 
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
/*---------------------------------------------Procedimiento Llenar ComboBox de Vehiculos seg�n Ruta y Horario ------------------------------------------------*/
create procedure ComboboxVehiculosRH
@Codigo_Ruta varchar(50),
@Horario varchar(15)
as
begin
	select vr.Codigo_Vehiculo from Vehiculos_Rutas vr
	inner join Vehiculos v on vr.Codigo_Vehiculo = v.Codigo_Vehiculo
	where (vr.Codigo_Ruta = @Codigo_Ruta) and (CONVERT(varchar(15),CAST(vr.Horario_Salida AS TIME),100)+' '+CONVERT(varchar(15),CAST(vr.Horario_Entrada AS TIME),100) = @Horario)
	and (vr.Cantidad_Pasajeros_Actuales < v.Capacidad_Vehiculo)    
end
GO 


/*---------------------------------------------Procedimiento Etiqueta Descripcion de Vehiculos------------------------------------------------*/
create procedure DescVehiculos
@Codigo_Vehiculo varchar(50) 
as
begin
	select Marca_Vehiculo+' '+Modelo_Vehiculo+' '+Color_Vehiculo 'Descripcion' from Vehiculos
	where Codigo_Vehiculo = @Codigo_Vehiculo 
end 
GO
/*---------------------------------------------Procedimiento Ingreso de Nuevo Contrato------------------------------------------------*/
create procedure NuevoContrato
@Anio_Contrato varchar(4),
@Nombre_Cliente_Contrato varchar(100),
@Id_Cliente_Contrato varchar(50),
@Tipo_Contrato int,
@Fecha_Inicio_Contrato date,
@Monto_Contrato money,
@Fecha_Vencimiento date,
@Monto_Mensual money,
@Cuotas_Mensuales int,
@Servicio varchar(50),
@Anticipo money,
@Tipo_Pago varchar(50)
as 
BEGIN 

	insert into Contratos 
	select CONCAT(@Anio_Contrato,'-',COUNT(*)+1,'-',SUBSTRING(@Nombre_Cliente_Contrato,1,1)), @Id_Cliente_Contrato, @Tipo_Contrato, @Monto_Mensual, 
	@Cuotas_Mensuales, @Servicio, @Anticipo, @Fecha_Inicio_Contrato, @Monto_Contrato, @Fecha_Vencimiento, '1', 'CTr',@Tipo_Pago from Contratos
END 
GO  
/* NO--------------------------------------Procedimiento para Crear una nueva Ruta---------------------------------------------------*/
create procedure NuevaRuta
	@Codigo_ruta varchar(50),
	@Nombre_Ruta varchar(100),
	@Descripcion_Ruta varchar(200),
	@Tipo_Ruta varchar(50)
as
begin
	insert into Rutas (Codigo_Ruta, Nombre_Ruta, Descripcion_Ruta, Tipo_Ruta)
	values (@Codigo_ruta, @Nombre_Ruta, @Descripcion_Ruta, @Tipo_Ruta)
end
GO
/*--------------------------------------Procedimiento para Vincular Ruta con Contrato---------------------------------------------------*/
create procedure RutaContrato
	@Codigo_ruta varchar(50),
	@Parada_Contrato varchar(50),
	@Anio_Contrato varchar(4),
	@Nombre_Cliente_Contrato varchar(100)      
as
begin
	--Variable para sacar el Contrato que se acaba de crear  
	declare @Cod_Contrato as varchar(50)
		
	set @Cod_Contrato = (select CONCAT(@Anio_Contrato,'-',COUNT(*),'-',SUBSTRING(@Nombre_Cliente_Contrato,1,1)) from Contratos)

	insert into Rutas_Contratos(Codigo_Ruta, Codigo_Contrato, Parada_Contrato)
	values (@Codigo_ruta, @Cod_Contrato, @Parada_Contrato)   
end 
GO
/*--------------------------------------Procedimiento para Asignar Horarios y Vehiculos a una Nueva Ruta---------------------------------------------------*/
create procedure AsignarHoraVeh
	@Codigo_ruta varchar(50),
	@Codigo_Vehiculo varchar(50),
	@Horario_Salida time(7),
	@Horario_Entrada time(7),
	@Pasajeros int
as
begin
	insert into Vehiculos_Rutas (Codigo_Ruta, Codigo_Vehiculo, Horario_Salida, Horario_Entrada, Cantidad_Pasajeros_Actuales)
	values (@Codigo_ruta, @Codigo_Vehiculo, @Horario_Salida, @Horario_Entrada, @Pasajeros)
end
GO 
/*--------------------------------------Procedimiento para Actualizar cantidad de pasajeros de una Ruta---------------------------------------------------*/
create procedure Pasajeros
	@Codigo_ruta varchar(50),
	@Codigo_Vehiculo varchar(50),
	@Horario varchar(50) 
as
begin
	update Vehiculos_Rutas
	set Cantidad_Pasajeros_Actuales = Cantidad_Pasajeros_Actuales + 1
	where (Codigo_Ruta = @Codigo_ruta) and (Codigo_Vehiculo = @Codigo_Vehiculo) and (CONVERT(varchar(15),CAST(Horario_Salida AS TIME),100)+' '+CONVERT(varchar(15),CAST(Horario_Entrada AS TIME),100) = @Horario)
end
GO
--VERIFICAR CANT DE PASAJEROS IF EXCEDE CAPACIDAD VEHICULO RETURN 1 ELSE 0

/*---------------------------------------------Procedimiento Llenar ComboBox Rutas------------------------------------------------*/
create procedure ComboboxRutas
as 
begin
	select Codigo_Ruta from Rutas
	where Tipo_Ruta = 'Temporal'
	group by Codigo_Ruta
end 
GO  
/*---------------------------------------------Procedimiento Llenar ComboBox Horarios------------------------------------------------*/
create procedure ComboboxHorarios
@Codigo_Ruta varchar(50)
as
begin
	select CONVERT(varchar(15),CAST(Horario_Salida AS TIME),100)+' '+CONVERT(varchar(15),CAST(Horario_Entrada AS TIME),100) 'Horarios'
	from Vehiculos_Rutas
	where Codigo_Ruta = @Codigo_Ruta   
end
GO
/*--------------------------------------------- Procedimiento Verificar Cliente Existente ------------------------------------------------*/
create procedure VerificarCliente
@Codigo_Cliente varchar(50)
as
begin
	select COUNT(*) from Cliente where Codigo_Cliente = @Codigo_Cliente
end
GO
/*--------------------------------------------- Procedimiento Verificar Ruta Existente ------------------------------------------------*/
create procedure VerificarRuta
@Codigo_Ruta varchar(50)
as
begin
	select COUNT(*) from Rutas where Codigo_Ruta = @Codigo_Ruta
end
GO
/*--------------------------------------------- Procedimiento Verificar Horario Existente para Vehiculos ------------------------------------------------*/
create procedure VerificarHoraVeh
@Codigo_Vehiculo varchar(50),
@Horario_Salida time(7) 
as
begin 
	select COUNT(*) from Vehiculos_Rutas where (Codigo_Vehiculo = @Codigo_Vehiculo) and ( @Horario_Salida between (CONVERT(varchar(15),CAST([Horario_Salida] AS TIME),100)) and (CONVERT(varchar(15),CAST([Horario_Entrada] AS TIME),100)))    
end 
GO
/*--------------------------------------------- Procedimiento Verificar Capacidad para Vehiculos en Viajes------------------------------------------------*/
create procedure VerificarCap
@Codigo_Vehiculo varchar(50),
@Pasajeros int
as
begin
	declare @cap as int

	set @cap = (select Capacidad_Vehiculo from Vehiculos where Codigo_Vehiculo = @Codigo_Vehiculo)
	
	if(@Pasajeros > @cap)
		select 1;
	else
		select 0;
end
GO
/* ----------------------------------------------------Procedimientos Almacenados USUARIOS---------------------------------------------------------- */

/*Procedimiento para el Inicio del Sitema*/
	--Entrar al sistema
	create procedure Entrar_Sistema
		@Nombre_Usuario varchar(100),
		@Contrasena_Usuario varchar(100)
		as
	begin
		select p.Nivel_Acceso from [dbo].[Usuarios] u
		inner join [dbo].[Perfiles] p  on u.Perfil_Acceso=p.Codigo_Perfil
		where u.Nombre_Usuario=@Nombre_Usuario and
		u.Contrasena_Usuario=@Contrasena_Usuario
	end
	GO
	--Verificacion de Correo
	create procedure VerificarCorreo
	@Nombre_Usuario varchar(100),
	@Correo varchar(100)
	as
	begin
		select COUNT(*) from Transporte_Bonilla.dbo.Empleado e
		inner join Usuarios u on u.Codigo_Empleado=e.Identidad_Empleado
		where u.Nombre_Usuario=@Nombre_Usuario and e.Correo=@Correo
	end
	GO
	create procedure CambioContrasena
	@Nombre_Usuario varchar(100)
	as
	begin
		update Transporte_Bonilla.dbo.Usuarios 
		set  Contrasena_Usuario=REVERSE(Nombre_Usuario+SUBSTRING(Contrasena_Usuario,1,3)+SUBSTRING(REVERSE(Codigo_Empleado),1,1))
		where Nombre_Usuario=@Nombre_Usuario
	end
	begin
		select  Contrasena_Usuario
		from Transporte_Bonilla.dbo.Usuarios 
		where Nombre_Usuario=@Nombre_Usuario
	end
	GO
	/*Cargar comboBox de Perfiles */
		create procedure cargarPerfiles
		as
		begin
			select p.Codigo_Perfil, p.Nombre_Perfil from [dbo].[Perfiles] p
		end
		GO
/*Procedimiento para Crear un Nuevo Usuario*/
	--Nuevo Usuario--
	create procedure NuevoUsuario
		@Codigo_Empleado varchar(50),
		@Nombre_Usuario varchar(100),
		@Contrasena_Usuario varchar(100),
		@Codigo_Perfil int
	
	as
	begin
		insert into [dbo].[Usuarios]
		values(
		@Codigo_Empleado,
		@Nombre_Usuario,
		@Contrasena_Usuario,
		@Codigo_Perfil
		)
	end
	GO
	--Verificacion si Empleado tiene usuario--
	create procedure verificar_empleado_usuario
	@Codigo_Empleado varchar(50)
	as
	begin
		select COUNT(*) from [dbo].[Usuarios] u where u.Codigo_Empleado=@Codigo_Empleado
	end
	GO
	--Verificacion si existe esa contrase�a con ese usuario
	create procedure VerificarContrasena
	@contra varchar (100),
	@identidad varchar(50)
	as
	begin
		select COUNT(*) FROM [dbo].[Usuarios] U WHERE U.Contrasena_Usuario=@contra and U.Codigo_Empleado=@identidad
	end
	GO
	--Verificacion si Ya existe ese usuario
	create procedure VerificarUsuario
	@Nombre_Usuario varchar(100)
	as
	begin
		select COUNT(*) FROM [dbo].[Usuarios] U WHERE U.Nombre_Usuario=@Nombre_Usuario
	END
	GO
	--verificar si existe ese empleado
	create procedure VerificarEmpleado
	@Codigo_Empleado varchar(50)
	as
	begin
		select COUNT(*) FROM [dbo].[Empleado] E WHERE E.Identidad_Empleado=@Codigo_Empleado
	END
	GO

/*---------------------------------Procedimientos Para Modificar usuarios---------------------------------*/
	--BuscarUsuarios
	create procedure BuscarUsuario
		@Codigo_Empleado  varchar(100)
	as
	begin
		select U.Nombre_Usuario,U.Contrasena_Usuario, U.Perfil_Acceso from Usuarios U where u.Codigo_Empleado=@Codigo_Empleado
	end
	GO
	--Modificar Usuario--
	create procedure ModificarUsuario
		@Codigo_Empleado as varchar(50),
		@Nombre_Usuario varchar(100),
		@Contrasena_Usuario varchar(100),
		@Perfil_Acceso int 
	as
	begin
		update [dbo].[Usuarios] 
		set Nombre_Usuario=@Nombre_Usuario,
		Contrasena_Usuario=@Contrasena_Usuario,
		Perfil_Acceso=@Perfil_Acceso
		where @Codigo_Empleado=Codigo_Empleado
	end
	GO
/*---------------------------------------Procedimientos Para perfiles------------------------------------*/
	--Crear Perfil
	create procedure CrearPerfil
		@Nivel_Acceso int,
		@Nombre_Perfil varchar(100),
		@Descripcion_Perfil varchar(200)
	as
		begin 
			insert into Transporte_Bonilla.dbo.Perfiles
			select COUNT(*)+1, @Nivel_Acceso,@Nombre_Perfil,@Descripcion_Perfil from [dbo].[Perfiles]
		end
	GO
	--Verificacion de Perfil
	create procedure VerificarPerfil
		@Nombre_Perfil as varchar(100)
	as
		begin
			select COUNT(*) from Transporte_Bonilla.dbo.Perfiles p
			where @Nombre_Perfil=p.Nombre_Perfil
		end
	GO
	--Mostrar Informacion Perfil
	create procedure InfoPerfil
		@Codigo_Perfil int
	as
		begin
			select  P.Nivel_Acceso,  P.Nombre_Perfil, P.Descripcion_Perfil from Transporte_Bonilla.dbo.Perfiles P 
			where Codigo_Perfil=@Codigo_Perfil 
		END
	GO
/*-------------------------------------------------------Modificar Perfil -----------------------------------------------------*/
	--Modificar Perfil
	create procedure ModificarPerfil
	@Codigo_Perfil int,
	@Nivel_Acceso int,
	@Nombre_Perfil varchar(100),
	@Descripcion_Perfil varchar(200)
	as
	begin
		update [Transporte_Bonilla].[dbo].[Perfiles]
		set Nivel_Acceso=@Nivel_Acceso,
		Nombre_Perfil=@Nombre_Perfil,
		Descripcion_Perfil=@Descripcion_Perfil
		where Codigo_Perfil=@Codigo_Perfil
	end
	GO
-----------------------------------------------------------Consultas de Usuarios------------------------------------------------------*/
create procedure consultasusuario
		@TipoConsulta as varchar(50)
	as
	if @TipoConsulta='Usuarios'
		Begin
			select e.Nombre_Empleado'Empleado', u.Nombre_Usuario'Usuario',convert(varchar(50),ENCRYPTBYPASSPHRASE(u.Codigo_Empleado,u.Contrasena_Usuario))'Contrasena',
			p.Nombre_Perfil'Perfil Usuario',a.Tipo_Acceso'Acceso Usuario'
			from dbo.Usuarios u
			inner join dbo.Empleado e on u.Codigo_Empleado = e.Identidad_Empleado
			inner join dbo.Perfiles p on u.Perfil_Acceso = p.Codigo_Perfil
			inner join dbo.Acceso a on p.Nivel_Acceso = a.Codigo_Acceso
		end
	if @TipoConsulta='Perfiles'
		Begin
			select p.Codigo_Perfil'Codigo del Perfil',p.Nombre_Perfil'Perfil',p.Descripcion_Perfil'Descripci�n Perfil',
			a.Tipo_Acceso'Acceso del Perfil'
			from dbo.Perfiles p
			inner join dbo.Acceso a on p.Nivel_Acceso = a.Codigo_Acceso
		end
	if @TipoConsulta='Niveles de Acceso'
		Begin
			select a.Codigo_Acceso 'Codigo del Acceso', a.Tipo_Acceso 'Acceso', a.Descripcion_Acceso'Descripci�n Acceso'
			from dbo.Acceso a
end
GO
/*------------------------------------------------------Consultar Clientes---------------------------------------------*/
create procedure consultaclientes
		@consultacliente as varchar(50)
	as
begin
	if @consultacliente = 'Clientes'
	select c.Codigo_Cliente'Identificador del Cliente', c.Nombre_Cliente'Nombre del Cliente',c.Telefono_Cliente'Telefono del Cliente',
	c.Correo_Cliente'Correo del Cliente', c.Direccion_Cliente'Direccion del Cliente',count(co.Codigo_Contrato)'Contratos del Cliente'
	from dbo.Cliente c
	inner join dbo.Contratos co on c.Codigo_Cliente = co.Cliente_Contrato
	group by c.Codigo_Cliente,c.Correo_Cliente,c.Direccion_Cliente,c.Nombre_Cliente,c.Telefono_Cliente
	if @consultacliente ='Contratos por Cliente'
	select c.Nombre_Cliente'Cliente del Contrato',c.Telefono_Cliente'Contacto del Cliente', co.Codigo_Contrato'Contrato',tc.Tipo_Contrato'Tipo de Contrato',e.Nombre_Estado'Estado Contrato'
	from  dbo.Cliente c
	inner join dbo.Contratos co on c.Codigo_Cliente = co.Cliente_Contrato
	inner join dbo.TipoContrato tc on co.Tipo_Contrato = tc.Cod_Contrato
	inner join dbo.Estado e on co.Estado_Contrato = e.Codigo_Estado
end
GO
/*------------------------------------------------------Consultar Rutas---------------------------------------------*/
create procedure consultarutas
		@consultacliente as varchar(50)
	as
begin
	if @consultacliente = 'Rutas Generales'
	select r.Codigo_Ruta'Codigo Ruta',r.Nombre_Ruta'Paradas de la Ruta' from Rutas r
	where r.Tipo_Ruta='Temporal';
	if @consultacliente ='Rutas de Clientes'
	select r.Codigo_Ruta'Codigo Ruta',cl.Nombre_Cliente'Cliente de la Ruta',c.Codigo_Contrato'Contrato del Cliente', 
	concat(v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Vehiculo de la Ruta',concat(Cast(vr.Horario_Salida as time(0)),'-',cast(vr.Horario_Entrada as time(0)))'Hora de Ruta'
	, rc.Parada_Contrato'Se Baja en:',c.Servicio'Servicio de Ruta' from Rutas R
	inner join Rutas_Contratos rc on r.Codigo_Ruta = rc.Codigo_Ruta
	inner join Vehiculos_Rutas vr on r.Codigo_Ruta = vr.Codigo_Ruta
	inner join Contratos c on rc.Codigo_Contrato = c.Codigo_Contrato
	inner join Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
	inner join Vehiculos v on vr.Codigo_Vehiculo = v.Codigo_Vehiculo
	if @consultacliente ='Rutas Viajes Privados'
	select r.Codigo_Ruta'Codigo Viaje',r.Nombre_Ruta'Nombre de Viaje',r.Descripcion_Ruta'Descripcion Viaje',rc.Parada_Contrato'Final de Viaje', c.Servicio'Tipo de Viaje' from Rutas r
	inner join Rutas_Contratos rc on r.Codigo_Ruta = rc.Codigo_Ruta
	inner join Contratos c on rc.Codigo_Contrato = c.Codigo_Contrato
	where r.Tipo_Ruta='Viaje';

end
GO
/*---------------------------------------------Procedimiento Llenar ComboBox Clientes------------------------------------------------*/
create procedure ComboboxClientes
as
begin
	select Nombre_Cliente,Codigo_Cliente from DBO.Cliente
end
GO
/*---------------------------------------------Procedimiento Llenar ComboBox Puestos------------------------------------------------*/
create procedure ComboboxPuesto
as
begin
	select Nombre_Puesto,Codigo_Puesto from DBO.Puesto
end
GO
/*---------------------------------------------Procedimiento Llenar ComboBox Estados Contrato------------------------------------------------*/
create procedure ComboboxEstados
As
begin
	select Codigo_Estado,Nombre_Estado from dbo.Estado
	where Codigo_Categoria ='CT' 
end
GO
/*---------------------------------------------Procedimiento LLenar DGV Contratos------------------------------------------------*/
create procedure LLenarDVG
as
begin
	select c.Codigo_Contrato'Codigo del Contrato',cl.Nombre_Cliente 'Due�o del Contrato', tp.Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalizacion del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.TipoContrato tp on c.Tipo_Contrato = tp.Cod_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
end
go

/*------------------------------------------------------Filtrar Contratos---------------------------------------------*/
create procedure filtrarcontratos
		@tipobusqueda as varchar(50),
		@filtro as varchar(50)
	as
begin
	if @tipobusqueda = 'Clientes'
	select c.Codigo_Contrato'Codigo del Contrato',cl.Nombre_Cliente 'Due�o del Contrato', tp.Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalizacion del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.TipoContrato tp on c.Tipo_Contrato = tp.Cod_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
	where cl.Codigo_Cliente = @filtro;
	if @tipobusqueda = 'Estados'
	select c.Codigo_Contrato'Codigo del Contrato',cl.Nombre_Cliente 'Due�o del Contrato', tp.Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalizacion del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.TipoContrato tp on c.Tipo_Contrato = tp.Cod_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
	where e.Codigo_Estado = @filtro;
end
GO

/*----------------------------------Modificar cliente-----------------------------------*/

create procedure ModificarCliente
@Codigo_Cliente varchar(50),
@Nombre_Cliente varchar(100),
@Direccion_Cliente varchar(200),
@Telefono_Cliente varchar (20),
@Correo_Cliente varchar (50)
as
begin
	update Cliente
	set Nombre_Cliente = @Nombre_Cliente,
	Direccion_Cliente = @Direccion_Cliente,
	Telefono_Cliente = @Telefono_Cliente,
	Correo_Cliente = @Correo_Cliente
	where Codigo_Cliente = @Codigo_Cliente
end
GO
/*-------------------Cargar Cliente-------------------------------*/

create procedure CargarCliente
@Cod_Client varchar (50)
as 
begin
	select Nombre_Cliente, Direccion_Cliente, Telefono_Cliente, Correo_Cliente from Cliente
	where Codigo_Cliente = @Cod_Client
end
GO
/*---------------------Consulta Unica Cliente----------------------------*/

create procedure ConsultaUnicaCliente
as
begin
	select Codigo_Cliente'Codigo Cliente', Nombre_Cliente'Nombre del Cliente', Direccion_Cliente'Direccion del Cliente', Telefono_Cliente'Telefono del Cliente', Correo_Cliente'Correo del Cliente' 
	from CLiente 
end
GO
/*
select * from Estado
*/

/*--------------------------------Procedimiento Modificar Contrato------------------------------------*/

Create procedure ModificarContrato
@Codigo_Contrato varchar(50),
@Monto_Contrato money,
@Fecha_Vencimiento date,
@Estado_Contrato int
as
begin
	update Contratos
	set Monto_Contrato = @Monto_Contrato,
	Fecha_Vencimiento = @Fecha_Vencimiento,
	Estado_Contrato = @Estado_Contrato
	where Codigo_Contrato = @Codigo_Contrato
end
GO

/*-----------------Carga dgv Contrato------------------*/
Create procedure CargadgvContrato1
as
begin
	select cli.Codigo_Cliente'Codigo_Cliente', cli.Nombre_Cliente'Cliente Afiliado al contrato'
	from Cliente cli
end
GO
/*-------------------Carga dgv Datos contrato del cliente------------------*/
/*
select * from Contratos
*/
create procedure CargadgvDatoContratoCliente
@Cod_Cliente varchar(50)
as
begin
	select c.Codigo_Contrato'Nombre del Contrato', c.Fecha_Inicio_Contrato'Fecha de inicio del Contrato', c.Monto_Contrato'Monto del Contrato', 
	c.Fecha_Vencimiento'Fecha de vencimiento del contrato' , e.Nombre_Estado'Estado del Contrato'
	from Contratos c
	inner join Estado e on c.Estado_Contrato = e.Codigo_Estado
	where Cliente_Contrato = @Cod_Cliente
end
GO
/*
exec CargadgvDatoContratoCliente '0002'
*/
/*-------------------Carga Combobox Modificar Contrato--------------------------*/
create procedure ComboModContrato
As
begin
	select Codigo_Estado,Nombre_Estado from dbo.Estado
	where Codigo_Categoria ='CT' 
end
GO
/*-------------------------------------LO MIO DE MI PARTE--------------------------*/
/*---------------------------------------------Procedimiento Ingreso de Nuevo Empleado Actualizado------------------------------------------------*/
CREATE procedure [dbo].[NuevoEmpleado]
@Identidad varchar(50),   
@Nombr varchar(100),
@FNacimiento date,
@Genero as int,
@Telefono varchar(20), 
@Correo varchar(100),
@Direccion varchar(200),
@Puesto int,
@Salario money,
@Licencia varchar(50),
@FechaVLic as Date
as 
begin
	if(@Puesto=9)
	begin
	insert into Empleado values
	(@Identidad,@Nombr,@FNacimiento,@Genero,@Telefono,@Correo,@Direccion,@Puesto,@Salario,@Licencia,@FechaVLic)
	end
	else
	begin
	insert into Empleado values
	(@Identidad,@Nombr,@FNacimiento,@Genero,@Telefono,@Correo,@Direccion,@Puesto,@Salario,'N/A',null)
	end
	
end
GO
/*---------------------------------------------Procedimiento LLenar DGV Empleados Actualizado------------------------------------------------*/
create procedure DatosDVGEmpleados
as
begin
	select e.Identidad_Empleado'Identidad Empleado',e.Nombre_Empleado'Nombre Empleado',e.Fecha_Nacimiento'Fecha Nacimiento',
	g.Genero,E.Telefono,e.Correo,e.Direccion,p.Nombre_Puesto'Puesto Empleado',ROUND(e.Salario,2)'Salario'
	from Empleado E
	inner join Puesto p on E.Puesto_Empleado = P.Codigo_Puesto
	inner join Genero g on e.Genero = g.CodGenero;
end
GO
/*---------------------------------------------Procedimiento Buscar Empleado------------------------------------------------*/
create procedure [dbo].[BuscarEmpleado]
@Codigo_Empleado  varchar(100)
as
begin
	select e.Nombre_Empleado,e.Genero,e.Telefono,e.Correo,e.Direccion,e.Puesto_Empleado,
	e.salario,e.Licencia,e.Fecha_Vencimiento_Licencia from Empleado e
	where e.Identidad_Empleado=@Codigo_Empleado
end
GO
/*---------------------------------------------Procedimiento Cargar Generos------------------------------------------------*/
create procedure [dbo].[cargarGenero]
as
begin
	select g.CodGenero'Codigo', g.Genero'Gen' from dbo.Genero g
end
go
/*---------------------------------------------Procedimiento Filtro Encargado Vehiculos------------------------------------------------*/
create procedure [dbo].[ComboboEncVehiculos]
as
begin
	select e.Identidad_Empleado'Identidad',e.Nombre_Empleado'Nombre' from Empleado e
	inner join Vehiculos v on e.Identidad_Empleado = v.Responsable_Vehiculo
	group by e.Nombre_Empleado,e.Identidad_Empleado
end
go
/*---------------------------------------------Procedimiento Filtro Empleados Conductores------------------------------------------------*/
CREATE procedure [dbo].[ComboboxEmpleados]
as
begin
select e.Identidad_Empleado'codigo',e.Nombre_Empleado'Nombre' from Empleado e
where e.Puesto_Empleado=9;
end
Go
/*---------------------------------------------Procedimiento Filtro Estado Vehiculos------------------------------------------------*/
create procedure [dbo].[ComboboxEVehiculos]
as
begin
	select e.Codigo_Estado'Codigo',e.Nombre_Estado'Estado' from Estado e
	where e.Codigo_Categoria ='VE'
end
GO
/*---------------------------------------------Procedimiento Filtro Marca Vehiculos------------------------------------------------*/
create procedure [dbo].[ComboboxMVehiculos]
as
begin
	select v.Marca_Vehiculo'Marca' from Vehiculos v
end
GO
/*---------------------------------------------Procedimiento Filtro Tipo Vehiculos------------------------------------------------*/
create procedure [dbo].[ComboboxTVehiculos]
as
begin
	select v.Tipo_Vehiculo'Tipo' from Vehiculos v
	group by v.Tipo_Vehiculo
end
GO
/*---------------------------------------------Procedimiento Datagridview Datos Simples Vehiculos------------------------------------------------*/
Create procedure [dbo].[DatosVehiculosSencillos]
as
begin
select v.Codigo_Vehiculo'Placa',CONCAT(tv.Tipo_Vehiculo,' ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo,' ',v.Capacidad_Vehiculo,' Asientos')'Descripcion Vehiculo',tt.NombreTransmision'Transmision',tg.NombreGasolina'Tipo Combustible',e.Nombre_Estado'Estado Vehiculo',ep.Nombre_Empleado'Responsable' from Vehiculos v
inner join TipoVehiculo tv on v.Tipo_Vehiculo=tv.CodVehiculo
inner join TipoTransmision tt on v.Transmision_Vehiculo = tt.CodTransmision
inner join TipoGasolina tg on v.Combustible_Vehiculo = tg.CodGasolina
inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
end
GO
/*---------------------------------------------Procedimiento Datagridview Datos al Asignar un Vehiculo------------------------------------------------*/
CREATE procedure [dbo].[DatosVehiculosSencillosAsignar]
as
begin
select v.Codigo_Vehiculo'Placa',CONCAT(tv.Tipo_Vehiculo,' ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo,' ',v.Capacidad_Vehiculo,' Asientos')'Descripcion Vehiculo',tt.NombreTransmision 'Transmision',
e.Nombre_Estado 'Estado Vehiculo','Sin Asignar' as 'Responsable' from Vehiculos v
inner join TipoVehiculo tv on v.Tipo_Vehiculo=tv.CodVehiculo
inner join TipoTransmision tt on v.Transmision_Vehiculo = tt.CodTransmision
inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
where v.Responsable_Vehiculo is null
end
GO
/*---------------------------------------------Procedimiento Datagridview Datos al Devolver un Vehiculo------------------------------------------------*/
Create procedure [dbo].[DatosVehiculosSencillosdevolver]
as
begin
select v.Codigo_Vehiculo'Placa',CONCAT(tv.Tipo_Vehiculo,' ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo,' ',v.Capacidad_Vehiculo,' Asientos')'Descripcion Vehiculo',tt.NombreTransmision'Transmision',e.Nombre_Estado'Estado Vehiculo',ep.Nombre_Empleado'Responsable' from Vehiculos v
inner join TipoVehiculo tv on v.Tipo_Vehiculo=tv.CodVehiculo
inner join TipoTransmision tt on v.Transmision_Vehiculo = tt.CodTransmision
inner join TipoGasolina tg on v.Combustible_Vehiculo = tg.CodGasolina
inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
where v.Responsable_Vehiculo is not null;
end
GO
/*---------------------------------------------Procedimiento Modificar al Asignar/Devolver un Vehiculo------------------------------------------------*/
Create procedure [dbo].[devolverasignarunidades]
@tipo as int,
@empleado as varchar(50),
@placa as varchar(50)
as
begin
if(@tipo=1)
begin
update Vehiculos
set Responsable_Vehiculo=@empleado
where Codigo_Vehiculo=@placa;
end
if(@tipo=2)
update Vehiculos
set Responsable_Vehiculo=NULL
where Codigo_Vehiculo=@placa;
end
GO
/*---------------------------------------------Procedimiento Filtrar Datos DGV empleados------------------------------------------------*/
Create procedure [dbo].[FiltrarDatosDVGEmpleados]
@puesto as int
as
begin
	select e.Identidad_Empleado'Identidad Empleado',e.Nombre_Empleado'Nombre Empleado',e.Fecha_Nacimiento'Fecha Nacimiento',
	g.Genero,E.Telefono,e.Correo,e.Direccion,p.Nombre_Puesto'Puesto Empleado',ROUND(e.Salario,2)'Salario'
	from Empleado E
	inner join Puesto p on E.Puesto_Empleado = P.Codigo_Puesto
	inner join Genero g on e.Genero = g.CodGenero
	where e.Puesto_Empleado=@puesto;
end
GO
/*---------------------------------------------Procedimiento Filtrar Datos DGV Vehiculos------------------------------------------------*/
create procedure [dbo].[filtrarvehiculos]
		@tipobusqueda as varchar(50),
		@filtro as varchar(50)
	as
begin
	if @tipobusqueda = 'Marca Vehiculo'
	select v.Codigo_Vehiculo'Placa',v.Tipo_Vehiculo'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripcion',v.Capacidad_Vehiculo'Capacidad Vehiculo',
	v.Transmision_Vehiculo'Transmision Vehiculo',v.Combustible_Vehiculo'Combustible Vehiculo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehiculo',ep.Nombre_Empleado'Reponsable' from Vehiculos v
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
	where v.Marca_Vehiculo=@filtro;
	if @tipobusqueda = 'Tipo Vehiculo'
	select v.Codigo_Vehiculo'Placa',v.Tipo_Vehiculo'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripcion',v.Capacidad_Vehiculo'Capacidad Vehiculo',
	v.Transmision_Vehiculo'Transmision Vehiculo',v.Combustible_Vehiculo'Combustible Vehiculo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehiculo',ep.Nombre_Empleado'Reponsable' from Vehiculos v
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
	where v.Tipo_Vehiculo=@filtro;
	if @tipobusqueda = 'Estado Vehiculo'
	select v.Codigo_Vehiculo'Placa',v.Tipo_Vehiculo'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripcion',v.Capacidad_Vehiculo'Capacidad Vehiculo',
	v.Transmision_Vehiculo'Transmision Vehiculo',v.Combustible_Vehiculo'Combustible Vehiculo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehiculo',ep.Nombre_Empleado'Reponsable' from Vehiculos v
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
	where v.Estado_Vehiculo=@filtro;
	if @tipobusqueda = 'Responsable Vehiculo'
	select v.Codigo_Vehiculo'Placa',v.Tipo_Vehiculo'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripcion',v.Capacidad_Vehiculo'Capacidad Vehiculo',
	v.Transmision_Vehiculo'Transmision Vehiculo',v.Combustible_Vehiculo'Combustible Vehiculo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehiculo',ep.Nombre_Empleado'Reponsable' from Vehiculos v
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
	where v.Responsable_Vehiculo=@filtro;
end
GO
/*---------------------------------------------Procedimient Llenar Datos DGV Vehiculos Completos------------------------------------------------*/
CREATE procedure [dbo].[LLenarDVGvehiculos]
as
begin
	select v.Codigo_Vehiculo'Placa',tv.Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripcion',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehiculo',
	tt.NombreTransmision 'Transmision Vehiculo',tg.NombreGasolina 'Combustible Vehiculo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehiculo',e.Nombre_Estado'Estado',ep.Nombre_Empleado'Reponsable' from Vehiculos v
	inner join TipoVehiculo tv on v.Tipo_Vehiculo=tv.CodVehiculo
	inner join TipoTransmision tt on v.Transmision_Vehiculo = tt.CodTransmision
	inner join TipoGasolina tg on v.Combustible_Vehiculo = tg.CodGasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
end
GO
/*---------------------------------------------Procedimient Modificar Datos de un Empleado------------------------------------------------*/
Create procedure [dbo].[ModificarEmpleado]
@Identidad varchar(50),   
@Nombr varchar(100),
@Genero as int,
@Telefono varchar(20), 
@Correo varchar(100),
@Direccion varchar(200),
@Puesto int,
@Salario money,
@Licencia varchar(50),
@FechaVLic as Date
as 
begin
	if(@Puesto=9)
	begin
	update Empleado 
	set
	Nombre_Empleado= @Nombr,
	Genero= @Genero,
	Telefono= @Telefono,
	Correo= @Correo,
	Direccion= @Direccion,
	Puesto_Empleado= @Puesto,
	Salario= @Salario,
	Licencia= @Licencia,
	Fecha_Vencimiento_Licencia= @FechaVLic
	where Identidad_Empleado=@Identidad
	end
	else
	begin
	update Empleado 
	set 
	Nombre_Empleado= @Nombr,
	Genero= @Genero,
	Telefono= @Telefono,
	Correo= @Correo,
	Direccion= @Direccion,
	Puesto_Empleado= @Puesto,
	Salario= @Salario,
	Licencia= 'N/A',
	Fecha_Vencimiento_Licencia= NULL
	where Identidad_Empleado=@Identidad
	end
end
GO