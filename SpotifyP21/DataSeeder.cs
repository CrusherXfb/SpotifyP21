namespace SpotifyP21;

using SpotifyP21.Data;
using SpotifyP21.Entities;

public static class DataSeeder
{
    public static void SeedData(SpotifyContext context)
    {
        if (!context.Genres.Any())
        {
            var genres = new List<Genre>
            {
                new Genre { Title = "Rock" },
                new Genre { Title = "Pop" },
                new Genre { Title = "Jazz" },
                new Genre { Title = "Hip-Hop" },
                new Genre { Title = "Electronic" },
                new Genre { Title = "Classical" },
                new Genre { Title = "Country" },
                new Genre { Title = "Blues" },
                new Genre { Title = "Reggae" },
                new Genre { Title = "Folk" },
                new Genre { Title = "Metal" },
                new Genre { Title = "Punk" },
                new Genre { Title = "R&B" },
                new Genre { Title = "Latin" },
                new Genre { Title = "World" }
            };
            context.Genres.AddRange(genres);
            context.SaveChanges();
        }

        if (!context.Groups.Any())
        {
            var groups = new List<Group>
            {
                new Group { Title = "The Beatles" },
                new Group { Title = "Queen" },
                new Group { Title = "Miles Davis" },
                new Group { Title = "Nirvana" },
                new Group { Title = "Michael Jackson" },
                new Group { Title = "Daft Punk" },
                new Group { Title = "Beethoven" },
                new Group { Title = "Johnny Cash" },
                new Group { Title = "B.B. King" },
                new Group { Title = "Bob Marley" },
                new Group { Title = "Metallica" },
                new Group { Title = "Green Day" },
                new Group { Title = "Beyoncé" },
                new Group { Title = "Shakira" },
                new Group { Title = "Buena Vista Social Club" }
            };
            context.Groups.AddRange(groups);
            context.SaveChanges();
        }

        if (!context.Albums.Any())
        {
            var albums = new List<Album>
            {
                new Album
                {
                    Title = "Abbey Road",
                    Photo = "abbey_road.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Rock").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "The Beatles").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Come Together" },
                        new Song { Title = "Something" },
                        new Song { Title = "Maxwell's Silver Hammer" },
                        new Song { Title = "Oh! Darling" },
                        new Song { Title = "Octopus's Garden" },
                        new Song { Title = "I Want You (She's So Heavy)" },
                        new Song { Title = "Here Comes the Sun" },
                        new Song { Title = "Because" },
                        new Song { Title = "You Never Give Me Your Money" },
                        new Song { Title = "Sun King" },
                        new Song { Title = "Mean Mr. Mustard" },
                        new Song { Title = "Polythene Pam" },
                        new Song { Title = "She Came In Through the Bathroom Window" },
                        new Song { Title = "Golden Slumbers" },
                        new Song { Title = "Carry That Weight" },
                        new Song { Title = "The End" },
                        new Song { Title = "Her Majesty" }
                    }
                },
                new Album
                {
                    Title = "A Night at the Opera",
                    Photo = "night_at_the_opera.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Rock").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Queen").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Death on Two Legs (Dedicated to...)" },
                        new Song { Title = "Lazing on a Sunday Afternoon" },
                        new Song { Title = "I'm in Love with My Car" },
                        new Song { Title = "You're My Best Friend" },
                        new Song { Title = "39" },
                        new Song { Title = "Sweet Lady" },
                        new Song { Title = "Seaside Rendezvous" },
                        new Song { Title = "The Prophet's Song" },
                        new Song { Title = "Love of My Life" },
                        new Song { Title = "Good Company" },
                        new Song { Title = "Bohemian Rhapsody" },
                        new Song { Title = "God Save the Queen" }
                    }
                },
                new Album
                {
                    Title = "Kind of Blue",
                    Photo = "kind_of_blue.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Jazz").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Miles Davis").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "So What" },
                        new Song { Title = "Freddie Freeloader" },
                        new Song { Title = "Blue in Green" },
                        new Song { Title = "All Blues" },
                        new Song { Title = "Flamenco Sketches" }
                    }
                },
                new Album
                {
                    Title = "Nevermind",
                    Photo = "nevermind.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Rock").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Nirvana").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Smells Like Teen Spirit" },
                        new Song { Title = "In Bloom" },
                        new Song { Title = "Come as You Are" },
                        new Song { Title = "Breed" },
                        new Song { Title = "Lithium" },
                        new Song { Title = "Polly" },
                        new Song { Title = "Territorial Pissings" },
                        new Song { Title = "Drain You" },
                        new Song { Title = "Lounge Act" },
                        new Song { Title = "Stay Away" },
                        new Song { Title = "On a Plain" },
                        new Song { Title = "Something in the Way" }
                    }
                },
                new Album
                {
                    Title = "Thriller",
                    Photo = "thriller.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Pop").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Michael Jackson").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Wanna Be Startin' Somethin'" },
                        new Song { Title = "Baby Be Mine" },
                        new Song { Title = "The Girl Is Mine" },
                        new Song { Title = "Thriller" },
                        new Song { Title = "Beat It" },
                        new Song { Title = "Billie Jean" },
                        new Song { Title = "Human Nature" },
                        new Song { Title = "P.Y.T. (Pretty Young Thing)" },
                        new Song { Title = "The Lady in My Life" }
                    }
                },
                new Album
                {
                    Title = "Discovery",
                    Photo = "discovery.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Electronic").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Daft Punk").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "One More Time" },
                        new Song { Title = "Aerodynamic" },
                        new Song { Title = "Digital Love" },
                        new Song { Title = "Harder, Better, Faster, Stronger" },
                        new Song { Title = "Crescendolls" },
                        new Song { Title = "Nightvision" },
                        new Song { Title = "Superheroes" },
                        new Song { Title = "High Life" },
                        new Song { Title = "Something About Us" },
                        new Song { Title = "Voyager" },
                        new Song { Title = "Veridis Quo" },
                        new Song { Title = "Short Circuit" },
                        new Song { Title = "Face to Face" },
                        new Song { Title = "Too Long" }
                    }
                },
                new Album
                {
                    Title = "Symphony No. 9",
                    Photo = "symphony_no_9.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Classical").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Beethoven").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Allegro ma non troppo, un poco maestoso" },
                        new Song { Title = "Molto vivace" },
                        new Song { Title = "Adagio molto e cantabile" },
                        new Song { Title = "Presto" }
                    }
                },
                new Album
                {
                    Title = "At Folsom Prison",
                    Photo = "at_folsom_prison.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Country").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Johnny Cash").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Folsom Prison Blues" },
                        new Song { Title = "Dark as a Dungeon" },
                        new Song { Title = "I Still Miss Someone" },
                        new Song { Title = "Cocaine Blues" },
                        new Song { Title = "25 Minutes to Go" },
                        new Song { Title = "Orange Blossom Special" },
                        new Song { Title = "The Long Black Veil" },
                        new Song { Title = "Send a Picture of Mother" },
                        new Song { Title = "The Wall" },
                        new Song { Title = "Dirty Old Egg-Sucking Dog" },
                        new Song { Title = "Flushed from the Bathroom of Your Heart" },
                        new Song { Title = "Jackson" },
                        new Song { Title = "Give My Love to Rose" },
                        new Song { Title = "I Got Stripes" },
                        new Song { Title = "The Legend of John Henry's Hammer" },
                        new Song { Title = "Green, Green Grass of Home" },
                        new Song { Title = "Greystone Chapel" }
                    }
                },
                new Album
                {
                    Title = "Live at the Regal",
                    Photo = "live_at_the_regal.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Blues").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "B.B. King").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Every Day I Have the Blues" },
                        new Song { Title = "Sweet Sixteen" },
                        new Song { Title = "How Blue Can You Get?" },
                        new Song { Title = "Please Love Me" },
                        new Song { Title = "You Upset Me Baby" },
                        new Song { Title = "Worry, Worry" },
                        new Song { Title = "Woke Up This Morning" },
                        new Song { Title = "You Done Lost Your Good Thing Now" },
                        new Song { Title = "Help the Poor" }
                    }
                },
                new Album
                {
                    Title = "Exodus",
                    Photo = "exodus.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Reggae").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Bob Marley").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Natural Mystic" },
                        new Song { Title = "So Much Things to Say" },
                        new Song { Title = "Guiltiness" },
                        new Song { Title = "The Heathen" },
                        new Song { Title = "Exodus" },
                        new Song { Title = "Jamming" },
                        new Song { Title = "Waiting in Vain" },
                        new Song { Title = "Turn Your Lights Down Low" },
                        new Song { Title = "Three Little Birds" },
                        new Song { Title = "One Love/People Get Ready" }
                    }
                },
                new Album
                {
                    Title = "Master of Puppets",
                    Photo = "master_of_puppets.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Metal").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Metallica").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Battery" },
                        new Song { Title = "Master of Puppets" },
                        new Song { Title = "The Thing That Should Not Be" },
                        new Song { Title = "Welcome Home (Sanitarium)" },
                        new Song { Title = "Disposable Heroes" },
                        new Song { Title = "Leper Messiah" },
                        new Song { Title = "Orion" },
                        new Song { Title = "Damage, Inc." }
                    }
                },
                new Album
                {
                    Title = "Dookie",
                    Photo = "dookie.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Punk").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Green Day").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Burnout" },
                        new Song { Title = "Having a Blast" },
                        new Song { Title = "Chump" },
                        new Song { Title = "Longview" },
                        new Song { Title = "Welcome to Paradise" },
                        new Song { Title = "Pulling Teeth" },
                        new Song { Title = "Basket Case" },
                        new Song { Title = "She" },
                        new Song { Title = "Sassafras Roots" },
                        new Song { Title = "When I Come Around" },
                        new Song { Title = "Coming Clean" },
                        new Song { Title = "Emenius Sleepus" },
                        new Song { Title = "In the End" },
                        new Song { Title = "F.O.D." }
                    }
                },
                new Album
                {
                    Title = "Lemonade",
                    Photo = "lemonade.jpg",
                    Genres = context.Genres.Where(g => g.Title == "R&B").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Beyoncé").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Pray You Catch Me" },
                        new Song { Title = "Hold Up" },
                        new Song { Title = "Don't Hurt Yourself" },
                        new Song { Title = "Sorry" },
                        new Song { Title = "6 Inch" },
                        new Song { Title = "Daddy Lessons" },
                        new Song { Title = "Love Drought" },
                        new Song { Title = "Sandcastles" },
                        new Song { Title = "Forward" },
                        new Song { Title = "Freedom" },
                        new Song { Title = "All Night" },
                        new Song { Title = "Formation" }
                    }
                },
                new Album
                {
                    Title = "El Dorado",
                    Photo = "el_dorado.jpg",
                    Genres = context.Genres.Where(g => g.Title == "Latin").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Shakira").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Me Enamoré" },
                        new Song { Title = "Nada" },
                        new Song { Title = "Chantaje" },
                        new Song { Title = "When a Woman" },
                        new Song { Title = "Amarillo" },
                        new Song { Title = "Perro Fiel" },
                        new Song { Title = "Trap" },
                        new Song { Title = "Comme Moi" },
                        new Song { Title = "Coconut Tree" },
                        new Song { Title = "La Bicicleta" },
                        new Song { Title = "Deja Vu" },
                        new Song { Title = "What We Said" },
                        new Song { Title = "Toneladas" }
                    }
                },
                new Album
                {
                    Title = "Buena Vista Social Club",
                    Photo = "buena_vista_social_club.jpg",
                    Genres = context.Genres.Where(g => g.Title == "World").ToList(),
                    Groups = context.Groups.Where(g => g.Title == "Buena Vista Social Club").ToList(),
                    Songs = new List<Song>
                    {
                        new Song { Title = "Chan Chan" },
                        new Song { Title = "De Camino a La Vereda" },
                        new Song { Title = "El Cuarto de Tula" },
                        new Song { Title = "Pueblo Nuevo" },
                        new Song { Title = "Dos Gardenias" },
                        new Song { Title = "¿Y Tú Qué Has Hecho?" },
                        new Song { Title = "Veinte Años" },
                        new Song { Title = "El Carretero" },
                        new Song { Title = "Candela" },
                        new Song { Title = "Amor de Loca Juventud" },
                        new Song { Title = "Orgullecida" },
                        new Song { Title = "Murmullo" },
                        new Song { Title = "Buena Vista Social Club" },
                        new Song { Title = "La Bayamesa" }
                    }
                }
            };
            context.Albums.AddRange(albums);
            context.SaveChanges();
        }
    }
}
