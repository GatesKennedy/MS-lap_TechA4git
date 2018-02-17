using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(InputOne.Text);
            double numTwo = double.Parse(InputTwo.Text);

            double result = numOne + numTwo;

            ResultLabel.Text = result.ToString();
        }

        protected void SubtractButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(InputOne.Text);
            double numTwo = double.Parse(InputTwo.Text);

            double result = numOne - numTwo;

            ResultLabel.Text = result.ToString();

        }

        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(InputOne.Text);
            double numTwo = double.Parse(InputTwo.Text);

            double result = numOne * numTwo;

            ResultLabel.Text = result.ToString();
        }

        protected void DivideButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(InputOne.Text);
            double numTwo = double.Parse(InputTwo.Text);

            double result = numOne / numTwo;

            ResultLabel.Text = result.ToString();
        }
    }
}