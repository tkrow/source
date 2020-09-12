using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Password_Manager_Capstone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lengthBox.Controls.RemoveAt(0);
        }

        // Creates a desktop directory for file saving to the folder
        string desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        // Creates some global variables for the DataTable
        // Creates a DataTable object 'dataTable'
        DataTable dataTable = new DataTable();

        // Creates two columns for dataTable 'ID' and 'Info'
        DataColumn[] columns = { new DataColumn("ID"), new DataColumn("Info") };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adds the Columns and rows to table
            dataTable.Columns.AddRange(columns);
            fillTable("", "", "", "");

            // sets the datasource for the dataGridView as the dataTable
            infoGrid.DataSource = dataTable;

            // sets the size for columns and rows as needed
            DataGridViewColumn column = infoGrid.Columns[0];
            column.Width = 56;

            // Creates Password Manager folder if it does not exist
            // Displays message upon creation
            desktopPath += "\\Password Manager";
            folderExists();

            updateList();
        }

        // tests to see if info boxes are full
        // if not, display a message
        // encodes and encrypts info before writing
        // to a file
        private void submitBtn_Click(object sender, EventArgs e)
        {     
            // validInput is to be used to test for the correct number of proper inputs
            int validInput = 0;

            // sets strings to the respective textboxes for testing
            string website = siteBox.Text;
            string userName = nameBox.Text;
            string email = emailBox.Text;
            string password = passBox.Text;

            // Tests if input is blank, if not,
            // then increment validInput by 1
            if (!isInputEmpty(website))
            {
                validInput++;
            }
            if (!isInputEmpty(userName))
            {
                validInput++;
            }
            if (!isInputEmpty(email))
            {
                validInput++;
            }
            if (!isInputEmpty(password))
            {
                validInput++;
            }

            // if validInput does not match the number
            // of inputs, then outputs message, otherwise
            // will try to save data, creating file if 
            // a file does not already exist
            if (validInput == 4)
            {
                // checks if the following statements is true
                bool containsAt = email.Contains("@");
                bool containsDot = email.Contains(".");
                bool properPlacement = email.IndexOf("@") < email.IndexOf(".");
              
                if(containsAt & containsDot & properPlacement){
                    // counts the total of the '@' and '.' symbols
                    // if multiple exist, throw an error
                    int countAt = email.Split('@').Length - 1;
                    int countDot = email.Split('.').Length - 1;

                    if(countAt == 1 & countDot == 1)
                    {
                        // two substrings to aid in checking validity of email
                        string splitEmailAt = email.Split('@', '.')[0];
                        string splitEmailDot = email.Split('@', '.')[1];
                        bool nonBlankAt = splitEmailAt.Length > 0;
                        bool nonBlankDot = splitEmailDot.Length > 0;

                        if (nonBlankDot & nonBlankAt)
                        {
                            // Generates the IV value at random
                            string initValue = initGen();

                            // Encodes the encrypted input info as UTF-8
                            website = encodeInfo(website, true);
                            userName = encodeInfo(userName, true);
                            email = encodeInfo(email, true);
                            password = encodeInfo(password, true);

                            // Encrypts the info using Rindael
                            userName = encryptInfo(userName, initValue, true);
                            email = encryptInfo(email, initValue, true);
                            password = encryptInfo(password, initValue, true);
                            initValue = encodeInfo(initValue, true);

                            // creates the filepath
                            string filePath = Path.Combine(desktopPath, website + ".txt");

                            // Creates a string array to save info to the file
                            string[] info = { website, userName, email, password, initValue };

                            // checks if folder exists, CYA maneuver
                            // if nothing else
                            folderExists();

                            // If file exists, delete and remake
                            // otherwise, create file
                            // Write info to files upon creation
                            // overwrites text if file already exists
                            if (!File.Exists(filePath))
                            {
                                File.Create(filePath).Dispose();
                                File.WriteAllLines(filePath, info);
                                MessageBox.Show("File has been created/updated.");

                                clearEntryBoxes();
                            }
                            else
                            {
                                GC.Collect();
                                GC.WaitForPendingFinalizers();

                                File.WriteAllLines(filePath, info);
                                MessageBox.Show("File has been created/updated.");

                                clearEntryBoxes();
                            }
                            fillTable("", "", "", "");
                            updateList();
                        }
                        else
                        {
                            MessageBox.Show("You must not have empty space before the '@' and '.'");
                        }
                    }
                    else
                    {
                        MessageBox.Show("There may only be 1 '@' and '.' in an email.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your mail in the format of johndoe@domain.com");
                }
            }
            else
            {
                MessageBox.Show("Please do not leave any boxes blank");
            }
        }

        // When a file is selected from the listbox
        // prints files info to table after decoding and decryption
        private void siteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToString(siteList.SelectedItem) != "")
            {
                string fileName = encodeInfo(Convert.ToString(siteList.SelectedItem), true) + ".txt";
                string fullPath = desktopPath + "\\" + fileName;

                if (File.Exists(fullPath))
                {
                    int lineCount = File.ReadLines(fullPath).Count();
                    List<string> infoList = new List<string>();

                    StreamReader sr = new StreamReader(fullPath);
                    string lineReader;
                    while ((lineReader = sr.ReadLine()) != null)
                    {
                        infoList.Add(lineReader);
                    }

                    // decodes and decrypts as needed, took too long to figure out
                    infoList[4] = encodeInfo(infoList[4], false);
                    infoList[0] = encodeInfo(infoList[0], false);
                    infoList[1] = encodeInfo(encryptInfo(infoList[1], infoList[4], false), false);
                    infoList[2] = encodeInfo(encryptInfo(infoList[2], infoList[4], false), false);
                    infoList[3] = encodeInfo(encryptInfo(infoList[3], infoList[4], false), false);

                    fillTable(infoList[0], infoList[1], infoList[2], infoList[3]);
                }
                else
                {
                    updateList();
                }
            }
        }

        // if a selected file currently exists,
        // then delete it and update the list
        // also clear the table
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(siteList.SelectedItem) != "")
            {
                string fileName = encodeInfo(Convert.ToString(siteList.SelectedItem), true) + ".txt";
                string fullPath = desktopPath + "\\" + fileName;

                if (File.Exists(fullPath))
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    File.Delete(fullPath);

                    for (int n = siteList.Items.Count - 1; n >= 0; --n)
                    {
                        if (siteList.Items[n].ToString().Equals(Convert.ToString(siteList.SelectedItem)))
                        {
                            siteList.Items.RemoveAt(n);
                        }
                    }

                    MessageBox.Show("File was successfully deleted");

                    clearEntryBoxes();
                    fillTable("", "", "", "");
                    updateList();
                }
                else
                {
                    for (int n = siteList.Items.Count - 1; n >= 0; --n)
                    {
                        if (siteList.Items[n].ToString().Equals(Convert.ToString(siteList.SelectedItem)))
                        {
                            siteList.Items.RemoveAt(n);
                        }
                    }

                    MessageBox.Show("File was already deleted and the list has been updated");

                    updateList();
                }
            }
        }

        // Copies the info from a selected file and pastes
        // the text into the info boxes (WIP)
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(siteList.SelectedItem) != "")
            {
                string fileName = encodeInfo(Convert.ToString(siteList.SelectedItem), true) + ".txt";
                string fullPath = desktopPath + "\\" + fileName;

                if (File.Exists(fullPath))
                {
                    int lineCount = File.ReadLines(fullPath).Count();
                    List<string> infoList = new List<string>();

                    StreamReader sr = new StreamReader(fullPath);
                    string lineReader;
                    while ((lineReader = sr.ReadLine()) != null)
                    {
                        infoList.Add(lineReader);
                    }

                    // decodes and decrypts as needed, took too long to figure out
                    infoList[4] = encodeInfo(infoList[4], false);
                    infoList[0] = encodeInfo(infoList[0], false);
                    infoList[1] = encodeInfo(encryptInfo(infoList[1], infoList[4], false), false);
                    infoList[2] = encodeInfo(encryptInfo(infoList[2], infoList[4], false), false);
                    infoList[3] = encodeInfo(encryptInfo(infoList[3], infoList[4], false), false);

                    siteBox.Text = infoList[0];
                    nameBox.Text = infoList[1];
                    emailBox.Text = infoList[2];
                    passBox.Text = infoList[3];
                }
            }
        }

        // Generates a password with selected 
        // options and specified length
        private void generateBtn_Click(object sender, EventArgs e)
        {
            // pulls password length
            int length = Convert.ToInt16(lengthBox.Value);

            // strings for each of the select options
            string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerLetters = "abcdefghijklmnopqrstuvwxyz";
            string symbols = "`~!@#$%^&*()-_=+[{]}|;:,<.>?";
            string numbers = "1234567890";

            // determines how many boxes have been checked
            int checkedBox = 0;

            // empty string to create password
            string charString = "";

            if (upperBox.Checked == true)
            {
                charString += capitalLetters;
                checkedBox++;
            }
            if (lowerBox.Checked == true)
            {
                charString += lowerLetters;
                checkedBox++;
            }
            if (symbolBox.Checked == true)
            {
                charString += symbols;
                checkedBox++;
            }
            if (numberBox.Checked == true)
            {
                charString += numbers;
                checkedBox++;
            }

            if (checkedBox > 0)
            {
                if (length > lengthBox.Minimum)
                {
                    string generatedPassword = randomCharString(charString, length);
                    finishedPassBox.Text = generatedPassword;
                }
                else
                {
                    MessageBox.Show("Password must not be 0 characters in length");
                }
            }
            else
            {
                MessageBox.Show("Please select an option");
            }
        }

        // allows the user to click a button
        // and copies the finished password 
        // into the password box
        private void acceptPassBtn_Click(object sender, EventArgs e)
        {
            if (finishedPassBox.Text != "")
            {
                passBox.Text = finishedPassBox.Text;
            }
        }

        // Encodes the info before writing to the file
        // if toggle = true then encode, else decode
        private string encodeInfo(string info, bool toggle)
        {
            if(toggle) { 
                byte[] base64Bytes = Encoding.UTF8.GetBytes(info);
                return Convert.ToBase64String(base64Bytes);
            }
            else
            {
                byte[] base64Bytes = Convert.FromBase64String(info);
                return Encoding.UTF8.GetString(base64Bytes);
            }
        }

        // Encrypts the info before writing to the file
        // if toggle = true then encrypt, else decrypt
        public static string encryptInfo(string plainText, string IV, bool toggle)
        {
            if(toggle)
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(IV);
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(IV, null);
                byte[] keyBytes = password.GetBytes(256 / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                cryptoStream.FlushFinalBlock();
                byte[] cipherTextBytes = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();
                return Convert.ToBase64String(cipherTextBytes);
            }
            else
            {
                byte[] initVectorBytes = Encoding.UTF8.GetBytes(IV);
                byte[] cipherTextBytes = Convert.FromBase64String(plainText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(IV, null);
                byte[] keyBytes = password.GetBytes(256 / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }

        // Tests if rawInput is empty
        private bool isInputEmpty(string rawInput)
        {
            // if rawInput is not empty, then it is valid
            // and return true
            if(rawInput.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;  
            }
        }

        // fills and deploys table rows
        private void fillTable(string site, string name, string email, string pass)
        {
            // removes current tables so new tables can be added
            for (int i = dataTable.Rows.Count - 1; i >= 0; i--)
            {
                dataTable.Rows[i].Delete();
            }

            // Creates four rows with specified info
            Object[] siteRow = { "Website", site };
            Object[] nameRow = { "Username", name };
            Object[] emailRow = { "Email", email };
            Object[] passRow = { "Password", pass };

            // add rows to table
            dataTable.Rows.Add(siteRow);
            dataTable.Rows.Add(nameRow);
            dataTable.Rows.Add(emailRow);
            dataTable.Rows.Add(passRow);
        }

        // Trims the saved file and adds 
        // it to the file list siteList
        private void updateList()
        {
            folderExists();

            int fileCount = Directory.GetFiles(desktopPath, "*", SearchOption.TopDirectoryOnly).Length;
            int filePathLength = desktopPath.Length;
            string[] filesArray = Directory.GetFiles(desktopPath);
            string trimmedFile;

            // foreach file in filesArray
            // check if list already contains file
            // if so, then skip and check next
            // otherwise, add to list
            // then sort alphabetically
            foreach (string file in filesArray)
            {
                trimmedFile = file.Substring(filePathLength + 1);
                trimmedFile = trimmedFile.Remove(trimmedFile.Length - 4);
                trimmedFile = encodeInfo(trimmedFile, false);
                if (siteList.Items.Count == 0)
                {
                    siteList.Items.Add(trimmedFile);
                }
                else
                {
                    if (!siteList.Items.Contains(trimmedFile))
                    {
                        siteList.Items.Add(trimmedFile);
                    }
                }
            }
            siteList.Sorted = true;
        }

        // generates a list of specied length
        // from specied character list
        private string randomCharString(string charString, int length)
        {
            Random random = new Random();
            string randString = "";
            for (var i = 0; i < length; i++)
            {
                randString += charString[random.Next(0, charString.Length)];
            }

            return randString;
        }

        // checks if the folder exists
        // if not, creates folder
        // displays a message if folder
        // does not exist
        private void folderExists()
        {
            if (!Directory.Exists(desktopPath))
            {
                MessageBox.Show("The folder 'Password Manager does not currently exist");
                Directory.CreateDirectory(desktopPath);
                MessageBox.Show("The folder 'Password Manager' has been created on your desktop");
            }
        }

        // generates a 16-character IV value for encrypt
        private string initGen()
        {
            string charSymbolNum = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz`~!@#$%^&*()-_=+[{]}|;:',<.>/?1234567890";

            return randomCharString(charSymbolNum, 16);
        }

        // clears the text boxes
        // literally a code shortener
        // no other purpose
        private void clearEntryBoxes()
        {
            siteBox.Text = "";
            nameBox.Text = "";
            emailBox.Text = "";
            passBox.Text = "";
        }
    }
}