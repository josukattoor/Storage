SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [Name], [Price], [OrderDate], [Category], [Shelf], [Count], [Description]) VALUES (1, 'Apple', 20, getdate(), 'Klass1', '1A', 100, 'Apple Klass1')
SET IDENTITY_INSERT [dbo].[Product] OFF
