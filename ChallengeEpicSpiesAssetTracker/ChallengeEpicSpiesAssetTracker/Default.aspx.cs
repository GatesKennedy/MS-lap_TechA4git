using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        // Epic Spies Logo
            // 150px tall

        // Input
            // Name of spy (each asset)
            // # of Elections Rigged
            // # of Acts of Subterfuge 

        // Output
            // Total Elections Rigged by all Assets
                // sum All entries
            // Average Acts of Subterfuge per Asset
                // 2 significant digits
                // Asset Names
                    // Find unique Names
                    // if Statements
            // Name of Last Asset added
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetLog = new string[0];
                int[] electionLog = new int[0];
                int[] subterfugeLog = new int[0];

                ViewState.Add("AssetLog", assetLog);
                ViewState.Add("ElectionLog", electionLog);
                ViewState.Add("SubterfugeLog", subterfugeLog);
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string[] assetLog = (string[])ViewState["AssetLog"];
            int[] electionLog = (int[])ViewState["ElectionLog"];
            int[] subterfugeLog = (int[])ViewState["SubterfugeLog"];

            string assetAddition = AssetTextBox.Text;
            int electionAddition = int.Parse(ElectionsTextBox.Text);
            int subterfugeAddition = int.Parse(SubterfugeTextBox.Text);

            // Search for input Asset in AssetLog[]
            int i = 0;
            int foundIndex = 0;
            bool assetCheck = false;
            // Search Loop
            while (i < assetLog.Length)
            {
                if (assetAddition == assetLog[i])
                {
                    assetCheck = true;
                    foundIndex = i;
                    break;
                }
                else i += 1;
            }

            // Update Logs
            if (assetCheck == true)
            {
                // add Input values to Log values of indices equal to the matched Asset (foundIndex)
                electionLog[foundIndex] += electionAddition;
                subterfugeLog[foundIndex] += subterfugeAddition;

                // Update ViewState
                ViewState["ElectionLog"] = electionLog;
                ViewState["SubterfugeLog"] = subterfugeLog;
            }
            else
            {
                // Add empty elements to logs for new asset record
                Array.Resize(ref assetLog, assetLog.Length + 1);
                Array.Resize(ref electionLog, electionLog.Length + 1);
                Array.Resize(ref subterfugeLog, subterfugeLog.Length + 1);

                // retrieve new asset's index value
                int newRecordIndex = assetLog.GetUpperBound(0);

                // Assign new values for new asset record
                assetLog[newRecordIndex] = AssetTextBox.Text;
                electionLog[newRecordIndex] = int.Parse(ElectionsTextBox.Text);
                subterfugeLog[newRecordIndex] = int.Parse(SubterfugeTextBox.Text);

                // Update ViewState
                ViewState["AssetLog"] = assetLog;
                ViewState["ElectionLog"] = electionLog;
                ViewState["SubterfugeLog"] = subterfugeLog;
            }

            // Return Values to User
            int totalElections = electionLog.Sum();
            int totalSubterfuge = subterfugeLog.Sum();
            int totalAssets = assetLog.Length;
            double avgSubterfuge = (double)totalSubterfuge / (double)totalAssets;

            ResultLabel.Text =
                String.Format("Total Elections Rigged: {0}<br/>" +
                "Average Acts of Subterfuge per Asset: {1}<br/>" +
                "Last Asset updated: {2}",
                totalElections.ToString(), avgSubterfuge.ToString("N2"), assetAddition);

        }
    }
}