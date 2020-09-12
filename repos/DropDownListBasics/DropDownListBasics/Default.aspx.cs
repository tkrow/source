using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownListBasics
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1. single add
            DropDownList1.Items.Add(new ListItem("TV", "1"));

            // 2a. Create ListItemCollection, then add items
            ListItemCollection itemsListItemCollection = new ListItemCollection();

            // 2b. Add each individual time:
            itemsListItemCollection.Add(new ListItem("Radio", "2"));
            itemsListItemCollection.Add(new ListItem("Word of Mouth", "3"));

            // 2c. Add all of the items to the DropDown:
            ListItem[] listItemArray = itemsListItemCollection.Cast<ListItem>().ToArray();

            // We need to change our ListItemCollection to ListItem[] to add
            // DropDownList1.Items.AddRange(itemsListItemCollection);   // no
            DropDownList1.Items.AddRange(listItemArray);

            // 3. Loop through and add
            foreach (ListItem listItem in itemsListItemCollection)
            {

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 0)
            {
                lblOutput.Text = "Please select an item.";
            }
            else
            {
                lblOutput.Text = "Index is: " + DropDownList1.SelectedItem;
            }
        }
    }
}