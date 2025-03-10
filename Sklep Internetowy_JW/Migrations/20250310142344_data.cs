using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sklep_Internetowy_JW.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Movies full of dynamic scenes, fights, and chases.", "Action" },
                    { 2, "Movies designed to entertain and make the audience laugh.", "Comedy" },
                    { 3, "Movies that showcase intense emotions and serious situations.", "Drama" },
                    { 4, "Movies full of tension, fear, and surprising plot twists.", "Horror" },
                    { 5, "Movies set in futuristic or technologically advanced worlds.", "Science Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "CategoryId", "Desc", "Director", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "In a post-apocalyptic world, Max becomes part of a war for survival.", "George Miller", 19.99m, "Mad Max: Fury Road" },
                    { 2, 1, "A former assassin fights for survival in a world full of killers.", "Chad Stahelski", 14.99m, "John Wick" },
                    { 3, 2, "Four teenagers are sucked into a game where they must fight for their lives.", "Jake Kasdan", 12.99m, "Jumanji: Welcome to the Jungle" },
                    { 4, 2, "Three men wake up after an unforgettable night in Las Vegas, not knowing what happened.", "Todd Phillips", 9.99m, "The Hangover" },
                    { 5, 3, "A father struggles with adversity to provide a better life for his son.", "Gabriele Muccino", 11.99m, "The Pursuit of Happyness" },
                    { 6, 3, "The story of a mathematician struggling with mental illness while his genius changes the world.", "Ron Howard", 13.99m, "A Beautiful Mind" },
                    { 7, 4, "A couple of paranormal investigators face a terrifying haunting case.", "James Wan", 15.99m, "The Conjuring" },
                    { 8, 4, "A group of kids faces their fears against a demon that takes the form of a clown.", "Andrés Muschietti", 16.99m, "It" },
                    { 9, 5, "Detective K uncovers a secret that could change the future of humanity.", "Denis Villeneuve", 18.99m, "Blade Runner 2049" },
                    { 10, 5, "A group of astronauts travel through black holes to save humanity.", "Christopher Nolan", 19.49m, "Interstellar" },
                    { 11, 1, "A policeman fights terrorists who have taken over a skyscraper.", "John McTiernan", 17.99m, "Die Hard" },
                    { 12, 2, "The story of an eccentric hotel manager and his young assistant in a pre-World War II world.", "Wes Anderson", 13.49m, "The Grand Budapest Hotel" },
                    { 13, 3, "A trapper fights for survival in the wilderness after a brutal animal attack.", "Alejandro González Iñárritu", 14.49m, "The Revenant" },
                    { 14, 4, "A young African-American man uncovers a dark secret while visiting his girlfriend's family.", "Jordan Peele", 10.99m, "Get Out" },
                    { 15, 5, "A computer programmer discovers that his reality is a virtual world created by machines.", "Lana Wachowski, Lilly Wachowski", 17.49m, "The Matrix" },
                    { 16, 1, "Giant monsters attack Earth, and humanity fights back with giant robots.", "Guillermo del Toro", 18.99m, "Pacific Rim" },
                    { 17, 3, "The story of Mark Zuckerberg and the creation of Facebook.", "David Fincher", 14.99m, "The Social Network" },
                    { 18, 5, "A group of outlaws band together to stop a powerful villain from destroying the universe.", "James Gunn", 17.99m, "Guardians of the Galaxy" },
                    { 19, 3, "A U.S. Marshal investigates the disappearance of a patient from a mental institution.", "Martin Scorsese", 12.99m, "Shutter Island" },
                    { 20, 4, "A young FBI agent seeks the help of a cannibalistic serial killer to catch another murderer.", "Jonathan Demme", 16.49m, "The Silence of the Lambs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
