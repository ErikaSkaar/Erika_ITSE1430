﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSE1430.MovieLib
{
    public class MovieDatabase
    {
        public MovieDatabase() : this(true)
        {
        }

        private static Movie[] GetSeedMovies( bool seed )
        {
            if (!seed)
                return new Movie[0];

         return new [] {
          new Movie()
            {
                Name = "Jaws",
                RunLength = 120,
                ReleaseYear = 1977
            },
           new Movie()
            {
                Name = "What About Bob?",
                RunLength = 96,
                ReleaseYear = 2004,
            },
          };
        }
        public MovieDatabase( bool seed ) : this(GetSeedMovies(seed))
        {
            //if (seed)
            //{
            //    var movie = new Movie();
            //    movie.Name = "Jaws";
            //    movie.RunLength = 120;
            //    movie.ReleaseYear = 1977;
            //    Add(movie);

            //    movie = new Movie();
            //    movie.Name = "What About Bob?";
            //    movie.RunLength = 96;
            //    movie.ReleaseYear = 2004;
            //    Add(movie);
            //};
        }

        public MovieDatabase( Movie[] movies )
        {
            _items.AddRange(movies);
            //for (var index = 0; index < movies.Length; ++index)
            //    _items[index] = movies[index];
        }
        public void Add( Movie movie )
        {
            _items.Add(movie);
            //var index = FindNextFreeindex();
            //if (index >= 0)
            //    _movies[index] = movie;
        }

        //private Movie[] _movies = new Movie[100];
        private List<Movie> _items = new List<Movie>();

        public Movie[] GetAll()
        {
            //How many movies do we have
            var count = _items.Count;

            var temp = new Movie[count];
            var index = 0;
            foreach (var movie in _items)
            {
                temp[index++] = movie;
            };
            return temp;
        }

        public void Edit( string name, Movie movie )
        {
            //Find movie by name
            Remove(name);

            //Replace it
            Add(movie);
        }

        public void Remove( string name )
        {
            var movie = FindMovie(name);
            if (movie != null)
                _items.Remove(movie);
        }

        private Movie FindMovie( string name )
        {
            //for (var index = 0; index < _movies.Length; ++index)
            foreach (var movie in _items)
            {
                // if (String.Compare(name, _movies[index]?.Name, true) == 0)
                if (String.Compare(name, movie.Name, true) == 0)
                    return movie;
            };
            return null;
        }
    }
}