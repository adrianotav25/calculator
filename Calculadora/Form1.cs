using System.Globalization;

namespace Calculadora
{
    public partial class FrmCalculator : Form
    {
        decimal numberOne,numberTwo;
        string operation;

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            LblTextResult.Text = "Nossa Calculadora";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResult.Text += ",";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberTwo = Convert.ToInt32(txtResult.Text, CultureInfo.InvariantCulture);
                LblTextResult.Text += numberTwo + "=";
                decimal result = 0;
                switch (operation)
                {
                    case "sum":
                        result = numberOne + numberTwo;
                        break;
                    case "sub":
                        result = numberOne - numberTwo;
                        break;
                    case "multi":
                        result = numberOne * numberTwo;
                        break;
                    case "div":
                        if(numberTwo == 0)
                        {
                            txtResult.Text=("Não é possivel dividir por zero");

                        }
                        result = numberOne / numberTwo;
                        break;
                    case "restoDiv":
                        result = numberOne % numberTwo;
                        break ;
                }

                txtResult.Text = result.ToString();
                LblTextResult.Text += result.ToString();
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResult.Text += "1";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "") 
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "sum";
            LblTextResult.Text = txtResult.Text + "+";

            txtResult.Clear(); 

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "div";
            LblTextResult.Text = txtResult.Text + "/";

            txtResult.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "multi";
            LblTextResult.Text = txtResult.Text + "*";

            txtResult.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "restoDiv";
            LblTextResult.Text = txtResult.Text + "%";

            txtResult.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
            {
                numberOne = Convert.ToDecimal(txtResult.Text, CultureInfo.InvariantCulture);
            }
            else
            {
                MessageBox.Show("Você deve digitar um número");
                txtResult.Focus();
            }

            operation = "sub";
            LblTextResult.Text = txtResult.Text + "-";

            txtResult.Clear();
        }
    }
}