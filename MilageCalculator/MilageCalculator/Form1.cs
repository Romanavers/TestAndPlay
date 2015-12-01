using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilageCalculator
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMilage;
        double milesTraveled;
        double reimburseRate = 0.39;
        double amountOwned;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int) numericUpDown1.Value;
            endingMilage = (int) numericUpDown2.Value;
            if (startingMileage < endingMilage)
            {
                milesTraveled = endingMilage - startingMileage;
                amountOwned = milesTraveled * reimburseRate;
                label4.Text = "$" + amountOwned;
            }
            else
            {
                MessageBox.Show("Check your inputs", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }
    }
}
