using LearnLanguages.Models;
using Microsoft.EntityFrameworkCore;

namespace Languages.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        //Swedish
        public DbSet<PhrasesSE> PhrasesSE { get; set; }
        public DbSet<VocabulariesSE> VocabulariesSE { get; set; }


        //Polish
        public DbSet<PhrasesPL> PhrasesPL { get; set; }
        public DbSet<VocabulariesPL> VocabulariesPL { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Swedish Phrases
            modelBuilder.Entity<PhrasesSE>().HasData(

                new PhrasesSE
                {
                    Id = 1,
                    Language = "Swedish",
                    Text = "Hej",
                    Translation = "Hello"
                },
                new PhrasesSE
                {
                    Id = 2,
                    Language = "Swedish",
                    Text = "Jag heter Mateus",
                    Translation = "My name is Mateus"
                },

                new PhrasesSE
                {
                    Id = 3,
                    Language = "Swedish",
                    Text = "Hur mår du?",
                    Translation = "How are you"
                },

                new PhrasesSE
                {
                    Id = 4,
                    Language = "Swedish",
                    Text = "Var kommer du ifrån?",
                    Translation = "Where are you from?"
                },

                new PhrasesSE
                {
                    Id = 5,
                    Language = "Swedish",
                    Text = "Jag älskar dig",
                    Translation = "I love you"
                },

                new PhrasesSE
                {
                    Id = 6,
                    Language = "Swedish",
                    Text = "Jag älskar dricka Pepsi",
                    Translation = "I love drinking Pepsi"
                },

                new PhrasesSE
                {
                    Id = 7,
                    Language = "Swedish",
                    Text = "Jag bor i Göteborg",
                    Translation = "I live in Gothenburg"
                },

                new PhrasesSE
                {
                    Id = 8,
                    Language = "Swedish",
                    Text = "Jag brukar gå en promenad på morgonen",
                    Translation = "I usually go for a  walk during the morning"
                },

                new PhrasesSE
                {
                    Id = 9,
                    Language = "Swedish",
                    Text = "Hon lämnade mig för en annan kille",
                    Translation = "She left me for another guy"
                },

                new PhrasesSE
                {
                    Id = 10,
                    Language = "Swedish",
                    Text = "Jag är brasiliansk",
                    Translation = "I am Brazilian"
                },

                new PhrasesSE
                {
                    Id = 11,
                    Language = "Swedish",
                    Text = "Jag var på en restaurang med min fru",
                    Translation = "I was at a restaurant with my wife"
                },

                new PhrasesSE
                {
                    Id = 12,
                    Language = "Swedish",
                    Text = "Jag måste gå på toaletten",
                    Translation = "I need to go to the bathroom"
                },

                new PhrasesSE
                {
                    Id = 13,
                    Language = "Swedish",
                    Text = "De gick till parken tillsammans",
                    Translation = "They went to the park together"
                },

                new PhrasesSE
                {
                    Id = 14,
                    Language = "Swedish",
                    Text = "Min pappa är på sjukhuset",
                    Translation = "My dad is at the Hospital"
                },

                new PhrasesSE
                {
                    Id = 15,
                    Language = "Swedish",
                    Text = "Jag är en man med ett stort hjärta",
                    Translation = "I am a man with a big heart"
                },

                new PhrasesSE
                {
                    Id = 16,
                    Language = "Swedish",
                    Text = "Jag har sett hennes profil på Instagram",
                    Translation = "I've seen her profile on Instagram."
                },

                new PhrasesSE
                {
                    Id = 17,
                    Language = "Swedish",
                    Text = "Han är elak, vi borde polisanmäla honom",
                    Translation = "He's mean, we should report him to the police."
                },

                new PhrasesSE
                {
                    Id = 18,
                    Language = "Swedish",
                    Text = "Hon är från Ryssland men bor i Sverige",
                    Translation = "She is from Russia but lives in Sweden"
                },

                new PhrasesSE
                {
                    Id = 19,
                    Language = "Swedish",
                    Text = "Min bil slutade fungera",
                    Translation = "My car stopped working"
                },

                new PhrasesSE
                {
                    Id = 20,
                    Language = "Swedish",
                    Text = "Fokusera på dig själv och glöm det, min vän. Hon var inte värd det...",
                    Translation = "Focus on yourself and forget about it, my friend. She was not worth it..."
                }
                );

            //Swedish Vocab
            modelBuilder.Entity<VocabulariesSE>().HasData(

                new VocabulariesSE
                {
                    Id = 1,
                    Language = "Swedish",
                    Text = "Hej",
                    Translation = "Hello"

                },

                new VocabulariesSE
                {
                    Id = 2,
                    Language = "Swedish",
                    Text = "Tack",
                    Translation = "Thank you"
                },

                new VocabulariesSE
                {
                    Id = 3,
                    Language = "Swedish",
                    Text = "Ja",
                    Translation = "Yes"
                },

                new VocabulariesSE
                {
                    Id = 4,
                    Language = "Swedish",
                    Text = "Nej",
                    Translation = "No"
                },

                new VocabulariesSE
                {
                    Id = 5,
                    Language = "Swedish",
                    Text = "Vän",
                    Translation = "Friend"

                },

                new VocabulariesSE
                {
                    Id = 6,
                    Language = "Swedish",
                    Text = "Hus",
                    Translation = "House"
                },

                new VocabulariesSE
                {
                    Id = 7,
                    Language = "Swedish",
                    Text = "Mat",
                    Translation = "Food"
                },

                new VocabulariesSE
                {
                    Id = 8,
                    Language = "Swedish",
                    Text = "Vatten",
                    Translation = "Water"
                },

                new VocabulariesSE
                {
                    Id = 9,
                    Language = "Swedish",
                    Text = "Bok",
                    Translation = "Book"
                },

                new VocabulariesSE
                {
                    Id = 10,
                    Language = "Swedish",
                    Text = "Skola",
                    Translation = "School"
                },

                new VocabulariesSE
                {
                    Id = 11,
                    Language = "Swedish",
                    Text = "älskar",
                    Translation = "Love"
                },

                new VocabulariesSE
                {
                    Id = 12,
                    Language = "Swedish",
                    Text =  "Sol",
                    Translation = "Sun"
                },

                new VocabulariesSE
                {
                    Id = 13,
                    Language = "Swedish",
                    Text = "Mörk",
                    Translation = "Dark"

                },

                new VocabulariesSE
                {
                    Id = 14,
                    Language = "Swedish",
                    Text = "Ljus",
                    Translation = "Light"
                },

                new VocabulariesSE
                {
                    Id = 15,
                    Language = "Swedish",
                    Text = "Dator",
                    Translation = "Computer"
                },

                new VocabulariesSE
                {
                    Id = 16,
                    Language = "Swedish",
                    Text = "Fönster",
                    Translation = "Window"
                },

                new VocabulariesSE
                {
                    Id = 17,
                    Language = "Swedish",
                    Text = "Dörr",
                    Translation = "Door"
                },

                new VocabulariesSE
                {
                    Id = 18,
                    Language = "Swedish",
                    Text = "Skrivbord",
                    Translation = "Desk"
                },

                new VocabulariesSE
                {
                    Id = 19,
                    Language = "Swedish",
                    Text = "Säng",
                    Translation = "Bed"
                },

                new VocabulariesSE
                {
                    Id = 20,
                    Language = "Swedish",
                    Text = "Bilar",
                    Translation = "Cars"
                }


                );

            //Polish Phrases
            modelBuilder.Entity<PhrasesPL>().HasData(

                new PhrasesPL
                {
                    Id = 1,
                    Language = "Polish",
                    Text = "Dzień dobry",
                    Translation = "Good morning"
                },

                new PhrasesPL
                {
                    Id = 2,
                    Language = "Polish",
                    Text = "Do widzenia",
                    Translation = "Goodbye"
                },

                new PhrasesPL
                {
                    Id = 3,
                    Language = "Polish",
                    Text = "Jak się masz?",
                    Translation = "How are you?"
                },

                new PhrasesPL
                {
                    Id = 4,
                    Language = "Polish",
                    Text = "Dobrze, dziękuję",
                    Translation = "I'm fine, thank you"
                },

                new PhrasesPL
                {
                    Id = 5,
                    Language = "Polish",
                    Text = "Gdzie jest toaleta?",
                    Translation = "Where is the bathroom?"
                },

                new PhrasesPL
                {
                    Id = 6,
                    Language = "Polish",
                    Text = "Ile to kosztuje?",
                    Translation = "How much does it cost?"
                },

                new PhrasesPL
                {
                    Id = 7,
                    Language = "Polish",
                    Text = "Mówię po polsku",
                    Translation = "I speak Polish"
                },

                new PhrasesPL
                {
                    Id = 8,
                    Language = "Polish",
                    Text = "Nie rozumiem",
                    Translation = "Translation"
                },

                new PhrasesPL
                {
                    Id = 9,
                    Language = "Polish",
                    Text = "Możesz powtórzyć?",
                    Translation = "Can you repeat?"
                },

                new PhrasesPL
                {
                    Id = 10,
                    Language = "Polish",
                    Text = "Jestem z Polski",
                    Translation = "I am from Poland"
                },

                new PhrasesPL
                {
                    Id = 11,
                    Language = "Polish",
                    Text = "Co robisz?",
                    Translation = "What are you doing?"
                },

                new PhrasesPL
                {
                    Id = 12,
                    Language = "Polish",
                    Text = "Lubię to",
                    Translation = "I like it"
                },

                new PhrasesPL
                {
                    Id = 13,
                    Language = "Polish",
                    Text = "Skąd jesteś?",
                    Translation = "Where are you from?"
                },

                new PhrasesPL
                {
                    Id = 14,
                    Language = "Polish",
                    Text = "Ile masz lat?",
                    Translation = "How old are you?"
                },

                new PhrasesPL
                {
                    Id = 15,
                    Language = "Polish",
                    Text = "Co robisz w wolnym czasie?",
                    Translation = "What do you do in your free time?"

                },

               new PhrasesPL
               {
                   Id = 16,
                   Language = "Polish",
                   Text = "Lubię czytać książki.",
                   Translation = "I like to read books."
               },

              new PhrasesPL
              {
                  Id = 17,
                  Language = "Polish",
                  Text = "Czy mówisz po angielsku?",
                  Translation = "Do you speak English?"
              },

              new PhrasesPL
              {
                  Id = 18,
                  Language = "Polish",
                  Text = "Chciałbym coś do picia.",
                  Translation = " I would like something to drink."
              },

              new PhrasesPL
              {
                  Id = 19,
                  Language = "Polish",
                  Text = "Czy mogę pomóc?",
                  Translation = "Can I help?"
              },

              new PhrasesPL
              {
                  Id = 20,
                  Language = "Polish",
                  Text = "To jest smaczne!",
                  Translation = "This is delicious!"
              }

                );

            //Poilish Words
            modelBuilder.Entity<VocabulariesPL>().HasData(

                new VocabulariesPL
                {
                    Id = 1,
                    Language = "Polish",
                    Text = "Kocham",
                    Translation = "I love"
                },

                new VocabulariesPL
                {
                    Id = 2,
                    Language = "Polish",
                    Text = "Dzień",
                    Translation = "Day"
                },

                new VocabulariesPL
                {
                    Id = 3,
                    Language = "Polish",
                    Text = "Noc",
                    Translation = "Night"
                },

                new VocabulariesPL
                {
                    Id = 4,
                    Language = "Polish",
                    Text = "Pies",
                    Translation = "Dog"
                },

                new VocabulariesPL
                {
                    Id = 5,
                    Language = "Polish",
                    Text = "Kot",
                    Translation = "Cat"
                },

                new VocabulariesPL
                {
                    Id = 6,
                    Language = "Polish",
                    Text = "Dom",
                    Translation = "House"
                },

                new VocabulariesPL
                {
                    Id = 7,
                    Language = "Polish",
                    Text = "Szkoła",
                    Translation = "School"
                },

                new VocabulariesPL
                {
                    Id = 8,
                    Language = "Polish",
                    Text = "Przyjaciel",
                    Translation = " Friend"
                },

                new VocabulariesPL
                {
                    Id = 9,
                    Language = "Polish",
                    Text = "Rodzina",
                    Translation = "Family"
                },

                new VocabulariesPL
                {
                    Id = 10,
                    Language = "Polish",
                    Text = "Woda",
                    Translation = "Water"
                },

                new VocabulariesPL
                {
                    Id = 11,
                    Language = "Polish",
                    Text = "Jedzenie",
                    Translation = "Food"
                },

                new VocabulariesPL
                {
                    Id = 12,
                    Language = "Polish",
                    Text = "Kawa",
                    Translation = "Coffee"
                },

                new VocabulariesPL
                {
                    Id = 13,
                    Language = "Polish",
                    Text = "Herbata",
                    Translation = "Tea"
                },

                new VocabulariesPL
                {
                    Id = 14,
                    Language = "Polish",
                    Text = "Mężczyzna",
                    Translation = " Man"
                },

                new VocabulariesPL
                {
                    Id = 15,
                    Language = "Polish",
                    Text = "Kobieta",
                    Translation = "Woman"
                },

                new VocabulariesPL
                {
                    Id = 16,
                    Language = "Polish",
                    Text = "Dziecko",
                    Translation = "Child"
                },

                new VocabulariesPL
                {
                    Id = 17,
                    Language = "Polish",
                    Text = "Miłość",
                    Translation = "Love"
                },

                new VocabulariesPL
                {
                    Id = 18,
                    Language = "Polish",
                    Text = "Praca",
                    Translation = "Work"
                },

                new VocabulariesPL
                {
                    Id = 19,
                    Language = "Polish",
                    Text = "Samochód",
                    Translation = "Car"
                },

                new VocabulariesPL
                {
                    Id = 20,
                    Language = "Polish",
                    Text = "Miasto",
                    Translation = "City"
                }



                );




        }
    }
}
