using System;
using System.Collections.Generic;
using System.Text;
using DomainModels;


namespace Services
{
    public class SongServices
    {

        public void FindByName(SongModel[] songs, string name)
        {
            foreach (SongModel song in songs)
            {
                if (song.Name == name)
                {
                    Console.WriteLine($"{song.Name} is found");
                }
            }
         
        }

        public void FindByAuthor(SongModel[] songs, string author)
        {
            foreach (SongModel song in songs)
            {
                if (song.Author == author)
                {
                    Console.WriteLine($"{song.Author} is found");
                }
            }
        }

        public void FindByGenre(SongModel[] songs, Genre  genre)
        {
            foreach (SongModel song in songs)
            {
                if (song.Genre == genre)
                {
                    Console.WriteLine($"{song.Genre} is found.");
                }
            }
        }

        public void FindSongsLongerThan(SongModel[] songs, int lenght)
        {
            foreach (SongModel song in songs)
            {
            
                if (song.Length > lenght)
                {
                    Console.WriteLine($"{song.Name} - {song.Band}");
                }
            }
        }

        public void FindSongsShorterThan(SongModel[] songs, int length)
        {
            foreach (SongModel song in songs)
            {
                if (song.Length < length)
                {
                    Console.WriteLine($"{song.Name} - {song.Band}");
                }
            }
        }


        public SongModel[] AddSong(SongModel[] songs, SongModel song)
        {
            Array.Resize(ref songs, songs.Length+1);
            songs[songs.Length-1]= song;
            return songs;
           
        }



    }
}
