using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_Cellini
{
    class Movie
    {
        #region fields
        private string title;
        private string category;
        #endregion

        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        #endregion

        #region constructors

        //default constructor
        public Movie() { }

        // overloaded constructor
        public Movie(string Title, string Category)
        {
            title = Title;
            category = Category;
        }
        #endregion

        #region Methods
        public static string CategoryFilter(List<Movie> MovieList, string categoryinput)
        {
            //Takes the user input, filters the movies by category to display to user.
            //Couldn't get method to work correctly. Please advise.
            for (int i = 0; i < MovieList.Count; i++)
            {
                if (categoryinput == "sci-fi")
                {
                    if (MovieList[i].Category == "Sci-Fi")
                    {
                         return MovieList[i].Title;
                    }
                }
                else if (categoryinput == "horror")
                {
                    if (MovieList[i].Category == "Horror")
                    {
                        return MovieList[i].Title;
                    }
                }
                else if (categoryinput == "drama")
                {
                    if (MovieList[i].Category == "Drama")
                    {
                        return MovieList[i].Title;
                    }
                }
                else if (categoryinput == "animated")
                {
                    if (MovieList[i].Category == "Animated")
                    {
                        return MovieList[i].Title;
                    }
                }
            }
            return "Invalid input. Please try again.";
        }
        #endregion

    }
}
