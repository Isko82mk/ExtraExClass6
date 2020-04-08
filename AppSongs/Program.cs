using DomainModels;
using System;
using Services;

namespace AppSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            SongModel song1 = new SongModel("Smells Like Teen Spirit", "Nirvana", 4.38, Genre.Pop, " Kurt Cobain", "English");
            SongModel song2 = new SongModel("Big Poppa", "The Notorious B.I.G.", 4.21, Genre.HipHop, " Christopher George Latore Wallace ", "Englesh");
            SongModel song3 = new SongModel("Are You Gonna Be My Girl","Jet",3.34, Genre.Rock, " Nic Cester  ", "Englesh");
            SongModel song4 = new SongModel("Run's House", " RUN-DMC ", 3.20, Genre.Rap, " Darryl “DMC” McDaniels "," Englesh ");
            SongModel song5 = new SongModel("Freddie Freeloader", " Miles Davis ", 9.49, Genre.Jazz, " Miles Davis", " Englesh ");

            SongModel[] songs = new SongModel[] { song1, song2, song3, song4, song5 };

            //foreach (SongModel song in songs)
            //{
            //    Console.WriteLine(song.Author);
            //}


            SongServices songServices = new SongServices();

            //songServices.FindByName(songs, "Big Poppa");

            //songServices.FindByAuthor(songs, "Miles Davis");

            //songServices.FindByGenre(songs, Genre.Jazz);

            //songServices.FindSongsLongerThan(songs,4);

            //songServices.FindSongsShorterThan(songs,4);


            SongModel song6 = new SongModel("Around the world", " Daft Punk ", 7.09, Genre.House, " Thomas Bangalter", " Englesh ");
            songs= songServices.AddSong(songs,song6);

            songServices.FindByName(songs, "Around the world");


            //foreach (SongModel song in songs)
            //{
            //    Console.WriteLine(song.Author);
            //}


            Console.ReadLine();

        }
    }
}
