using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labwork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddFromCode(object sender, EventArgs e)
        {
            double grade = Convert.ToDouble(txtGrade.Text);
            
            listBox.Items.Add(grade);
       
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcAverage_Click(object sender, EventArgs e)
        {
            int i = 0, result = 0;

            while (i < listBox.Items.Count)
            {
                result += Convert.ToInt32(listBox.Items[i++]);
            }
            textBox1.Text = Convert.ToString((double)result / i);
        }
    }
}
