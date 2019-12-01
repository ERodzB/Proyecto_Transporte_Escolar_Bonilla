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
	--Se agrega el Nombre de Cliente para mejor visualización
	select con.Codigo_Contrato+' - '+cli.Nombre_Cliente 'Contratos' from Contratos con
	inner join Cliente cli on con.Cliente_Contrato = cli.Codigo_Cliente 
end
GO  

/*---------------------------------------------Procedimiento Llenar ComboBox Tipo de Contrato------------------------------------------------*/
create procedure ComboboxTipoContrato
as
begin
	select Nombre_Tipo_Contrato from Tipo_Contrato 
end
GO

/*---------------------------------------------Procedimiento Llenar ComboBox de Vehiculos------------------------------------------------*/
create procedure ComboboxVehiculos
as
begin
	select Codigo_Vehiculo from Vehiculos
end
GO 
/*---------------------------------------------Procedimiento Llenar ComboBox de Vehiculos según Ruta y Horario ------------------------------------------------*/
create procedure ComboboxVehiculosRH
@Codigo_Ruta varchar(50),
@Horario varchar(15)
as
begin
	select vr.Codigo_Vehiculo from Vehiculos_Rutas vr
	inner join Vehiculos v on vr.Codigo_Vehiculo = v.Codigo_Vehiculo
	where (vr.Codigo_Ruta = @Codigo_Ruta) and (CONVERT(varchar(15),CAST(vr.Horario_Salida as time(0)),100)+' '+CONVERT(varchar(15),CAST(vr.Horario_Entrada as time(0)),100) = @Horario)
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
/*--------------------------------Procedimiento para Extrar Inicio y Fin----------------------------------------------------------------------*/
create procedure InicioFinRuta
	@Codigo_Ruta varchar(50)
	as
begin
	select SUBSTRING(Codigo_Ruta,0,PATINDEX('%-%',Codigo_Ruta)),SUBSTRING(Codigo_Ruta,PATINDEX('%-%',Codigo_Ruta)+1,LEN(Codigo_Ruta)) 
	from Rutas WHERE Tipo_Ruta='Temporal' and Codigo_Ruta=@Codigo_Ruta
end
GO
/*---------------------------------------Procedimiento para Modificar Horarios-----------------------------------*/
create procedure Mantenimiento_Horarios
	@Codigo_Ruta varchar(50),
	@Codigo_Vehiculo varchar(50),
	@Horario_Salida time(7),
	@Horario_Entrada time(7),
	@Horario_Salida_Nuevo time(7),
	@Horario_Entrada_Nuevo time(7),
	@Decision as varchar(50)
	as
	if(@Decision='Modificar')
	begin
		update Vehiculos_Rutas
		set Codigo_Ruta=@Codigo_Ruta, Codigo_Vehiculo=@Codigo_Vehiculo, Horario_Salida=@Horario_Salida_Nuevo,Horario_Entrada=@Horario_Entrada_Nuevo
		where @Horario_Salida=CONVERT(varchar(15),Horario_Salida,100) and @Horario_Entrada=CONVERT(varchar(15),Horario_Entrada,100)
	end
	if(@Decision='Eliminar')
	begin
		delete from Vehiculos_Rutas
		where @Horario_Salida=CONVERT(varchar(15),Horario_Salida,100) and @Horario_Entrada=CONVERT(varchar(15),Horario_Entrada,100) and Codigo_Ruta=@Codigo_Ruta
	end
GO
/*-----------------------------------------------Modificar Rutas----------------------------------------*/
create procedure ModificarRutas
	@Codigo_Ruta varchar(50),
	@Nombre_Ruta varchar(100),
	@Descripcion_Ruta varchar(200),
	@Tipo_Ruta varchar(50)
	as
	begin
		select * from Rutas
	end
GO
/*--------------------------------------Procedimiento para Asignar Horarios y Vehiculos a una Nueva Ruta---------------------------------------------------*/
create procedure AsignarHoraVeh
	@Codigo_ruta varchar(50),
	@Codigo_Vehiculo varchar(50),
	@Horario_Salida time(0),
	@Horario_Entrada time(0),
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
	where (Codigo_Ruta = @Codigo_ruta) and (Codigo_Vehiculo = @Codigo_Vehiculo) and (CONVERT(varchar(15),CAST(Horario_Salida as time(0)),100)+' '+CONVERT(varchar(15),CAST(Horario_Entrada AS TIME),100) = @Horario)
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


/*---------------------------------------------Procedimiento Verificar si la Ruta se puede modificar------------------------------------------------*/
create procedure VerificarModiRuta
@codigo_ruta varchar(50)
as 
begin
	select COUNT(*) from Rutas_Contratos cr
	inner join Contratos c on cr.Codigo_Contrato = c.Codigo_Contrato
	where cr.Codigo_Ruta = @codigo_ruta and c.Estado_Contrato = 1
end 
GO



/*---------------------------------------------Procedimiento Llenar ComboBox Horarios------------------------------------------------*/
create procedure ComboboxHorarios
@Codigo_Ruta varchar(50)
as
begin
	select CONVERT(varchar(15),CAST(Horario_Salida as time(0)),100)+' '+CONVERT(varchar(15),CAST(Horario_Entrada as time(0)),100) 'Horarios'
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

/*Procedimiento para el Inicio del Sistema*/
	--Verificar Estado Usuario
	create procedure EstadoUsuario
		@Nombre_Usuario varchar(100),
		@Contrasena_Usuario varchar(100)
		as 
	begin
		select Estado_Usuario from [dbo].[Usuarios]
		where Nombre_Usuario=@Nombre_Usuario and
		Contrasena_Usuario=@Contrasena_Usuario
	end
	GO
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

	--Verificar cambio constante de Contraseñas por seguridad (CADA 3 MESES)
	create procedure VerificarActualizarContrasena
	@Nombre_Usuario varchar(100)
	as
	begin
		select Top 1 DATEDIFF(month, Fecha, GETDATE()) 'Meses sin actualizar' from Historial_usuarios
		where Nombre_Usuario = @Nombre_Usuario
		order by Fecha desc  
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
		@Codigo_Perfil,
		201
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
	--Verificacion si existe esa contraseña con ese usuario
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
		select U.Nombre_Usuario,U.Contrasena_Usuario, U.Perfil_Acceso, U.Estado_Usuario from Usuarios U where u.Codigo_Empleado=@Codigo_Empleado
	end
	GO
	--Modificar Usuario--
	create procedure ModificarUsuario
		@Codigo_Empleado as varchar(50),
		@Nombre_Usuario varchar(100),
		@Contrasena_Usuario varchar(100),
		@Perfil_Acceso int,
		@Estado_Usuario int
	as
	begin
		update [dbo].[Usuarios] 
		set Nombre_Usuario=@Nombre_Usuario,
		Contrasena_Usuario=@Contrasena_Usuario,
		Perfil_Acceso=@Perfil_Acceso,
		Estado_Usuario=@Estado_Usuario
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
			select COUNT(*) from Perfiles p
			where @Nombre_Perfil=p.Nombre_Perfil
		end
	GO
	--Mostrar Informacion Perfil
	create procedure InfoPerfil
		@Codigo_Perfil int
	as
		begin
			select  P.Nivel_Acceso,  P.Nombre_Perfil, P.Descripcion_Perfil from Perfiles P 
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
		update Perfiles
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
			select e.Nombre_Empleado'Empleado', u.Nombre_Usuario'Usuario',convert(varchar(50),ENCRYPTBYPASSPHRASE(u.Codigo_Empleado,u.Contrasena_Usuario))'Contraseña',
			p.Nombre_Perfil'Perfil Usuario',a.Tipo_Acceso'Acceso Usuario', s.Nombre_Estado 'Estado'
			from dbo.Usuarios u
			inner join dbo.Empleado e on u.Codigo_Empleado = e.Identidad_Empleado
			inner join dbo.Perfiles p on u.Perfil_Acceso = p.Codigo_Perfil
			inner join dbo.Acceso a on p.Nivel_Acceso = a.Codigo_Acceso
			inner join dbo.Estado s on u.Estado_Usuario = s.Codigo_Estado
		end
	if @TipoConsulta='Perfiles'
		Begin
			select p.Codigo_Perfil'Código del Perfil',p.Nombre_Perfil'Perfil',p.Descripcion_Perfil'Descripción Perfil',
			a.Tipo_Acceso'Acceso del Perfil'
			from dbo.Perfiles p
			inner join dbo.Acceso a on p.Nivel_Acceso = a.Codigo_Acceso
		end
	if @TipoConsulta='Niveles de Acceso'
		Begin
			select a.Codigo_Acceso 'Código del Acceso', a.Tipo_Acceso 'Acceso', a.Descripcion_Acceso'Descripción Acceso'
			from dbo.Acceso a
end
GO
/*------------------------------------------------------Consultar Clientes---------------------------------------------*/
create procedure consultaclientes
		@consultacliente as varchar(50)
	as
begin
	if @consultacliente = 'Clientes'
	select c.Codigo_Cliente'Identificador del Cliente', c.Nombre_Cliente'Nombre del Cliente',c.Telefono_Cliente'Teléfono del Cliente',
	c.Correo_Cliente'Correo del Cliente', c.Direccion_Cliente'Dirección del Cliente',count(co.Codigo_Contrato)'Contratos del Cliente'
	from dbo.Cliente c
	inner join dbo.Contratos co on c.Codigo_Cliente = co.Cliente_Contrato
	group by c.Codigo_Cliente,c.Correo_Cliente,c.Direccion_Cliente,c.Nombre_Cliente,c.Telefono_Cliente
	if @consultacliente ='Contratos por Cliente'
	select c.Nombre_Cliente'Cliente del Contrato',c.Telefono_Cliente'Contacto del Cliente', co.Codigo_Contrato'Contrato',tc.Nombre_Tipo_Contrato'Tipo de Contrato',e.Nombre_Estado'Estado Contrato'
	from  dbo.Cliente c
	inner join dbo.Contratos co on c.Codigo_Cliente = co.Cliente_Contrato
	inner join dbo.Tipo_Contrato tc on co.Tipo_Contrato = tc.Codigo_Tipo_Contrato
	inner join dbo.Estado e on co.Estado_Contrato = e.Codigo_Estado
end
GO
/*------------------------------------------------------Consultar Rutas---------------------------------------------*/
create procedure consultarutas
		@consultacliente as varchar(50)
	as
begin
	if @consultacliente = 'Rutas Generales'
	select r.Codigo_Ruta'Codigo Ruta',r.Nombre_Ruta'Nombre de la Ruta' from Rutas r
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
	select r.Codigo_Ruta'Codigo Viaje',r.Nombre_Ruta'Nombre de Viaje',r.Descripcion_Ruta'Descripcion Viaje', c.Servicio'Tipo de Viaje' from Rutas r
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
	select c.Codigo_Contrato'Código del Contrato',cl.Nombre_Cliente 'Dueño del Contrato', tp.Nombre_Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalización del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.Tipo_Contrato tp on c.Tipo_Contrato = tp.Codigo_Tipo_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
end
GO

/*------------------------------------------------------Filtrar Contratos---------------------------------------------*/
create procedure filtrarcontratos
		@tipobusqueda as varchar(50),
		@filtro as varchar(50)
	as
begin
	if @tipobusqueda = 'Clientes'
	select c.Codigo_Contrato'Código del Contrato',cl.Nombre_Cliente 'Dueño del Contrato', tp.Nombre_Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalización del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.Tipo_Contrato tp on c.Tipo_Contrato = tp.Codigo_Tipo_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
	where cl.Codigo_Cliente = @filtro;
	if @tipobusqueda = 'Estados'
	select c.Codigo_Contrato'Código del Contrato',cl.Nombre_Cliente 'Dueño del Contrato', tp.Nombre_Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalización del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.Tipo_Contrato tp on c.Tipo_Contrato = tp.Codigo_Tipo_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
	where e.Codigo_Estado = @filtro;
end
GO

/*-------------------------------- Verificar Cambios realizados en el Cliente-----------*/
create procedure CambiosCliente
@Codigo_Cliente varchar(50),
@Nombre_Cliente varchar(100),
@Direccion_Cliente varchar(200),
@Telefono_Cliente varchar (20),
@Correo_Cliente varchar (100)
as
begin
	select COUNT(*) from Cliente where (Codigo_Cliente = @Codigo_Cliente and Nombre_Cliente = @Nombre_Cliente and Direccion_Cliente = @Direccion_Cliente 
	                                   and Telefono_Cliente = @Telefono_Cliente and Correo_Cliente = @Correo_Cliente)
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
	select Codigo_Cliente'Código Cliente', Nombre_Cliente'Nombre del Cliente', Direccion_Cliente'Dirección del Cliente', Telefono_Cliente'Teléfono del Cliente', Correo_Cliente'Correo del Cliente' 
	from CLiente 
end
GO
/*--------------------------------Procedimiento Modificar Contrato------------------------------------*/
Create procedure ModificarContratoTemporal
@Codigo_Contrato varchar(50),
@Monto_Mensual money,
@Servicio varchar(50),
@Fecha_Inicio_Contrato date,
@Monto_Contrato money,
@Fecha_Vencimiento date,
@Estado_Contrato int,
@Tipo_Pago_Contrato int,
@Cuotas_Mensuales int
as
begin
	update Contratos
	set [Monto_Mensual] = @Monto_Mensual,
	Fecha_Inicio_Contrato = @Fecha_Inicio_Contrato,
	Fecha_Vencimiento = @Fecha_Vencimiento,
	Cuotas_Mensuales = @Cuotas_Mensuales,
	Servicio = @Servicio,
	Monto_Contrato = @Monto_Contrato,
	Estado_Contrato = @Estado_Contrato,
	Tipo_Pago = @Tipo_Pago_Contrato
	where Codigo_Contrato = @Codigo_Contrato
end
GO
Create procedure ModificarContratoViaje
@Codigo_Contrato varchar(50),
@Servicio varchar(50), 
@Anticipo money,
@Fecha_Inicio_Contrato date,
@Monto_Contrato money,
@Fecha_Vencimiento date,
@Estado_Contrato int
as
begin
	update Contratos
	set Servicio = @Servicio,	
	Anticipo = @Anticipo,
	Fecha_Inicio_Contrato = @Fecha_Inicio_Contrato,
	Monto_Contrato = @Monto_Contrato,
	Fecha_Vencimiento = @Fecha_Vencimiento,
	Estado_Contrato = @Estado_Contrato
	where Codigo_Contrato = @Codigo_Contrato
end
GO
/*--------------------Procedimiento para ComboBox Tipo de Pago ------------------------------*/
create procedure ComboboxTipoPago
as
begin
	
	select Codigo_Tipo_Pago 'Codigo_Tipo_Pago', Nombre_Tipo_Pago 'Nombre_Tipo_Pago' from Tipo_Pago
end
GO


/*-----------------Carga dgv Contrato------------------*/
Create procedure CargadgvContrato1
as
begin
	select cli.Codigo_Cliente'Código_Cliente', cli.Nombre_Cliente'Cliente Afiliado al contrato'
	from Cliente cli
end
GO

/*-------------------Carga dgv Datos contrato del cliente------------------*/
create procedure CargadgvDatoContratoCliente
@Cod_Cliente varchar(50)
as
begin
	select c.Codigo_Contrato'Nombre del Contrato', tp.Nombre_Tipo_Contrato'Tipo de Contrato', 
	c.[Monto_Mensual]'Monto Mensual', c.Cuotas_Mensuales'Cuotas Mensuales', 
	c.Servicio'Servicio', c.Anticipo'Anticipo', c.Fecha_Inicio_Contrato'Fecha de Inicio del Contrato',
	 c.Monto_Contrato'Monto del Contrato', 
	Fecha_Vencimiento'Fecha de Vencimiento Contrato',e.Nombre_Estado'Estado del Contrato', 
	p.Nombre_Tipo_Pago 'Tipo de Pago'
	from Contratos c
	inner join Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join Tipo_Contrato tp on c.Tipo_Contrato = tp.Codigo_Tipo_Contrato
	inner join Estado es on es.Codigo_Estado=c.Estado_Contrato
	inner join Tipo_Pago p on c.Tipo_Pago = p.Codigo_Tipo_Pago
	where Cliente_Contrato = @Cod_Cliente
end
GO
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
Create procedure [dbo].[NuevoEmpleado]
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
@FechaVLic as Date,
@tipolic as int
as
declare @filtro as int
set  @filtro=(Select p.Codigo_Puesto from Puesto p where p.Nombre_Puesto='Conductor' )
begin
	if(@Puesto=@filtro)
	begin
	insert into Empleado values
	(@Identidad,@Nombr,@FNacimiento,@Genero,@Telefono,@Correo,@Direccion,@Puesto,@Salario,@Licencia,@FechaVLic,@tipolic)
	end
	else
	begin
	insert into Empleado values
	(@Identidad,@Nombr,@FNacimiento,@Genero,@Telefono,@Correo,@Direccion,@Puesto,@Salario,'N/A',null,0)
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
	inner join Genero g on e.Genero = g.Codigo_Genero;
end
GO
/*---------------------------------------------Procedimiento Buscar Empleado------------------------------------------------*/
Create procedure [dbo].[BuscarEmpleado]
@Codigo_Empleado  varchar(100)
as
begin
	select e.Nombre_Empleado,e.Genero,e.Telefono,e.Correo,e.Direccion,e.Puesto_Empleado,
	e.salario,e.Licencia,e.Fecha_Vencimiento_Licencia,e.Tipo_Licencia from Empleado e
	where e.Identidad_Empleado=@Codigo_Empleado
end
GO
/*---------------------------------------------Procedimiento Cargar Generos------------------------------------------------*/
create procedure [dbo].[cargarGenero]
as
begin
	select g.Codigo_Genero'Codigo', g.Genero'Gen' from dbo.Genero g
end
go
/*---------------------------------------------Procedimiento Filtro Encargado Vehiculos------------------------------------------------*/
create procedure [dbo].[ComboboEncVehiculos]
as
begin
select e.Identidad_Empleado'Identidad',e.Nombre_Empleado'Nombre' from Empleado e
inner join Puesto p on e.Puesto_Empleado = p.Codigo_Puesto
where p.Nombre_Puesto='Conductor'
end
go
/*---------------------------------------------Procedimiento Filtro Empleados Conductores------------------------------------------------*/
CREATE procedure [dbo].[ComboboxEmpleados]
as
begin
select e.Identidad_Empleado'codigo',e.Nombre_Empleado'Nombre' from Empleado e
inner join Puesto p on e.Puesto_Empleado = p.Codigo_Puesto
where p.Nombre_Puesto='Conductor'
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
	group by v.Marca_Vehiculo
end
GO
/*---------------------------------------------Procedimiento Filtro Tipo Vehiculos------------------------------------------------*/
create procedure [dbo].[ComboboxTVehiculos]
as
begin
begin
	select v.Tipo_Vehiculo'Codigo',tv.Nombre_Tipo_Vehiculo'Tipo' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	group by v.Tipo_Vehiculo,tv.Nombre_Tipo_Vehiculo
end

end
GO
/*---------------------------------------------Procedimiento Datagridview Datos Simples Vehiculos------------------------------------------------*/
Create procedure [dbo].[DatosVehiculosSencillos]
as
begin
select v.Codigo_Vehiculo'Placa',CONCAT(tv.Nombre_Tipo_Vehiculo,' ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo,' ',v.Capacidad_Vehiculo,' Asientos')'Descripción Vehículo',tt.Nombre_Tipo_Transmision'Transmisión',tg.Nombre_Tipo_Gasolina'Tipo Combustible',e.Nombre_Estado'Estado Vehiculo',ep.Nombre_Empleado'Responsable' from Vehiculos v
inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
end
GO
/*---------------------------------------------Procedimiento Datagridview Datos al Asignar un Vehiculo------------------------------------------------*/
CREATE procedure [dbo].[DatosVehiculosSencillosAsignar]
as
begin
select v.Codigo_Vehiculo'Placa',CONCAT(tv.Nombre_Tipo_Vehiculo,' ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo,' ',v.Capacidad_Vehiculo,' Asientos')'Descripción Vehículo',tt.Nombre_Tipo_Transmision 'Transmisión',
'Sin Asignar' as 'Responsable',e.Nombre_Estado 'Estado Vehiculo' from Vehiculos v
inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
where v.Responsable_Vehiculo is null
end
GO
/*---------------------------------------------Procedimiento Datagridview Datos al Devolver un Vehiculo------------------------------------------------*/
create procedure [dbo].[DatosVehiculosSencillosdevolver]
as
begin
select v.Codigo_Vehiculo'Placa',CONCAT(tv.Nombre_Tipo_Vehiculo,' ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo,' ',v.Capacidad_Vehiculo,' Asientos')'Descripción Vehículo',tt.Nombre_Tipo_Transmision'Transmisión',ep.Nombre_Empleado'Responsable' from Vehiculos v
inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
where v.Responsable_Vehiculo is not null;
end
GO
/*---------------------------------------------Procedimiento Modificar al Asignar/Devolver un Vehiculo------------------------------------------------*/
Create procedure [dbo].[devolverasignarunidades]
@tipo as int,
@empleado as varchar(50),
@placa as varchar(50),
@estado as int
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
set Responsable_Vehiculo=NULL,
Estado_Vehiculo=@estado
where Codigo_Vehiculo=@placa;
end
GO
/*---------------------------------------------Procedimiento Filtrar Datos DGV empleados------------------------------------------------*/
Create procedure [dbo].[FiltrarDatosDVGEmpleados]
@puesto as int
as
declare @filtro as int
set  @filtro=(Select p.Codigo_Puesto from Puesto p where p.Nombre_Puesto='Conductor' )
begin
	if(@puesto =@filtro)
	select e.Identidad_Empleado'Identidad Empleado',e.Nombre_Empleado'Nombre Empleado',e.Fecha_Nacimiento'Fecha Nacimiento',
	g.Genero,E.Telefono,e.Correo,e.Direccion,p.Nombre_Puesto'Puesto Empleado',ROUND(e.Salario,2)'Salario', tl.Nombre_Tipo_Licencia'Tipo de Licencia'
	from Empleado E
	inner join Puesto p on E.Puesto_Empleado = P.Codigo_Puesto
	inner join Genero g on e.Genero = g.Codigo_Genero
	inner join Tipo_Licencia tl on e.Tipo_Licencia = tl.Codigo_Tipo_Licencia
	where e.Puesto_Empleado=@puesto;
	else
	select e.Identidad_Empleado'Identidad Empleado',e.Nombre_Empleado'Nombre Empleado',e.Fecha_Nacimiento'Fecha Nacimiento',
	g.Genero,E.Telefono,e.Correo,e.Direccion,p.Nombre_Puesto'Puesto Empleado',ROUND(e.Salario,2)'Salario'
	from Empleado E
	inner join Puesto p on E.Puesto_Empleado = P.Codigo_Puesto
	inner join Genero g on e.Genero = g.Codigo_Genero
	where e.Puesto_Empleado=@puesto;

end
GO
/*---------------------------------------------Procedimiento Filtrar Datos DGV Vehiculos------------------------------------------------*/
create procedure [dbo].[filtrarvehiculos]
		@tipobusqueda as varchar(50),
		@filtro as varchar(50)
	as
begin
	if @tipobusqueda = 'Marca Vehículo'
	select v.Codigo_Vehiculo'Placa',tv.Nombre_Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripción',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehículo',
	tt.Nombre_Tipo_Transmision 'Transmisión Vehículo',tg.Nombre_Tipo_Gasolina 'Combustible Vehículo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehículo',e.Nombre_Estado'Estado' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	where v.Marca_Vehiculo=@filtro;
	if @tipobusqueda = 'Tipo Vehículo'
	select v.Codigo_Vehiculo'Placa',tv.Nombre_Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripción',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehículo',
	tt.Nombre_Tipo_Transmision 'Transmisión Vehículo',tg.Nombre_Tipo_Gasolina 'Combustible Vehículo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehículo',e.Nombre_Estado'Estado' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	where v.Tipo_Vehiculo=@filtro;
	if @tipobusqueda = 'Estado Vehículo'
	select v.Codigo_Vehiculo'Placa',tv.Nombre_Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripción',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehículo',
	tt.Nombre_Tipo_Transmision 'Transmision Vehículo',tg.Nombre_Tipo_Gasolina 'Combustible Vehículo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehículo',e.Nombre_Estado'Estado' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	where v.Estado_Vehiculo=@filtro;
	if @tipobusqueda = 'Responsable Vehículo'
	select v.Codigo_Vehiculo'Placa',tv.Nombre_Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripción',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehículo',
	tt.Nombre_Tipo_Transmision 'Transmisión Vehículo',tg.Nombre_Tipo_Gasolina 'Combustible Vehículo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehículo',e.Nombre_Estado'Estado',ep.Nombre_Empleado'Responsable' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	inner join Empleado ep on v.Responsable_Vehiculo = ep.Identidad_Empleado
	where v.Responsable_Vehiculo=@filtro;
	if @tipobusqueda = 'Sin Asignar'
	select v.Codigo_Vehiculo'Placa',tv.Nombre_Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripción',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehiculo',
	tt.Nombre_Tipo_Transmision 'Transmisión Vehículo',tg.Nombre_Tipo_Gasolina 'Combustible Vehículo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehículo',e.Nombre_Estado'Estado','Sin Asignar'as'Responsable' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
	where v.Responsable_Vehiculo is null;
end
GO
/*---------------------------------------------Procedimient Llenar Datos DGV Vehiculos Completos------------------------------------------------*/
create procedure [dbo].[LLenarDVGvehiculos]
as
begin
	select v.Codigo_Vehiculo'Placa',tv.Nombre_Tipo_Vehiculo 'Tipo',concat(v.Anio_Vehiculo,' ',V.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' ',v.Color_Vehiculo)'Descripción',Concat(v.Capacidad_Vehiculo,' Asientos')'Capacidad Vehículo',
	tt.Nombre_Tipo_Transmision 'Transmisión Vehículo',tg.Nombre_Tipo_Gasolina 'Combustible Vehículo',V.Anio_Adquisicion'Adquirido en: ' ,
	concat(v.Emision_Permiso,'-',v.Vencimiento_Permiso)'Permiso de Vehículo',e.Nombre_Estado'Estado' from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo=tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
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
@FechaVLic as Date,
@tipolicencia as int
as 
declare @filtro as int
set  @filtro=(Select p.Codigo_Puesto from Puesto p where p.Nombre_Puesto='Conductor' )
begin
	if(@Puesto=@filtro)
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
	Fecha_Vencimiento_Licencia= @FechaVLic,
	Tipo_Licencia =@tipolicencia
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
	Fecha_Vencimiento_Licencia= NULL,
	Tipo_Licencia = 0
	where Identidad_Empleado=@Identidad
	end
end
GO
/*--------------------------------------Procedimiento de Pagos-------------------------------------------------*/
create procedure NuevoPago
	@Codigo_Contrato nvarchar(50),
	@Numero_Cuota int,
	@Monto money,
	@Descripcion_Recibo varchar(200)
	as
	begin
	insert into Recibos
		select COUNT(*)+1,@Numero_Cuota,@Codigo_Contrato,'RCTr',GETDATE(),@Monto,'DFCA9C-C556B3-7744AB-61D5D6-61F4A7-F5',
		@Descripcion_Recibo from Recibos
	end
	GO
create procedure TotalRecibosContratos
	@Codigo_Contrato varchar(50)
	as
	begin
		select COUNT(*) from Recibos where Codigo_Contrato=@Codigo_Contrato
	end
	GO


/* Procedimientos Almacenados UNIDADES DE TRANSPORTE */ 

/*--------------------------------------Procedimiento Llenar ComboBox Tipo de Vehiculo-------------------------------------------------*/
create procedure ComboboxTipoVeh
as
begin
	select Codigo_Tipo_Vehiculo 'Codigo' , Nombre_Tipo_Vehiculo 'Tipo' from Tipo_Vehiculo
end
GO

/*--------------------------------------Procedimiento Llenar Trasnmision de Vehiculo-------------------------------------------------*/
create procedure ComboboxTipoTrans
as
begin
	select Codigo_Tipo_Transmision 'Codigo', Nombre_Tipo_Transmision 'Transmision' from Tipo_Transmision
end
GO

/*--------------------------------------Procedimiento Llenar ComboBox Combustible de Vehiculo-------------------------------------------------*/
create procedure ComboboxTipoGas
as
begin
	select Codigo_Tipo_Gasolina 'Codigo', Nombre_Tipo_Gasolina 'Gasolina' from Tipo_Gasolina
end
GO

/*--------------------------------------Procedimiento Llenar ComboBox Estado de Vehiculo-------------------------------------------------*/
create procedure ComboboxEstadoVeh
as
begin
	select Codigo_Estado 'Codigo', Nombre_Estado 'Estado' from Estado
	where Codigo_Categoria = 'VE'
end
GO

/*-------------------------------------Procedimiento Verificar Vehiculo Existente-------------------------------------------------*/
create procedure VerificarVehiculo
@Codigo_Vehiculo varchar(50)
as
begin
	select COUNT(*) from Vehiculos where Codigo_Vehiculo = @Codigo_Vehiculo
end
GO


/*--------------------------------------Procedimiento Nuevo Vehiculo-------------------------------------------------*/
create procedure NuevaUnidad
@Codigo_Vehiculo varchar(50),
@Tipo_Vehiculo int,
@Anio_Vehiculo int,
@Marca_Vehiculo varchar(100),
@Modelo_Vehiculo varchar(100),
@Capacidad_Vehiculo int,
@Transmision_Vehiculo int,
@Combustible_Vehiculo int,
@Color_Vehiculo varchar(100),
@Anio_Adquisicion int,
@Estado_Vehiculo int,
@Emision_Permiso date,
@Vencimiento_Permiso date
as
begin
	insert into Vehiculos (Codigo_Vehiculo, Tipo_Vehiculo, Anio_Vehiculo, Marca_Vehiculo, Modelo_Vehiculo, Capacidad_Vehiculo, Transmision_Vehiculo, 
	                       Combustible_Vehiculo, Color_Vehiculo, Anio_Adquisicion, Estado_Vehiculo, Emision_Permiso, Vencimiento_Permiso)
	values (@Codigo_Vehiculo, @Tipo_Vehiculo, @Anio_Vehiculo, @Marca_Vehiculo, @Modelo_Vehiculo, @Capacidad_Vehiculo, @Transmision_Vehiculo,
	        @Combustible_Vehiculo, @Color_Vehiculo, @Anio_Adquisicion, @Estado_Vehiculo, @Emision_Permiso, @Vencimiento_Permiso)
end
GO


/*--------------------------------------Procedimiento Llenar ComboBox Tipo de Mantenimiento-------------------------------------------------*/
create procedure ComboboxTipoMant
as
begin
	select Codigo_Tipo_Mantenimiento 'Codigo', Nombre_Tipo_Mantenimiento 'Mantenimiento' from Tipo_Mantenimientos
end
GO

/*--------------------------------------Procedimiento Llenar ComboBox Estado de Mantenimiento-------------------------------------------------*/
create procedure ComboboxEstadoMant
as
begin
	select Codigo_Estado 'Codigo', Nombre_Estado 'Estado' from Estado
	where Codigo_Categoria = 'MT'
end
GO

/*--------------------------------------Procedimiento Llenar Guardar Mantenimiento-------------------------------------------------*/
create procedure NuevoMantenimiento
@Tipo_Mantenimiento int,
@Fecha_Mantenimiento date,
@Codigo_Vehiculo varchar(50),
@Costo_Mantenimiento money
as
begin
	insert into Mantenimientos (Codigo_Mantenimiento, Tipo_Mantenimiento, Fecha_Mantenimiento, Codigo_Vehiculo, Costo_Mantenimiento)
	values ( (select COUNT(*)+1 from Mantenimientos), @Tipo_Mantenimiento, @Fecha_Mantenimiento, @Codigo_Vehiculo, @Costo_Mantenimiento)
end
GO

/*--------------------------------------Procedimiento Llenar Poner Vehiculo en Mantenimiento-------------------------------------------------*/
--701
create procedure VehEnMantenimiento
@Codigo_Vehiculo varchar(50)
as
begin
	update Vehiculos
	set Estado_Vehiculo = 701
	where Codigo_Vehiculo = @Codigo_Vehiculo
end
GO
	GO
/*--------------------------------------Procedimiento de Bitacora-------------------------------------------------*/
create procedure [dbo].[actualizarbitacora]
@desc as varchar(50),
@tipo as int,
@dato1 as varchar(100),
@dato2 as varchar(100),
@dato3 as varchar(100),
@dato4 as varchar(100),
@dato5 as varchar(100),
@dato6 as varchar(100)
as
begin
	declare @contador as int
	if(@tipo=1)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=1)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=2)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=2)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=3)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=3)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=4)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=4)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=5)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=5)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=6)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=6)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=7)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=7)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=8)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=8)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=9)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=9)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end
	if(@tipo=10)
	begin
		set @contador=(select count(*) from Eventos where Tipo_Evento=10)+1
		select @contador
		insert into Eventos values
		(CONCAT(@desc,@contador),@tipo,GETDATE(),@dato1,@dato2,@dato3,@dato4,@dato5,@dato6)
	end

end
go

/*------------------------------------------Modificar Vehiculo-------------------------------------------*/

create procedure ModificarVehiculo
@Cod_Vehiculo varchar(50),
@Color_Vehiculo varchar (100),
@Estado_Vehiculo int,
@Emision_Permiso date,
@Vencimiento_Permiso date
as
begin
	Update Vehiculos
	set Color_Vehiculo = @Color_Vehiculo,
	Estado_Vehiculo = @Estado_Vehiculo,
	Emision_Permiso = @Emision_Permiso,
	Vencimiento_Permiso = @Vencimiento_Permiso
	where Codigo_Vehiculo = @Cod_Vehiculo
end
GO

/*----------------------------------Combobox Estado Vehiculo---------------------------------------*/
create procedure ComboModVehiculo
As
begin
	select Codigo_Estado,Nombre_Estado from dbo.Estado
	where Codigo_Categoria ='VE' 
end
GO
/*----------------------------------Combobox Tipos de Eventos---------------------------------------*/
create procedure ComboTipoEventos
As
begin
	select tv.Codigo_Tipo_Evento'Codigo',tv.Nombre_Tipo_Evento'Nombre' from dbo.Tipo_Evento tv
end
GO
/*----------------------------------Datagrid Eventos---------------------------------------*/
Create procedure dgvEventos
@filtro as int
As
begin
	select e.Codigo_Evento'Código Evento',e.Fecha_Evento'Fecha del Evento',e.Dato1'Descripción Evento',e.Dato2'Clave del Afectado'
	,e.Dato3'Información Adicional',e.Dato4'Observaciones Adicionales' from Eventos e
	where e.Tipo_Evento = @filtro;
end
GO


/*----------------------Cargar dgv Vehiculos----------------------------*/

Create Procedure CargaDgvModVehiculo
as
begin
	select v.Codigo_Vehiculo'Placa Vehículo', tv.Nombre_Tipo_Vehiculo'Tipo de Vehículo', v.Anio_Vehiculo'Año del Vehículo', v.Marca_Vehiculo'Marca del Vehículo', v.Modelo_Vehiculo'Modelo del Vehículo',
	v.Capacidad_Vehiculo'Capacidad del Vehículo', tt.Nombre_Tipo_Transmision'Transmisión del Vehículo', tg.Nombre_Tipo_Gasolina'Combustible del Vehículo', v.Color_Vehiculo,
	v.Anio_Adquisicion, e.Nombre_Estado'Estado del Vehículo', v.Emision_Permiso'Emision del Permiso', v.Vencimiento_Permiso'Vencimiento del Permiso', v.Responsable_Vehiculo'Responsable del Vehículo'
	from Vehiculos v
	inner join Tipo_Vehiculo tv on v.Tipo_Vehiculo = tv.Codigo_Tipo_Vehiculo
	inner join Tipo_Transmision tt on v.Transmision_Vehiculo = tt.Codigo_Tipo_Transmision
	inner join Tipo_Gasolina tg on v.Combustible_Vehiculo = tg.Codigo_Tipo_Gasolina
	inner join Estado e on v.Estado_Vehiculo = e.Codigo_Estado
end
GO
/*------------------------------Procedimiento de Notificaciones -----------------------------------*/
create procedure Notificaciones
as
begin
	select CONCAT(Marca_Vehiculo,' ', Modelo_Vehiculo,' con placa ', v.Codigo_Vehiculo,
	' entro a mantenimiento de ', tp.Nombre_Tipo_Mantenimiento) as 'Notificaciones' from Vehiculos v
	inner join Mantenimientos m on v.Codigo_Vehiculo = m.Codigo_Vehiculo
	inner join Tipo_Mantenimientos tp on tp.[Codigo_Tipo_Mantenimiento] =[Tipo_Mantenimiento]
	where v.Estado_Vehiculo = 701 and  DATEDIFF(DAY,m.Fecha_Mantenimiento,GETDATE())=0
	union
	select CONCAT(Marca_Vehiculo,' ', Modelo_Vehiculo,' con placa ', v.Codigo_Vehiculo,
	' está en mantenimiento de ', tp.Nombre_Tipo_Mantenimiento , ' hace ',
	DATEDIFF(DAY,GETDATE(),m.Fecha_Mantenimiento),' días') as 'Notificaciones' from Vehiculos v
	inner join Mantenimientos m on v.Codigo_Vehiculo = m.Codigo_Vehiculo
	inner join Tipo_Mantenimientos tp on tp.[Codigo_Tipo_Mantenimiento] =[Tipo_Mantenimiento]
	where v.Estado_Vehiculo = 701 and  DATEDIFF(DAY,m.Fecha_Mantenimiento,GETDATE())!=0
	union
	select CONCAT('El cliente ',cl.Nombre_Cliente,' no ha pagado el mes de ',DATENAME(month,getdate()),' del contrato ', c.Codigo_Contrato,' de Tipo ', tp.Nombre_Tipo_Contrato) from Contratos c
	left join Cliente cl on c.Cliente_Contrato=cl.Codigo_Cliente
	left join Recibos r on r.Codigo_Contrato = c.Codigo_Contrato
	left join Tipo_Contrato tp on tp.Codigo_Tipo_Contrato=c.Tipo_Contrato
	group by c.Codigo_Contrato, cl.Nombre_Cliente, c.Fecha_Inicio_Contrato, C.Cuotas_Mensuales, tp.Nombre_Tipo_Contrato, c.Estado_Contrato
	having DATEPART(MONTH,GETDATE())>=DATEPART(MONTH,DATEADD(MONTH,COUNT(R.Numero_Recibo),c.Fecha_Inicio_Contrato)) and DATEPART(MONTH,GETDATE())<=DATEPART(MONTH,DATEADD(MONTH, COUNT(R.Numero_Recibo)+1,c.Fecha_Inicio_Contrato)) and c.Cuotas_Mensuales>COUNT(R.Numero_Recibo) and c.Estado_Contrato=1
	union
	select CONCAT('Ya se acerca la fecha de Pago del mes de ',DATENAME(MONTH,DATEADD(month,1,getdate())),' hazlo saber a tus clientes')
	where DATEPART(DAY,GETDATE())>=25
	union
	select CONCAT('El Conductor/a ',e.Nombre_Empleado,' se le aproxima la fecha de vencimiento de su licencia el ', DATEPART(day,e.Fecha_Vencimiento_Licencia),' de ',DATENAME(month, e.Fecha_Vencimiento_Licencia), ' ',DATEPART(year,e.Fecha_Vencimiento_Licencia)) from Empleado e
	inner join Puesto p on e.Puesto_Empleado=p.Codigo_Puesto
	where p.Codigo_Puesto=1 and e.Fecha_Vencimiento_Licencia is not null and DATEPART(MONTH,GETDATE())<=DATEPART(MONTH,e.Fecha_Vencimiento_Licencia) AND DATEPART(YEAR,GETDATE())=DATEPART(YEAR,e.Fecha_Vencimiento_Licencia) and DATEPART(DAY,GETDATE())<DATEPART(DAY,e.Fecha_Vencimiento_Licencia)
	union
	select CONCAT('El Conductor/a ',e.Nombre_Empleado,' tiene su licencia vencida desde el ', DATEPART(day,e.Fecha_Vencimiento_Licencia),' de ',DATENAME(month, e.Fecha_Vencimiento_Licencia), ' ',DATEPART(year,e.Fecha_Vencimiento_Licencia)) from Empleado e
	inner join Puesto p on e.Puesto_Empleado=p.Codigo_Puesto
	where p.Codigo_Puesto=1 and DATEPART(YEAR,GETDATE())>=DATEPART(YEAR,e.Fecha_Vencimiento_Licencia) and (DATEPART(DAY,GETDATE())>=DATEPART(DAY,e.Fecha_Vencimiento_Licencia) or DATEPART(MONTH,GETDATE())>DATEPART(MONTH,e.Fecha_Vencimiento_Licencia))
	union
	select CONCAT(Marca_Vehiculo,' ', Modelo_Vehiculo,' con placa ', v.Codigo_Vehiculo,' se le aproxima la fecha de vencimiento de su permiso el ', DATEPART(day,v.Vencimiento_Permiso),' de ',DATENAME(month, v.Vencimiento_Permiso), ' ',DATEPART(year,v.Vencimiento_Permiso)) from Vehiculos v
	where DATEPART(MONTH,GETDATE())<=DATEPART(MONTH,v.Vencimiento_Permiso) AND DATEPART(YEAR,GETDATE())=DATEPART(YEAR,v.Vencimiento_Permiso) and DATEPART(DAY,GETDATE())>DATEPART(DAY,v.Vencimiento_Permiso)
	union
	select CONCAT(Marca_Vehiculo,' ', Modelo_Vehiculo,' con placa ', v.Codigo_Vehiculo,' tiene su permiso vencido desde el ', DATEPART(day,v.Vencimiento_Permiso),' de ',DATENAME(month, v.Vencimiento_Permiso), ' ',DATEPART(year,v.Vencimiento_Permiso)) from Vehiculos v
	where DATEPART(YEAR,GETDATE())>=DATEPART(YEAR,v.Vencimiento_Permiso) and DATEPART(DAY,GETDATE())>=DATEPART(DAY,v.Vencimiento_Permiso) and DATEPART(MONTH,GETDATE())>DATEPART(MONTH,v.Vencimiento_Permiso)
	union
	select  CONCAT('El Vehículo ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' con placa ',v.Codigo_Vehiculo,' lleva 3 meses sin mantenimiento aceite') from Vehiculos v
	left join Mantenimientos m on m.Codigo_Vehiculo=v.Codigo_Vehiculo
	left join Tipo_Mantenimientos tp on m.Tipo_Mantenimiento=tp.Codigo_Tipo_Mantenimiento 
	where  GETDATE()>=DATEADD(MONTH,3,m.Fecha_Mantenimiento) and  tp.Codigo_Tipo_Mantenimiento=1
	group by CONCAT('El Vehículo ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' con placa ',v.Codigo_Vehiculo,' lleva 3 meses sin mantenimiento aceite')
	union
	select  CONCAT('El Vehículo ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' con placa ',v.Codigo_Vehiculo,' lleva 6 meses sin mantenimiento de llantas') from Vehiculos v
	left join Mantenimientos m on m.Codigo_Vehiculo=v.Codigo_Vehiculo
	left join Tipo_Mantenimientos tp on m.Tipo_Mantenimiento=tp.Codigo_Tipo_Mantenimiento 
	where  GETDATE()>=DATEADD(MONTH,3,m.Fecha_Mantenimiento) and  tp.Codigo_Tipo_Mantenimiento=2
	group by CONCAT('El Vehículo ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' con placa ',v.Codigo_Vehiculo,' lleva 6 meses sin mantenimiento de llantas')
	union
	select  CONCAT('El Vehículo ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' con placa ',v.Codigo_Vehiculo,' nunca se ha llevado a mantenimiento') from Vehiculos v
	left join Mantenimientos m on m.Codigo_Vehiculo=v.Codigo_Vehiculo
	left join Tipo_Mantenimientos tp on m.Tipo_Mantenimiento=tp.Codigo_Tipo_Mantenimiento 
	group by CONCAT('El Vehículo ',v.Marca_Vehiculo,' ',v.Modelo_Vehiculo,' con placa ',v.Codigo_Vehiculo,' nunca se ha llevado a mantenimiento')
	having COUNT(m.Codigo_Vehiculo)=0
end
go
GO



/******************************************************* MANTENIMIENTOS CREAR Y MODIFICAR **********************************************/

/*----------------------Cargar dgv Mantenimientos----------------------------*/
create procedure ComboboxMant
as
begin
	select Nombre_Tipo_Mantenimiento 'Mantenimiento' from Tipo_Mantenimientos
end
GO


/*----------------------Guardar nuevo Mantenimiento----------------------------*/
create procedure NuevoTipoMantenimiento
@nombre varchar(100),
@descripcion varchar(200)
as
begin
	insert into Tipo_Mantenimientos (Codigo_Tipo_Mantenimiento, Nombre_Tipo_Mantenimiento, Descripcion_Tipo_Mantenimiento)
	values ( (select COUNT(*)+1 from Tipo_Mantenimientos), @nombre, @descripcion )
end
GO

/*----------------------Obtener Datos de Mantenimiento Existente----------------------------*/
create procedure DatosMantenimiento
@codigo int
as
begin
	select Nombre_Tipo_Mantenimiento 'Nombre', Descripcion_Tipo_Mantenimiento 'Descripcion' from Tipo_Mantenimientos
	where Codigo_Tipo_Mantenimiento = @codigo
end
GO


/*----------------------Modificar Mantenimiento Existente----------------------------*/
create procedure ModificarMantenimiento
@codigo int,
@nombre varchar(100),
@descripcion varchar(200)
as
begin
	UPDATE Tipo_Mantenimientos set Nombre_Tipo_Mantenimiento = @nombre, Descripcion_Tipo_Mantenimiento = @descripcion
	where Codigo_Tipo_Mantenimiento = @codigo
end
GO

/*----------------------Verificar Mantenimiento Existente----------------------------*/
create procedure VerificarMantenimiento
@codigo int,
@nombre varchar(100),
@opcion int
as
begin
	if(@opcion = 1) --Nuevo
	BEGIN
		select COUNT(*) from Tipo_Mantenimientos where (Nombre_Tipo_Mantenimiento = @nombre)
	END

	if(@opcion = 2) --Modifica
	BEGIN
		select COUNT(*) from Tipo_Mantenimientos where (Nombre_Tipo_Mantenimiento = @nombre and Codigo_Tipo_Mantenimiento != @codigo)
	END
end
GO

/*----------------------Verificar Si Cambio Mantenimiento Existente----------------------------*/
create procedure CambiosMantenimiento
@nombre varchar(100),
@descripcion varchar(200)
as
begin
	select COUNT(*) from Tipo_Mantenimientos where (Nombre_Tipo_Mantenimiento = @nombre and Descripcion_Tipo_Mantenimiento = @descripcion)
end
GO


GO

/*----------------------------------Carga Generar Contrato-------------------------*/
Create Procedure CargaGenerarContrato
as
begin
	select c.Codigo_Contrato'Código del Contrato',cli.Codigo_Cliente'Identidad del Cliente', cli.Nombre_Cliente'Nombre del Cliente', tp.Nombre_Tipo_Contrato'Tipo del Contrato', c.[Monto_Mensual]'Monto Mensual', c.Cuotas_Mensuales'Cuotas Mensuales',
	c.Servicio'Servicio', c.Monto_Contrato'Monto del Contrato', c.Fecha_Vencimiento'Fecha de Vencimiento del Contrato', c.Fecha_Inicio_Contrato'Fecha de Inicio del Contrato', rut.Codigo_Ruta'Ruta', rut.Parada_Contrato'Parada', c.Anticipo'Anticipo'  from Contratos c
	inner join Rutas_Contratos rut on c.Codigo_Contrato = rut.Codigo_Contrato
	inner join Tipo_Contrato tp on c.Tipo_Contrato = tp.Codigo_Tipo_Contrato
	inner join Cliente cli on c.Cliente_Contrato = cli.Codigo_Cliente	 
end
GO

/*****-----------------------Actualizar Matricula -----------------------------------*/
create procedure ActualizacionMatricula
	@Codigo_Vehiculo_Anterior varchar(50),
	@Codigo_Vehiculo_Nuevo varchar(50)
	as
	begin

		insert into [dbo].[Vehiculos]
		select @Codigo_Vehiculo_Nuevo,v.Tipo_Vehiculo,v.Anio_Vehiculo,v.Marca_Vehiculo,v.Modelo_Vehiculo, v.Capacidad_Vehiculo
		,v.Transmision_Vehiculo, v.Combustible_Vehiculo, v.Color_Vehiculo, v.Anio_Adquisicion, v.Estado_Vehiculo, v.Emision_Permiso, v.Vencimiento_Permiso, v.Responsable_Vehiculo, @Codigo_Vehiculo_Anterior from Vehiculos v
		where @Codigo_Vehiculo_Anterior=v.Codigo_Vehiculo

		update [dbo].[Mantenimientos]
		set
		Codigo_Mantenimiento =	m.Codigo_Mantenimiento,
		Tipo_Mantenimiento = m.Tipo_Mantenimiento,
		Fecha_Mantenimiento = m.Fecha_Mantenimiento,
		Codigo_Vehiculo=@Codigo_Vehiculo_Nuevo,
		Costo_Mantenimiento=m.Costo_Mantenimiento
		from Mantenimientos m
		where m.Codigo_Vehiculo=@Codigo_Vehiculo_Anterior

		update [dbo].[Vehiculos_Rutas]
		set
		Codigo_Ruta=vr.Codigo_Ruta,
		Codigo_Vehiculo=@Codigo_Vehiculo_Nuevo,
		Horario_Salida=vr.Horario_Salida,
		Horario_Entrada=vr.Horario_Entrada,
		Cantidad_Pasajeros_Actuales=vr.Cantidad_Pasajeros_Actuales
		from [dbo].[Vehiculos_Rutas] vr
		where vr.Codigo_Vehiculo=@Codigo_Vehiculo_Anterior

		delete from[dbo].[Vehiculos] 
		where Codigo_Vehiculo=@Codigo_Vehiculo_Anterior
		

		delete from Vehiculos_Rutas
		where Codigo_Vehiculo=@Codigo_Vehiculo_Anterior

		delete from Mantenimientos
		where Codigo_Vehiculo=@Codigo_Vehiculo_Anterior

	end
	GO

	/*----------------------Ver si vehiculo esta en mantenimiento----------------------------*/
create procedure BuscaMantenimiento
	@matricula varchar (50)
	as
	Begin
		select Estado_Vehiculo from Vehiculos
		where Codigo_Vehiculo=@matricula
	End
	GO


/*----------------------Asignar solo licencias livianas a carros livianos----------------------------*/
create procedure LicenciaLiviana
	@NomEmp varchar (50)
	as
	Begin
		select count(*) from Empleado e
		where e.Nombre_Empleado=@NomEmp and (e.Tipo_Licencia=1 or e.Tipo_Licencia=3)
	End
	GO


/*----------------------Asignar solo licencias livianas a carros livianos----------------------------*/
create procedure VehiculosPesados
	@matricula varchar (50)
	as
	Begin
		select count(*) from Vehiculos v
		where v.Codigo_Vehiculo=@matricula and v.Tipo_Vehiculo!=1 and v.Tipo_Vehiculo!=2
	End
	GO
/*-----------------------------------------Vencimiento de Contratos--------------------------------------------------------*/
create procedure VencimientoContratos
	as
	begin
		update[dbo].[Contratos]
		set Estado_Contrato=2
		where GETDATE()> Fecha_Vencimiento
	end
	GO
/*---------------------------------------------Validacion VehiculoConductor--------------------------------------------------*/

create procedure VehiculoConductor
	@Codigo_Vehiculo varchar(50)
	as
	begin
		select COUNT(v.Responsable_Vehiculo) from Vehiculos v
		where v.Codigo_Vehiculo=@Codigo_Vehiculo
	end
	go

/*---------------------------------------------Nueva Cotizacion--------------------------------------------------*/

create procedure NuevaCotizacion
@nombre as varchar(100),
@correo as varchar(100),
@telefono1 as varchar(20),
@telefono2 as varchar(20),
@origen as varchar(100),
@destino as varchar(100),
@distancia as float,
@tarifa as money,
@tipoviaje as varchar(50),
@subtotal as money,
@descuento as money,
@isv as money,
@rebaja as money,
@total as money
as 
begin
 insert into [dbo].[Cotizacion] ([Fecha_Cotizacion],[Nombre_Interesado],[Correo_Interesado],[Telefono1_Interesado],[Telefono2_Interesado],
 [Origen_Cotizacion],[Destino_Cotizacion],[Distancia_Cotizacion],[Tarifa_x_Km_Cotizacion],[Tipo_Viaje_Cotizacion],[Subtotal_Cotizacion],
 [ISV_Cotizacion],[Porce_Descuento_Cotizacion],[Rebaja_Cotizacion],[Total_Cotizacion])
 values (GETDATE(),@nombre,@correo,@telefono1,@telefono2,@origen,@destino,@distancia,@tarifa,@tipoviaje,@subtotal,@isv,@descuento,@rebaja,@total)
end
GO

/*---------------------------------------------Triggers Historial Usuarios--------------------------------------------------*/

--Cuando se Ingresa un Nuevo Usuario
create trigger TR_Insert_Usuario
on Usuarios		--La tabla que se desea monitorear
for insert		--La accion que se desea monitorear
as
begin
	set nocount on; --Evita que se muestre el guardado de los datos en esta tabla como mensaje en consola

	-- Insertar en la Tabla de Historial (en sus campos) los datos que fueron insertados
	insert into Historial_Usuarios (Codigo_Empleado, Nombre_Usuario, Contrasena_Usuario, Fecha, Descripcion)
	select Codigo_Empleado, Nombre_Usuario, Contrasena_Usuario, getdate(), 'Se insertó un Usuario'
	from inserted
end
GO 

--Cuando se Modifica un Usuario
create trigger TR_Update_Usuario
on Usuarios		--La tabla que se desea monitorear
for update		--La accion que se desea monitorear
as
begin
	set nocount on; --Evita que se muestre el guardado de los datos en esta tabla como mensaje en consola

	-- Insertar en la Tabla de Historial (en sus campos) los datos que fueron insertados
	insert into Historial_Usuarios (Codigo_Empleado, Nombre_Usuario, Contrasena_Usuario, Fecha, Descripcion)
	select Codigo_Empleado, Nombre_Usuario, Contrasena_Usuario, getdate(), 'Se modificó un Usuario'
	from inserted --No existe un UPDATED, el nuevo registro se inserta (INSERTED) una vez que se elimina (DELETED) el anterior
end
GO

/*INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'08011996444', N'Empleado1', CAST(N'1965-03-28' AS Date), 1, N'94543929', N'alroca.rodriguez@gmail.com ', N'Colonia Brisas del Humuya', 1,4.0000, N'N/A', NULL, 1)

INSERT [dbo].[Usuarios] ([Codigo_Empleado],[Nombre_Usuario], [Contrasena_Usuario], [Perfil_Acceso], [Estado_Usuario]) VALUES (N'08011996444', N'empleado1', N'empleado1', 1, 201)


update [dbo].[Usuarios] 
		set Nombre_Usuario='empleado2',
		Contrasena_Usuario='contrasena2',
		Perfil_Acceso=1,
		Estado_Usuario=201
		where Codigo_Empleado = '08011996444'*/