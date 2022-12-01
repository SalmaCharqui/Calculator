using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastCalculatrice
{
    public partial class frmCalculatrice: Form
    {
        public frmCalculatrice()
        {
            InitializeComponent();
        }
        
         private void Form1_Load(object sender, EventArgs e)
         {
             this.Width = pnlcalcul.Width+20;
             txtR.Width = this.Width-20;
         }


         
         

        



        bool estOperationPerforme =false;
        double resultvaleur = 0;
        String operationperforme = "";
         double memo;
        
          private void btnNegatif_Click(object sender, EventArgs e)
         {
             memo = (double.Parse(txtR.Text))*(-1);
             txtR.Text = memo.ToString();
         }


        private void button_click(object sender, EventArgs e)
        {
            if ((txtR.Text == "0") || (estOperationPerforme))
                txtR.Clear();

            estOperationPerforme = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            { 
               if(!txtR.Text.Contains("."))
                   txtR.Text = txtR.Text + button.Text;

            }else
            txtR.Text = txtR.Text + button.Text;


        }

        

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultvaleur != 0)
            {
                btnegale.PerformClick();
                operationperforme = button.Text;
                lblafficher.Text = resultvaleur + " " + operationperforme;
                estOperationPerforme = true;
            }
            else
            {

                operationperforme = button.Text;
                resultvaleur = Double.Parse(txtR.Text);
                lblafficher.Text = resultvaleur + " " + operationperforme;
                estOperationPerforme = true;
            }
        }
        
        private void btnegale_Click(object sender, EventArgs e)
        {
            switch (operationperforme)
            {
                case "+":
                    txtR.Text = (resultvaleur + Double.Parse(txtR.Text)).ToString();
                    break;
                case "-":
                    txtR.Text = (resultvaleur - Double.Parse(txtR.Text)).ToString();
                    break;
                case "*":
                    txtR.Text = (resultvaleur * Double.Parse(txtR.Text)).ToString();
                    break;
                case "/":
                    txtR.Text = (resultvaleur / Double.Parse(txtR.Text)).ToString();
                    break;
                case "%":
                    // txtR.Text = (resultvaleur / Double.Parse(txtR.Text)).ToString();
                    memo = (double.Parse(txtR.Text)) / (100);
                    txtR.Text = memo.ToString();
                    break;
                default:
                    break;
            }
            resultvaleur = Double.Parse(txtR.Text);
            lblafficher.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtR.Text = "0";
            resultvaleur = 0;
        }
        // }







    }
}
