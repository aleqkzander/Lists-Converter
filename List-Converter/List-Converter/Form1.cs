using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Converter
{
    public partial class Form1 : Form
    {
        public List<string> initalList;
        public string buildString;
        public List<string> convertedList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initalList = new List<string>();
            convertedList = new List<string>();
            buildString = string.Empty;

            initalList.Add("user1:references1");
            initalList.Add("user2:references2");
            initalList.Add("user3:references3");

            // Convert initial list to stringdata
            StringTextBox.Text = ConvertListToString(initalList);
        }

        private void ClearInitialListBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            // Step 1
            // This happens server side
            // Convert initial list to stringdata
            StringTextBox.Text = ConvertListToString(initalList);


            // Step 2
            // This happens on the client
            // Convert the data back to formated string
            ConvertedTextBox.Text = FormatStringData(StringTextBox.Text);


            // Step 3
            // This happens on the client
            // Convert information back to list
            ConvertStringToList(convertedList, ConvertedTextBox.Text);


            // Clear the box for debugging
            StringTextBox.Clear();


            //Loop through the converted list and print entrys
            groupBox2.Text = "Debug";
            foreach(string entry in convertedList)
            {
                StringTextBox.Text += FinalizeCovertedData(entry) + "\n\n";
            }

        }


        /// <summary>
        /// Convert listdata to string data
        /// </summary>
        /// <param name="ListToConvert"></param>
        /// <returns></returns>
        public string ConvertListToString(List<string> ListToConvert)
        {
            // initalize string to return
            string stringData = string.Empty;

            // loop through list and build string
            foreach (string entry in ListToConvert)
            {
                // make sure entry is not empty
                if (entry != string.Empty)
                {
                    // add entry with seperator
                    stringData += entry + "#";
                }
            }

            // return string
            return stringData;
        }


        /// <summary>
        /// Convert unformated string into useable string 
        /// </summary>
        /// <param name="sendvalues"></param>
        /// <returns></returns>
        public string FormatStringData(string sendvalues)
        {
            /*
             * Conversion look like this
             * user1:references1
             * user2:references2
             * 
             */

            string replacedString = sendvalues.Replace("#", "\n");
            return replacedString;
        }


        public string FinalizeCovertedData(string converteddata)
        {
            string finalized = converteddata.Replace(":", "\n");
            return finalized;
        }


        /// <summary>
        /// Convert string data into Listdata and return the list
        /// </summary>
        /// <param name="ConvertedList"></param>
        /// <param name="StringToConvert"></param>
        public void ConvertStringToList(List<string> ConvertedList, string StringToConvert)
        {
            using (StringReader reader = new StringReader(StringToConvert))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ConvertedList.Add(line);
                }
            }
        }

    }
}
