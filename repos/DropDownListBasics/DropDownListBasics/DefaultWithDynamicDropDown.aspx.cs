using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropDownListBasics
{
    public partial class DefaultWithDynamicDropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DropDownList DropDownList1 = new DropDownList();

            // 1. single add
            DropDownList1.Items.Add(new ListItem("- Please Select an Option", "0"));
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
            // DropDownList1.Items.AddRange(listItemArray);

            // 3. Loop through and add
            foreach (ListItem listItem in itemsListItemCollection)
            {
                DropDownList1.Items.Add(listItem);
            }

            // Create an  event handler for a dynamic control
            // 1. Make a method that takes object sender, EventArgs e as
            // arguments
            // 2. tie that method  to a new Event Handler object
            DropDownList1.SelectedIndexChanged += new EventHandler(CheckIndex);

            // Add DropDownList to PlaceHolder
            PlaceHolder1.Controls.Add(DropDownList1);

        }   // end Page_Load
        
        protected void CheckIndex(object sender, EventArgs e)
        {
            // First Version - we are tied to an individual control,
            // which is 'DropDownList1'
            /*
            if(DropDownList1.SelectedIndex == 0)
            {
                lblOutput.Text = "Please select an item";
            }
            else
            {
                lblOutput.Text = "Index is: " + DropDownList1.SelectedIndex;
            }
            */

            // Second version - we are able to handle multiple DropDownList
            // controls that are the same

            // Make the 'sender', which is type Object,
            // into  a DropDownList
            DropDownList ddl = (DropDownList)sender;

            /*
            if (sender.getType)
            {

            }
            */

            if (ddl.SelectedIndex == 0)
            {
                lblOutput.Text = "Please select an item";
            }
            else
            {
                lblOutput.Text = "Index is: " + ddl.SelectedItem;
            }
            
        }
        
    }
}