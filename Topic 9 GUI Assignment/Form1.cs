using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_GUI_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            imgCharacter.Visible = true;
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            imgCharacter1.Visible = true;
        }
    }
}
