using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstDab.Model
{
    public static class DataService
    {
        public static IList<Article> GetArticles()
        {
            return new List<Article>()
            {
                new Article()
                {
                    Title = "Harry Potter And The Last Dab",
                    Author = "Sqøren",
                    URL = "FakeURL"
                },
                new Article()
                {
                    Title = "Harry Potter And The Last Fap",
                    Author = "Sqøren",
                    URL = "FakeURL"
                },
                new Article()
                {
                    Title = "Tanja Grotter And The Last Cap",
                    Author = "Sqøren",
                    URL = "FakeURL"
                },
                new Article()
                {
                    Title = "I Am Lorde",
                    Author = "Sqøren",
                    URL = "https://soundcloud.com/hans-jessen/soren-er-lorde-remix"
                }

            };
        }
    }
}
