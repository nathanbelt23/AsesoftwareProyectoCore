USE [Asesoftware]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comercio]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comercio](
	[id_comercio] [int] IDENTITY(1,1) NOT NULL,
	[non_comercio] [nvarchar](max) NULL,
	[num_aforo] [int] NOT NULL,
 CONSTRAINT [PK_Comercio] PRIMARY KEY CLUSTERED 
(
	[id_comercio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_estado] [nvarchar](max) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[id_servicio] [int] IDENTITY(1,1) NOT NULL,
	[nom_servicio] [nvarchar](max) NULL,
	[hora_apertura] [time](7) NOT NULL,
	[hora_cierre] [time](7) NOT NULL,
	[id_comercio] [int] NOT NULL,
	[duracion] [int] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[id_turno] [int] IDENTITY(1,1) NOT NULL,
	[fecha_turno] [datetime2](7) NOT NULL,
	[hora_inicio] [datetime2](7) NOT NULL,
	[hora_fin] [datetime2](7) NOT NULL,
	[id_estado] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[id_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210516204654_Version_0.0.1', N'3.1.1')
GO
SET IDENTITY_INSERT [dbo].[Comercio] ON 

INSERT [dbo].[Comercio] ([id_comercio], [non_comercio], [num_aforo]) VALUES (1, N'Sede Calle 116 con  7', 50)
INSERT [dbo].[Comercio] ([id_comercio], [non_comercio], [num_aforo]) VALUES (2, N'Sede Calle 72 con 10', 50)
SET IDENTITY_INSERT [dbo].[Comercio] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado] ON 

INSERT [dbo].[Estado] ([id_estado], [nombre_estado]) VALUES (1, N'Generado')
INSERT [dbo].[Estado] ([id_estado], [nombre_estado]) VALUES (2, N'Atendido')
SET IDENTITY_INSERT [dbo].[Estado] OFF
GO
SET IDENTITY_INSERT [dbo].[Servicios] ON 

INSERT [dbo].[Servicios] ([id_servicio], [nom_servicio], [hora_apertura], [hora_cierre], [id_comercio], [duracion]) VALUES (1, N'Odontologia sede chico', CAST(N'08:00:00' AS Time), CAST(N'18:00:00' AS Time), 2, 30)
INSERT [dbo].[Servicios] ([id_servicio], [nom_servicio], [hora_apertura], [hora_cierre], [id_comercio], [duracion]) VALUES (2, N'Odontologia sede norte', CAST(N'08:00:00' AS Time), CAST(N'18:00:00' AS Time), 1, 30)
SET IDENTITY_INSERT [dbo].[Servicios] OFF
GO
SET IDENTITY_INSERT [dbo].[Turno] ON 

INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (142, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T15:37:16.3400000' AS DateTime2), CAST(N'2021-05-17T16:07:16.3400000' AS DateTime2), 1, 1)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (143, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T16:07:16.3400000' AS DateTime2), CAST(N'2021-05-17T16:37:16.3400000' AS DateTime2), 1, 1)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (144, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T16:37:16.3400000' AS DateTime2), CAST(N'2021-05-17T17:07:16.3400000' AS DateTime2), 1, 1)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (158, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T17:07:16.3400000' AS DateTime2), CAST(N'2021-05-17T17:37:16.3400000' AS DateTime2), 1, 1)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (275, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T13:08:38.7333333' AS DateTime2), CAST(N'2021-05-17T13:38:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (276, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T13:38:38.7333333' AS DateTime2), CAST(N'2021-05-17T14:08:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (277, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T14:08:38.7333333' AS DateTime2), CAST(N'2021-05-17T14:38:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (278, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T14:38:38.7333333' AS DateTime2), CAST(N'2021-05-17T15:08:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (279, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T15:08:38.7333333' AS DateTime2), CAST(N'2021-05-17T15:38:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (280, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T15:38:38.7333333' AS DateTime2), CAST(N'2021-05-17T16:08:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (281, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T16:08:38.7333333' AS DateTime2), CAST(N'2021-05-17T16:38:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (282, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T16:38:38.7333333' AS DateTime2), CAST(N'2021-05-17T17:08:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (283, CAST(N'2021-05-17T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-17T17:08:38.7333333' AS DateTime2), CAST(N'2021-05-17T17:38:38.7333333' AS DateTime2), 1, 2)
INSERT [dbo].[Turno] ([id_turno], [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]) VALUES (284, CAST(N'2021-05-18T00:00:00.0000000' AS DateTime2), CAST(N'2021-05-18T08:00:00.0000000' AS DateTime2), CAST(N'2021-05-18T08:30:00.0000000' AS DateTime2), 1, 2)
SET IDENTITY_INSERT [dbo].[Turno] OFF
GO
ALTER TABLE [dbo].[Servicios]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_Comercio_id_comercio] FOREIGN KEY([id_comercio])
REFERENCES [dbo].[Comercio] ([id_comercio])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Servicios] CHECK CONSTRAINT [FK_Servicios_Comercio_id_comercio]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Estado_id_estado] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estado] ([id_estado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Estado_id_estado]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Servicios_id_servicio] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[Servicios] ([id_servicio])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Servicios_id_servicio]
GO
/****** Object:  StoredProcedure [dbo].[PC_I_TURNO]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PC_I_TURNO]
	-- Add the parameters for the stored procedure here
@Fecha_Inicio     DATE='2021-05-18',
@Fecha_Fin		  DATE='2021-05-19',
@Id_Servicio      INT=2



AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

SET LANGUAGE SPANISH

DECLARE @fechaIns datetime = @Fecha_Inicio
DECLARE @fechaSalFin datetime = @Fecha_Inicio




 DECLARE @duracion  int, 
 @hora_apertura  time(7),
 @hora_cierre   time(7),
 @salir  bit=0,
 @creo  bit=0


 select 
 @duracion= duracion,
 @hora_apertura= hora_apertura,
 @hora_cierre= hora_cierre
 from  [dbo].[Servicios] 
 where id_servicio= @Id_Servicio


 if(@duracion is null)
 begin
 select 
		 0 as Ok, 
			'Ups el servicio no existe', 0  as ID

set  @salir=1

 end



 while @salir=0 and   CONVERT(DATE,@fechaIns)<= @Fecha_Fin
 begin
 DECLARE @hora_fin DATETIME2= (
  
 SELECT  MAX(HORA_FIN)
  FROM 
	 [dbo].[Turno] 
  WHERE    
		id_servicio		=	@Id_Servicio
		and
		CONVERT(date,[fecha_turno])	=	CONVERT(date,@fechaIns) 

	)



	if not  exists (
	
	 
 SELECT *  
 FROM 
		Turno 
 WHERE    
		id_servicio		=	@Id_Servicio
		and
		CONVERT(date,[fecha_turno])	= CONVERT(date,@fechaIns) 
	
	)
	begin
		IF(convert(date, @fechaIns)=convert(date, GETDATE()))
		BEGIN
			set  @hora_fin=  GETDATE()

				
		END
		
	
	end

	
if(convert(date, @fechaIns)=convert(date, GETDATE()) and  @hora_fin is not null)
begin

if(@hora_fin)<GETDATE()
begin
set @hora_fin= getdate()
		print(100)
end


end



if(@hora_fin is null and  convert(date, @fechaIns)>convert(date, GETDATE()) )
begin
		print(111)
	set  @hora_fin=   @fechaIns

	set  @hora_fin=  DATEADD(HOUR,  datepart(HOUR, @hora_apertura), @hora_fin)		
	set  @hora_fin=  DATEADD(HOUR,  datepart(minute, @hora_apertura), @hora_fin)		
	set @fechaSalFin =DATEADD(MINUTE, @duracion,@hora_fin)  
	set @fechaIns = @hora_fin;
		
	  insert into [dbo].[Turno] 
	  (
	   [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]
	  )
	  values (convert(date,@fechaIns ), @fechaIns,@fechaSalFin, 1, @Id_Servicio ) 

	  select 
			1  as Ok, 
			'Registro  exitoso para ' + convert(nvarchar, @fechaIns ) Message, @@IDENTITY  as ID
	  set @creo=1				
	  set  @salir=1
			
end


else


if  CAST(@hora_fin as  time)>DATEADD(minute,-1*@duracion , @hora_cierre)
begin
		set @fechaIns=CONVERT(date,  DATEADD(day, 1, @fechaIns))
		---set  @fechaIns=DATEADD(HOUR , DATEPART(HOUR, @hora_apertura),@fechaIns)
	    ---set  @fechaIns=DATEADD(HOUR , DATEPART(MINUTE, @hora_apertura),@fechaIns)
		SET  @hora_fin= NULL
		print(143)

end
else
begin



		set @fechaSalFin =DATEADD(MINUTE, @duracion,@hora_fin)  

		set @fechaIns = @hora_fin;
		print(150)
	  insert into [dbo].[Turno] 
	  (
	   [fecha_turno], [hora_inicio], [hora_fin], [id_estado], [id_servicio]
	  )
	  values (convert(date,@fechaIns ), @fechaIns,@fechaSalFin, 1, @Id_Servicio ) 

	  select 
			1  as Ok, 
			'Registro  exitoso para ' + convert(nvarchar, @fechaIns ) Message, @@IDENTITY  as ID
	  set @creo=1				
	  set  @salir=1
end


end



if(@creo=0)
begin
select 
			0  as Ok, 
			'Ups no tengo agenda para este rango de fechas, por fa intenta con otro dia' Message, 0  as ID
end



END
GO
/****** Object:  StoredProcedure [dbo].[PC_V_Turno]    Script Date: 17/05/2021 13:46:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[PC_V_Turno]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
SELECT  

top 100

		T.id_turno, T.fecha_turno, T.hora_fin, T.hora_inicio
		,S.id_servicio, S.nom_servicio , C.non_comercio, C.id_comercio
		,ES.id_estado, ES.nombre_estado
FROM  
			Turno  AS T
			INNER  JOIN
			[dbo].[Servicios]   AS S   ON  T.id_servicio = S.id_servicio
			INNER JOIN
			[dbo].[Comercio] AS    C   ON S.id_comercio = C.id_comercio 
			INNER JOIN
			Estado    ES  ON ES.id_estado = T.id_estado
order by  convert(date,T.fecha_turno) DESC,  T.hora_fin desc

END

GO
