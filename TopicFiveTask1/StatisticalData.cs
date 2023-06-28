using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopicFiveTask1
{
    internal class StatisticalData
    {
        private int num1;
        private int num2; private int num3;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        public int Num3
        {
            get { return num3; }
            set { num3 = value; }
        }

        public void largestNum()
        {
            int num;
            
            num = Math.Max(Math.Max(num1, num2), num3);

            MessageBox.Show($"{num} is the largest number");
        }

        public void smallestNum()
        {
            int num;
            
            num = Math.Min(Math.Min(num1, num2), num3);

            MessageBox.Show($"{num} is the smallest number");
        }

        public void average()
        {
            double num = (num1 + num2 + num3) / 3.0;

            MessageBox.Show($"Average: {num}"); 
        }
    }
}
