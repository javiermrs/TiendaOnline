USE [TiendaOnline]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 26/4/2021 11:24:44 a. m. ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[fechaNacimiento] [datetime2](7) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrito]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[email] [nvarchar](max) NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Carrito] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriaProductos]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaProductos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombreCategoria] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CategoriaProductos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especiales]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especiales](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Especiales] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[numeroOrden] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[numeroTel] [nvarchar](max) NOT NULL,
	[Estado] [nvarchar](max) NULL,
	[Correo] [nvarchar](max) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Lat] [nvarchar](max) NOT NULL,
	[Long] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenDetalles]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenDetalles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrdenID] [int] NOT NULL,
	[ProductoID] [int] NOT NULL,
 CONSTRAINT [PK_OrdenDetalles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Precio] [float] NOT NULL,
	[Imagen] [nvarchar](max) NULL,
	[Disponibilidad] [bit] NOT NULL,
	[Detalles] [nvarchar](max) NOT NULL,
	[CategoriaProductoId] [int] NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slider]    Script Date: 26/4/2021 11:24:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slider](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Slider] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200724030033_agregarProductosEnLaBaseDeDatos', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200724204905_agregarEspecialesEnLaBaseDeDatos', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200724234012_agregarModeloProducto', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200725061521_cambioTipoDeDatoPrecio', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200726003700_agregandoOrdenYOrdenDetalles', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200727020434_AgregandoCampoTablaUsuario', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200802235533_agregandoSlider', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200803023620_Carrito', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200803151247_cambiandoRequiredFoto', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200803155308_SliderUpdate', N'2.2.6-servicing-10079')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1', N'ADMIN', N'ADMIN', NULL)
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'2', N'USER', N'USER', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'724a87f6-41f6-4381-a536-11ef10c709a3', N'1')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'425842e9-dceb-4fd3-b02a-ab62423bff38', N'2')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e1c9ac01-f9c8-4b28-9bcd-20b58afb9010', N'2')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [fechaNacimiento]) VALUES (N'425842e9-dceb-4fd3-b02a-ab62423bff38', N'morillo@gmail.com', N'MORILLO@GMAIL.COM', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEFb4CQbUy7hLjCccpvCuu2RKSxogrKSkBsS/0YzRWJcI6qQHP9/BuY+fCoi+Di33PQ==', N'GQ464XY3HNU6IU7J6CIDJCOULL5V2Z7R', N'c0465738-9525-452d-a2f6-cca2c11df4cd', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', CAST(N'2021-04-26T09:56:00.0000000' AS DateTime2))
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [fechaNacimiento]) VALUES (N'724a87f6-41f6-4381-a536-11ef10c709a3', N'javier@gmail.com', N'JAVIER@GMAIL.COM', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEASBVDdUBo9reGjQDmi1z6niL7jv1yPzwCWYgq89KIRHeGlXL2+6LY1aK37BUuJG0Q==', N'YJGLZ7KJJMZA6RWEASU6VESN3VJ5TQ5G', N'82530cb9-bf5d-4d32-a360-7dfa637a00a9', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', CAST(N'2000-12-26T09:42:00.0000000' AS DateTime2))
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [fechaNacimiento]) VALUES (N'e1c9ac01-f9c8-4b28-9bcd-20b58afb9010', N'jams@gmail.com', N'JAMS@GMAIL.COM', NULL, NULL, 0, N'AQAAAAEAACcQAAAAEM5Bia8dQzqKTira2h44yUFrWAvKPel91hvV7V/T6miKTnxR0XxbmsDU5be1sV/fjg==', N'IFK6NPCGXFAOZTRGXA2BY7XLR2YBNV6T', N'157480d0-40dc-4297-a510-246e806006a3', NULL, 0, 0, NULL, 1, 0, N'ApplicationUser', CAST(N'2000-02-26T09:45:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[CategoriaProductos] ON 
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (1, N'Tecnología')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (2, N'Ropas')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (3, N'Calzados')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (4, N'Deportes')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (5, N'Salud y Belleza')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (7, N'Hogar')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (8, N'Repuestos/Accesorios')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (9, N'Videojuegos')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (10, N'Bebés ')
GO
INSERT [dbo].[CategoriaProductos] ([ID], [nombreCategoria]) VALUES (11, N'Música')
GO
SET IDENTITY_INSERT [dbo].[CategoriaProductos] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (1, N'MSI GL65 LEOPARD', 70000, N'Imagenes/msi.png', 1, N'I7, 16GB DDR4, W10, 1TB SSD', 1)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (2, N'IPhone 11 Pro Max', 40000, N'Imagenes/iph.jpg', 1, N'Gold 250GB', 1)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (3, N'Nike Lebron 17', 10000, N'Imagenes/lebron.jpg', 1, N'Low Bred', 3)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (4, N'Gucci Shoes', 40000, N'Imagenes/gucci.jpg', 1, N'Women, Size 40', 3)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (5, N'Balon Molten Fiba', 3000, N'Imagenes/balon.jpg', 1, N'2015-2018', 4)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (6, N'Sillon Reclinable', 20000, N'Imagenes/Sillon.jpg', 1, N'Este sillón reclinable está diseñado para tu máxima comodidad, cuenta con reposaba brazos y espaldar acolchados', 7)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (7, N'PS5', 50000, N'Imagenes/ps5.jpeg', 1, N'Nuevo', 9)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (8, N'Gorra Nike', 2000, N'Imagenes/nike gorra.jpg', 1, N'Aerobill Classic9', 2)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (9, N'Panntalon deportio Nike', 1000, N'Imagenes/Nikee.jpg', 1, N'size 32', 4)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (10, N'Cuna para Bebe', 18000, N'Imagenes/cuna.jpg', 1, N'Confortable', 10)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (11, N'Equipo de Sonido', 5000, N'Imagenes/sonido.jpg', 1, N'Bocinas, TV', 11)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (12, N'Piano Yamaha Motif XF6', 80000, N'Imagenes/piano.jpg', 1, N'5 Octavas', 11)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (13, N'Volante Sparco', 14000, N'Imagenes/volante.jpg', 1, N'350mm', 8)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (14, N'Mascara Negra', 1000, N'Imagenes/mascara.jpg', 1, N'Limpieza facial profunda', 5)
GO
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio], [Imagen], [Disponibilidad], [Detalles], [CategoriaProductoId]) VALUES (15, N'Xbox Series X', 50000, N'Imagenes/Xbox Series X.png', 1, N'Nueo', 9)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Slider] ON 
GO
INSERT [dbo].[Slider] ([ID], [image], [Nombre], [Descripcion]) VALUES (1, N'Slider/pexels-victor-freitas-841130.jpg', N'Gym', N'The best clothes')
GO
INSERT [dbo].[Slider] ([ID], [image], [Nombre], [Descripcion]) VALUES (2, N'Slider/pexels-nathan-cowley-1153369.jpg', N'Cocina', N'Cocina')
GO
INSERT [dbo].[Slider] ([ID], [image], [Nombre], [Descripcion]) VALUES (3, N'Slider/pexels-pixabay-459654.jpg', N'Mac', N'Mac')
GO
SET IDENTITY_INSERT [dbo].[Slider] OFF
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Carrito]  WITH CHECK ADD  CONSTRAINT [FK_Carrito_Productos_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Productos] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Carrito] CHECK CONSTRAINT [FK_Carrito_Productos_ProductId]
GO
ALTER TABLE [dbo].[OrdenDetalles]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDetalles_Orden_OrdenID] FOREIGN KEY([OrdenID])
REFERENCES [dbo].[Orden] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdenDetalles] CHECK CONSTRAINT [FK_OrdenDetalles_Orden_OrdenID]
GO
ALTER TABLE [dbo].[OrdenDetalles]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDetalles_Productos_ProductoID] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Productos] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdenDetalles] CHECK CONSTRAINT [FK_OrdenDetalles_Productos_ProductoID]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_CategoriaProductos_CategoriaProductoId] FOREIGN KEY([CategoriaProductoId])
REFERENCES [dbo].[CategoriaProductos] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_CategoriaProductos_CategoriaProductoId]
GO