using Microsoft.EntityFrameworkCore;
using Sklep_Internetowy_JW.Models;

namespace Sklep_Internetowy_JW.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Category> Categories { get; set; }
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var films = new List<Film>
            {
                new Film { FilmId = 1, Title = "Mad Max: Fury Road", Director = "George Miller", Desc = "In a post-apocalyptic world, Max becomes part of a war for survival.", Price = 19.99m, CategoryId = 1 ,Poster = "1.jpg"},
                new Film { FilmId = 2, Title = "John Wick", Director = "Chad Stahelski", Desc = "A former assassin fights for survival in a world full of killers.", Price = 14.99m, CategoryId = 1,Poster = "2.jpg" },
                new Film { FilmId = 3, Title = "Jumanji: Welcome to the Jungle", Director = "Jake Kasdan", Desc = "Four teenagers are sucked into a game where they must fight for their lives.", Price = 12.99m, CategoryId = 2 ,Poster = "3.jpg"},
                new Film { FilmId = 4, Title = "The Hangover", Director = "Todd Phillips", Desc = "Three men wake up after an unforgettable night in Las Vegas, not knowing what happened.", Price = 9.99m, CategoryId = 2 ,Poster = "4.jpg"},
                new Film { FilmId = 5, Title = "The Pursuit of Happyness", Director = "Gabriele Muccino", Desc = "A father struggles with adversity to provide a better life for his son.", Price = 11.99m, CategoryId = 3 ,Poster = "5.jpg"},
                new Film { FilmId = 6, Title = "A Beautiful Mind", Director = "Ron Howard", Desc = "The story of a mathematician struggling with mental illness while his genius changes the world.", Price = 13.99m, CategoryId = 3 ,Poster = "6.jpg"},
                new Film { FilmId = 7, Title = "The Conjuring", Director = "James Wan", Desc = "A couple of paranormal investigators face a terrifying haunting case.", Price = 15.99m, CategoryId = 4 ,Poster = "7.jpg"},
                new Film { FilmId = 8, Title = "It", Director = "Andrés Muschietti", Desc = "A group of kids faces their fears against a demon that takes the form of a clown.", Price = 16.99m, CategoryId = 4 ,Poster = "8.jpg"},
                new Film { FilmId = 9, Title = "Blade Runner 2049", Director = "Denis Villeneuve", Desc = "Detective K uncovers a secret that could change the future of humanity.", Price = 18.99m, CategoryId = 5 ,Poster = "9.jpg"},
                new Film { FilmId = 10, Title = "Interstellar", Director = "Christopher Nolan", Desc = "A group of astronauts travel through black holes to save humanity.", Price = 19.49m, CategoryId = 5 ,Poster = "10.jpg"},
                new Film { FilmId = 11, Title = "Die Hard", Director = "John McTiernan", Desc = "A policeman fights terrorists who have taken over a skyscraper.", Price = 17.99m, CategoryId = 1 ,Poster = "11.jpg"},
                new Film { FilmId = 12, Title = "The Grand Budapest Hotel", Director = "Wes Anderson", Desc = "The story of an eccentric hotel manager and his young assistant in a pre-World War II world.", Price = 13.49m, CategoryId = 2 ,Poster = "12.jpg"},
                new Film { FilmId = 13, Title = "The Revenant", Director = "Alejandro González Iñárritu", Desc = "A trapper fights for survival in the wilderness after a brutal animal attack.", Price = 14.49m, CategoryId = 3 ,Poster = "13.jpg"},
                new Film { FilmId = 14, Title = "Get Out", Director = "Jordan Peele", Desc = "A young African-American man uncovers a dark secret while visiting his girlfriend's family.", Price = 10.99m, CategoryId = 4 ,Poster = "14.jpg"},
                new Film { FilmId = 15, Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Desc = "A computer programmer discovers that his reality is a virtual world created by machines.", Price = 17.49m, CategoryId = 5 ,Poster = "15.jpg"},
                new Film { FilmId = 16, Title = "Pacific Rim", Director = "Guillermo del Toro", Desc = "Giant monsters attack Earth, and humanity fights back with giant robots.", Price = 18.99m, CategoryId = 1 ,Poster = "16.jpg"},
                new Film { FilmId = 17, Title = "The Social Network", Director = "David Fincher", Desc = "The story of Mark Zuckerberg and the creation of Facebook.", Price = 14.99m, CategoryId = 3 ,Poster = "17.jpg"},
                new Film { FilmId = 18, Title = "Guardians of the Galaxy", Director = "James Gunn", Desc = "A group of outlaws band together to stop a powerful villain from destroying the universe.", Price = 17.99m, CategoryId = 5 ,Poster = "18.jpg"},
                new Film { FilmId = 19, Title = "Shutter Island", Director = "Martin Scorsese", Desc = "A U.S. Marshal investigates the disappearance of a patient from a mental institution.", Price = 12.99m, CategoryId = 3 ,Poster = "19.jpg"},
                new Film { FilmId = 20, Title = "The Silence of the Lambs", Director = "Jonathan Demme", Desc = "A young FBI agent seeks the help of a cannibalistic serial killer to catch another murderer.", Price = 16.49m, CategoryId = 4,Poster = "20.jpg" }
            };

            var categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Action", Description = "Movies full of dynamic scenes, fights, and chases." },
                new Category { CategoryId = 2, Name = "Comedy", Description = "Movies designed to entertain and make the audience laugh." },
                new Category { CategoryId = 3, Name = "Drama", Description = "Movies that showcase intense emotions and serious situations." },
                new Category { CategoryId = 4, Name = "Horror", Description = "Movies full of tension, fear, and surprising plot twists." },
                new Category { CategoryId = 5, Name = "Science Fiction", Description = "Movies set in futuristic or technologically advanced worlds." }
            };
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Film>().HasData(films);
        }
    }
}
