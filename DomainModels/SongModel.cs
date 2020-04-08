using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
   public class SongModel
    {
        public string Name { get; set; }
        public string Band { get; set; }
        public double Length { get; set; }
        public Genre Genre { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }


        public SongModel()
        {
            Name = "";
            Band = "";
            Length = 0;
            Genre = Genre.Pop;
            Author = "";
            Language = "English";
        }


        public SongModel(string aName, string aBand, double aLenght, Genre genre, string aAuthor, string aLanguage)
        {
            Name = aName;
            Band = aBand;
            Length = aLenght;
            Genre = genre;
            Author = aAuthor;
            Language = aLanguage;

        }




    }
}
