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

    
    }
}
