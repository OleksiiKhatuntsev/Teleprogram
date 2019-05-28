using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teleprogram
{
    public class DatabaseHelper
    {
        public ICollection<TeleprogramModel> GetProgramsForMonth(ICollection<TeleprogramModel> models)
        {
            ICollection<TeleprogramModel> monthPrograms = new List<TeleprogramModel>();
            foreach (var model in models)
            {
                var thisMonth = "";
                var counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (model.Date[i] == '/' && counter != 0)
                    {
                        break;
                    }
                    else if (model.Date[i] == '/' && counter == 0)
                    {
                        counter++;
                    }
                    else if (model.Date[i] != '/' && counter != 0)
                    {
                        thisMonth += model.Date[i];
                    }
                }

                if (thisMonth == DateTime.Today.Month.ToString())
                {
                    monthPrograms.Add(model);
                }
            }

            return monthPrograms;
        }

        public ICollection<TeleprogramModel> GetProgramsForDay(ICollection<TeleprogramModel> models)
        {
            ICollection<TeleprogramModel> todayPrograms = new List<TeleprogramModel>();
            foreach (var model in models)
            {
                var thisDay = "";
                for (int i = 0; i < 10; i++)
                {
                    if (model.Date[i] == '/')
                    {
                        break;
                    }

                    thisDay += model.Date[i];
                }

                if (thisDay == DateTime.Today.Day.ToString())
                {
                    todayPrograms.Add(model);
                }
            }

            return todayPrograms;
        }

        public void DeleteProgram(ICollection<TeleprogramModel> models)
        {
            var nonExpiredPrograms = new List<TeleprogramModel>();
            foreach (var teleprogramModel in models)
            {
                if (WorkWithText.GetDateFromString(teleprogramModel.Date) >= DateTime.Today)
                {
                    nonExpiredPrograms.Add(teleprogramModel);
                }
            }
            WorkWithText.SaveProgram(nonExpiredPrograms);
        }
    }
}
