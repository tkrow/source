using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntermProgFinalProject
{
    public partial class Form1 : Form
    {
        BankAccount ba = new BankAccount();

        public Form1()
        {
            InitializeComponent();
        }

        public void checkInt(string userInput, string errorOutput)
        {
            for (int i = 0; i < userInput.Length; i++)
            {
                string userInputText = userInput;

                char c = userInput[i];             
                
                bool validInt;

                if (c == '0' | c == '1' | c == '2' | c == '3' | c == '4' | c == '5' | c == '6' | c == '7' | c == '8' | c == '9')
                {
                    
                }
                else
                {
                    validInt = false;

                    if (validInt == false)
                    {
                        MessageBox.Show(errorOutput);

                        break;
                    }
                }                
            }
        }

        private void processTransactionInput_Click(object sender, EventArgs e)
        {            
            //assigns the value for transaction
            ba.getTransaction().setAmount(inputTransactionAmount.Text);
            string amount = ba.getTransaction().getAmount();

            //assigns the value for date
            DateTime mydateTime = DateTime.Now;
            string dateTime = Convert.ToString(mydateTime);
            ba.getTransaction().setDate(dateTime);
            string date = ba.getTransaction().getDate();
      
            //tests if the user values are valid, puts bool to true
            if(amount.Length > 0)
            {
                bool validDecimal;
                bool validNumber;

                string amountstring;

                for (int i = 0; i < amount.Length; i++)
                {
                    char c = amount[i];

                    if (c == '0' | c == '1' | c == '2' | c == '3' | c == '4' | c == '5' | c == '6' | c == '7' | c == '8' | c == '9')
                    {
                        if(amount.Contains("."))
                        {
                            transactionBox.Items.Add(amount + "   " + date);

                            break;
                        }
                        else
                        {
                            transactionBox.Items.Add(amount + ".00   " + date);

                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Letters are not allowed in a Decimal Number");

                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Decimal Amount");
            }
        }

        private void processUserInput_Click(object sender, EventArgs e)
        {
            //sets a boolean value to test each of the Person inputs
            bool validUserInput = false;

            //assigns the value for firstName
            ba.getPerson().setFirstName(firstNameBox.Text);
            string firstname = ba.getPerson().getFirstName();

            //assigns the value for lastName
            ba.getPerson().setLastName(lastNameBox.Text);
            string lastname = ba.getPerson().getLastName();

            //assigns the value for ssn
            ba.getPerson().setSSN(ssnBox.Text);
            string ssn = ba.getPerson().getSSN();

            //assigns the value for date of birth
            ba.getPerson().setDateOfBirth(dateOfBirthBox.Text);
            string dateofbirth = ba.getPerson().getDateOfBirth();

            //assigns the value for userID
            ba.getPerson().setUserID(userIdBox.Text);
            string userid = ba.getPerson().getUserID();

            //assigns the value for street address
            ba.getPerson().setStreetAddress(streetBox.Text);
            string streetaddress = ba.getPerson().getStreetAddress();

            //assigns the value for city
            ba.getPerson().setCity(cityBox.Text);
            string city = ba.getPerson().getCity();

            //assigns the value for state
            ba.getPerson().setState(stateBox.Text);
            string state = ba.getPerson().getState();

            //assigns the value for zipcode
            ba.getPerson().setZipCode(zipCodeBox.Text);
            string zipcode = ba.getPerson().getZipCode();
            
            //tests the input values and if they are all valid, sets the bool true
            if(firstname.Length > 0)
            {
                if (lastname.Length > 0)
                {
                    if (ssn.Length == 9)
                    {
                        checkInt(ssn, "Letters are not allowed in a SSN");

                        if (dateofbirth.Length > 0)
                        {                                
                            if (userid.Length == 5)
                            {
                                checkInt(userid, "Letters are not allowed in a UserID");

                                if (streetaddress.Length > 0)
                                {
                                    if (city.Length > 0)
                                    {
                                        if(zipcode.Length == 7)
                                        {
                                            checkInt(zipcode, "Letters are not allowed in a Zipcode");

                                            if (state.Length > 0)
                                            {
                                                validUserInput = true;

                                                if (validUserInput == true)
                                                {
                                                    personInfoOutput.Text = "First Name: " + firstname + "\n" +
                                                                            "Last Name: " + lastname + "\n" +
                                                                            "SSN: " + ssn + "\n" +
                                                                            "Date of Birth: " + dateofbirth + "\n" +
                                                                            "UserID: " + userid + "\n" +
                                                                            "Street Address: " + streetaddress + "\n" +
                                                                            "City: " + city + "\n" +
                                                                            "Zipcode: " + zipcode + "\n" +
                                                                            "State: " + state;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please enter a valid State");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please enter a valid Zipcode");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter a valid City");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter a valid Street Address");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid UserID");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid date of birth");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid SSN");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Last Name");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid First Name");
            }           
        }
    }
}
