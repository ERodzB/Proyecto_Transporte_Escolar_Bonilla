USE Transporte_Bonilla
GO
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (1, N'Cambio Aceite', N'Cambio de aceite quemado')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (2, N'Cambio de llantas', N'Cambio de llantas gastadas')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (3, N'Cambio de asientos', N'Cambio de asientos maltratados')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (4, N'Arreglos Electricos', N'Aparatos Electricos')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (5, N'Pintura', N'Retoques de Pintura')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (6, N'Suspension', N'Arreglar Suspension')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (7, N'Transmision', N'Mantenimiento a Transmision')
INSERT [dbo].[Tipo_Mantenimientos] ([Codigo_Tipo_Mantenimiento], [Nombre_Mantenimiento], [Descripcion_Mantenimiento]) VALUES (8, N'Motor', N'Mantenimiento al motor del vehiculo')
GO
INSERT [dbo].[Tipo_Pago] ([TipoPago], [NombrePago], [DescripcionPago]) VALUES (1, N'Pago Mensual', N'Pago monto Mensual por tiempo estipulado')
INSERT [dbo].[Tipo_Pago] ([TipoPago], [NombrePago], [DescripcionPago]) VALUES (2, N'Pago Completo', N'Pago todo el monto completo y se le dio un descuento')
GO
INSERT [dbo].[Tipo_Ruta] ([Tipo_Ruta], [Descripcion_Tipo_Ruta]) VALUES (N'Temporal', N'Contrato por Plazo de Meses')
INSERT [dbo].[Tipo_Ruta] ([Tipo_Ruta], [Descripcion_Tipo_Ruta]) VALUES (N'Viaje', N'Viaje Privado')
GO
INSERT [dbo].[TipoContrato] ([Cod_Contrato], [Tipo_Contrato], [Descripcion_Contrato]) VALUES (1, N'Temporal', N'Contrato por un Tiempo Establecido')
INSERT [dbo].[TipoContrato] ([Cod_Contrato], [Tipo_Contrato], [Descripcion_Contrato]) VALUES (2, N'Viaje', N'Contrato por un viaje privado')
GO
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (1, N'Vehiculos')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (2, N'Contratos')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (3, N'Empleados')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (4, N'Rutas')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (5, N'Usuarios')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (6, N'Pagos')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (7, N'Clientes')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (8, N'Asignacion')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (9, N'Devolucion')
INSERT [dbo].[TipoEvento] ([CodTipoEvento], [TipoEvento]) VALUES (10, N'Modificacion')
GO
INSERT [dbo].[TipoGasolina] ([CodGasolina], [NombreGasolina], [DescripcionGasolina]) VALUES (1, N'Super', N'Gasolina Super')
INSERT [dbo].[TipoGasolina] ([CodGasolina], [NombreGasolina], [DescripcionGasolina]) VALUES (2, N'Regular', N'Gasolina Regular')
INSERT [dbo].[TipoGasolina] ([CodGasolina], [NombreGasolina], [DescripcionGasolina]) VALUES (3, N'Diesel', N'Gasolina Diesel')
INSERT [dbo].[TipoGasolina] ([CodGasolina], [NombreGasolina], [DescripcionGasolina]) VALUES (4, N'Aeroplano', N'Gasolina de Aeronave')
GO
INSERT [dbo].[TipoLicencia] ([CodTipoLicencia], [TipoLicencia]) VALUES (1, N'Liviana')
INSERT [dbo].[TipoLicencia] ([CodTipoLicencia], [TipoLicencia]) VALUES (2, N'Pesada')
INSERT [dbo].[TipoLicencia] ([CodTipoLicencia], [TipoLicencia]) VALUES (3, N'Liviana Internacional')
INSERT [dbo].[TipoLicencia] ([CodTipoLicencia], [TipoLicencia]) VALUES (4, N'Pesada Internacional')
GO
INSERT [dbo].[TipoServicio] ([TipoServicio], [Descripcion]) VALUES (N'Bus Completo', N'Bus de salida y regreso')
INSERT [dbo].[TipoServicio] ([TipoServicio], [Descripcion]) VALUES (N'Medio Bus', N'Bus solo de salida, o solo de regreso')
INSERT [dbo].[TipoServicio] ([TipoServicio], [Descripcion]) VALUES (N'Salida o Regreso', N'Bus solo de Salida o solo de regreso')
INSERT [dbo].[TipoServicio] ([TipoServicio], [Descripcion]) VALUES (N'Salida y Regreso', N'Bus recoge los clientes y los retorna al mismo punto')
GO
INSERT [dbo].[TipoTransmision] ([CodTransmision], [NombreTransmision], [DescripcionTransmision]) VALUES (1, N'Manual', N'Tiene palanca de Cambios')
INSERT [dbo].[TipoTransmision] ([CodTransmision], [NombreTransmision], [DescripcionTransmision]) VALUES (2, N'Automatico', N'Solo pongalo en D')
INSERT [dbo].[TipoTransmision] ([CodTransmision], [NombreTransmision], [DescripcionTransmision]) VALUES (3, N'CVT', N'Automatico Falso')
INSERT [dbo].[TipoTransmision] ([CodTransmision], [NombreTransmision], [DescripcionTransmision]) VALUES (4, N'RVT', N'Automatico Fancy')
GO
INSERT [dbo].[TipoVehiculo] ([CodVehiculo], [Tipo_Vehiculo], [Descripcion_Tipo_Vehiculo]) VALUES (1, N'Microbus', N'Bus de Bajo Rodaje')
INSERT [dbo].[TipoVehiculo] ([CodVehiculo], [Tipo_Vehiculo], [Descripcion_Tipo_Vehiculo]) VALUES (2, N'Coaster', N'Bus de Medio Rodaje')
INSERT [dbo].[TipoVehiculo] ([CodVehiculo], [Tipo_Vehiculo], [Descripcion_Tipo_Vehiculo]) VALUES (3, N'Bus', N'Bus de Alto Rodaje')
GO
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'CT', N'Contrato')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'DC', N'Documentos')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'EP', N'Empleado')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'EV', N'Eventos')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'MT', N'Mantenimientos')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'PG', N'Pagos')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'RT', N'Rutas')
INSERT [dbo].[Categoria] ([Codigo_Categoria], [Nombre_Categoria]) VALUES (N'VE', N'Vehiculos')
GO
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (1, N'CT', N'Vigente', N'Contrato Vigente')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (2, N'CT', N'No Vigente', N'Contrato No Vigente')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (3, N'CT', N'Sin Validar', N'Contrato sin Firma')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (101, N'DC', N'Vigente', N'Documento Vigente')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (102, N'DC', N'No Vigente', N'Documento Vencido')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (201, N'EP', N'Enfermo', N'Con Incapacidad')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (301, N'EV', N'Sin Retornar', N'El vehiculo no ha sido retornada aun')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (302, N'EV', N'Retornado', N'El vehiculo fue retornado')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (303, N'EV', N'Retornado con Atraso', N'El vehiculo se retorno fuera de la hora laboral')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (304, N'EV', N'Concluido', N'Evento Terminado')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (305, N'EV', N'En Proceso', N'Eventro en Proceso')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (401, N'MT', N'Sin Empezar', N'Aun no se ha empezado el mantenimiento')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (402, N'MT', N'En Proceso', N'El mantenimiento se esta llevando acabo')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (403, N'MT', N'Concluido', N'Se concluyo el mantenimiento correctamente')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (501, N'PG', N'Pagado', N'Se realizo el pago sin problemas')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (502, N'PG', N'Sin Pagar', N'Aun no se ha realizado el Pago')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (503, N'PG ', N'Moroso', N'Tiene deuda con la empresa')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (604, N'RT', N'Deshabilitada', N'Hay problema en la Ruta')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (605, N'RT', N'Segura', N'La ruta no presenta ningun problema')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (701, N'VE', N'En Mantenimiento', N'El vehiculo esta en mantenimiento')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (702, N'VE', N'En Buen Estado', N'El vehiculo esta listo para rodar')
INSERT [dbo].[Estado] ([Codigo_Estado], [Codigo_Categoria], [Nombre_Estado], [Descripcion_Estado]) VALUES (703, N'VE', N'Dañado', N'El vehiculo esta fuera de servicio')
GO
INSERT [dbo].[Eventos] ([CodEvento], [TipoEvento], [FechaEvento], [Dato1], [Dato2], [Dato3], [Dato4], [Dato5], [Dato6]) VALUES (N'Asignacion1', 8, CAST(N'2019-07-15' AS Date), N'Asignacion de Unidad', N'APX4978', N'0801199802725', NULL, NULL, NULL)
INSERT [dbo].[Eventos] ([CodEvento], [TipoEvento], [FechaEvento], [Dato1], [Dato2], [Dato3], [Dato4], [Dato5], [Dato6]) VALUES (N'Contratacion1', 3, CAST(N'2019-07-17' AS Date), N'Contratacion Nuevo Empleado', N'1321232', NULL, NULL, NULL, NULL)
INSERT [dbo].[Eventos] ([CodEvento], [TipoEvento], [FechaEvento], [Dato1], [Dato2], [Dato3], [Dato4], [Dato5], [Dato6]) VALUES (N'Contratacion2', 3, CAST(N'2019-07-17' AS Date), N'Contratacion Nuevo Empleado', N'213213123', NULL, NULL, NULL, NULL)
INSERT [dbo].[Eventos] ([CodEvento], [TipoEvento], [FechaEvento], [Dato1], [Dato2], [Dato3], [Dato4], [Dato5], [Dato6]) VALUES (N'Devolucion1', 9, CAST(N'2019-07-15' AS Date), N'Devolucion de Unidad', N'APT7513', N'0801199701568', NULL, NULL, NULL)
INSERT [dbo].[Eventos] ([CodEvento], [TipoEvento], [FechaEvento], [Dato1], [Dato2], [Dato3], [Dato4], [Dato5], [Dato6]) VALUES (N'Modificacion1', 10, CAST(N'2019-07-17' AS Date), N'Modificacion de Empleado', N'0801199802725', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Genero] ([CodGenero], [Genero], [Descripcion_Genero]) VALUES (1, N'Masculino', N'Hombre')
INSERT [dbo].[Genero] ([CodGenero], [Genero], [Descripcion_Genero]) VALUES (2, N'Femenino', N'Mujer')
INSERT [dbo].[Genero] ([CodGenero], [Genero], [Descripcion_Genero]) VALUES (3, N'Otros', N'LGBT')
GO
INSERT [dbo].[Rutas] ([Codigo_Ruta], [Nombre_Ruta], [Descripcion_Ruta], [Tipo_Ruta]) VALUES (N'Aleman-El Centro', N'Aleman - Los Llanos - La Isla - El Centro	', N'Sin Especificar', N'Temporal')
INSERT [dbo].[Rutas] ([Codigo_Ruta], [Nombre_Ruta], [Descripcion_Ruta], [Tipo_Ruta]) VALUES (N'Anillo Periferico - Carrizal', N'	Anillo Periferico - UNAH - La Sosa - Ulloa - Carrizal', N'Sin Especificar', N'Temporal')
INSERT [dbo].[Rutas] ([Codigo_Ruta], [Nombre_Ruta], [Descripcion_Ruta], [Tipo_Ruta]) VALUES (N'Carrizal - Miraflores', N'	Carrizal - El Centro - Miraflores', N'Sin Especificar', N'Temporal')
INSERT [dbo].[Rutas] ([Codigo_Ruta], [Nombre_Ruta], [Descripcion_Ruta], [Tipo_Ruta]) VALUES (N'Cerro Grande - La Sosa', N'	Cerro Grande - Mall Premier - UNAH - La Sosa', N'Sin Especificar', N'Temporal')
INSERT [dbo].[Rutas] ([Codigo_Ruta], [Nombre_Ruta], [Descripcion_Ruta], [Tipo_Ruta]) VALUES (N'San Francisco-El Centro', N'	San Francisco - El Centro', N'Sin Especificar', N'Temporal')
INSERT [dbo].[Rutas] ([Codigo_Ruta], [Nombre_Ruta], [Descripcion_Ruta], [Tipo_Ruta]) VALUES (N'Viaje-1', N'Viaje Jorge Salgado', N'Tegucigalpa-Comoyagua', N'Viaje')
GO
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'AP', N'Ante. Penales')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'APl', N'Ante. Policiales')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'CCP', N'Carta Compromiso')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'CTr', N'Contrato')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'CV', N'Curriculum Vitae')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'ID', N'Identidad')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'IHSS', N'Carnet Seguro')
INSERT [dbo].[Documentos] ([Codigo_Documento], [Nombre_Documento]) VALUES (N'RCTr', N'Recibo de Pago de un Contrato')
GO
INSERT [dbo].[Cliente] ([Codigo_Cliente], [Nombre_Cliente], [Direccion_Cliente], [Telefono_Cliente], [Correo_Cliente]) VALUES (N'0705199000015', N'Allan Castellanos', N'Col. Linda Vista, Calle Principal, Casa #3', N'22334545', N'afcastellanos@hotmail.com')
INSERT [dbo].[Cliente] ([Codigo_Cliente], [Nombre_Cliente], [Direccion_Cliente], [Telefono_Cliente], [Correo_Cliente]) VALUES (N'0801199000001', N'Berta Romero', N'Col. Hato del Medio, Sector 7', N'96273132', N'maro@yahoo.com')
INSERT [dbo].[Cliente] ([Codigo_Cliente], [Nombre_Cliente], [Direccion_Cliente], [Telefono_Cliente], [Correo_Cliente]) VALUES (N'0801199802725', N'Eduardo Salgado', N'Nowhere', N'33967131', N'esalgado@dowalschool.net')
INSERT [dbo].[Cliente] ([Codigo_Cliente], [Nombre_Cliente], [Direccion_Cliente], [Telefono_Cliente], [Correo_Cliente]) VALUES (N'0801199802726', N'Jorge Romero', N'Col. Bella Oriente, Bloque J, Casa 4513', N'22555684', N'jesalgadoromero26@gmail.com')
INSERT [dbo].[Cliente] ([Codigo_Cliente], [Nombre_Cliente], [Direccion_Cliente], [Telefono_Cliente], [Correo_Cliente]) VALUES (N'0802199900011', N'Juanita Marina', N'Col. Bella Oriente, Bloque J, Casa 4513', N'22555684', N'jmarina@hotmail.com')
GO
INSERT [dbo].[Contratos] ([Codigo_Contrato], [Cliente_Contrato], [Tipo_Contrato], [Monto Mensual], [Cuotas_Mensuales], [Servicio], [Anticipo], [Fecha_Inicio_Contrato], [Monto_Contrato], [Fecha_Vencimiento], [Estado_Contrato], [Cod_Documento], [Tipo_Pago]) VALUES (N'2019-1-E', N'0801199802725', 1, 1200.0000, 5, N'Bus Completo', 0.0000, CAST(N'2019-01-01' AS Date), 6000.0000, CAST(N'2019-06-01' AS Date), 1, N'CTr', 1)
INSERT [dbo].[Contratos] ([Codigo_Contrato], [Cliente_Contrato], [Tipo_Contrato], [Monto Mensual], [Cuotas_Mensuales], [Servicio], [Anticipo], [Fecha_Inicio_Contrato], [Monto_Contrato], [Fecha_Vencimiento], [Estado_Contrato], [Cod_Documento], [Tipo_Pago]) VALUES (N'2019-2-B', N'0801199000001', 2, 0.0000, 0, N'Salida y Regreso', 2500.0000, CAST(N'2019-06-06' AS Date), 4500.0000, CAST(N'2019-06-07' AS Date), 2, N'CTr', 2)
GO
INSERT [dbo].[Rutas_Contratos] ([Codigo_Ruta], [Codigo_Contrato], [Parada_Contrato]) VALUES (N'Viaje-1', N'2019-2-B', N'Centro Comercial Comayagua')
INSERT [dbo].[Rutas_Contratos] ([Codigo_Ruta], [Codigo_Contrato], [Parada_Contrato]) VALUES (N'Cerro Grande - La Sosa', N'2019-1-E', N'Cerro Grande')
GO
INSERT [dbo].[Puesto] ([Codigo_Puesto], [Nombre_Puesto], [Descripcion_Puesto]) VALUES (1, N'Conductor', N'Maneja los vehiculos de la empresa')
INSERT [dbo].[Puesto] ([Codigo_Puesto], [Nombre_Puesto], [Descripcion_Puesto]) VALUES (2, N'Gerente de RRHH', N'Jefe de RRHH')
INSERT [dbo].[Puesto] ([Codigo_Puesto], [Nombre_Puesto], [Descripcion_Puesto]) VALUES (3, N'Gerente de IT', N'Jefe de IT')
INSERT [dbo].[Puesto] ([Codigo_Puesto], [Nombre_Puesto], [Descripcion_Puesto]) VALUES (4, N'Desarrollador', N'Desarrolla Cosas')
INSERT [dbo].[Puesto] ([Codigo_Puesto], [Nombre_Puesto], [Descripcion_Puesto]) VALUES (5, N'Asistente Tecnico', N'Asiste a los departamentos')
INSERT [dbo].[Puesto] ([Codigo_Puesto], [Nombre_Puesto], [Descripcion_Puesto]) VALUES (6, N'Asistente General', N'Asiste en todo lo que se pueda')
GO
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0301199901357', N'Eric Isaac Rodríguez Bonilla ', CAST(N'1990-04-30' AS Date), 1, N'95091516', N'pineapplebakerman@gmail.com', N'x', 2, 15000.0000, N'N/A', NULL, 0)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199502729', N'Alejandra Amador Salinas Garcia', CAST(N'2019-07-05' AS Date), 3, N'78789652', N'aamador@yahoo.com', N'Residencial Las Colinas, Casa 2432', 3, 3400.0000, N'N/A', NULL, 0)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199601515', N'Maria Alejandra Lupiac Garcia', CAST(N'1996-07-16' AS Date), 2, N'97665876', N'M.LupiacG@gmail.com', N'Colonia Hato En Medio, Casa #33', 1, 11000.0000, N'0801199601515', CAST(N'2025-06-05' AS Date), 1)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199701568', N'Bryan Adalberto Montoya Rivera', CAST(N'1997-01-26' AS Date), 3, N'98785469', N'b.montoya@gmail.com', N'Colonia Los Llanos, Bloque Z, Casa 2311', 1, 11500.0000, N'0801199701568', CAST(N'2024-07-12' AS Date), 2)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199802525', N'Jorgito de la Flor Perez Andino', CAST(N'1998-01-27' AS Date), 1, N'33874565', N'jflor@gmail.com', N'Colonia Altos del trapiche, casa #4', 4, 15689.0000, N'N/A', NULL, 0)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199802725', N'Jorge Eduardo Salgado Romero', CAST(N'1998-01-26' AS Date), 1, N'33967131', N'jesalgadoromero26@gmail.com', N'Colonia Bella Oriente, Bloque J, Casa 4513', 2, 25000.0000, N'N/A', NULL, 0)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199810682', N'Stephan Marcel Duarte Peña ', CAST(N'1998-05-29' AS Date), 1, N'99207373', N'stephan.1998@outlook.com', N'Colonia Altos de Toncontin, Bloque F, Casa #2114', 5, 19000.0000, N'N/A', NULL, 0)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'0801199919518', N'Anthony Wylberth Rodríguez Thompson', CAST(N'1999-09-07' AS Date), 1, N'87345567', N'awrodriguezt@gmail.com', N'Residencial Plaza, Bloque 70, Casa #2350', 6, 14000.0000, N'N/A', NULL, 0)
INSERT [dbo].[Empleado] ([Identidad_Empleado], [Nombre_Empleado], [Fecha_Nacimiento], [Genero], [Telefono], [Correo], [Direccion], [Puesto_Empleado], [Salario], [Licencia], [Fecha_Vencimiento_Licencia], [Tipo_Licencia]) VALUES (N'1502199600657', N'Lidia Nicole Mejía Carrasco', CAST(N'1996-05-29' AS Date), 2, N'99723232', N'lidiamejia29@yahoo.com', N'Residencial Centroamérica Este, Bloque 31, Casa #1813', 6, 18000.0000, N'N/A', NULL, 0)
GO
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'APL4398', 1, 2016, N'Toyota', N'Hiace TB', 16, 1, 3, N'Rojo', 2016, 702, CAST(N'2018-01-01' AS Date), CAST(N'2028-01-01' AS Date), N'0801199701568')
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'APT7513', 2, 2017, N'Nissan', N'Civilian W41', 30, 1, 3, N'Blanco', 2017, 703, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'APX4978', 1, 2014, N'Nissan', N'Urvan', 15, 2, 3, N'Negro', 2017, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), N'0801199802725')
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATB9978', 3, 2019, N'Mercedes-Benz', N'Citaro XLE', 60, 2, 3, N'Gris', 2018, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATF5599', 1, 2015, N'Toyota', N'Hiace TA', 18, 1, 3, N'Gris', 2016, 702, CAST(N'2018-01-01' AS Date), CAST(N'2028-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATH6757', 2, 2019, N'Hyundai', N'County', 25, 1, 3, N'Crema', 2019, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATP5709', 2, 2015, N'Toyota', N'Coaster', 35, 1, 3, N'Amarillo', 2018, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATU9989', 3, 2019, N'Mercedes-Benz', N'Citaro LE', 55, 2, 3, N'Titanio', 2018, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATY2690', 3, 2019, N'Kia', N'Granbird', 52, 1, 3, N'Anaranjado', 2019, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATY8790', 2, 2017, N'Toyota', N'Coaster', 32, 1, 3, N'Gris', 2018, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
INSERT [dbo].[Vehiculos] ([Codigo_Vehiculo], [Tipo_Vehiculo], [Anio_Vehiculo], [Marca_Vehiculo], [Modelo_Vehiculo], [Capacidad_Vehiculo], [Transmision_Vehiculo], [Combustible_Vehiculo], [Color_Vehiculo], [Anio_Adquisicion], [Estado_Vehiculo], [Emision_Permiso], [Vencimiento_Permiso], [Responsable_Vehiculo]) VALUES (N'ATZ7895', 3, 2019, N'Mercedes-Benz', N'Tourismo', 50, 2, 3, N'Verde', 2019, 702, CAST(N'2019-01-01' AS Date), CAST(N'2029-01-01' AS Date), NULL)
GO
INSERT [dbo].[Vehiculos_Rutas] ([Codigo_Ruta], [Codigo_Vehiculo], [Horario_Salida], [Horario_Entrada], [Cantidad_Pasajeros_Actuales]) VALUES (N'Aleman-El Centro', N'APL4398', CAST(N'04:30:00' AS Time), CAST(N'06:00:00' AS Time), 0)
INSERT [dbo].[Vehiculos_Rutas] ([Codigo_Ruta], [Codigo_Vehiculo], [Horario_Salida], [Horario_Entrada], [Cantidad_Pasajeros_Actuales]) VALUES (N'Anillo Periferico - Carrizal', N'ATB9978', CAST(N'06:00:00' AS Time), CAST(N'07:30:00' AS Time), 0)
INSERT [dbo].[Vehiculos_Rutas] ([Codigo_Ruta], [Codigo_Vehiculo], [Horario_Salida], [Horario_Entrada], [Cantidad_Pasajeros_Actuales]) VALUES (N'Cerro Grande - La Sosa', N'ATH6757', CAST(N'07:30:00' AS Time), CAST(N'09:00:00' AS Time), 0)
INSERT [dbo].[Vehiculos_Rutas] ([Codigo_Ruta], [Codigo_Vehiculo], [Horario_Salida], [Horario_Entrada], [Cantidad_Pasajeros_Actuales]) VALUES (N'San Francisco-El Centro', N'ATZ7895', CAST(N'06:00:00' AS Time), CAST(N'09:00:00' AS Time), 0)
INSERT [dbo].[Vehiculos_Rutas] ([Codigo_Ruta], [Codigo_Vehiculo], [Horario_Salida], [Horario_Entrada], [Cantidad_Pasajeros_Actuales]) VALUES (N'Carrizal - Miraflores', N'ATY8790', CAST(N'09:30:00' AS Time), CAST(N'12:00:00' AS Time), 0)
INSERT [dbo].[Vehiculos_Rutas] ([Codigo_Ruta], [Codigo_Vehiculo], [Horario_Salida], [Horario_Entrada], [Cantidad_Pasajeros_Actuales]) VALUES (N'Viaje-1', N'ATY2690', CAST(N'06:00:00' AS Time), CAST(N'12:00:00' AS Time), NULL)
GO
INSERT [dbo].[Acceso] ([Codigo_Acceso], [Tipo_Acceso], [Descripcion_Acceso]) VALUES (1, N'Alto', N'Acceso Completo')
INSERT [dbo].[Acceso] ([Codigo_Acceso], [Tipo_Acceso], [Descripcion_Acceso]) VALUES (2, N'Medio', N'Acceso de consultor')
INSERT [dbo].[Acceso] ([Codigo_Acceso], [Tipo_Acceso], [Descripcion_Acceso]) VALUES (3, N'Bajo', N'Acceso Superficial')
GO
INSERT [dbo].[Mantenimientos] ([Codigo_Mantenimiento], [Tipo_Mantenimiento], [Fecha_Mantenimiento], [Codigo_Vehiculo], [Costo_Mantenimiento]) VALUES (1, 1, CAST(N'2019-01-27' AS Date), N'ATB9978', 1500.0000)
INSERT [dbo].[Mantenimientos] ([Codigo_Mantenimiento], [Tipo_Mantenimiento], [Fecha_Mantenimiento], [Codigo_Vehiculo], [Costo_Mantenimiento]) VALUES (2, 5, CAST(N'2019-01-27' AS Date), N'ATH6757', 9000.0000)
GO
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (1, 1, N'Administrador', N'Tiene acceso completo')
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (2, 2, N'Consultor', N'Puede hacer consultas')
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (3, 2, N'Digitalizador', N'Puede ingresar datos')
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (4, 2, N'Auditor', N'Puede modifcar datos')
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (5, 2, N'Empleado', N'Puede Ingresar, Modificar y Consultar')
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (6, 3, N'Invitado', N'Solo puede ver notificaciones')
INSERT [dbo].[Perfiles] ([Codigo_Perfil], [Nivel_Acceso], [Nombre_Perfil], [Descripcion_Perfil]) VALUES (7, 3, N'Pasante ', N'Invitado con usuario')
GO
INSERT [dbo].[Usuarios] ([Codigo_Empleado], [Nombre_Usuario], [Contrasena_Usuario], [Perfil_Acceso]) VALUES (N'0801199919518', N'athompson', N'1', 1)
INSERT [dbo].[Usuarios] ([Codigo_Empleado], [Nombre_Usuario], [Contrasena_Usuario], [Perfil_Acceso]) VALUES (N'0301199901357', N'ebonilla', N'1', 1)
INSERT [dbo].[Usuarios] ([Codigo_Empleado], [Nombre_Usuario], [Contrasena_Usuario], [Perfil_Acceso]) VALUES (N'0801199802725', N'esalgado', N'1', 1)
INSERT [dbo].[Usuarios] ([Codigo_Empleado], [Nombre_Usuario], [Contrasena_Usuario], [Perfil_Acceso]) VALUES (N'1502199600657', N'lmejia', N'1', 1)
INSERT [dbo].[Usuarios] ([Codigo_Empleado], [Nombre_Usuario], [Contrasena_Usuario], [Perfil_Acceso]) VALUES (N'0801199810682', N'sduarte', N'1', 1)
GO


