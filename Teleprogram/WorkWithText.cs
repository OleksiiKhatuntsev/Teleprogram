using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

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
                else if(counter == 3)
                {
                    if (text == 'T')
                        teleprogram.isSaved = true;
                    if (text == 'F')
                        teleprogram.isSaved = false;
                }
            }

            return teleprograms;
        }

        public static void SaveNewProgram(ICollection<TeleprogramModel> models)
        {
            FileManager.DeleteFile();
            using (StreamWriter writer = new StreamWriter(@"C:\Temp\TeleprogramsDb.txt"))
            {
                string data = "";
                foreach (var teleprogramModel in models)
                {
                    data += teleprogramModel.ToString();
                }
                writer.WriteLine(data);
            }
        }

        public static void AddFakeDb()
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Temp\TeleprogramsDb.txt"))
            {
                TeleprogramModel model0 = new TeleprogramModel { Name = "GoT", Genre = "Film", Date = "13/5/2019", isSaved = false};
                TeleprogramModel model1 = new TeleprogramModel { Name = "Dota", Genre = "Stream", Date = "14/5/2019", isSaved = false};
                TeleprogramModel model2 = new TeleprogramModel { Name = "Avengers", Genre = "Film", Date = "15/5/2019", isSaved = false};
                TeleprogramModel model3 = new TeleprogramModel { Name = "Квартал 95", Genre = "Show", Date = "15/6/2019", isSaved = false };
                writer.Write(model0.ToString() + model1.ToString() + model2.ToString() + model3.ToString());
            }
        }
    }
}
