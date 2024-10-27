SET IDENTITY_INSERT [dbo].[UserActions] ON
INSERT INTO [dbo].[UserActions] ([ActionId], [UserId], [Foto], [Name], [Patrocinador], [ActionDate], [ActionBio], [ODS], [ActionStatus], [VolunteersTotal], [NumberOfPeopleHelped], [Rate]) 
VALUES (1, 1, 0x, 'Nome da Ação', 0, '2024-10-27', 'Descrição da Ação', 1, 1, 10, 100, 5)
SET IDENTITY_INSERT [dbo].[UserActions] OFF
