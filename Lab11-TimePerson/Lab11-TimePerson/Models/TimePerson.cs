using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_TimePerson.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }


        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {
            // create a list of Time persons (instantiate a new list)
            List<TimePerson> mylist = new List<TimePerson>();

            // get the path of your timeperson.csv file
            // getting the path is not as simple as ../../../ have to use 
            // the Path or Environment class
            // once you get the file path, 
            // read all the lines and save it into an array of strings

            string stuff = "./wwwroot/personOfTheYear.csv";


            /*  string[] stuffSplit = stuff[0].Split(',');*/

            using (TextFieldParser csvParse = new TextFieldParser(stuff)) {
                csvParse.CommentTokens = new string[] { "#" };
                csvParse.SetDelimiters(new string [] { ","});
                csvParse.HasFieldsEnclosedInQuotes = true;

                csvParse.ReadLine();

                while (!csvParse.EndOfData)
                {
                    string[] things = csvParse.ReadFields();
                    string year = things[0];
                    string honor = things[1];
                    string name = things[2];
                    string country = things[3];
                    string birthyear = things[4];
                    string deathyear = things[5];
                    string title = things[6];
                    string category = things[7];
                    string context = things[8];

                }
            }

            // traverse through the strings for each line item
            // remember CSV is delimited by commas. 
           /* TimePerson thing = new TimePerson()
            {
                Year = year,
                Honor = honor,
                Name = name,
                Country = country,
                BirthYear = birthyear,
                DeathYear = deathyear,
                Title = title,
                Category = category,
                Context = context;
            }*/
            // use LINQ to filter out with the years that you brought in against your list of persons

            //return your list of persons

            return null;
        }
    }
}
