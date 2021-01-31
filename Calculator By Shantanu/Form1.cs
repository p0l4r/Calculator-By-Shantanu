using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_By_Shantanu
{
    public partial class Form1 : Form
    {
        double value = 0;
        double mem_value = 0;
        string operation = "";
        bool operation_pressed = false;
        bool equal_pressed = false;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        // event handler
        private void button_Click(object sender, EventArgs e) // 0-9 and . button
        {
            if( (result.Text == "0") || ( operation_pressed==true) || (equal_pressed == true) )
            {
                result.Text = "";
            }
        
            operation_pressed = false;
            equal_pressed = false;
            Button b = (Button)sender; // casting sender parameter and making it a button type object
         
            result.Text = result.Text + b.Text;
            
         
        }

        private void button17_Click(object sender, EventArgs e)  //CE button
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e) // + , - , * , / all four opearator button
        {
            Button b = (Button)sender; // casting sender parameter and making it a button type object
            operation = b.Text; // assigning text value of the operator button to operation variable
            value = double.Parse(result.Text); // parsing text value of result and then converting it to double type and then assigning it to value variable
            if (b.Text == "√")
            {
                result.Text = b.Text + result.Text;
            }
            else if (b.Text == "x²")
            {
                result.Text = result.Text;
            }
            else if (b.Text == "x^y")
            {
                result.Text = result.Text + "^";
            }
            else if (b.Text == "log")
            {
                result.Text = b.Text + " " + result.Text + " ";
            }
            else
            {
                result.Text = result.Text + b.Text;
            }
            operation_pressed = true;

        }

        private void button16_Click(object sender, EventArgs e) // = opearator button
        {
          
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    equal_pressed = true;
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    equal_pressed = true;
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    equal_pressed = true;
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    equal_pressed = true;
                    break;
                case "√":
                    result.Text = (Math.Sqrt(value)).ToString();
                    equal_pressed = true;
                    break;
                case "%":
                    result.Text = (value / 100).ToString();
                    equal_pressed = true;
                    break;
                case "x²":
                    result.Text = (value*value).ToString();
                    equal_pressed = true;
                    break;
                case "x^y":
                    result.Text = (Math.Pow(value, double.Parse(result.Text))).ToString();
                    equal_pressed = true;
                    break;
                case "log":
                    result.Text = (Math.Log(value, double.Parse(result.Text))).ToString();
                    equal_pressed = true;
                    break;
                default:
                    break;

            }
            operation_pressed = false;
      
            
        }

        private void button18_Click(object sender, EventArgs e)  // C button
        {
            result.Text = "";
            value = 0;

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form3 popup = new Form3();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
    }
}
