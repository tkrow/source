using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Gridview_and_Detailsview_Project
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemUpdated(object sender, DetailsViewUpdatedEventArgs e)
        {
            refreshGridView();
        }

        protected void DetailsView1_ItemDeleted(object sender, DetailsViewDeletedEventArgs e)
        {
            refreshGridView();
        }

        private void refreshGridView()
        {
            GridView1.DataBind();
            GridView1.SelectedIndex = -1;
        }

        // enables the insertion of values from the textboxes
        protected void submitBtn_Click(object sender, EventArgs e)
        {
            // creates a bool variable that is only used to check for duplicate values 
            // in the Competitor name
            bool duplicateCompetitors;          
            
            // Code to implement the first two steps of a
            // SQL connection (I want to scream and cry)
            string connStr = ConfigurationManager.ConnectionStrings["UnitConnection"].ConnectionString;

            SqlConnection dbConnect = new SqlConnection(connStr);

            // resets the text with each button press
            ErrorLabel.Text = " ";

            // assigns a value that will increment with each valid entry in both the WargamingStatsString array
            // and WargamingStatsInt array
            int entryValid = 0;

            // assigns a value that will increment with each valid character entered for the Strings
            int validChar;

            // grabs the input values from the boxes
            // and will simply not cooperate if the 
            // input value is not valid
            string competitor = competitorBox.Text;
            string faction = factionBox.Text;
            string league = leagueBox.Text;
            string country = countryBox.Text;
            string wins = winBox.Text;
            string losses = lossesBox.Text;

            // assigns each predefined string or integer stat to a place in an array
            string[] WargamingStats = { competitor, faction, league, country, wins, losses };

            // assigns each string value label to a place in a string array
            string[] StatLabel = { competitorLbl.Text, factionLbl.Text, leagueLbl.Text,
                countryLbl.Text, winLbl.Text, lossesLbl.Text };           
            
            // first check, for the Competitor's Play Name, does not allow a blank space or any spaces
            // in the name, sending an error if detected
            if(WargamingStats[0].Length == 0)
            {
                ErrorLabel.Text += StatLabel[0] + " is not valid. <br />";           
            }
            else
            {
                validChar = 0;

                foreach (char a in WargamingStats[0])
                {
                    if (a == ' ')
                    {
                        ErrorLabel.Text += StatLabel[0] + " is not valid. <br />";
                        break;
                    }
                    else
                    {
                        validChar++;
                    }
                }

                if(validChar == WargamingStats[0].Length)
                {
                    entryValid++;
                }
            }

            // second check, for player's faction, does not allow numbers to be 
            // in the name, sending an error if one is detected
            if (WargamingStats[1].Length == 0)
            {
                ErrorLabel.Text += StatLabel[1] + " is not valid. <br />";
            }
            else
            {
                validChar = 0;

                foreach (char a in WargamingStats[1])
                {
                    if (System.Char.IsDigit(a))
                    {
                        ErrorLabel.Text += StatLabel[1] + " is not valid. <br />";
                        break;
                    }
                    else
                    {
                        validChar++;
                    }
                }

                if (validChar == WargamingStats[1].Length)
                {
                    entryValid++;
                }
            }

            // third check, for player's entered League, does not allow numbers to be 
            // in the name, sending an error if one is detected
            if (WargamingStats[2].Length == 0)
            {
                ErrorLabel.Text += StatLabel[2] + " is not valid. <br />";
            }
            else
            {
                validChar = 0;

                foreach (char a in WargamingStats[2])
                {
                    if (System.Char.IsDigit(a))
                    {
                        ErrorLabel.Text += StatLabel[2] + " is not valid. <br />";
                        break;
                    }
                    else
                    {
                        validChar++;
                    }
                }

                if (validChar == WargamingStats[2].Length)
                {
                    entryValid++;
                }
            }

            // fourth check, for the Competitor's Home Country, does not allow numbers to be 
            // in the name, sending an error if one is detected
            if (WargamingStats[3].Length == 0)
            {
                ErrorLabel.Text += StatLabel[3] + " is not valid. <br />";
            }
            else
            {
                validChar = 0;

                foreach (char a in WargamingStats[3])
                {
                    if (System.Char.IsDigit(a))
                    {
                        ErrorLabel.Text += StatLabel[3] + " is not valid. <br />";
                        break;
                    }
                    else
                    {
                        validChar++;
                    }
                }

                if (validChar == WargamingStats[3].Length)
                {
                    entryValid++;
                }
            }

            // fifth check, for the number of wins, does not allow letters to be 
            // in the number, sending an error if one is detected
            if (WargamingStats[4].Length == 0)
            {
                ErrorLabel.Text += StatLabel[4] + " is not valid. <br />";
            }
            else
            {
                validChar = 0;

                foreach (char a in WargamingStats[4])
                {
                    if (!System.Char.IsDigit(a))
                    {
                        ErrorLabel.Text += StatLabel[4] + " is not valid. <br />";
                        break;
                    }
                    else
                    {
                        validChar++;
                    }
                }

                if (validChar == WargamingStats[4].Length)
                {
                    entryValid++;
                }
            }

            // sixth check, for the number of losses, does not allow letters to be 
            // in the number, sending an error if one is detected
            if (WargamingStats[5].Length == 0)
            {
                ErrorLabel.Text += StatLabel[5] + " is not valid. <br />";
            }
            else
            {
                validChar = 0;

                foreach (char a in WargamingStats[5])
                {
                    if (!System.Char.IsDigit(a))
                    {
                        ErrorLabel.Text += StatLabel[5] + " is not valid. <br />";
                        break;
                    }
                    else
                    {
                        validChar++;
                    }
                }

                if (validChar == WargamingStats[5].Length)
                {
                    entryValid++;
                }
            }

            // if all entries are valid, begins to make the db connection
            // and makes a SQL Insert Query
            if(entryValid == WargamingStats.Length)
            {
                dbConnect.Open();

                string insert = string.Format("INSERT INTO WargamingStats (Competitor, Faction, " +
                    "League, Country, Wins, Losses)"
                    + " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}');", competitor, faction, league, country, wins, losses);

                string select = string.Format("SELECT Competitor FROM WargamingStats WHERE Competitor = competitor");

                SqlCommand cmd = new SqlCommand(insert, dbConnect);
                SqlCommand cmdChk = new SqlCommand(select, dbConnect);

                cmd.Parameters.AddWithValue("competitor", competitor);
                cmd.Parameters.AddWithValue("faction", faction);
                cmd.Parameters.AddWithValue("league", league);
                cmd.Parameters.AddWithValue("country", country);
                cmd.Parameters.AddWithValue("wins", wins);
                cmd.Parameters.AddWithValue("losses", losses);

                using (SqlDataReader reader = cmdChk.ExecuteReader())
                {
                    duplicateCompetitors = (reader != null && reader.HasRows);
                }

                if(duplicateCompetitors == false)
                {
                    cmd.ExecuteNonQuery();

                    refreshGridView();
                }
                else
                {
                    ErrorLabel.Text += "A Competitor already exists with that name.";
                }

                dbConnect.Close();
            }
        }
    }
}