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

            initalList.Add("Test1:Test2");
            initalList.Add("Test2:Test3");
            initalList.Add("Test3:Test4");
        }

        private void ClearInitialListBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            // Convert initial list to stringdata
            StringTextBox.Text = ConvertListToString(initalList);


            // SEND THE STRINGDATA TO CLIENT NOW VIA HEADER ETC...


            // On the client side convert the string
            SplitStringIntoValues();


            // Add converted data to a list and compare
            ConvertStringToList(convertedList, StringTextBox.Text);

        }


        public string ConvertListToString(List<string> ListToConvert)
        {
            // definde string to return
            string stringData = string.Empty;

            // loop through list and build string
            foreach (string entry in ListToConvert)
            {
                // get entry
                string entryID = ListToConvert.IndexOf(entry).ToString();
                stringData += entry + "\n";
            }

            // return string
            return stringData;
        }


        public void SplitStringIntoValues()
        {

        }


        public void ConvertStringToList(List<string> ConvertedList, string StringToConvert)
        {
            using (StringReader reader = new StringReader(StringToConvert))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ConvertedList.Add(line + "\n");
                }
            }
        }
    }
}
