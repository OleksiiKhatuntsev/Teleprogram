using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading;

namespace Teleprogram
{
    public class WorkWithText
    {
        public static ICollection<TeleprogramModel> GetAllTeleprograms()
        {
            string textFromFile = "";
            using (StreamReader reader = new StreamReader(@"C:\Temp\TeleprogramsDb.txt"))
            {
                textFromFile = reader.ReadToEnd();
            }
            var teleprograms = new List<TeleprogramModel>();
            var teleprogram = new TeleprogramModel();
            var counter = 0;
            foreach (var text in textFromFile)
            {
                if (text == '*')
                {
                    teleprograms.Add(teleprogram);
                    counter = 0;
                    teleprogram = new TeleprogramModel();
                }
                else if (text == '.')
                {
                    counter++;
                }
                else if (counter == 0)
                {
                    teleprogram.Name += text;
                }
                else if (counter == 1)
                {
                    teleprogram.Genre += text;
                }
                else if(counter == 2)
                {
                    teleprogram.Date += text;
                }
                else if (counter == 3)
                {
                    teleprogram.Channel += text;
                }
                else if(counter == 4)
                {
                    if (text == 'T')
                        teleprogram.isSaved = true;
                    if (text == 'F')
                        teleprogram.isSaved = false;
                }
            }

            return teleprograms;
        }

        public static void SaveProgram(ICollection<TeleprogramModel> models, string path = @"C:\Temp\TeleprogramsDb.txt")
        {
            FileManager.DeleteFile(path);
            using (StreamWriter writer = new StreamWriter(path))
            {
                string data = "";
                foreach (var teleprogramModel in models)
                {
                    data += teleprogramModel.ToString();
                }
                writer.WriteLine(data);
            }
        }

        public static string ConvertDateToString(DateTime date)
        {
            var s = date.ToString("dd/MM/yyyy");
            string result = "";
            foreach (var symbol in s)
            {
                if (symbol == ' ')
                {
                    break;
                }

                result += symbol;
            }

            return result;
        }

        public static DateTime GetDateFromString(string stringDate)
        {
            string day = "";
            string month = "";
            string year = "";
            int counter = 0;
            foreach (var symbol in stringDate)
            {
                if (symbol == '/')
                {
                    counter++;
                    continue;
                }

                if (counter == 0)
                {
                    day += symbol;
                }
                else if (counter == 1)
                {
                    month += symbol;
                }
                else if (counter == 2)
                {
                    year += symbol;
                }
            }
            DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
            return date;
        }

        public static void AddFakeDb()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Temp\TeleprogramsDb.txt"))
            {
                TeleprogramModel model0 = new TeleprogramModel { Name = "GoT", Genre = "Film", Date = "13/5/2019", Channel = "Inter", isSaved = false};
                TeleprogramModel model1 = new TeleprogramModel { Name = "Dota", Genre = "Stream", Date = "14/5/2019", Channel = "First Channel", isSaved = false};
                TeleprogramModel model2 = new TeleprogramModel { Name = "Avengers", Genre = "Film", Date = "15/5/2019", Channel = "Fifth Channel", isSaved = false};
                TeleprogramModel model3 = new TeleprogramModel { Name = "Квартал 95", Genre = "Show", Date = "15/6/2019", Channel = "YouTube", isSaved = false };
                writer.Write(model0.ToString() + model1.ToString() + model2.ToString() + model3.ToString());
            }
        }
    }
}
