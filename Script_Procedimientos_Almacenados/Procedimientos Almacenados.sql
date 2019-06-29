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
@Fecha_Vencimiento date   
as 
begin 
	insert into Contratos 
	select CONCAT(@Anio_Contrato,'-',COUNT(*)+1,'-',SUBSTRING(@Nombre_Cliente_Contrato,1,1)), @Id_Cliente_Contrato, @Tipo_Contrato, @Fecha_Inicio_Contrato, @Monto_Contrato, @Fecha_Vencimiento, '1', 'CTr' from Contratos
end 
GO  

/*--------------------------------------Procedimiento para Crear una nueva Ruta---------------------------------------------------*/
create procedure NuevaRuta
	@Codigo_ruta varchar(50),
	@Nombre_Ruta varchar(100),
	@Descripcion_Ruta varchar(200),
	@Codigo_Contrato varchar(50),
	@Anio_Contrato varchar(4),
	@Nombre_Cliente_Contrato varchar(100),      
	@Opcion int
as
BEGIN
	declare @Cod_Contrato as varchar(50)
		
	set @Cod_Contrato = (select CONCAT(@Anio_Contrato,'-',COUNT(*),'-',SUBSTRING(@Nombre_Cliente_Contrato,1,1)) from Contratos)

	if(@Opcion=1) --Ruta guardada junto con el contrato
	begin
		insert into Rutas (Codigo_Ruta, Nombre_Ruta, Descripcion_Ruta, Codigo_Contrato)
		values (@Codigo_ruta, @Nombre_Ruta, @Descripcion_Ruta, @Cod_Contrato)  
	end

	if(@Opcion=2) --Ruta creada despues, donde se selecciona el contrato al que esta asociada
	begin
		insert into Rutas (Codigo_Ruta, Nombre_Ruta, Descripcion_Ruta, Codigo_Contrato)
		values (@Codigo_ruta, @Nombre_Ruta, @Descripcion_Ruta, (select SUBSTRING(@Codigo_Contrato,1,charindex(' ',@Codigo_Contrato,1)-1))) 
		--ComboBox fuente lleno con Nombre de Cliente para mejor Visualización (Ver PA ComboboxContratos), se realiza esto para obtener solo el codigo de Contrato

		--charindex busca una subcadena dentro de una cadena y devuelve la posicion en la que se encuentra
		--Charindex(substring, string, start)
		--select charindex('M','Hola Mundo',1)   
	end   
END  
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
			select p.Codigo_Perfil'Codigo del Perfil',p.Nombre_Perfil'Perfil',p.Descripcion_Perfil'Descripción Perfil',
			a.Tipo_Acceso'Acceso del Perfil'
			from dbo.Perfiles p
			inner join dbo.Acceso a on p.Nivel_Acceso = a.Codigo_Acceso
		end
	if @TipoConsulta='Niveles de Acceso'
		Begin
			select a.Codigo_Acceso 'Codigo del Acceso', a.Tipo_Acceso 'Acceso', a.Descripcion_Acceso'Descripción Acceso'
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
/*---------------------------------------------Procedimiento Llenar ComboBox Clientes------------------------------------------------*/
create procedure ComboboxClientes
as
begin
	select Nombre_Cliente,Codigo_Cliente from DBO.Cliente
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
	select c.Codigo_Contrato'Codigo del Contrato',cl.Nombre_Cliente 'Dueño del Contrato', tp.Tipo_Contrato 'Tipo de Contrato',
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
	select c.Codigo_Contrato'Codigo del Contrato',cl.Nombre_Cliente 'Dueño del Contrato', tp.Tipo_Contrato 'Tipo de Contrato',
	c.Fecha_Inicio_Contrato'Incio del Contrato',c.Fecha_Vencimiento'Finalizacion del Contrato',e.Nombre_Estado 'Estado del Contrato',
	c.Monto_Contrato'Costo del Contrato'
	from Contratos C
	inner join dbo.Estado e on c.Estado_Contrato = e.Codigo_Estado
	inner join dbo.TipoContrato tp on c.Tipo_Contrato = tp.Cod_Contrato
	inner join dbo.Cliente cl on c.Cliente_Contrato = cl.Codigo_Cliente
	where cl.Codigo_Cliente = @filtro;
	if @tipobusqueda = 'Estados'
	select c.Codigo_Contrato'Codigo del Contrato',cl.Nombre_Cliente 'Dueño del Contrato', tp.Tipo_Contrato 'Tipo de Contrato',
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