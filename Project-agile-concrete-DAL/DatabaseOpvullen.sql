SET IDENTITY_INSERT [dbo].[Klanten] ON
INSERT INTO [ProjectAgile].dbo.Klanten(Id,Naam,Voornaam,Email,Telefoon,Straat,Huisnummer,Gemeente,Postcode, BTWNummer)
VALUES
  (1,'Cherry','Hasad','erat.vel.pede@hotmail.com','(598) 369-9844','Netus Road',52,'Umbria','393124',NULL),
  (2,'Hurley','Wesley','enim.commodo.hendrerit@icloud.edu','(388) 545-6802','P.O. Box 383, 3034 Fusce St.',4,'Gilgit Baltistan','5454',NuLL),
  (3,'Winters','Marvin','nam@protonmail.net','1-292-257-0308','720-8499 Morbi Rd.',25,'Friuli-Venezia Giulia','651747',NULL),
  (4,'Dickerson','Hamilton','dictum.proin.eget@outlook.edu','1-555-717-7360','281-6519 Aenean Av.',60,'Oost-Vlaanderen','26608',Null),
  (5,'Boyle en Co',Null,'libero.nec.ligula@icloud.couk','1-603-298-5485','Ap #201-1428 Euismod Av.',59,'Tula Oblast','6367','ddf887339'),
  (6,'Decker','Abdul','morbi@hotmail.couk','(887) 726-8869','8147 Mauris St.',75,'Victoria','3965',NULL),
  (7,'Rosa','Cyrus','dictum.proin.eget@google.net','(150) 671-7151','659-6101 Vulputate Av.',48,'Bayern','516967',NULL),
  (8,'CannonMD',Null,'integer@outlook.org','(859) 111-6774','P.O. Box 476, 5768 Fringilla Street',41,'Norte de Santander','25634','dfdff33434'),
  (9,'Weber','Graham','sem.consequat@google.net','1-316-513-7495','142-9244 Blandit. Street',71,'Manitoba','41230',NULL),
  (10,'Carey','Arthur','elit.nulla@google.net','(701) 538-5295','8029 Phasellus St.',75,'Emilia-Romagna','35770',Null);
  insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (11, 'Haslen', 'Rivkah', 'rhaslena@samsung.com', '780-966-6892', 'Hanson', 94, 'Beerse', 3000, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (12, 'Poncet', 'Vittorio', 'vponcetb@wikispaces.com', '493-430-3278', 'Ohio', 179, 'Turnhout', 1207, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (13, 'Leonards', 'Claude', 'cleonardsc@istockphoto.com', '233-608-4887', 'Northwestern', 92, 'Gävleborg', 3003, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (14, 'Bartlosz', 'Audy', 'abartloszd@unblog.fr', '355-912-7333', 'Mcguire', 79, 'Antwerpen', 2115, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (15, 'Throughton', NULL, 'sthroughtone@fotki.com', '115-927-7074', 'Texas', 198, 'Berchem', 3003, '704463625-X');
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (16, 'Kirmond', 'Lonnie', 'lkirmondf@nba.com', '693-277-8200', 'Donald', 75, 'Brecht', 4909, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (17, 'Benge en zonen', NULL, 'abengeg@dagondesign.com', '883-588-6628', 'Eastlawn', 144, 'Norrbotten', 1590, '477487960-6');
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (18, 'Bryden', 'Teddi', 'tbrydenh@google.co.uk', '457-458-8694', 'Crowley', 5, 'Antwerpen', 1562, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (19, 'Durnan', 'Myrle', 'mdurnani@bloglines.com', '516-477-1102', 'Sachs', 186, 'Droes', 1379, null);
insert into dbo.Klanten (id, Naam, Voornaam, Email, Telefoon, Straat, Huisnummer, Gemeente, Postcode, BTWNummer) values (20, 'Doge', 'Elisabetta', 'edogej@wiley.com', '302-185-3554', 'Center', 129, 'Field', 2746, null);

  SET IDENTITY_INSERT [dbo].[Klanten] OFF

  SET IDENTITY_INSERT [dbo].Winkels ON
  INSERT INTO [dbo].Winkels(Id,Gemeente,Naam,Postcode)
VALUES
  (1,'South Chungcheong','Fermentum Fermentum Corporation','738613'),
  (2,'Emilia-Romagna','Mauris Eu Turpis Incorporated','9596'),
  (3,'Guerrero','Mi Felis Limited','305790'),
  (4,'Kujawsko-pomorskie','Id Blandit Ltd','6209'),
  (5,'East Kalimantan','Libero Mauris Limited','33626'),
  (6,'Michoacán','Fusce Feugiat Lorem Incorporated','93464'),
  (7,'Brandenburg','Odio Aliquam Vulputate PC','53337'),
  (8,'Arizona','Faucibus Ut Nulla LLC','3979957'),
  (9,'Victoria','Aliquet Vel Incorporated','5554'),
  (10,'Centre','Et Rutrum Incorporated','6438');
INSERT INTO [dbo].Winkels(Id,Gemeente,Naam,Postcode)
VALUES
  (11,'Connacht','Donec Egestas Industries','413332'),
  (12,'South Jeolla','Molestie Sed LLC','123688'),
  (13,'Limón','Risus Duis A Industries','301483'),
  (14,'Kentucky','Donec Felis Orci Associates','646784'),
  (15,'Kostroma Oblast','Non Leo Incorporated','11668');
  SET IDENTITY_INSERT [dbo].Winkels OFF

  SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT INTO [dbo].[Categories] ([Id], [Naam]) 
VALUES 
(1, 'Badkamer'),
(2, 'Verlichting'),
(3, 'Tuingereedschap'),
(4, 'Hout'),
(5, 'Ruwbouw'),
(6, 'Gereedschap'),
(7, 'Diensten')
SET IDENTITY_INSERT [dbo].[Categories] OFF

SET IDENTITY_INSERT [dbo].[Producten] ON
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (1, N'Wood', 0, 5.34 , 4)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (2, N'Stone', 1, 4.40 , 5)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (3, N'Aluminum', 1, 6.29 , 5)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (4, N'Wood', 1, 8.22 , 5)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (5, N'Stone', 0, 2.57 , 1)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (6, N'Wood', 1, 2.72 , 3)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (7, N'Glass', 0, 5.45 , 4)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (8, N'Vinyl', 0, 6.63 , 5)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (9, N'Aluminum', 1, 9.96 , 6)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (10, N'Plexiglass', 0, 2.90 , 6)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (11, N'Plexiglass', 0, 9.33 , 5)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (12, N'Glass', 0, 9.69 , 6)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (13, N'Granite', 1, 2.59 , 4)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (14, N'Vinyl', 1, 2.56 , 3)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (15, N'Glass', 0, 2.10 , 1)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (16, N'Vinyl', 0, 1.89 , 5)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (17, N'Plexiglass', 1, 9.13 , 4)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (18, N'Stone', 1, 1.32 , 4)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (19, N'Glass', 0, 7.49 , 6)
INSERT INTO [dbo].[Producten] ([Id], [Naam], [EcoCheque], [prijs], [CategorieId]) VALUES (20, N'Vinyl', 1, 2.89 , 5)
SET IDENTITY_INSERT [dbo].[Producten] OFF

SET IDENTITY_INSERT [dbo].Stock ON
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (1, 86, 10, 5);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (2, 59, 18, 2);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (3, 40, 14, 4);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (4, 45, 19, 2);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (5, 94, 12, 14);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (6, 43, 1, 4);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (7, 91, 11, 3);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (8, 73, 8, 3);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (9, 74, 18, 5);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (10, 6, 2, 9);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (11, 73, 2, 1);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (12, 75, 6, 6);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (13, 31, 5, 11);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (14, 9, 20, 8);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (15, 10, 19, 10);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (16, 63, 5, 11);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (17, 35, 6, 1);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (18, 94, 15, 15);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (19, 35, 1, 14);
insert into dbo.Stock (id, Aantal, ProductId, WinkelId) values (20, 98, 3, 4);
SET IDENTITY_INSERT [dbo].Stock OFF

SET IDENTITY_INSERT [dbo].Facturen ON
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (1, '8/12/2022', 1, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (2, '11/7/2022', 3, 3);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (3, '8/13/2022', 5, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (4, '2/17/2022', 6, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (5, '6/23/2022', 9, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (6, '12/12/2021', 2, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (7, '8/27/2022', 6, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (8, '5/10/2022', 6, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (9, '12/7/2021', 4, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (10, '12/24/2021', 3, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (11, '11/20/2022', 10, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (12, '1/22/2022', 5, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (13, '8/3/2022', 3, 3);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (14, '8/18/2022', 3, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (15, '6/30/2022', 4, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (16, '9/4/2022', 5, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (17, '6/4/2022', 3, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (18, '3/2/2022', 7, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (19, '11/13/2022', 8, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (20, '9/20/2022', 9, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (21, '3/20/2022', 9, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (22, '1/16/2022', 3, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (23, '12/16/2021', 10, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (24, '3/1/2022', 10, 3);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (25, '10/6/2022', 7, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (26, '3/29/2022', 3, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (27, '7/5/2022', 6, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (28, '3/31/2022', 3, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (29, '8/15/2022', 7, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (30, '12/6/2021', 8, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (31, '2/22/2022', 6, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (32, '10/10/2022', 8, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (33, '12/31/2021', 3, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (34, '1/13/2022', 1, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (35, '3/11/2022', 4, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (36, '10/17/2022', 3, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (37, '3/15/2022', 10, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (38, '6/29/2022', 2, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (39, '6/5/2022', 6, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (40, '10/20/2022', 8, 5);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (41, '1/21/2022', 7, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (42, '9/29/2022', 8, 3);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (43, '7/10/2022', 2, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (44, '5/11/2022', 9, 3);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (45, '4/15/2022', 3, 3);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (46, '6/8/2022', 8, 2);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (47, '1/14/2022', 2, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (48, '6/21/2022', 6, 1);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (49, '1/17/2022', 5, 4);
insert into dbo.Facturen (id, Datum, WinkelId, KlantId) values (50, '7/28/2022', 8, 4);


SET IDENTITY_INSERT [dbo].Facturen OFF

SET IDENTITY_INSERT [dbo].ProductFactuur ON
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (1, 15, 13, 14, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (2, 14, 6, 21, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (3, 12, 7, 97, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (4, 9, 6, 40, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (5, 10, 13, 45, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (6, 2, 3, 75, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (7, 18, 2, 83, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (8, 8, 4, 45, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (9, 5, 20, 94, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (10, 13, 1, 6, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (11, 18, 3, 2, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (12, 15, 3, 62, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (13, 11, 5, 38, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (14, 11, 11, 61, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (15, 3, 13, 55, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (16, 3, 17, 70, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (17, 9, 12, 88, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (18,5, 2, 9, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (19, 13, 11, 10, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (20, 20, 13, 81, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (21, 4, 10, 75, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (22, 6, 8, 97, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (23, 7, 18, 37, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (24, 3, 18, 66, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (25, 8, 17, 26, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (26, 5, 4, 31, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (27, 15, 12, 43, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (28, 17, 9, 25, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (29, 17, 8, 93, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (30, 5, 8, 1, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (31, 4, 1, 86, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (32, 1, 11, 35, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (33, 5, 15, 41, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (34, 9, 9, 51, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (35, 2, 19, 54, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (36, 12, 15, 36, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (37, 5, 20, 24, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (38, 13, 15, 55, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (39, 16, 3, 39, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (40, 16, 10, 89, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (41, 7, 5, 7, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (42, 5, 1, 58, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (43, 9, 16, 83, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (44, 8, 20, 55, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (45, 15, 8, 22, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (46, 15, 12, 56, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (47, 8, 3, 61, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (48, 10, 6, 92, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (49, 14, 18, 91, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (50, 9, 16, 97, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (51, 17, 9, 16, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (52, 9, 17, 10, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (53, 1, 14, 81, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (54, 5, 11, 35, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (55, 5, 15, 84, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (56, 11, 9, 80, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (57, 13, 10, 36, NULL );
insert into dbo.ProductFactuur (id,  FactuurId, ProductId, Hoeveelheid, DienstId) values (58, 17, 19, 19, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (60, 4, 8, 60, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (61, 12, 17, 91, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (62, 17, 3, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (63, 4, 2, 65, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (64, 8, 15, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (65, 2, 14, 93, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (66, 16, 3, 89, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (67, 9, 3, 99, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (68, 7, 12, 75, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (69, 10, 17, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (70, 19, 6, 67, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (71, 10, 13, 36, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (72, 8, 7, 19, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (73, 18, 5, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (74, 7, 2, 42, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (75, 7, 3, 34, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (76, 15, 15, 95, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (77, 4, 12, 25, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (78, 13, 16, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (79, 3, 13, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (80, 10, 2, 44, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (81, 14, 13, 29, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (82, 19, 12, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (83, 9, 14, 98, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (84, 5, 6, 64, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (85, 17, 10, 65, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (86, 9, 14, 37, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (87, 17, 17, 55, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (88, 1, 17, 62, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (89, 12, 3, 81, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (90, 16, 10, 61, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (91, 7, 14, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (92, 2, 11, 68, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (93, 15, 10, 62, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (94, 9, 7, 30, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (95, 11, 18, 63, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (96, 4, 10, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (97, 16, 13, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (98, 1, 17, 61, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (99, 8, 9, 2, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (100, 10, 6, 78, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (101, 17, 3, 53, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (102, 9, 8, 21, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (103, 12, 2, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (104, 14, 12, 75, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (105, 19, 5, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (106, 4, 17, 78, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (107, 10, 20, 35, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (108, 4, 20, 95, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (109, 16, 6, 99, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (110, 4, 17, 54, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (111, 18, 20, 76, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (112, 18, 4, 64, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (113, 1, 14, 98, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (114, 3, 17, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (115, 14, 4, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (116, 2, 6, 2, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (117, 10, 14, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (118, 18, 17, 85, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (119, 1, 16, 58, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (120, 4, 7, 8, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (121, 5, 1, 95, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (122, 15, 4, 86, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (123, 8, 8, 72, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (124, 9, 18, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (125, 10, 12, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (126, 1, 7, 91, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (127, 10, 15, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (128, 2, 3, 77, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (129, 18, 5, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (130, 9, 17, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (131, 12, 1, 65, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (132, 14, 14, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (133, 14, 11, 80, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (134, 11, 18, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (135, 9, 4, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (136, 11, 12, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (137, 4, 12, 65, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (138, 11, 17, 80, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (139, 16, 5, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (140, 18, 8, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (141, 11, 19, 70, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (142, 8, 11, 54, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (143, 19, 10, 64, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (144, 2, 8, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (145, 9, 17, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (146, 20, 5, 63, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (147, 19, 1, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (148, 2, 17, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (149, 9, 1, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (150, 18, 17, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (151, 6, 6, 96, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (152, 3, 10, 11, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (153, 4, 4, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (154, 14, 19, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (155, 7, 20, 69, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (156, 8, 10, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (157, 11, 5, 35, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (158, 3, 1, 73, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (159, 19, 12, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (160, 2, 1, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (161, 11, 12, 44, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (162, 7, 1, 19, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (163, 14, 8, 11, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (164, 16, 16, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (165, 7, 19, 60, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (166, 6, 12, 15, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (167, 17, 4, 39, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (168, 6, 20, 12, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (169, 6, 1, 86, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (170, 18, 14, 14, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (171, 1, 19, 85, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (172, 6, 12, 54, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (173, 16, 11, 11, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (174, 3, 6, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (175, 17, 17, 99, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (176, 2, 1, 59, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (177, 10, 15, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (178, 16, 7, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (179, 14, 5, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (180, 14, 9, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (181, 4, 10, 93, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (182, 17, 15, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (183, 18, 10, 5, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (184, 1, 18, 15, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (185, 19, 6, 87, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (186, 10, 20, 44, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (187, 18, 4, 5, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (188, 20, 10, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (189, 12, 14, 5, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (190, 15, 20, 70, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (191, 6, 3, 100, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (192, 15, 18, 94, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (193, 9, 4, 43, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (194, 4, 13, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (195, 12, 13, 81, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (196, 15, 5, 82, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (197, 10, 7, 40, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (198, 5, 1, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (199, 13, 14, 28, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (200, 2, 20, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (201, 48, 9, 11, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (202, 43, 2, 36, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (203, 21, 13, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (204, 37, 3, 37, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (205, 24, 13, 43, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (206, 38, 12, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (207, 27, 14, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (208, 25, 12, 41, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (209, 36, 16, 26, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (210, 29, 7, 26, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (211, 40, 11, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (212, 24, 14, 30, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (213, 40, 14, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (214, 47, 6, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (215, 23, 19, 12, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (216, 45, 4, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (217, 30, 16, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (218, 42, 20, 43, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (219, 20, 12, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (220, 26, 9, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (221, 43, 4, 5, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (222, 34, 5, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (223, 41, 4, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (224, 42, 11, 1, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (225, 41, 16, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (226, 37, 7, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (227, 38, 11, 49, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (228, 20, 7, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (229, 44, 5, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (230, 41, 13, 43, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (231, 38, 5, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (232, 30, 20, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (233, 40, 8, 35, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (234, 49, 15, 28, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (235, 28, 7, 1, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (236, 50, 11, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (237, 29, 1, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (238, 37, 20, 25, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (239, 23, 7, 35, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (240, 23, 18, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (241, 33, 13, 8, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (242, 40, 20, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (243, 33, 16, 32, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (244, 26, 10, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (245, 34, 13, 36, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (246, 23, 6, 12, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (247, 42, 17, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (248, 23, 20, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (249, 42, 14, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (250, 36, 8, 1, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (251, 41, 15, 2, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (252, 42, 17, 29, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (253, 42, 1, 15, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (254, 50, 6, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (255, 46, 17, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (256, 25, 10, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (257, 44, 16, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (258, 22, 9, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (259, 37, 10, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (260, 45, 20, 4, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (261, 29, 13, 37, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (262, 38, 7, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (263, 35, 12, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (264, 25, 3, 8, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (265, 46, 10, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (266, 26, 12, 42, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (267, 27, 8, 5, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (268, 20, 15, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (269, 40, 8, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (270, 50, 2, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (271, 27, 7, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (272, 35, 16, 19, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (273, 46, 13, 12, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (274, 33, 16, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (275, 39, 12, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (276, 46, 5, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (277, 40, 5, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (278, 46, 12, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (279, 48, 20, 46, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (280, 30, 13, 32, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (281, 50, 14, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (282, 40, 17, 18, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (283, 46, 10, 34, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (284, 43, 6, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (285, 41, 19, 28, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (286, 25, 19, 18, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (287, 39, 9, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (288, 35, 11, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (289, 33, 12, 12, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (290, 26, 4, 36, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (291, 28, 9, 36, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (292, 34, 2, 12, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (293, 43, 8, 18, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (294, 38, 6, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (295, 34, 11, 42, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (296, 35, 2, 4, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (297, 24, 5, 9, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (298, 49, 11, 49, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (299, 27, 15, 11, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (300, 49, 19, 28, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (301, 42, 11, 9, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (302, 31, 20, 40, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (303, 42, 14, 32, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (304, 42, 3, 27, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (305, 48, 12, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (306, 31, 7, 43, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (307, 35, 20, 15, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (308, 30, 8, 14, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (309, 29, 8, 19, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (310, 22, 8, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (311, 25, 9, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (312, 50, 17, 8, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (313, 35, 2, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (314, 48, 4, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (315, 34, 15, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (316, 45, 9, 1, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (317, 34, 15, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (318, 44, 5, 24, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (319, 20, 5, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (320, 34, 4, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (321, 35, 3, 9, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (322, 20, 13, 41, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (323, 45, 9, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (324, 47, 13, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (325, 20, 11, 9, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (326, 45, 18, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (327, 37, 5, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (328, 37, 11, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (329, 41, 12, 27, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (330, 48, 20, 37, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (331, 50, 9, 35, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (332, 33, 14, 34, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (333, 37, 18, 42, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (334, 25, 7, 26, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (335, 50, 19, 14, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (336, 27, 14, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (337, 31, 17, 42, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (338, 28, 6, 44, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (339, 35, 3, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (340, 22, 2, 2, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (341, 20, 14, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (342, 48, 2, 28, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (343, 47, 19, 26, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (344, 29, 9, 27, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (345, 38, 12, 13, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (346, 32, 10, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (347, 46, 19, 10, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (348, 27, 5, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (349, 37, 19, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (350, 46, 19, 4, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (351, 36, 8, 37, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (352, 38, 17, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (353, 40, 10, 36, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (354, 48, 16, 46, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (355, 42, 8, 47, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (356, 44, 3, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (357, 44, 17, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (358, 22, 10, 26, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (359, 23, 18, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (360, 28, 9, 46, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (361, 32, 5, 5, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (362, 30, 1, 27, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (363, 20, 7, 39, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (364, 42, 8, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (365, 24, 4, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (366, 25, 16, 44, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (367, 32, 4, 49, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (368, 47, 2, 18, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (369, 26, 20, 6, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (370, 31, 9, 32, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (371, 34, 9, 20, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (372, 25, 10, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (373, 29, 2, 3, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (374, 23, 13, 16, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (375, 44, 7, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (376, 42, 10, 38, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (377, 50, 1, 22, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (378, 25, 20, 31, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (379, 26, 13, 2, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (380, 50, 1, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (381, 36, 4, 4, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (382, 29, 11, 11, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (383, 39, 17, 17, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (384, 42, 10, 29, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (385, 27, 13, 23, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (386, 21, 18, 7, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (387, 32, 13, 14, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (388, 30, 18, 42, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (389, 50, 6, 50, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (390, 44, 9, 1, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (391, 20, 2, 39, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (392, 24, 7, 1, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (393, 20, 18, 41, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (394, 22, 17, 27, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (395, 47, 18, 45, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (396, 50, 11, 43, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (397, 35, 16, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (398, 43, 11, 33, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (399, 35, 15, 48, NULL );
insert into dbo.ProductFactuur (id, FactuurId, ProductId, Hoeveelheid, DienstId) values (400, 40, 20, 12, NULL );


SET IDENTITY_INSERT [dbo].ProductFactuur OFF

SET IDENTITY_INSERT [dbo].Diensten ON
insert into dbo.Diensten (id, Naam, CategorieId, Prijs) values (1, 'Loodgieter', 7, 50.00);
insert into dbo.Diensten (id, Naam, CategorieId, Prijs) values (2, 'Schrijnwerker', 7, 75.00);
insert into dbo.Diensten (id, Naam, CategorieId, Prijs) values (3, 'Metser', 7, 45.00);
SET IDENTITY_INSERT [dbo].Diensten OFF



