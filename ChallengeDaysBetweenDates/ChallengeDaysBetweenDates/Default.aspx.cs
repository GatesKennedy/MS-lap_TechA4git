using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void ResultButton_Click(object sender, EventArgs e)
        {
            DateTime timeOne = Calendar1.SelectedDate;
            DateTime timeTwo = Calendar2.SelectedDate;

            int compareValue = DateTime.Compare(timeOne, timeTwo);

            if (compareValue<0)
            {
                //  Calendar1 BEFORE Calendar2
                TimeSpan elapsedTime = timeTwo.Subtract(timeOne);
                ResultLabel.Text = "The elapsed time is "+ elapsedTime.TotalDays.ToString() +" days.";


            }
            else if (compareValue>0)
            {
                // Calendar1 is AFTER Calendar2
                TimeSpan elapsedTime = timeOne.Subtract(timeTwo);
                ResultLabel.Text = "The elapsed time is "+ elapsedTime.TotalDays.ToString() +" days.";
           

            }
            else
            {
                // Calendar1 is SAME as Calendar2
                ResultLabel.Text = "The chosen dates are the same.";
            }
        }
    }
}