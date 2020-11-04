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
			StartTime = new TimeSpan(9,05,0),
			EndTime = new TimeSpan(10,52,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Footloose"),
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(11,30,0),
			EndTime = new TimeSpan(13,24,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "WarGames"),
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(14,00,0),
			EndTime = new TimeSpan(15,29,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Office Space"),
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(15,55,0),
			EndTime = new TimeSpan(17,55,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Diamonds are Forever"),
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(18,40,0),
			EndTime = new TimeSpan(21,12,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "West Side Story"),
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(21,37,0),
			EndTime = new TimeSpan(23,59,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Forrest Gump"),
			Theatre = "1",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(09,00,0),
			EndTime = new TimeSpan(10,21,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Toy Story"),
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(10,50,0),
			EndTime = new TimeSpan(12,32,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Dazed and Confused"),
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(13,00,0),
			EndTime = new TimeSpan(14,40,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "The Lego Movie"),
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(15,20,0),
			EndTime = new TimeSpan(16,58,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "The Princess Bride"),
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(17,25,0),
			EndTime = new TimeSpan(19,05,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Finding Nemo"),
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(19,30,0),
			EndTime = new TimeSpan(22,11,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "Harry Potter and the Chamber of Secrets"),
			Theatre = "2",
		});
		Showings.Add(new Showing
		{
			StartTime = new TimeSpan(22,40,0),
			EndTime = new TimeSpan(23,49,0),
			Movie = db.Movies.FirstOrDefault(c => c.Title == "The Land Before Time"),
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
					intMovieSchedule = seedShowing.ShowingID;
					//see if the movie is already in the database using the IMDBID
					Showing dbMovieSchedule = db.Showings.FirstOrDefault(f => f.Movie == seedShowing.Movie);

					//if Movie Schedule is null, MovieSchedule is not in database
					if (dbMovieSchedule == null)
					{
						//Add the MovieSchedule to the database
						db.Showings.Add(seedShowing);
						db.SaveChanges();
					}
					else //the MovieSchedule is in the database - reset all fields except ID and IMDBID
					{
						dbMovieSchedule.StartTime = seedShowing.StartTime;
						dbMovieSchedule.EndTime = seedShowing.EndTime;
						dbMovieSchedule.Movie = seedShowing.Movie;
						dbMovieSchedule.Theatre = seedShowing.Theatre;
					}
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
