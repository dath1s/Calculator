namespace calculator
{
    public partial class Form1 : Form
    {
        public string first_string = "", second_string = "0";
        public double value = 0, result = 0;
        public string last_action = "";
        public double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            value = memory;
            label1.Text = first_string + "\n" + value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memory = value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory += value;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            memory -= value;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (second_string.Length <= 15 || (second_string[second_string.Length - 1] == ',' && second_string.Length <= 17))
            {
                if (second_string == "0")
                {
                    second_string = B.Text;
                }
                else
                {
                    second_string += B.Text;
                }
                
                value = double.Parse(second_string);
                label1.Text = first_string + "\n" + second_string;
            }
        }
        private void point_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if (!second_string.Contains(','))
            {
                second_string += B.Text;
            }
            label1.Text = first_string + "\n" + second_string;
        }

        private void erase_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (second_string != "0") second_string = second_string[..^1];
            if (second_string.Length == 0) second_string = "0";

            value = double.Parse(second_string);
            label1.Text = first_string + "\n" + second_string;
        }

        private void clean_cur_num_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            second_string = "0";
            label1.Text = first_string + "\n" + second_string;
        }

        private void clean_all_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            second_string = "0";
            first_string = "";
            label1.Text = first_string + "\n" + second_string;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (second_string != "0")
            {
                if (second_string[0] == '-')
                {
                    second_string = second_string.Substring(1);
                }
                else
                {
                    second_string = "-" + second_string;
                }
                value *= -1;
            }
            label1.Text = first_string + "\n" + second_string;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (first_string == "") result = value;
            else
            {
                switch (last_action)
                {
                    case "+":
                        result += value;
                        break;
                    case "-":
                        result -= value;
                        break;
                    case "*":
                        result *= value;
                        break;
                    case "/":
                        result /= value;
                        if (value == 0) second_string = "Деление на 0!";
                        break;
                }
            }

            last_action = "+";
            if (second_string != "Деление на 0!") first_string += $"{value.ToString()}+";
            else first_string = "";
            if (first_string.Length >= 18) first_string = first_string.Substring(first_string.Length - 18);
            value = 0;
            label1.Text = first_string + "\n" + second_string;
            second_string = "0";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (first_string == "") result = value;
            else
            {
                switch (last_action)
                {
                    case "+":
                        result += value;
                        break;
                    case "-":
                        result -= value;
                        break;
                    case "*":
                        result *= value;
                        break;
                    case "/":
                        result /= value;
                        if (value == 0) second_string = "Деление на 0!";
                        break;
                }
            }

            last_action = "-";
            if (second_string != "Деление на 0!") first_string += $"{value.ToString()}-";
            else first_string = "";
            if (first_string.Length >= 18) first_string = first_string.Substring(first_string.Length - 18);
            value = 0;
            label1.Text = first_string + "\n" + second_string;
            second_string = "0";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (first_string == "") result = value;
            else
            {
                switch (last_action)
                {
                    case "+":
                        result += value;
                        break;
                    case "-":
                        result -= value;
                        break;
                    case "*":
                        result *= value;
                        break;
                    case "/":
                        result /= value;
                        if (value == 0) second_string = "Деление на 0!";
                        break;
                }
            }

            last_action = "*";
            if (second_string != "Деление на 0!") first_string += $"{value.ToString()}*";
            else first_string = "";
            if (first_string.Length >= 18) first_string = first_string.Substring(first_string.Length - 18);
            value = 0;
            label1.Text = first_string + "\n" + second_string;
            second_string = "0";
        }

        private void div_Click(object sender, EventArgs e)
        {
            if (first_string == "") result = value;
            else
            {
                switch (last_action)
                {
                    case "+":
                        result += value;
                        break;
                    case "-":
                        result -= value;
                        break;
                    case "*":
                        result *= value;
                        break;
                    case "/":
                        result /= value;
                        if (value == 0) second_string = "Деление на 0!";
                        break;
                }
            }

            last_action = "/";
            if (second_string != "Деление на 0!") first_string += $"{value.ToString()}/";
            else first_string = "";
            if (first_string.Length >= 18) first_string = first_string.Substring(first_string.Length - 18);
            value = 0;
            label1.Text = first_string + "\n" + second_string;
            second_string = "0";
        }

        private void eq_Click(object sender, EventArgs e)
        {
            switch (last_action)
            {
                case "+":
                    result += value;
                    break;
                case "-":
                    result -= value;
                    break;
                case "*":
                    result *= value;
                    break;
                case "/":
                    result /= value;
                    break;
            }

            first_string = "";
            second_string = result.ToString();
            if (second_string == "∞" || second_string == "-∞") second_string = "Деление на 0!";
            label1.Text = first_string + "\n" + second_string;
            value = 0;
            second_string = "0";
            result = 0;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            value = Math.Sqrt(value);
            label1.Text = first_string + "\n" + value.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            value = 1 / value;
            second_string = value.ToString();
            if (second_string == "∞" || second_string == "-∞") second_string = "Деление на 0!";
            label1.Text = first_string + "\n" + second_string;
        }

        private void percent_Click(object sender, EventArgs e)
        {
            value = result / 100 * value;
            label1.Text = first_string + "\n" + value.ToString();
        }
    }
}
