using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OkButton_Click(object sender, EventArgs e)
        {
          
            if (PencilRadioButton.Checked)
            {
                ResultLabel.Text = "You selected Pencil";
                ResultImage.ImageUrl = "pencil.png";
            }
            else if (PenRadioButton.Checked)
            {
                ResultLabel.Text = "You selected Pen";
                ResultImage.ImageUrl = "pen.png";
            }
            else if (PhoneRadioButton.Checked)
            {
                ResultLabel.Text = "You selected Phone";
                ResultImage.ImageUrl = "phone.png";
            }
            else if (TabletRadioButton.Checked)
            {
                ResultLabel.Text = "You selected Tablet";
                ResultImage.ImageUrl = "tablet.png";
            }
            else
            {
                ResultLabel.Text = "Please Select an Option";
                ResultImage.ImageUrl = "";
            }
        }
    }
}