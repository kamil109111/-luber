using Microsoft.EntityFrameworkCore.Migrations;

namespace Śluber.Data.Migrations
{
    public partial class WypenenieListyZadan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        migrationBuilder.Sql(@"SET IDENTITY_INSERT [dbo].[Errand] ON
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (2, N'Zorganizować spotkanie rodziców', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (3, N'Ustalić wstępną listę gości', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (4, N'Znajdź konsultanta ślubnego', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (5, N'Oszacować budżet ślubny', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (6, N'Wybór sali weselnej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (7, N'Rezerwacja terminu w kościele lub USC', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (8, N'Wybór kamerzysty', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (9, N'Wybór zespołu weselnego', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (10, N'Wybór fotografa', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (11, N'Wybór DJ', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (12, N'Wybór barmana', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (13, N'Wybór świadków', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (14, N'Wybierz motyw ślubu', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (15, N'Umów się na wizytę w salonie sukien ślubnych', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (16, N'Wybór garnituru Pana Młodego', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (17, N'Wybór i zamówienie obrączek', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (18, N'Wybór i zamówienie zaproszeń', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (19, N'Zapisać się na nauki przedmałżeńskie', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (20, N'Odbiór dokumentów w USC', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (21, N'Wysyłanie/dostarczenie zaproszeń', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (22, N'Wybór dekoracji', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (23, N'Dostarczenie dokumentów dp parafii', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (24, N'Przymiarka garnituru', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (25, N'Przymiarka sukni ślubnej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (26, N'Zaplanowanie podróży poślubnej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (27, N'Zapisać się na kurs tańca', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (28, N'Zakup biżuterii ślubnej Panny Młodej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (29, N'Zakup dodatków do garnituru ślubnej Pana Młodego', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (30, N'Zakup butów Panny Młodej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (31, N'Zamówienie bukietu ślubnego i butonierki', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (32, N'Zapewnienie transportu dla gości', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (33, N'Próbna fryzura', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (34, N'Próbny makijaż', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (35, N'Rezerwacja ewentualnych miejsc noclegowych dla gości', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (36, N'Zakup butów Pana Młodego', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (37, N'Ustalić z zespołem muzycznym zabawy i repertuar weselny', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (38, N'Ustalić szczegóły weselnego menu', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (39, N'Rozplanować usadzenie gości przy stołach weselnych', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (40, N'Zaplanować podziękowania dla rodziców i gości', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (41, N'Wybrać i zamówić tort weselny', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (42, N'Odbiór garnituru', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (43, N'Ostatnia przymiarka i odbiór sukni ślubnej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (44, N'Zamówcie wizytówki i winietki na stół i alkohol', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (45, N'Odbiór obrączek', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (46, N'Spowiedź przedmałżeńska', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (47, N'Zakup bielizny ślubnej', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (48, N'Wybierz strój na poprawiny', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (49, N'Przygotowanie ślubnego niezbędnika', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (50, N'Ustalić ze świadkami ich role i zadania', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (51, N'Zamknąć ostateczną listę gości', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (52, N'Ułóżcie podziękowania dla rodziców', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (53, N'Ustalcie scenariusz uroczystości w kościele (dopytajcie o organistę)', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (54, N'Ślubny manicure i pedicure', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (55, N'Przygotujcie obrączki i dokumenty', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (56, N'Potwierdźcie ze wszystkimi kontrahentami datę i godzinę ślubu', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (57, N'Weźcie ze sobą trochę gotówki', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (58, N'Pamiętajcie o obrączkach', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (59, N'Odbiór bukietu i butonierki', NULL, 0, 0, NULL)
INSERT INTO [dbo].[Errand] ([Id], [Name], [ErrandDate], [ErrandStatus], [ErrandPrice], [Note]) VALUES (60, N'Wizyta u fryzjera i kosmetyczki', NULL, 0, 0, NULL)

 
SET IDENTITY_INSERT [dbo].[Errand] OFF");
       
    }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
