/* Procedimientos Almacenados */

/*Procedimiento para el Inicio del Sitema*/
create procedure Entrar_Sistema
	@Nombre_Usuario varchar(50),
	@Contrasena_Usuario varchar(50)
	as
begin
	select p.Nivel_Acceso from [dbo].[Usuarios] u
	inner join [dbo].[Perfiles] p  on u.Perfil_Acceso=p.Codigo_Perfil
	where u.Nombre_Usuario=@Nombre_Usuario and
	u.Contrasena_Usuario=@Contrasena_Usuario
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
		@Codigo_Empleado varchar(20),
		@Nombre_Usuario varchar(50),
		@Contrasena_Usuario varchar(50),
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
	@Codigo_Empleado varchar(20)
	as
	begin
		select COUNT(*) from [dbo].[Usuarios] u where u.Codigo_Empleado=@Codigo_Empleado
	end
	--Verificacion si Ya existe ese usuario
	create procedure VerificarUsuario
	@Nombre_Usuario varchar(50)
	as
	begin
		select COUNT(*) FROM [dbo].[Usuarios] U WHERE U.Nombre_Usuario=@Nombre_Usuario
	END
	--verificar si existe ese empleado
	create procedure VerificarEmpleado
	@Codigo_Empleado varchar(20)
	as
	begin
		select COUNT(*) FROM [dbo].[Empleado] E WHERE E.Identidad_Empleado=@Codigo_Empleado
	END 

/*---------------------------------Procedimientos Para Modificar usuarios---------------------------------*/
create procedure BuscarUsuario
	@Codigo_Empleado  varchar(50)
as
begin
	select U.Nombre_Usuario,U.Contrasena_Usuario, U.Perfil_Acceso from Usuarios U where u.Codigo_Empleado=@Codigo_Empleado
end
	--Modificar Usuario--
	create procedure ModificarUsuario
		@Codigo_Empleado as varchar(20),
		@Nombre_Usuario varchar(50),
		@Contrasena_Usuario varchar(50),
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
		@Nombre_Perfil varchar(20),
		@Descripcion_Perfil varchar(50)
	as
		begin 
			insert into Transporte_Bonilla.dbo.Perfiles
			select COUNT(*)+1, @Nivel_Acceso,@Nombre_Perfil,@Descripcion_Perfil from [dbo].[Perfiles]
		end
	--Verificacion de Perfil
	create procedure VerificarPerfil
		@Nombre_Perfil as varchar(50)
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


