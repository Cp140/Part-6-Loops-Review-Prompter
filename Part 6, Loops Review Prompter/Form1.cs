using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_6__Loops_Review_Prompter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rangeHigh;
        int rangeLow;
        int rangeBetween;


        private void button4_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtHigh.Text, out rangeHigh);
            Int32.TryParse(txtLow.Text, out rangeLow);
            Int32.TryParse(txtInput.Text, out rangeHigh);
            if (rangeBetween >= rangeLow && rangeBetween <= rangeHigh)
            {


            }
        }
    }
}
