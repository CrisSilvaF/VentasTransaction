USE [VentasTransactionDB]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([Id], [Descripcion], [PrecioUnitario]) VALUES (1, N'Azucar', CAST(27.00 AS Decimal(18, 2)))
INSERT [dbo].[Productos] ([Id], [Descripcion], [PrecioUnitario]) VALUES (2, N'Jugo Mango', CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[Productos] ([Id], [Descripcion], [PrecioUnitario]) VALUES (3, N'Jugo Tropicana', CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[Productos] ([Id], [Descripcion], [PrecioUnitario]) VALUES (4, N'Soda', CAST(43.50 AS Decimal(18, 2)))
INSERT [dbo].[Productos] ([Id], [Descripcion], [PrecioUnitario]) VALUES (5, N'Cacahuates', CAST(10.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Existencias] ON 

INSERT [dbo].[Existencias] ([Id], [ProductoId], [Existencia]) VALUES (1, 1, CAST(47.000 AS Decimal(18, 3)))
INSERT [dbo].[Existencias] ([Id], [ProductoId], [Existencia]) VALUES (2, 2, CAST(97.000 AS Decimal(18, 3)))
INSERT [dbo].[Existencias] ([Id], [ProductoId], [Existencia]) VALUES (3, 3, CAST(3.000 AS Decimal(18, 3)))
INSERT [dbo].[Existencias] ([Id], [ProductoId], [Existencia]) VALUES (4, 4, CAST(1000.000 AS Decimal(18, 3)))
INSERT [dbo].[Existencias] ([Id], [ProductoId], [Existencia]) VALUES (5, 5, CAST(800.000 AS Decimal(18, 3)))
SET IDENTITY_INSERT [dbo].[Existencias] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [Nombre]) VALUES (1, N'Alex')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Folios] ON 

INSERT [dbo].[Folios] ([Id], [Folio]) VALUES (1, 0)
SET IDENTITY_INSERT [dbo].[Folios] OFF
GO
