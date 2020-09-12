using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Web_Scraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void scrapeBtn_Click(object sender, EventArgs e)
        {
            string result = null;
            string url = urlBox.Text;
            WebResponse response = null;
            StreamReader reader = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                response = request.GetResponse();
                reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                // handle error
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (response != null)
                    response.Close();


                // Custom Code

                string FPathOpen;

                FPathOpen = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "HTMLfile.txt");

                StreamWriter Sw = new StreamWriter(FPathOpen);
                Sw.WriteLine(result);
                Sw.Close();
         
                Process.Start(FPathOpen);
            }
        }
    }
}
