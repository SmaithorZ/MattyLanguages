using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LearnLanguages.Migrations
{
    /// <inheritdoc />
    public partial class initialmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhrasesPL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhrasesPL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhrasesSE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhrasesSE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VocabulariesPL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabulariesPL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VocabulariesSE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Translation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabulariesSE", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PhrasesPL",
                columns: new[] { "Id", "Language", "Text", "Translation" },
                values: new object[,]
                {
                    { 1, "Polish", "Dzień dobry", "Good morning" },
                    { 2, "Polish", "Do widzenia", "Goodbye" },
                    { 3, "Polish", "Jak się masz?", "How are you?" },
                    { 4, "Polish", "Dobrze, dziękuję", "I'm fine, thank you" },
                    { 5, "Polish", "Gdzie jest toaleta?", "Where is the bathroom?" },
                    { 6, "Polish", "Ile to kosztuje?", "How much does it cost?" },
                    { 7, "Polish", "Mówię po polsku", "I speak Polish" },
                    { 8, "Polish", "Nie rozumiem", "Translation" },
                    { 9, "Polish", "Możesz powtórzyć?", "Can you repeat?" },
                    { 10, "Polish", "Jestem z Polski", "I am from Poland" },
                    { 11, "Polish", "Co robisz?", "What are you doing?" },
                    { 12, "Polish", "Lubię to", "I like it" },
                    { 13, "Polish", "Skąd jesteś?", "Where are you from?" },
                    { 14, "Polish", "Ile masz lat?", "How old are you?" },
                    { 15, "Polish", "Co robisz w wolnym czasie?", "What do you do in your free time?" },
                    { 16, "Polish", "Lubię czytać książki.", "I like to read books." },
                    { 17, "Polish", "Czy mówisz po angielsku?", "Do you speak English?" },
                    { 18, "Polish", "Chciałbym coś do picia.", " I would like something to drink." },
                    { 19, "Polish", "Czy mogę pomóc?", "Can I help?" },
                    { 20, "Polish", "To jest smaczne!", "This is delicious!" }
                });

            migrationBuilder.InsertData(
                table: "PhrasesSE",
                columns: new[] { "Id", "Language", "Text", "Translation" },
                values: new object[,]
                {
                    { 1, "Swedish", "Hej", "Hello" },
                    { 2, "Swedish", "Jag heter Mateus", "My name is Mateus" },
                    { 3, "Swedish", "Hur mår du?", "How are you" },
                    { 4, "Swedish", "Var kommer du ifrån?", "Where are you from?" },
                    { 5, "Swedish", "Jag älskar dig", "I love you" },
                    { 6, "Swedish", "Jag älskar dricka Pepsi", "I love drinking Pepsi" },
                    { 7, "Swedish", "Jag bor i Göteborg", "I live in Gothenburg" },
                    { 8, "Swedish", "Jag brukar gå en promenad på morgonen", "I usually go for a  walk during the morning" },
                    { 9, "Swedish", "Hon lämnade mig för en annan kille", "She left me for another guy" },
                    { 10, "Swedish", "Jag är brasiliansk", "I am Brazilian" },
                    { 11, "Swedish", "Jag var på en restaurang med min fru", "I was at a restaurant with my wife" },
                    { 12, "Swedish", "Jag måste gå på toaletten", "I need to go to the bathroom" },
                    { 13, "Swedish", "De gick till parken tillsammans", "They went to the park together" },
                    { 14, "Swedish", "Min pappa är på sjukhuset", "My dad is at the Hospital" },
                    { 15, "Swedish", "Jag är en man med ett stort hjärta", "I am a man with a big heart" },
                    { 16, "Swedish", "Jag har sett hennes profil på Instagram", "I've seen her profile on Instagram." },
                    { 17, "Swedish", "Han är elak, vi borde polisanmäla honom", "He's mean, we should report him to the police." },
                    { 18, "Swedish", "Hon är från Ryssland men bor i Sverige", "She is from Russia but lives in Sweden" },
                    { 19, "Swedish", "Min bil slutade fungera", "My car stopped working" },
                    { 20, "Swedish", "Fokusera på dig själv och glöm det, min vän. Hon var inte värd det...", "Focus on yourself and forget about it, my friend. She was not worth it..." }
                });

            migrationBuilder.InsertData(
                table: "VocabulariesPL",
                columns: new[] { "Id", "Language", "Text", "Translation" },
                values: new object[,]
                {
                    { 1, "Polish", "Kocham", "I love" },
                    { 2, "Polish", "Dzień", "Day" },
                    { 3, "Polish", "Noc", "Night" },
                    { 4, "Polish", "Pies", "Dog" },
                    { 5, "Polish", "Kot", "Cat" },
                    { 6, "Polish", "Dom", "House" },
                    { 7, "Polish", "Szkoła", "School" },
                    { 8, "Polish", "Przyjaciel", " Friend" },
                    { 9, "Polish", "Rodzina", "Family" },
                    { 10, "Polish", "Woda", "Water" },
                    { 11, "Polish", "Jedzenie", "Food" },
                    { 12, "Polish", "Kawa", "Coffee" },
                    { 13, "Polish", "Herbata", "Tea" },
                    { 14, "Polish", "Mężczyzna", " Man" },
                    { 15, "Polish", "Kobieta", "Woman" },
                    { 16, "Polish", "Dziecko", "Child" },
                    { 17, "Polish", "Miłość", "Love" },
                    { 18, "Polish", "Praca", "Work" },
                    { 19, "Polish", "Samochód", "Car" },
                    { 20, "Polish", "Miasto", "City" }
                });

            migrationBuilder.InsertData(
                table: "VocabulariesSE",
                columns: new[] { "Id", "Language", "Text", "Translation" },
                values: new object[,]
                {
                    { 1, "Swedish", "Hej", "Hello" },
                    { 2, "Swedish", "Tack", "Thank you" },
                    { 3, "Swedish", "Ja", "Yes" },
                    { 4, "Swedish", "Nej", "No" },
                    { 5, "Swedish", "Vän", "Friend" },
                    { 6, "Swedish", "Hus", "House" },
                    { 7, "Swedish", "Mat", "Food" },
                    { 8, "Swedish", "Vatten", "Water" },
                    { 9, "Swedish", "Bok", "Book" },
                    { 10, "Swedish", "Skola", "School" },
                    { 11, "Swedish", "älskar", "Love" },
                    { 12, "Swedish", "Sol", "Sun" },
                    { 13, "Swedish", "Mörk", "Dark" },
                    { 14, "Swedish", "Ljus", "Light" },
                    { 15, "Swedish", "Dator", "Computer" },
                    { 16, "Swedish", "Fönster", "Window" },
                    { 17, "Swedish", "Dörr", "Door" },
                    { 18, "Swedish", "Skrivbord", "Desk" },
                    { 19, "Swedish", "Säng", "Bed" },
                    { 20, "Swedish", "Bilar", "Cars" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhrasesPL");

            migrationBuilder.DropTable(
                name: "PhrasesSE");

            migrationBuilder.DropTable(
                name: "VocabulariesPL");

            migrationBuilder.DropTable(
                name: "VocabulariesSE");
        }
    }
}
