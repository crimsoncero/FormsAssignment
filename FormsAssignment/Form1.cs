using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsAssignment
{

    public partial class Form1 : Form
    {
        private float _numLeft = 0f;
        private bool _isLeftValid = false;
        private float _numRight = 0f;
        private bool _isRightValid = false;
        private Func<float, float, float> _operation;

        private bool IsInputValid { get { return _isLeftValid && _isRightValid && (_operation != null); } }

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (IsInputValid)
            {
                Console.WriteLine("Calculating...");

                Result.Text = _operation.Invoke(_numLeft, _numRight).ToString();
            }
            else
            {
                Console.WriteLine("Not Valid");
                Result.Text = "Not Valid Input";
            }
        }

        private void leftBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;


            // Try and parse the textbox, sets the num if possible, and changes text color to indicate if there is an error
            if(float.TryParse(textBox.Text, out float num))
            {
                _numLeft = num;
                textBox.ForeColor = Color.Blue;
                _isLeftValid = true;
            }
            else
            {
                textBox.ForeColor = Color.Red;
                _isLeftValid = false;
            }
        }

        private void rightBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;


            // Try and parse the textbox, sets the num if possible, and changes text color to indicate if there is an error
            if (float.TryParse(textBox.Text, out float num))
            {
                _numRight = num;
                textBox.ForeColor = Color.Blue;
                _isRightValid = true;
            }
            else
            {
                textBox.ForeColor = Color.Red;
                _isRightValid = false;
            }
        }

        private void Operator_TextChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedItem)
            {
                case "Add":
                    _operation = Add;
                    break;
                case "Subtract":
                    _operation = Subtract;
                    break;
                case "Multiply":
                    _operation = Multiply;
                    break;
                case "Divide":
                    _operation = Divide;
                    break;
                case "Power":
                    _operation = Power;
                    break;
                case "Log":
                    _operation = Log;
                    break;
                default:
                    _operation = null;
                    break;
            }
        }


        private float Add(float x, float y)
        {
            return x + y;
        }
        private float Subtract(float x, float y)
        {
            return x - y;
        }
        private float Multiply(float x, float y)
        {
            return x * y;
        }
        private float Divide(float x, float y)
        {
            return x / y;
        }
        private float Power(float @base, float exponent)
        {
            if (exponent == 0) return 1; 
            float res = @base;
            for(int i = 1; i < exponent; i++)
            {
                res *= @base; 
            }

            return res;
        }
        private float Log(float x, float y)
        {
            return (float)Math.Log(x, y); 
        }
        
    }
}
