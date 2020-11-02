using FinalProjectWorkspace.DAL;
using FinalProjectWorkspace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;


namespace FinalProjectWorkspace.Seeding
{
    public static class SeedMovieSchedule
    {
		public static void SeedShowings(AppDbContext db)
		{
		//Create a new list for all of the Movie Schedules
		List<Showing> Showings = new List<Showing>();
		Showings.Add(new Showing
		{
			StartTime = 9:05,
			EndTime = 10:52,
			Movie = "Footloose",
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = 11:30,
			EndTime = 13:24,
			Movie = "WarGames",
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = 14:00,
			EndTime = 15:29,
			Movie = "Office Space",
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = 15:55,
			EndTime = 17:55,
			Movie = "Diamonds are Forever",
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = 18:40,
			EndTime = 21:12,
			Movie = "West Side Story",
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = 21:37,
			EndTime = 23:59,
			Movie = "Forrest Gump",
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = 9:00,
			EndTime = 10:21,
			Movie = "Toy Story",
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = 10:50,
			EndTime = 12:32,
			Movie = "Dazed and Confused",
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = 13:00,
			EndTime = 14:40,
			Movie = "The Lego Movie",
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = 15:20,
			EndTime = 16:58,
			Movie = "The Princess Bride",
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = 17:25,
			EndTime = 19:05,
			Movie = "Finding Nemo",
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = 19:30,
			EndTime = 22:11,
			Movie = "Harry Potter and the Chamber of Secrets",
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = 22:40,
			EndTime = 23:49,
			Movie = "The Land Before Time",
			Theatre = "2",
		});

		//create some counters to help debug problems
		Int32 intMovieSchedule = 0;
		String strMovieSchedule = "Start";

			//loop through the list to add or update the Movie Schedule
			try
		{
			foreach (Showing seedShowing in Showings)
			{
                    //update the counters
                    intMovieSchedule = Showings.Movie;
                    //see if the movie is already in the database using the IMDBID
                    Showing dbMovieSchedule = db.Showings.FirstOrDefault(f => f.Movie == Showings.Movie);

					//if Movie Schedule is null, MovieSchedule is not in database
					if (dbMovieSchedule == null)
					{
						//Add the MovieSchedule to the database
						db.Showings.Add(seedMovieSchedule);
						db.SaveChanges();
					}
					else //the MovieSchedule is in the database - reset all fields except ID and IMDBID
					{
						dbMovieSchedule.StartTime = Showings.StartTime;
						dbMovieSchedule.EndTime = Showings.EndTime;
						dbMovieSchedule.Movie = Showings.Movie;
						dbMovieSchedule.Theatre = Showings.Theatre;
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the MovieSchedule with the Movie: ");
				msg.Append(strMovieSchedule);
				msg.Append(" (ID: ");
				msg.Append(intMovieSchedule);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
