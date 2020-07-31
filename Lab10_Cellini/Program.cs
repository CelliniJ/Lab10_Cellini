using System;
using System.Collections.Generic;

namespace Lab10_Cellini
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>() { };

            //Selection of movies added to list.
            MovieList.Add(new Movie("Star Wars", "Sci-Fi"));
            MovieList.Add(new Movie("Minority Report", "Sci-Fi"));
            MovieList.Add(new Movie("Blade Runner", "Sci-Fi"));
            MovieList.Add(new Movie("Independence Day", "Sci-Fi"));
            MovieList.Add(new Movie("The Martian", "Sci-Fi"));

            MovieList.Add(new Movie("Get Out", "Horror"));
            MovieList.Add(new Movie("Us", "Horror"));
            MovieList.Add(new Movie("Midsommar", "Horror"));
            MovieList.Add(new Movie("Hereditary", "Horror"));
            MovieList.Add(new Movie("The Exorcist", "Horror"));

            MovieList.Add(new Movie("Parasite", "Drama"));
            MovieList.Add(new Movie("The Irishman", "Drama"));
            MovieList.Add(new Movie("Dunkirk", "Drama"));
            MovieList.Add(new Movie("The Departed", "Drama"));
            MovieList.Add(new Movie("A Few Good Men", "Drama"));

            MovieList.Add(new Movie("Toy Story", "Animated"));
            MovieList.Add(new Movie("The Lion King", "Animated"));
            MovieList.Add(new Movie("Hercules", "Animated"));
            MovieList.Add(new Movie("Aladdin", "Animated"));
            MovieList.Add(new Movie("The Emporer's New Groove", "Animated"));


            Console.WriteLine("Welcome to the Movie List Application");
            Console.WriteLine($"There are {MovieList.Count} in this list.");

            string repeat = "y";
            while (repeat == "y")
            {
                Console.WriteLine("What category are you interested in? (Sci-fi, Horror, Drama, Animated): ");
                string categoryinput = Console.ReadLine().ToLower();

                //Makes sure that the user input is of the 4 choices.
                while (categoryinput != "sci-fi" && categoryinput != "horror" && categoryinput != "drama" && categoryinput != "animated")
                {
                    Console.WriteLine("Invalid input. Please try again");
                    categoryinput = Console.ReadLine();
                    continue;
                }


                //Takes the user input, filters the movies by category to display.
                for (int i = 0; i < MovieList.Count; i++)
                {

                    if (categoryinput == "sci-fi")
                    {
                        if (MovieList[i].Category == "Sci-Fi")
                        {
                            Console.WriteLine(MovieList[i].Title);
                        }
                    }
                    else if (categoryinput == "horror")
                    {
                        if (MovieList[i].Category == "Horror")
                        {
                            Console.WriteLine(MovieList[i].Title);
                        }
                    }
                    else if (categoryinput == "drama")
                    {
                        if (MovieList[i].Category == "Drama")
                        {
                            Console.WriteLine(MovieList[i].Title);
                        }
                    }
                    else if (categoryinput == "animated")
                    {
                        if (MovieList[i].Category == "Animated")
                        {
                            Console.WriteLine(MovieList[i].Title);
                        }
                    }
                }
                Console.WriteLine("Continue? (y/n): ");
                    repeat = Console.ReadLine().ToLower();

                //Checks to make sure the input is only "y" or "n".
                while(repeat != "y" && repeat != "n")
                {
                    Console.WriteLine("Invalid input. Continue? (y/n): ");
                    repeat = Console.ReadLine().ToLower();
                }
                if (repeat == "n")
                {
                    Console.WriteLine("See ya!");
                }
                }
            }
        }
    }
