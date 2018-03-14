using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace hashingTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static int passwordBCryptCost = 10;
        public static string passwordSalt = "u6RG2esAFhr8x5RyxwBfv."; 
        public String salt = ("$2a$" + passwordBCryptCost + "$" + passwordSalt );

         private void hashSomeShit_Click(object sender, EventArgs e)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(inputTxt.ToString(),salt); //Creates the hashed password and stores as the hased password variable

            bool validPassword = BCrypt.Net.BCrypt.Verify(inputTxt.ToString(), hashedPassword); //Varifies if the password is valid 

            if (validPassword == true)
            {
                outputHashed.Text = hashedPassword;
                string hashedPassword1 = BCrypt.Net.BCrypt.HashPassword(inputTxt.ToString(),salt);
                System.Threading.Thread.Sleep(5000);

                if (hashedPassword == hashedPassword1)
                {
                    MessageBox.Show("Good Job Declan, You did Good");
                }
                else
                {
                    MessageBox.Show("Something went Wrong");
                }
                
            }
            else
                MessageBox.Show("ERROR");
            /*
             Where string is: $2a$10$vI8aWBnW3fID.ZQ4/zo1G.q1lRps.9cGLcZEiGDMVr5yUP1KUOYTa
             This is actually three fields, delimited by "$":

             2a identifies the bcrypt algorithm version that was used.
             10 is the cost factor; 210 iterations of the key derivation function are used (which is not enough, by the way. I'd recommend a cost of 12 or more.)
             vI8aWBnW3fID.ZQ4/zo1G.q1lRps.9cGLcZEiGDMVr5yUP1KUOYTa is the salt and the cipher text, concatenated and encoded in a modified Base-64. The first 22 characters decode to a 16-byte value for the salt. The remaining characters are cipher text to be compared for authentication.
             */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
