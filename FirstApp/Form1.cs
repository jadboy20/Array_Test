using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string firstname;
            string lastname;
            firstname = FirstNameTextBox.Text;
            lastname = LastNameTextBox.Text;


            MessageBox.Show("Hello " + firstname + " " + lastname);

        }
    }
}
