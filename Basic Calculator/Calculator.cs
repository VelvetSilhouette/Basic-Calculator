

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double numb1;
        double numb2;
        string MathOp = "";
        double Result;

        private void btn1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            numb1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = btnAdd.Text + " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            numb1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = btnSub.Text + " ";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            numb1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = btnMultiply.Text + " ";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            numb1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = btnDivide.Text + " ";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MathOp = Convert.ToString(txtScreen.Text.Substring(0, 1));
            numb2 = Convert.ToDouble(txtScreen.Text.Substring(2));
            switch (MathOp)
            {
                case "+":
                    Result = numb1 + numb2;
                    break;

                case "-":
                    Result = numb1 - numb2;
                    break;

                case "x":
                    Result = numb1 * numb2;
                    break;

                case "/":
                    Result = numb1 / numb2;
                    break;

            }
            numb1 = Result;
            txtScreen.Text = Convert.ToString(Result);
        }
    }
}