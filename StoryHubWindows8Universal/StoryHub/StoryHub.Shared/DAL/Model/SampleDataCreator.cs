using System;
using System.Collections.Generic;
using System.Text;

namespace StoryHub.DAL.Model
{
    public static class SampleDataCreator
    {
        
        //authors
        public static Author Author_Garendel = new Author()
        {
            AuthorGender = Gender.Shklee,
            AuthorGenres = new List<Genre>() { Genre.fantasy, Genre.horror },
            AuthorNationality = Nationality.German,
            BirthDate = DateTime.Now,
            Description = "I am Lorten Voldemorten",
            Name = "Garendel",
            Pseudonyme = "Grundy",
            Stories = new List<string>() { "Hansel and Gretel" },
            Surename = "Swinnechantzel"
        };
        public static Author Author_Miranda = new Author() 
        {
            AuthorGender = Gender.Female,
            AuthorGenres = new List<Genre>() { Genre.fantasy, Genre.horror, Genre.romantic },
            AuthorNationality = Nationality.American,
            BirthDate = DateTime.Now,
            Description = "My name is Miranda McNarry and I am itty pitty princess.",
            Name = "Miranda",
            Pseudonyme = "Mirri",
            Stories = new List<string>() { "Dawn of Dragons" },
            Surename = "McNarry"
        };
        public static Author Author_Cendric = new Author() 
        {
            AuthorGender = Gender.Male,
            AuthorGenres = new List<Genre>() { Genre.fantasy, Genre.horror, Genre.romantic, Genre.scifi },
            AuthorNationality = Nationality.British,
            BirthDate = DateTime.Now,
            Description = "Howdy guys. I hope you enjoy my stories ;)",
            Name = "Cendric",
            Pseudonyme = "StarWolf",
            Stories = new List<string>() { "Warmoger" },
            Surename = "Bludburry"
        };

        //stories
        private static Story st1 = new Story() { Title = "About author", Subtitle = "Modofokin dude", Added = DateTime.Now, Rating = 4, Author = Author_Garendel, Body = "This is the new shit." };

        //storylines
        public static Storyline Storyline_HanselAndGretel = new Storyline()
        {
            Abstrakt = "bla",
            Added = DateTime.Now,
            Author = Author_Cendric,
            Genres = new List<Genre>() { Genre.fantasy },
            HasNew = true,
            LastChange = DateTime.Now,
            Rating = 5,
            Restriction = new List<Restriction>() { new Restriction() { Name = "Gore", Description = "Lot of blood and intestines" } },
            Stories = new List<Story>() 
            {  st1,
                new Story()
                {
                    Added = DateTime.Now,
                    Author = Author_Garendel,
                    Title = "Prologue",

                    
                    
                }, 
                new Story()
                {
                    Title = "Chapter I",
                }, 
                new Story()
                {
                    Title = "Chapter II",
                }
            },
            Subtitle = "The old story",
            Title = "Hansel and Gretel",
            
        };
        public static Storyline Storyline_DawnOfDragons = new Storyline();
        public static Storyline Storyline_Warmonger = new Storyline();

        //user
        public static User TestUser1_Cendric = new User()
        {
            AuthorEgo = Author_Cendric,
            Email = "cendric@mail.com",
            FavouriteGenres = new List<Genre>() { Genre.scifi },
            Password = "test",
            Storylines = new List<Storyline>() { Storyline_HanselAndGretel, Storyline_DawnOfDragons, Storyline_Warmonger }
        };
    }
}
