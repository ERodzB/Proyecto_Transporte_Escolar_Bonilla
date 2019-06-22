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
 

/* Procedimientos Almacenados */

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

/*Cargar comboBox de Perfiles */
create procedure cargarPerfiles
as
begin
	select p.Codigo_Perfil, p.Nombre_Perfil from [dbo].[Perfiles] p
end
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
	--Verificacion si Empleado tiene usuario--
	create procedure verificar_empleado_usuario
	@Codigo_Empleado varchar(50)
	as
	begin
		select COUNT(*) from [dbo].[Usuarios] u where u.Codigo_Empleado=@Codigo_Empleado
	end
	--Verificacion si Ya existe ese usuario
	create procedure VerificarUsuario
	@Nombre_Usuario varchar(100)
	as
	begin
		select COUNT(*) FROM [dbo].[Usuarios] U WHERE U.Nombre_Usuario=@Nombre_Usuario
	END
	--verificar si existe ese empleado
	create procedure VerificarEmpleado
	@Codigo_Empleado varchar(50)
	as
	begin
		select COUNT(*) FROM [dbo].[Empleado] E WHERE E.Identidad_Empleado=@Codigo_Empleado
	END 

/*---------------------------------Procedimientos Para Modificar usuarios---------------------------------*/
create procedure BuscarUsuario
	@Codigo_Empleado  varchar(100)
as
begin
	select U.Nombre_Usuario,U.Contrasena_Usuario, U.Perfil_Acceso from Usuarios U where u.Codigo_Empleado=@Codigo_Empleado
end
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
	--Verificacion de Perfil
	create procedure VerificarPerfil
		@Nombre_Perfil as varchar(100)
	as
		begin
			select COUNT(*) from Transporte_Bonilla.dbo.Perfiles p
			where @Nombre_Perfil=p.Nombre_Perfil
		end
	--Mostrar Informacion Perfil
	create procedure InfoPerfil
		@Codigo_Perfil int
	as
		begin
			select  P.Nivel_Acceso,  P.Nombre_Perfil, P.Descripcion_Perfil from Transporte_Bonilla.dbo.Perfiles P 
			where Codigo_Perfil=@Codigo_Perfil
		END
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
		

select  * from Transporte_Bonilla.dbo.Perfiles
select * from Empleado
select * from Usuarios


