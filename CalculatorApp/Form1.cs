namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        double firstNum;
        double secondNum;
        double result;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NO_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void NO_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void NO_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void NO_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void NO_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void NO_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void NO_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void NO_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void NO_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "/";
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "+";
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            operation = "-";
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void EqualsBtn_Click(object sender, EventArgs e)
        {
            secondNum = Convert.ToDouble(textBox1.Text);

            switch (operation) {
                case "+":
                    result = firstNum + secondNum;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = firstNum - secondNum;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "*":
                    result = firstNum * secondNum;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "/":
                    String error = "Undefined";

                    if (secondNum == 0)
                    {
                        textBox1.Text = error;
                    }
                    else { 
                        result = firstNum / secondNum;
                        textBox1.Text = Convert.ToString(result);
                    }
                    break;
            }
        }
    }
}