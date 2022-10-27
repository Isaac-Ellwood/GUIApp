using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    private void btnMoveWord_Click(object sender, EventArgs e)
        {
            string myWord = tbxUserInput.Text;
            rtbOutput.Text += myWord + "\n";
            tbxUserInput.Text = "";
        }
    }
}
