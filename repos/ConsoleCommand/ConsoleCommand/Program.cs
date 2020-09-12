using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ConsoleCommand
{
    class Program
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA")]
        public static extern void mciSendStringA(string lpstrCommand, string lpstrReturnString, long uReturnLength, long hwndCallback);
        string returnString = "";

        //method used to check and open/close a disk drive
        static void DiskDrive()
        {     
            bool open = false;
           
            if (open = true)
            {
                mciSendStringA("open " + )
                mciSendStringA("set CDAudio door closed", returnString, 127, 0);
                open = false;
            }
            else
            {
                mciSendStringA("set CDAudio door open", returnString, 127, 0);
                open = true;
            }
        }

        //method used to check for a valid command
        static void command(string cmmd)
        {
            string cmd = cmmd.ToLower();

            if (cmd == "disk open")
            {
                Console.WriteLine("Operating your Disk Drive.");
                DiskDrive();
            }
            else
            {
                Console.WriteLine("Please input a valid command.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input 'list' for a full list of commands.");
            string cmd = Console.ReadLine();
            
            
            Console.ReadKey();
        }
    }
}
