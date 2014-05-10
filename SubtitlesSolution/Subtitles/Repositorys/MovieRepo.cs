﻿using Subtitles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Subtitles.Repositorys
{
	public class MovieRepo
	{
		AppDataContext context = new AppDataContext();
        public IEnumerable<Movie> GetAllNews()
        {
            var values = from s in context.Movies
                         orderby s.dateTime descending
                         select s;

            return values;
        }

		public void AddMovie(Movie m)
		{
			context.Movies.Add(m);
		}
	}
}