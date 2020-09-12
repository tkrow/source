using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace RegexAssignmentTimtohy
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // All parts of the assignment are done in order going down
            // the list on CourseWeb



            // Regex test to check the validity
            // of an input date formatted 11-2-2016

            // Can be layed out as any combo of "m(1-2)-d(1-2)-y(1-4)" in order to be read as true
            string date = "1-31-2019";

            // he he, have fun reading this next line                       
            Regex goodDateString = new Regex("(^[1-9]{1}-[1-9]{1}-[1-9]{1}$)|(^[10-12]{2}-[1-9]{1}-[1-9]{1}$)|(^[1-9]{1}-[10-31]{2}-[1-9]{1}$)|(^[10-12]{2}-[10-31]{2}-[1-9]{1}$)" +
                                             "(^[1-9]{1}-[1-9]{1}-[10-99]{2}$)|(^[10-12]{2}-[1-9]{1}-[10-99]{2}$)|(^[1-9]{1}-[10-31]{2}-[10-99]{2}$)|(^[10-12]{2}-[10-31]{2}-[10-99]{2}$)" +
                                             "(^[1-9]{1}-[1-9]{1}-[100-999]{3}$)|(^[10-12]{2}-[1-9]{1}-[100-999]{3}$)|(^[1-9]{1}-[10-31]{2}-[100-999]{3}$)|(^[10-12]{2}-[10-31]{2}-[100-999]{3}$)" +
                                             "(^[1-9]{1}-[1-9]{1}-[1000-9999]{4}$)|(^[10-12]{2}-[1-9]{1}-[1000-9999]{4}$)|(^[1-9]{1}-[10-31]{2}-[1000-9999]{4}$)|(^[10-12]{2}-[10-31]{2}-[1000-9999]{4}$)");

            Response.Write("goodDateString.IsMatch(date): " + goodDateString.IsMatch(date));


            //--------------------------------------------------------------------------------------


            // Regex test to check the validity
            // of an input American Express card

            // Randomly pressed a set of numbers according
            // to the specifications of the card type

            // must either start with 34 or 37
            // and be a total of 15 digits long
            // ex. "34xx-xxxxxx-xxxxx"
            string amerExpress = "3466-593756-48566";

            Regex goodAmerExpress = new Regex("^[34|37]{2}([0-9]{2}-[0-9]{6}-[0-9]{5}$)");

            Response.Write("<br />goodAmerExpress.IsMatch(amerExpress): " + goodAmerExpress.IsMatch(amerExpress));


            //--------------------------------------------------------------------------------------


            // Regex test to check the validity
            // of an input Diners Club card

            // Randomly pressed a set of numbers according
            // to the specifications of the card type

            // must start with 36, 38, or be between 300 and 305
            // and be a total of 14 digits long
            // ex. "36xx-xxxxxx-xxxx" or "300x-xxxxxx-xxxx"
            string dinerClub = "3018-485763-9387";

            Regex goodDinerClub = new Regex("(^[36|38]{2}([0-9]{2}-[0-9]{6}-[0-9]{4}$))|(^[300-305]{3}([0-9]{1}-[0-9]{6}-[0-9]{4}$))");

            Response.Write("<br />goodDinerClub.IsMatch(dinerClub): " + goodDinerClub.IsMatch(dinerClub));


            //--------------------------------------------------------------------------------------


            // Regex test to check the validity
            // of an input Discover card

            // Randomly pressed a set of numbers according
            // to the specifications of the card type

            // must either start with 6011 or 65 and be a total of 
            // 16 digits long
            // ex. "6011-xxxx-xxxx-xxxx" or "65xx-xxxx-xxxx-xxxx"
            string discoverCard = "6011-5943-5803-8543";

            Regex goodDiscoverCard = new Regex("(^[65]{2}([0-9]{2}-[0-9]{4}-[0-9]{4}-[0-9]{4}$))|(^[6011]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}$)");

            Response.Write("<br />goodDiscoverCard.IsMatch(discoverCard): " + goodDiscoverCard.IsMatch(discoverCard));


            //--------------------------------------------------------------------------------------


            // Regex test to check the validity
            // of an input JCB card

            // Randomly pressed a set of numbers according
            // to the specifications of the card type

            // first style starts with either 2132 or 1800 and is a total
            // of 15 digits long or starts with 35 and is a total of 16
            // digits long
            // ex. "2131-xxxxxx-xxxxx" or "35xx-xxxx-xxxx-xxxx"
            string jcbCard = "3531-5013-8493-9785";

            Regex goodJcbCard = new Regex("(^[2131|1800]{4}-[0-9]{6}-[0-9]{5}$)|(^[35]{2}([0-9]{2}-[0-9]{4}-[0-9]{4}-[0-9]{4}$))");

            Response.Write("<br />goodJcbCard.IsMatch(jcbCard): " + goodJcbCard.IsMatch(jcbCard));


            //--------------------------------------------------------------------------------------


            // Regex test to check the validity
            // of an input Mastercard card

            // Randomly pressed a set of numbers according
            // to the specifications of the card type

            // starts with 51 to 55 and is a total of 16 digits long
            // ex. "53xx-xxxx-xxxx-xxxx"
            string mastercard = "5476-5580-4213-8543";

            Regex goodMastercard = new Regex("(^[51-55]{2}([0-9]{2}-[0-9]{4}-[0-9]{4}-[0-9]{4}$))");

            Response.Write("<br />goodMastercard.IsMatch(mastercard): " + goodMastercard.IsMatch(mastercard));


            //--------------------------------------------------------------------------------------


            // Regex test to check the validity
            // of an input Visa card

            // Randomly pressed a set of numbers according
            // to the specifications of the card type

            // starts with a 4 and is a total of 16 digits long with
            // older cards being a total of 13 digits long
            // ex. "4xxx-xxxx-xxxx-xxxx" or "4xxx-xxx-xxx-xxx"
            string visaCard = "4476-580-413-543";

            Regex goodVisaCard= new Regex("(^[4]{1}([0-9]{3}-[0-9]{4}-[0-9]{4}-[0-9]{4}$))|(^[4]{1}([0-9]{3}-[0-9]{3}-[0-9]{3}-[0-9]{3}$))");

            Response.Write("<br />goodVisaCard.IsMatch(visaCard): " + goodVisaCard.IsMatch(visaCard));
        }
    }
}