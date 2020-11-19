using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateManagementDemo
{
    public partial class Form1 : Form
    {
        int count = 0;//global declareation
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LOGIC TO DEMONSTRATE FOR COUNT ON BUTTON CLICK
            count += 1;
            MessageBox.Show("number of hit counts are:" + count);
        }
    }
}
