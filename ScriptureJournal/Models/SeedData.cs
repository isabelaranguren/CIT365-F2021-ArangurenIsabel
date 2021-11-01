using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScriptureJournal.Data;
using System;
using System.Linq;

namespace ScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                   new Scripture
                   {
                       Title = "How to love Him",
                       DateAdded = DateTime.Parse("2021-10-29"),
                       Book = "John",
                       Chapter = 14,
                       Verse = "15",
                       Notes = "It seems easy, but when we do not obey, is it like we completely do not love him?"
                   },

                   new Scripture 
                   
                   {
                       Title = "Sinning Vs. Transgressing",
                       DateAdded = DateTime.Parse("2021-10-28"),
                       Book = "1 Samuel",
                       Chapter = 16,
                       Verse = "7",
                       Notes = "I feel like it is talking about our intentions in our actions. But how much does that excuse us when we make a wrong choice"
                   },

                   new Scripture
                   {
                       Title = "Forgiveness is Achievable",
                       DateAdded = DateTime.Parse("2021-10-27"),
                       Book = "Doctrine and Covenants",
                       Chapter = 58,
                       Verse = "42-43",
                       Notes = "It is good to know if we repent we will be forgiven. Combine that with how often we will be forgiven it seems reassuring"
                   }
               
                );
                context.SaveChanges();
            }
        }
    }
}