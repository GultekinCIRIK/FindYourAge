using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyAge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            DateTime dtBirtday = dateTimePicker_age.Value;
            DateTime dtNow = DateTime.Now;
            int age = dtNow.Year - dtBirtday.Year;
            textBox_age.Text = age.ToString();
            label_age.Visible = true;
            textBox_age.Visible = true;
        }
    }
}
