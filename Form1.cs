using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg455Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpBoxUnits_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndFocus();
            comBoxFrom.Items.AddRange(new string[] { "Meter", "Kilometer", "Inch"});
            comBoxTo.Items.AddRange(new string[] { "Meter", "Kilometer", "Inch"});
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndFocus();
            comBoxFrom.Items.AddRange(new string[] { "Gram", "Kilogram", "Pound"});
            comBoxTo.Items.AddRange(new string[] { "Gram", "Kilogram", "Pound"});
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndFocus();
            comBoxFrom.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
            comBoxTo.Items.AddRange(new string[] { "Celsius", "Fahrenheit", "Kelvin" });
        }

        private void ClearAndFocus()
        {
            txtBoxFrom.Clear();
            txtBoxTo.Clear();
            comBoxFrom.Items.Clear();
            comBoxTo.Items.Clear();
            comBoxFrom.SelectedIndex = -1;
            comBoxTo.SelectedIndex = -1;
            txtBoxFrom.Focus();
        }

        private void grpBoxFrom_Enter(object sender, EventArgs e)
        {

        }

        private void comBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformConversion();
        }

        private void txtBoxFrom_TextChanged(object sender, EventArgs e)
        {
            PerformConversion();
        }

        private void grpBoxTo_Enter(object sender, EventArgs e)
        {

        }

        private void comBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformConversion();
        }
        private void PerformConversion()
        {
            if (comBoxFrom.SelectedIndex == -1 || comBoxTo.SelectedIndex == -1) { return; }

            if (!double.TryParse(txtBoxFrom.Text, out double input))
            {
                txtBoxTo.Text = "Invalid";
                return;
            }

            string from = comBoxFrom.SelectedItem.ToString();
            string to = comBoxTo.SelectedItem.ToString();
            double output = ConvertUnits(input, from, to);
            txtBoxTo.Text = output.ToString();
        }

        private double ConvertUnits(double input, string fromUnit, string toUnit)
        {
            if (fromUnit == "Meter" && toUnit == "Kilometer") return input / 1000;
            if (fromUnit == "Kilometer" && toUnit == "Meter") return input * 1000;
            if (fromUnit == "Meter" && toUnit == "Inch") return input * 39.36;
            if (fromUnit == "Inch" && toUnit == "Meter") return input / 39.36;
            if (fromUnit == "Kilometer" && toUnit == "Inch") return input * 39370.1;
            if (fromUnit == "Inch" && toUnit == "Kilometer") return input / 39370.1;


            if (fromUnit == "Gram" && toUnit == "Kilogram") return input / 1000;
            if (fromUnit == "Kilogram" && toUnit == "Gram") return input * 1000;
            if (fromUnit == "Pound" && toUnit == "Gram") return input * 453.592;
            if (fromUnit == "Gram" && toUnit == "Pound") return input / 453.592;
            if (fromUnit == "Pound" && toUnit == "Kilogram") return input / 2.205;
            if (fromUnit == "Kilogram" && toUnit == "Pound") return input * 2.205;

            if (fromUnit == "Celsius" && toUnit == "Fahrenheit") return (input * 9 / 5) + 32;
            if (fromUnit == "Fahrenheit" && toUnit == "Celsius") return (input - 32) * 5 / 9;
            if (fromUnit == "Celsius" && toUnit == "Kelvin") return input + 273.15;
            if (fromUnit == "Kelvin" && toUnit == "Celsius") return input - 273.15;
            if (fromUnit == "Fahrenheit" && toUnit == "Kelvin") return (input - 32) * 5 / 9 + 273.15;
            if (fromUnit == "Kelvin" && toUnit == "Fahrenheit") return (input - 273.15) * 9 / 5 + 32;

            return input;
        }


        private void txtBoxTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetMenuStrip_Click(object sender, EventArgs e)
        {
            txtBoxFrom.Clear();
            txtBoxTo.Clear();
            comBoxFrom.SelectedIndex = -1;
            comBoxTo.SelectedIndex = -1;
            txtBoxFrom.Focus();
        }

        private void exitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
