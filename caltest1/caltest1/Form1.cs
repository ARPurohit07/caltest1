namespace caltest1
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string oper1 = string.Empty;
        string oper2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "1";
            this.textBox.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "2";
            this.textBox.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "3";
            this.textBox.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "4";
            this.textBox.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "5";
            this.textBox.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "6";
            this.textBox.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "7";
            this.textBox.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "8";
            this.textBox.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "9";
            this.textBox.Text += input;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += "0";
            this.textBox.Text += input;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            oper1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            input += ".";
            this.textBox.Text += input;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.textBox.Text = textBox.Text.Substring(0, textBox.TextLength - 1);
            this.input = textBox.Text;
            
        }

        private void equals_Click(object sender, EventArgs e)
        {
            oper2 = input;
            double num1, num2;
            double.TryParse(oper1, out num1);
            double.TryParse(oper2, out num2);
            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                textBox.Text = result.ToString();
            }
            else
            {
                textBox.Text = "invalid";
            }

        }

        private void allClear_Click(object sender, EventArgs e)
        {
            this.textBox.Text = "";
            this.input = string.Empty;
            this.oper1 = string.Empty;
            this.oper2 = string.Empty;
        }
    }
}
