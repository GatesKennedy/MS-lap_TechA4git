using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!Page.IsPostBack)
            {
                OldEndCalendar.SelectedDate = DateTime.Now.Date;

                NewStartCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                NewStartCalendar.VisibleDate = DateTime.Now.Date.AddDays(14);

                NewEndCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
                NewEndCalendar.VisibleDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void ResultButton_Click(object sender, EventArgs e)
        {
            DateTime dateOldEnd = OldEndCalendar.SelectedDate;
            DateTime dateNewStart = NewStartCalendar.SelectedDate;
            DateTime dateNewEnd = NewEndCalendar.SelectedDate;

            // Compare Start/End Dates
            int compareVacay = DateTime.Compare(dateOldEnd, dateNewStart);
            int compareWork = DateTime.Compare(dateNewStart, dateNewEnd);

            if (compareVacay<0)
            {
                //::::dateOldEnd is BEFORE dateNewStart::::\\

                // convert spans to day values
                TimeSpan spanVacay = dateNewStart.Subtract(dateOldEnd);
                int daysVacay = spanVacay.Days;
                TimeSpan spanWork = dateNewEnd.Subtract(dateNewStart);
                int daysWork = spanWork.Days;

                // Check Bonus Interval
                int bonusCheck = (daysWork > 21) ? 1000 : 0;

                // Check Vacation and Work Intervals
                bool checkVacay = (daysVacay > 13) ? true : false;
                bool checkWork = (daysWork <= 0) ? false : true;

                if (checkVacay==true && checkWork==true)
                {
                    // Vacation and Work Intervals are VALID
                    string spyNameInput = SpyNameTextBox.Text;
                    string assignNameInput = AssignNameTextBox.Text;
                    int costAssignment = daysWork*500+bonusCheck;
                    ResultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized.<br />"
                        + "Budget total: {2:C}", spyNameInput, assignNameInput, costAssignment);
                }
                else if (checkVacay==false && checkWork==true)
                {
                    // Vacation Interval is INVALID
                    ResultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment...<br />"
                        + "Please adjust the assignment dates to meet this requirement.";
                }
                else if (checkVacay==true && checkWork==false)
                {
                    // Work Interval is INVALID
                    ResultLabel.Text = "Error: The start and end dates of the assignment to not represent a positive interval of time...<br />"
                        + "Please adjust these dates to represent at least one day of work.";
                }
                else
                {
                    // Vacation Interval and Work Interval are BOTH INVALID
                    ResultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment...<br />"
                        + "Please adjust the assignment dates to meet this requirement.<br /><br />"
                        + "Error: The start and end dates of the assignment to not represent a positive interval of time...<br />"
                        + "Please adjust these dates to represent at least one day of work.";
                }
            }
            else if (compareVacay>0)
            {
                //::::dateOldEnd is AFTER dateNewStart::::\\

                TimeSpan spanVacay = dateOldEnd.Subtract(dateNewStart);
                int daysVacay = spanVacay.Days;
                ResultLabel.Text = String.Format("The Assignment Start Date precedes the agent's availability by {0} days...<br />"
                    + "Please choose a later start date for this assignment.", daysVacay);
            }
            else
            {
                //::::dateOldEnd is SAME as dateNewStart::::\\

                ResultLabel.Text = "The assignment start date is on the same day the agents old assignment ends...<br />"
                    + "Agents require a minimum two weeks off between assignments. Please choose different dates.";
            }
        }
    }
}