using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApp;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        DataTable table;
        //Form2 secondForm = new Form2();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Discription", typeof(string));

            noteList.DataSource = table;

            noteList.Columns["Discription"].Visible = false;
            noteList.Columns["Title"].Width = 145;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            titleTxt.Clear();
            descripTxt.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (descripTxt.Text == "" && titleTxt.Text == "")
            {
                MessageBox.Show("Please supply both a title and description for your note.", "Missing Note Info");
            }
            else if (titleTxt.Text == ""){ MessageBox.Show("Please supply a title for your note.", "Missing Title"); }
            else if (descripTxt.Text == ""){ MessageBox.Show("Please supply a description for your note.", "Missing Description"); }
            else
            {
                table.Rows.Add(titleTxt.Text, descripTxt.Text);
                titleTxt.Clear();
                descripTxt.Clear();
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            int index = noteList.CurrentCell.RowIndex;

            if(index>-1)
            {
                titleTxt.Text = table.Rows[index].ItemArray[0].ToString();
                descripTxt.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //string f2title = secondForm.titleTxt.Text;
            //string f2descrip = secondForm.descripTxt.Text;
            int index = noteList.CurrentCell.RowIndex;
            string titleInfo = table.Rows[index].ItemArray[0].ToString();
            string descripInfo = table.Rows[index].ItemArray[1].ToString();

            if (titleTxt.Text == titleInfo && descripTxt.Text == descripInfo)
            { titleTxt.Clear(); descripTxt.Clear(); }
            //if (f2title == titleInfo && f2descrip == descripInfo)
            //{ secondForm.titleTxt.Clear(); secondForm.descripTxt.Clear(); }            

            table.Rows[index].Delete();
        }

        private void newFormBtn_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            secondForm.titleTxt.Text = titleTxt.Text;
            secondForm.descripTxt.Text = descripTxt.Text;
        }
    }
}
