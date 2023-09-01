

using System.Reflection.Metadata.Ecma335;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            {

            }
            InitializeComponent();
        }
        double numb1 = 0;
        double numb2 = 0;
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
            txtScreen.Text = txtScreen.Text + btn0.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (CheckNumb(numb1)== true)
            {
                int Index = txtScreen.Text.LastIndexOf(" ");
                numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                MultCal(MathOp, ref numb1);
            }
            else
            {
                numb1 = Convert.ToDouble(txtScreen.Text);
            }
            

            txtScreen.Text = Convert.ToString(numb1) + btnAdd.Text + " ";
            MathOp = "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (CheckNumb(numb1) == true)
            {
                int Index = txtScreen.Text.LastIndexOf(" ");
                numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                MultCal(MathOp, ref numb1);
            }
            else
            {
                numb1 = Convert.ToDouble(txtScreen.Text);
            }

            txtScreen.Text = Convert.ToString(numb1) + btnSub.Text + " ";
            MathOp = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (CheckNumb(numb1) == true)
            {
                int Index = txtScreen.Text.LastIndexOf(" ");
                numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                MultCal(MathOp, ref numb1);
            }
            else
            {
                numb1 = Convert.ToDouble(txtScreen.Text);
            }
            txtScreen.Text = Convert.ToString(numb1) + btnMultiply.Text + " ";
            MathOp = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (CheckNumb(numb1) == true)
            {
                int Index = txtScreen.Text.LastIndexOf(" ");
                numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                MultCal(MathOp, ref numb1);
            }
            else
            {
                numb1 = Convert.ToDouble(txtScreen.Text);
                
            }
            txtScreen.Text = Convert.ToString(numb1) + btnDivide.Text + " ";
            MathOp = "/";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Index = 0;
            
            switch (MathOp)
            {
                case "+":
                    Index = txtScreen.Text.LastIndexOf(" ");
                    numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                    Result = numb1 + numb2;
                    break;
                case "-":
                    Index = txtScreen.Text.LastIndexOf(" ");
                    numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                    Result = numb1 - numb2;
                    break;
                case "*":
                    Index = txtScreen.Text.LastIndexOf(" ");
                    numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                    Result = numb1 * numb2;
                    break;
                case "/":
                    Index = txtScreen.Text.LastIndexOf(" ");
                    numb2 = Convert.ToDouble(txtScreen.Text.Substring(Index));
                    Result = numb1 / numb2;
                    break;
            }
            txtScreen.Text = Convert.ToString(Result);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int i = txtScreen.Text.Length - 1;
            txtScreen.Text.Remove(i, 1);

        }
        
        private bool CheckNumb(double numb)        //Check if numb1 already been entered
        {
            if (numb == 0) return false;
            else return true;
        }
        
        private void MultCal(string Math, ref double numb1)
        {
            switch (Math)
            {
                case "+":
                    numb1 += numb2;
                break;
                case "-":
                    numb1 -= numb2;
                break;
                case "*":
                    numb1 *= numb2;
                break;
                case "/":
                    numb1 /= numb2;
                break;

            }               
            
        }

    }
}