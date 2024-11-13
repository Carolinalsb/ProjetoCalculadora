namespace ProjetoCalculadora
{
    public partial class frmCalculadora : Form
    {

        decimal v1;
        decimal v2;
        decimal soma;


        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblSinal.Visible = false;
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblValor1.Visible = false;
            lblValor2.Visible = false;
            lblSinal.Visible = false;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 1;
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 2;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 3;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 4;
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 5;
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 6;
        }

        private void lbl8_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 8;
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 7;
        }

        private void lbl9_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 9;
        }

        private void lbl0_Click(object sender, EventArgs e)
        {

            var res = txtResultado.Text;
            txtResultado.Text = res + 0;
        }

        private void lblPonto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 0)
            {
                txtResultado.Text = txtResultado.Text + ",";
            }
            else
            {
                txtResultado.Text = "0,";

            }
        }

        private void lblSoma_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "+";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblIgual_Click(object sender, EventArgs e)
        {
            if (lblSinal.Text == "+")
            {
                v2 = Convert.ToDecimal(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 + v2;
                if (soma % 1 == 0)
                {
                    int arredondado = (int)soma;
                    txtResultado.Text = arredondado.ToString();
                }
                else
                {
                    txtResultado.Text = soma.ToString("0.0");
                }
            }
            else if (lblSinal.Text == "-")
            {
                v2 = Convert.ToDecimal(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 - v2;
                if (soma % 1 == 0)
                {
                    int arredondado = (int)soma;
                    txtResultado.Text = arredondado.ToString();
                }
                else
                {
                    txtResultado.Text = soma.ToString("0.0");
                }
            }
            else if (lblSinal.Text == "x")
            {
                v2 = Convert.ToDecimal(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 * v2;
                if (soma % 1 == 0)
                {
                    int arredondado = (int)soma;
                    txtResultado.Text = arredondado.ToString();
                }
                else
                {
                    txtResultado.Text = soma.ToString("0.0");
                }


            }
            else if (lblSinal.Text == "÷")
            {
                v2 = Convert.ToDecimal(txtResultado.Text);
                lblValor2.Visible = true;
                lblValor2.Text = v2.ToString();
                soma = v1 / v2;
                if (soma % 1 == 0)
                {
                    int arredondado = (int)soma;
                    txtResultado.Text = arredondado.ToString();
                }
                else
                {
                    txtResultado.Text = soma.ToString("0.0");
                }




            }
        }

        private void lblSubtracao_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "-";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblSinal_Click(object sender, EventArgs e)
        {

        }

        private void lblMultiplicacao_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "x";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void lblDivisao_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblSinal.Visible = true;
            lblSinal.Text = "÷";
            lblValor1.Visible = true;
            lblValor1.Text = v1.ToString();
        }

        private void txtResultado_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
            {
                e.Handled = true;

                if (lblValor2.Text.Length == 0)
                {
                    lblValor2.Text = txtResultado.Text;

                }
                else
                {
                    lblValor1.Text = lblValor2.Text;
                    lblValor2.Text = txtResultado.Text;
                    decimal val1 = Convert.ToDecimal(lblValor1.Text);
                    decimal val2 = Convert.ToDecimal(lblValor2.Text);
                    soma = val1 + val2;

                    if (soma % 1 == 0)
                    {
                        int arredondado = (int)soma;
                    }
                    else
                    {
                        txtResultado.Text = soma.ToString("0.0");
                    }
                }
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != '=')
            {
                e.Handled = true;
            }
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }
    }
}
