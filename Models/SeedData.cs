using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "The Good, the Bad and the Ugly",
                    ReleaseDate = DateTime.Parse("1966-12-23"),
                    Genre = "Western",
                    Price = 4.99M
                },
new Movie
{
    Title = "Once Upon a Time in the West",
    ReleaseDate = DateTime.Parse("1968-12-21"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "High Noon",
    ReleaseDate = DateTime.Parse("1952-7-24"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Magnificent Seven",
    ReleaseDate = DateTime.Parse("1960-10-23"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "True Grit",
    ReleaseDate = DateTime.Parse("1969-6-11"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Butch Cassidy and the Sundance Kid",
    ReleaseDate = DateTime.Parse("1969-9-23"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Searchers",
    ReleaseDate = DateTime.Parse("1956-3-13"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Unforgiven",
    ReleaseDate = DateTime.Parse("1992-8-7"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "Django Unchained",
    ReleaseDate = DateTime.Parse("2012-12-25"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "The Wild Bunch",
    ReleaseDate = DateTime.Parse("1969-6-18"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "High Plains Drifter",
    ReleaseDate = DateTime.Parse("1973-8-22"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Shane",
    ReleaseDate = DateTime.Parse("1953-8-23"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Stagecoach",
    ReleaseDate = DateTime.Parse("1939-3-2"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Outlaw Josey Wales",
    ReleaseDate = DateTime.Parse("1976-6-30"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "A Fistful of Dollars",
    ReleaseDate = DateTime.Parse("1964-1-18"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "For a Few Dollars More",
    ReleaseDate = DateTime.Parse("1965-5-10"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Hang 'Em High",
    ReleaseDate = DateTime.Parse("1968-7-31"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "My Darling Clementine",
    ReleaseDate = DateTime.Parse("1946-12-3"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Cowboys",
    ReleaseDate = DateTime.Parse("1972-1-13"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Shootist",
    ReleaseDate = DateTime.Parse("1976-8-20"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Man Who Shot Liberty Valance",
    ReleaseDate = DateTime.Parse("1962-4-22"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Rio Grande",
    ReleaseDate = DateTime.Parse("1950-11-15"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "3:10 to Yuma",
    ReleaseDate = DateTime.Parse("1957-8-7"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Jeremiah Johnson",
    ReleaseDate = DateTime.Parse("1972-5-21"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Winchester '73",
    ReleaseDate = DateTime.Parse("1950-7-12"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Ox-Bow Incident",
    ReleaseDate = DateTime.Parse("1943-5-21"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Sons of Katie Elder",
    ReleaseDate = DateTime.Parse("1965-10-1"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Big Country",
    ReleaseDate = DateTime.Parse("1958-10-1"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "The Revenant",
    ReleaseDate = DateTime.Parse("2015-12-25"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "Tombstone",
    ReleaseDate = DateTime.Parse("1993-12-25"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "Silverado",
    ReleaseDate = DateTime.Parse("1985-7-10"),
    Genre = "Western",
    Price = 3.99M
},
new Movie
{
    Title = "Open Range",
    ReleaseDate = DateTime.Parse("2003-8-15"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "The Hateful Eight",
    ReleaseDate = DateTime.Parse("2015-12-25"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "True Grit",
    ReleaseDate = DateTime.Parse("2010-12-22"),
    Genre = "Western",
    Price = 4.99M
},
new Movie
{
    Title = "The Assassination of Jesse James by the Coward Robert Ford",
    ReleaseDate = DateTime.Parse("2007-11-30"),
    Genre = "Western",
    Price = 4.99M
}

            );
            context.SaveChanges();
        }
    }
}