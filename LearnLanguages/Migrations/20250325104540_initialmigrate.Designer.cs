﻿// <auto-generated />
using Languages.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnLanguages.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250325104540_initialmigrate")]
    partial class initialmigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LearnLanguages.Models.PhrasesPL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhrasesPL");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Language = "Polish",
                            Text = "Dzień dobry",
                            Translation = "Good morning"
                        },
                        new
                        {
                            Id = 2,
                            Language = "Polish",
                            Text = "Do widzenia",
                            Translation = "Goodbye"
                        },
                        new
                        {
                            Id = 3,
                            Language = "Polish",
                            Text = "Jak się masz?",
                            Translation = "How are you?"
                        },
                        new
                        {
                            Id = 4,
                            Language = "Polish",
                            Text = "Dobrze, dziękuję",
                            Translation = "I'm fine, thank you"
                        },
                        new
                        {
                            Id = 5,
                            Language = "Polish",
                            Text = "Gdzie jest toaleta?",
                            Translation = "Where is the bathroom?"
                        },
                        new
                        {
                            Id = 6,
                            Language = "Polish",
                            Text = "Ile to kosztuje?",
                            Translation = "How much does it cost?"
                        },
                        new
                        {
                            Id = 7,
                            Language = "Polish",
                            Text = "Mówię po polsku",
                            Translation = "I speak Polish"
                        },
                        new
                        {
                            Id = 8,
                            Language = "Polish",
                            Text = "Nie rozumiem",
                            Translation = "Translation"
                        },
                        new
                        {
                            Id = 9,
                            Language = "Polish",
                            Text = "Możesz powtórzyć?",
                            Translation = "Can you repeat?"
                        },
                        new
                        {
                            Id = 10,
                            Language = "Polish",
                            Text = "Jestem z Polski",
                            Translation = "I am from Poland"
                        },
                        new
                        {
                            Id = 11,
                            Language = "Polish",
                            Text = "Co robisz?",
                            Translation = "What are you doing?"
                        },
                        new
                        {
                            Id = 12,
                            Language = "Polish",
                            Text = "Lubię to",
                            Translation = "I like it"
                        },
                        new
                        {
                            Id = 13,
                            Language = "Polish",
                            Text = "Skąd jesteś?",
                            Translation = "Where are you from?"
                        },
                        new
                        {
                            Id = 14,
                            Language = "Polish",
                            Text = "Ile masz lat?",
                            Translation = "How old are you?"
                        },
                        new
                        {
                            Id = 15,
                            Language = "Polish",
                            Text = "Co robisz w wolnym czasie?",
                            Translation = "What do you do in your free time?"
                        },
                        new
                        {
                            Id = 16,
                            Language = "Polish",
                            Text = "Lubię czytać książki.",
                            Translation = "I like to read books."
                        },
                        new
                        {
                            Id = 17,
                            Language = "Polish",
                            Text = "Czy mówisz po angielsku?",
                            Translation = "Do you speak English?"
                        },
                        new
                        {
                            Id = 18,
                            Language = "Polish",
                            Text = "Chciałbym coś do picia.",
                            Translation = " I would like something to drink."
                        },
                        new
                        {
                            Id = 19,
                            Language = "Polish",
                            Text = "Czy mogę pomóc?",
                            Translation = "Can I help?"
                        },
                        new
                        {
                            Id = 20,
                            Language = "Polish",
                            Text = "To jest smaczne!",
                            Translation = "This is delicious!"
                        });
                });

            modelBuilder.Entity("LearnLanguages.Models.PhrasesSE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhrasesSE");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Language = "Swedish",
                            Text = "Hej",
                            Translation = "Hello"
                        },
                        new
                        {
                            Id = 2,
                            Language = "Swedish",
                            Text = "Jag heter Mateus",
                            Translation = "My name is Mateus"
                        },
                        new
                        {
                            Id = 3,
                            Language = "Swedish",
                            Text = "Hur mår du?",
                            Translation = "How are you"
                        },
                        new
                        {
                            Id = 4,
                            Language = "Swedish",
                            Text = "Var kommer du ifrån?",
                            Translation = "Where are you from?"
                        },
                        new
                        {
                            Id = 5,
                            Language = "Swedish",
                            Text = "Jag älskar dig",
                            Translation = "I love you"
                        },
                        new
                        {
                            Id = 6,
                            Language = "Swedish",
                            Text = "Jag älskar dricka Pepsi",
                            Translation = "I love drinking Pepsi"
                        },
                        new
                        {
                            Id = 7,
                            Language = "Swedish",
                            Text = "Jag bor i Göteborg",
                            Translation = "I live in Gothenburg"
                        },
                        new
                        {
                            Id = 8,
                            Language = "Swedish",
                            Text = "Jag brukar gå en promenad på morgonen",
                            Translation = "I usually go for a  walk during the morning"
                        },
                        new
                        {
                            Id = 9,
                            Language = "Swedish",
                            Text = "Hon lämnade mig för en annan kille",
                            Translation = "She left me for another guy"
                        },
                        new
                        {
                            Id = 10,
                            Language = "Swedish",
                            Text = "Jag är brasiliansk",
                            Translation = "I am Brazilian"
                        },
                        new
                        {
                            Id = 11,
                            Language = "Swedish",
                            Text = "Jag var på en restaurang med min fru",
                            Translation = "I was at a restaurant with my wife"
                        },
                        new
                        {
                            Id = 12,
                            Language = "Swedish",
                            Text = "Jag måste gå på toaletten",
                            Translation = "I need to go to the bathroom"
                        },
                        new
                        {
                            Id = 13,
                            Language = "Swedish",
                            Text = "De gick till parken tillsammans",
                            Translation = "They went to the park together"
                        },
                        new
                        {
                            Id = 14,
                            Language = "Swedish",
                            Text = "Min pappa är på sjukhuset",
                            Translation = "My dad is at the Hospital"
                        },
                        new
                        {
                            Id = 15,
                            Language = "Swedish",
                            Text = "Jag är en man med ett stort hjärta",
                            Translation = "I am a man with a big heart"
                        },
                        new
                        {
                            Id = 16,
                            Language = "Swedish",
                            Text = "Jag har sett hennes profil på Instagram",
                            Translation = "I've seen her profile on Instagram."
                        },
                        new
                        {
                            Id = 17,
                            Language = "Swedish",
                            Text = "Han är elak, vi borde polisanmäla honom",
                            Translation = "He's mean, we should report him to the police."
                        },
                        new
                        {
                            Id = 18,
                            Language = "Swedish",
                            Text = "Hon är från Ryssland men bor i Sverige",
                            Translation = "She is from Russia but lives in Sweden"
                        },
                        new
                        {
                            Id = 19,
                            Language = "Swedish",
                            Text = "Min bil slutade fungera",
                            Translation = "My car stopped working"
                        },
                        new
                        {
                            Id = 20,
                            Language = "Swedish",
                            Text = "Fokusera på dig själv och glöm det, min vän. Hon var inte värd det...",
                            Translation = "Focus on yourself and forget about it, my friend. She was not worth it..."
                        });
                });

            modelBuilder.Entity("LearnLanguages.Models.VocabulariesPL", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VocabulariesPL");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Language = "Polish",
                            Text = "Kocham",
                            Translation = "I love"
                        },
                        new
                        {
                            Id = 2,
                            Language = "Polish",
                            Text = "Dzień",
                            Translation = "Day"
                        },
                        new
                        {
                            Id = 3,
                            Language = "Polish",
                            Text = "Noc",
                            Translation = "Night"
                        },
                        new
                        {
                            Id = 4,
                            Language = "Polish",
                            Text = "Pies",
                            Translation = "Dog"
                        },
                        new
                        {
                            Id = 5,
                            Language = "Polish",
                            Text = "Kot",
                            Translation = "Cat"
                        },
                        new
                        {
                            Id = 6,
                            Language = "Polish",
                            Text = "Dom",
                            Translation = "House"
                        },
                        new
                        {
                            Id = 7,
                            Language = "Polish",
                            Text = "Szkoła",
                            Translation = "School"
                        },
                        new
                        {
                            Id = 8,
                            Language = "Polish",
                            Text = "Przyjaciel",
                            Translation = " Friend"
                        },
                        new
                        {
                            Id = 9,
                            Language = "Polish",
                            Text = "Rodzina",
                            Translation = "Family"
                        },
                        new
                        {
                            Id = 10,
                            Language = "Polish",
                            Text = "Woda",
                            Translation = "Water"
                        },
                        new
                        {
                            Id = 11,
                            Language = "Polish",
                            Text = "Jedzenie",
                            Translation = "Food"
                        },
                        new
                        {
                            Id = 12,
                            Language = "Polish",
                            Text = "Kawa",
                            Translation = "Coffee"
                        },
                        new
                        {
                            Id = 13,
                            Language = "Polish",
                            Text = "Herbata",
                            Translation = "Tea"
                        },
                        new
                        {
                            Id = 14,
                            Language = "Polish",
                            Text = "Mężczyzna",
                            Translation = " Man"
                        },
                        new
                        {
                            Id = 15,
                            Language = "Polish",
                            Text = "Kobieta",
                            Translation = "Woman"
                        },
                        new
                        {
                            Id = 16,
                            Language = "Polish",
                            Text = "Dziecko",
                            Translation = "Child"
                        },
                        new
                        {
                            Id = 17,
                            Language = "Polish",
                            Text = "Miłość",
                            Translation = "Love"
                        },
                        new
                        {
                            Id = 18,
                            Language = "Polish",
                            Text = "Praca",
                            Translation = "Work"
                        },
                        new
                        {
                            Id = 19,
                            Language = "Polish",
                            Text = "Samochód",
                            Translation = "Car"
                        },
                        new
                        {
                            Id = 20,
                            Language = "Polish",
                            Text = "Miasto",
                            Translation = "City"
                        });
                });

            modelBuilder.Entity("LearnLanguages.Models.VocabulariesSE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VocabulariesSE");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Language = "Swedish",
                            Text = "Hej",
                            Translation = "Hello"
                        },
                        new
                        {
                            Id = 2,
                            Language = "Swedish",
                            Text = "Tack",
                            Translation = "Thank you"
                        },
                        new
                        {
                            Id = 3,
                            Language = "Swedish",
                            Text = "Ja",
                            Translation = "Yes"
                        },
                        new
                        {
                            Id = 4,
                            Language = "Swedish",
                            Text = "Nej",
                            Translation = "No"
                        },
                        new
                        {
                            Id = 5,
                            Language = "Swedish",
                            Text = "Vän",
                            Translation = "Friend"
                        },
                        new
                        {
                            Id = 6,
                            Language = "Swedish",
                            Text = "Hus",
                            Translation = "House"
                        },
                        new
                        {
                            Id = 7,
                            Language = "Swedish",
                            Text = "Mat",
                            Translation = "Food"
                        },
                        new
                        {
                            Id = 8,
                            Language = "Swedish",
                            Text = "Vatten",
                            Translation = "Water"
                        },
                        new
                        {
                            Id = 9,
                            Language = "Swedish",
                            Text = "Bok",
                            Translation = "Book"
                        },
                        new
                        {
                            Id = 10,
                            Language = "Swedish",
                            Text = "Skola",
                            Translation = "School"
                        },
                        new
                        {
                            Id = 11,
                            Language = "Swedish",
                            Text = "älskar",
                            Translation = "Love"
                        },
                        new
                        {
                            Id = 12,
                            Language = "Swedish",
                            Text = "Sol",
                            Translation = "Sun"
                        },
                        new
                        {
                            Id = 13,
                            Language = "Swedish",
                            Text = "Mörk",
                            Translation = "Dark"
                        },
                        new
                        {
                            Id = 14,
                            Language = "Swedish",
                            Text = "Ljus",
                            Translation = "Light"
                        },
                        new
                        {
                            Id = 15,
                            Language = "Swedish",
                            Text = "Dator",
                            Translation = "Computer"
                        },
                        new
                        {
                            Id = 16,
                            Language = "Swedish",
                            Text = "Fönster",
                            Translation = "Window"
                        },
                        new
                        {
                            Id = 17,
                            Language = "Swedish",
                            Text = "Dörr",
                            Translation = "Door"
                        },
                        new
                        {
                            Id = 18,
                            Language = "Swedish",
                            Text = "Skrivbord",
                            Translation = "Desk"
                        },
                        new
                        {
                            Id = 19,
                            Language = "Swedish",
                            Text = "Säng",
                            Translation = "Bed"
                        },
                        new
                        {
                            Id = 20,
                            Language = "Swedish",
                            Text = "Bilar",
                            Translation = "Cars"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
