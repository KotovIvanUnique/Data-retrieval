using System;
using System.Text.RegularExpressions;

namespace DR_Lab1
{
    public class Movie
    {
        public Int32? Id { get; set; }
        public Int32? Year { get; set; }
        public String Name { get; set; }

        public static Movie FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            var yearFinder = new Regex(@".+\((\d{4})\)");
            var match = yearFinder.Match(values[1]);
            var valuesYear = 9999;

            if (match.Success)
            {
                valuesYear = int.Parse(match.Groups[1].Value);
            }

            Movie movieValues = new Movie();
            movieValues.Id = Convert.ToInt32(values[0]);
            movieValues.Year = Convert.ToInt32(valuesYear);
            movieValues.Name = Convert.ToString(values[1]);
            return movieValues;
        }

    }
}
