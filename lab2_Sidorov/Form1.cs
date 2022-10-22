using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_Sidorov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);

            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox_C.Text = strC;
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
        }
    }
}
