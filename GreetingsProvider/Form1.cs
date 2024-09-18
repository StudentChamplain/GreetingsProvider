using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingsProvider
{
    public partial class mainForm : Form
    {


        public mainForm()
        {
            InitializeComponent();
        }

        public string name; 
        public string URL;
        public string timeOfDay = "";

        public string phoneAndAddress;
        




        private void displayRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (!string.IsNullOrEmpty(displayRichTextBox.SelectedText))
                {
                    Clipboard.SetText(displayRichTextBox.SelectedText);
                }
                else
                {
                    Clipboard.SetText(displayRichTextBox.Text);
                }
                e.SuppressKeyPress = true;
            }
        }


        private void previewButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            URL = ticketTextBox.Text;

            if (morningRadioButton.Checked)
            {
                timeOfDay = "morning,";
            }
            else
            {
                timeOfDay = "afternoon,";
            }




            displayRichTextBox.Text = "Good " + timeOfDay + " " + name + ",\r\n\r\nHope you are doing well today, I am reaching out regarding the following ticket concerning the Evergreen of your old laptop: \r\n\r\n" + URL + "\r\n\r\nCould you kindly let me know when you will be available so we can schedule a meeting to provide you with the new computer?\r\n" + phoneAndAddress + " \r\nThank you. ";



            //displayRichTextBox.Text = "Good " + timeOfDay + " " + name + ",\r\n\r\nHope you are doing well today, I am reaching out regarding the following ticket: \r\n\r\n" + URL + "\r\n\r\nCould you kindly let me know when you will be available to schedule a call, so I can take a closer look at the issue?\r\n" + phoneAndAddress + " \r\nThank you. ";

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(displayRichTextBox.Text);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Text = "";
            nameTextBox.Text = "";
            ticketTextBox.Text = "" ;
            morningRadioButton.Checked = true;
        }
    }
}
