using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

         private void hashSomeShit_Click(object sender, EventArgs e)
        { 

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(inputTxt.ToString()); //Creates the hashed password and stores as the hased password variable

            bool validPassword = BCrypt.Net.BCrypt.Verify(inputTxt.ToString(), hashedPassword); //Varifies if the password is valid

            MessageBox.Show(hashedPassword);
            
        }
    }
}
