using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicFiveTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StatisticalData number1 = new StatisticalData();
        StatisticalData number2 = new StatisticalData();
        StatisticalData number3 = new StatisticalData();
        StatisticalData number4 = new StatisticalData();
        StatisticalData number5 = new StatisticalData();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(txtNum.Text);
            int num2 = Int32.Parse(txtNum2.Text);
            int num3 = Int32.Parse(txtNum3.Text);
            
            //number1.smallestNum(txtNum.Text)

            number1.Num1 = num1;
            number1.Num2 = num2;
            number1.Num3 = num3;

            number1.smallestNum();
            number1.largestNum();
            number1.average();         
        }
    }
}
