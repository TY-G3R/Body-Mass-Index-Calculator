using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class BMI_Calculator : Form
    {
    
        public BMI_Calculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtResult.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double result = 0.0;
            string result2 = "";

            if (radKg.Checked)
            {
                result = weight / (height * height);
            }
            else
                if (radLb.Checked)
            {
                weight = weight / 2.205;
                result = weight / (height * height);
            }

            if (result < 18.5)
            {
                result2 = "You are underweight";
            }
            else
            if (result < 25)
            {
                result2 = "You are normal weight";
            }
            else
            if (result < 30)
            {
                result2 = "You are overweight";
            }
            else
            if (result >= 30)
                result2 = "You are obese";

            txtResult.Text = "Your BMI is: " + result.ToString("#.#") + " \r\n" + result2;

            /*
            * Underweight = <18.5
                Normal weight = 18.5-24.9
                Overweight = 25-29.9
                Obesity = BMI of 30 or greater
            *
            */
        }
        private void BMI_Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
