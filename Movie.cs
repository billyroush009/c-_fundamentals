using System;

namespace C_
{
    //Class example
    public class Movie
    {
        public string title, director;
        private string rating; //"private", only accessible from within the "Movie.cs" file

        public Movie(string aTitle, string aDirector, string aRating){
            title = aTitle;
            director = aDirector;
            Rating = aRating; //setting the "rating" variable through the getter / setter method below, used for validation
        }

        //getter / setter examples
        public string Rating{
            get { return rating; } //used to return value of private string "rating"
            set { 
                //"value" used for input parameter, if requested value is valid from if check below, sets rating to new value
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR"){
                    rating = value;
                } else {
                    rating = "NR"; //default case for invalid inputs
                }
            }
        }


    }
}