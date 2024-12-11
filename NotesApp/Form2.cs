using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApp;

namespace NotesApp
{
    public partial class Form2 : Form
    {
        //string title, string descrip
        public Form2()
        {
            InitializeComponent();
        }

        private void newFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
