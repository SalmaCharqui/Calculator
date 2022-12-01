namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultat = 0;
       // string operationPerforme = "";
        bool estOpertionPerforme = false;
        double premiernbr;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            if((textBoxAffichage.Text =="0") || (estOpertionPerforme))
                textBoxAffichage.Clear();
            estOpertionPerforme = false;
            Button button=(Button)sender;
            if(button.Text==".")
            {
                if (!textBoxAffichage.Text.Contains("."))
                    textBoxAffichage.Text = textBoxAffichage.Text + button.Text;
            }else
            textBoxAffichage.Text = textBoxAffichage.Text + button.Text;
        }
      private void btnclearEntree_Click(object sender, EventArgs e)
        {
            textBoxAffichage.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxAffichage.Text = "0";
            resultat = 0;
        }

        private void btnaddition_Click(object sender, EventArgs e)
        {
            try
            {
                premiernbr = Convert.ToDouble(textBoxAffichage.Text);
                textBoxAffichage.Text = "0";
                operation = "+";
            }catch(Exception ex)
            {
                MessageBox.Show("erreur");
            }
        }

        private void btnsoustraction_Click(object sender, EventArgs e)
        {
            premiernbr = Convert.ToDouble(textBoxAffichage.Text);
            textBoxAffichage.Text = "0";
            operation = "-";

        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            premiernbr = Convert.ToDouble(textBoxAffichage.Text);
            textBoxAffichage.Text = "0";
            operation = "*";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            premiernbr = Convert.ToDouble(textBoxAffichage.Text);
            textBoxAffichage.Text = "0";
            operation = "/";
        }

        private void btnegale_Click(object sender, EventArgs e)
        {
            try { 
            double deuxiemenbr;
            double resultat;
            deuxiemenbr = Convert.ToDouble(textBoxAffichage.Text);
            if (operation == "+")
            {
                resultat = (premiernbr + deuxiemenbr);
                textBoxAffichage.Text = Convert.ToString(resultat);
                premiernbr = resultat;
            }
            if (operation == "-")
            {
                resultat = (premiernbr - deuxiemenbr);
                textBoxAffichage.Text = Convert.ToString(resultat);
                premiernbr = resultat;
            }
            if (operation == "*")
            {
                resultat = (premiernbr * deuxiemenbr);
                textBoxAffichage.Text = Convert.ToString(resultat);
                premiernbr = resultat;
            }
            if (operation == "/")
            {
                if (deuxiemenbr == 0)
                {
                    textBoxAffichage.Text = "impossible de diviser sur 0";
                }
                else
                {
                    resultat = (premiernbr / deuxiemenbr);
                    textBoxAffichage.Text = Convert.ToString(resultat);
                    premiernbr = resultat;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur");
            }
        }
        private void textBoxAffichage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}