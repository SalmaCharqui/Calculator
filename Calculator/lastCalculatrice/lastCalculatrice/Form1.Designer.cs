namespace lastCalculatrice
{
    partial class frmCalculatrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculatrice));
            this.pnlcalcul = new System.Windows.Forms.Panel();
            this.btnNegatif = new System.Windows.Forms.Button();
            this.btnegale = new System.Windows.Forms.Button();
            this.btnvergule = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnun = new System.Windows.Forms.Button();
            this.btnaddition = new System.Windows.Forms.Button();
            this.btntrois = new System.Windows.Forms.Button();
            this.btndeux = new System.Windows.Forms.Button();
            this.btnpourcentage = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnquatre = new System.Windows.Forms.Button();
            this.btnsoustraction = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btncinque = new System.Windows.Forms.Button();
            this.btnsept = new System.Windows.Forms.Button();
            this.btnmultiplication = new System.Windows.Forms.Button();
            this.btnneuf = new System.Windows.Forms.Button();
            this.btnhuit = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblafficher = new System.Windows.Forms.Label();
            this.pnlcalcul.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlcalcul
            // 
            this.pnlcalcul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlcalcul.Controls.Add(this.btnNegatif);
            this.pnlcalcul.Controls.Add(this.btnegale);
            this.pnlcalcul.Controls.Add(this.btnvergule);
            this.pnlcalcul.Controls.Add(this.btnzero);
            this.pnlcalcul.Controls.Add(this.btnun);
            this.pnlcalcul.Controls.Add(this.btnaddition);
            this.pnlcalcul.Controls.Add(this.btntrois);
            this.pnlcalcul.Controls.Add(this.btndeux);
            this.pnlcalcul.Controls.Add(this.btnpourcentage);
            this.pnlcalcul.Controls.Add(this.btndivision);
            this.pnlcalcul.Controls.Add(this.btnclear);
            this.pnlcalcul.Controls.Add(this.btnCE);
            this.pnlcalcul.Controls.Add(this.btnquatre);
            this.pnlcalcul.Controls.Add(this.btnsoustraction);
            this.pnlcalcul.Controls.Add(this.btnsix);
            this.pnlcalcul.Controls.Add(this.btncinque);
            this.pnlcalcul.Controls.Add(this.btnsept);
            this.pnlcalcul.Controls.Add(this.btnmultiplication);
            this.pnlcalcul.Controls.Add(this.btnneuf);
            this.pnlcalcul.Controls.Add(this.btnhuit);
            this.pnlcalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlcalcul.Location = new System.Drawing.Point(3, 79);
            this.pnlcalcul.Name = "pnlcalcul";
            this.pnlcalcul.Size = new System.Drawing.Size(357, 278);
            this.pnlcalcul.TabIndex = 0;
            // 
            // btnNegatif
            // 
            this.btnNegatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegatif.Location = new System.Drawing.Point(0, 217);
            this.btnNegatif.Name = "btnNegatif";
            this.btnNegatif.Size = new System.Drawing.Size(98, 59);
            this.btnNegatif.TabIndex = 34;
            this.btnNegatif.Text = "+/-";
            this.btnNegatif.UseVisualStyleBackColor = true;
            this.btnNegatif.Click += new System.EventHandler(this.btnNegatif_Click);
            // 
            // btnegale
            // 
            this.btnegale.Location = new System.Drawing.Point(272, 217);
            this.btnegale.Name = "btnegale";
            this.btnegale.Size = new System.Drawing.Size(85, 59);
            this.btnegale.TabIndex = 33;
            this.btnegale.Text = "=";
            this.btnegale.UseVisualStyleBackColor = true;
            this.btnegale.Click += new System.EventHandler(this.btnegale_Click);
            // 
            // btnvergule
            // 
            this.btnvergule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvergule.Location = new System.Drawing.Point(187, 217);
            this.btnvergule.Name = "btnvergule";
            this.btnvergule.Size = new System.Drawing.Size(92, 59);
            this.btnvergule.TabIndex = 32;
            this.btnvergule.Text = ",";
            this.btnvergule.UseVisualStyleBackColor = true;
            this.btnvergule.Click += new System.EventHandler(this.button_click);
            // 
            // btnzero
            // 
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(95, 217);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(95, 59);
            this.btnzero.TabIndex = 31;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.button_click);
            // 
            // btnun
            // 
            this.btnun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnun.Location = new System.Drawing.Point(0, 165);
            this.btnun.Name = "btnun";
            this.btnun.Size = new System.Drawing.Size(98, 59);
            this.btnun.TabIndex = 30;
            this.btnun.Text = "1";
            this.btnun.UseVisualStyleBackColor = true;
            this.btnun.Click += new System.EventHandler(this.button_click);
            // 
            // btnaddition
            // 
            this.btnaddition.Location = new System.Drawing.Point(272, 165);
            this.btnaddition.Name = "btnaddition";
            this.btnaddition.Size = new System.Drawing.Size(85, 59);
            this.btnaddition.TabIndex = 29;
            this.btnaddition.Text = "+";
            this.btnaddition.UseVisualStyleBackColor = true;
            this.btnaddition.Click += new System.EventHandler(this.operator_click);
            // 
            // btntrois
            // 
            this.btntrois.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrois.Location = new System.Drawing.Point(187, 165);
            this.btntrois.Name = "btntrois";
            this.btntrois.Size = new System.Drawing.Size(92, 59);
            this.btntrois.TabIndex = 28;
            this.btntrois.Text = "3";
            this.btntrois.UseVisualStyleBackColor = true;
            this.btntrois.Click += new System.EventHandler(this.button_click);
            // 
            // btndeux
            // 
            this.btndeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeux.Location = new System.Drawing.Point(95, 165);
            this.btndeux.Name = "btndeux";
            this.btndeux.Size = new System.Drawing.Size(95, 59);
            this.btndeux.TabIndex = 27;
            this.btndeux.Text = "2";
            this.btndeux.UseVisualStyleBackColor = true;
            this.btndeux.Click += new System.EventHandler(this.button_click);
            // 
            // btnpourcentage
            // 
            this.btnpourcentage.Location = new System.Drawing.Point(0, 0);
            this.btnpourcentage.Name = "btnpourcentage";
            this.btnpourcentage.Size = new System.Drawing.Size(98, 59);
            this.btnpourcentage.TabIndex = 26;
            this.btnpourcentage.Text = "%";
            this.btnpourcentage.UseVisualStyleBackColor = true;
            this.btnpourcentage.Click += new System.EventHandler(this.operator_click);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(272, 0);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(85, 59);
            this.btndivision.TabIndex = 25;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.operator_click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(187, 0);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(92, 59);
            this.btnclear.TabIndex = 24;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(95, 0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(95, 59);
            this.btnCE.TabIndex = 23;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnquatre
            // 
            this.btnquatre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquatre.Location = new System.Drawing.Point(0, 110);
            this.btnquatre.Name = "btnquatre";
            this.btnquatre.Size = new System.Drawing.Size(98, 59);
            this.btnquatre.TabIndex = 22;
            this.btnquatre.Text = "4";
            this.btnquatre.UseVisualStyleBackColor = true;
            this.btnquatre.Click += new System.EventHandler(this.button_click);
            // 
            // btnsoustraction
            // 
            this.btnsoustraction.Location = new System.Drawing.Point(272, 110);
            this.btnsoustraction.Name = "btnsoustraction";
            this.btnsoustraction.Size = new System.Drawing.Size(85, 59);
            this.btnsoustraction.TabIndex = 21;
            this.btnsoustraction.Text = "-";
            this.btnsoustraction.UseVisualStyleBackColor = true;
            this.btnsoustraction.Click += new System.EventHandler(this.operator_click);
            // 
            // btnsix
            // 
            this.btnsix.Location = new System.Drawing.Point(187, 110);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(92, 59);
            this.btnsix.TabIndex = 20;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.button_click);
            // 
            // btncinque
            // 
            this.btncinque.Location = new System.Drawing.Point(95, 110);
            this.btncinque.Name = "btncinque";
            this.btncinque.Size = new System.Drawing.Size(95, 59);
            this.btncinque.TabIndex = 19;
            this.btncinque.Text = "5";
            this.btncinque.UseVisualStyleBackColor = true;
            this.btncinque.Click += new System.EventHandler(this.button_click);
            // 
            // btnsept
            // 
            this.btnsept.Location = new System.Drawing.Point(0, 54);
            this.btnsept.Name = "btnsept";
            this.btnsept.Size = new System.Drawing.Size(98, 59);
            this.btnsept.TabIndex = 18;
            this.btnsept.Text = "7";
            this.btnsept.UseVisualStyleBackColor = true;
            this.btnsept.Click += new System.EventHandler(this.button_click);
            // 
            // btnmultiplication
            // 
            this.btnmultiplication.Location = new System.Drawing.Point(272, 54);
            this.btnmultiplication.Name = "btnmultiplication";
            this.btnmultiplication.Size = new System.Drawing.Size(85, 59);
            this.btnmultiplication.TabIndex = 17;
            this.btnmultiplication.Text = "*";
            this.btnmultiplication.UseVisualStyleBackColor = true;
            this.btnmultiplication.Click += new System.EventHandler(this.operator_click);
            // 
            // btnneuf
            // 
            this.btnneuf.Location = new System.Drawing.Point(187, 54);
            this.btnneuf.Name = "btnneuf";
            this.btnneuf.Size = new System.Drawing.Size(92, 59);
            this.btnneuf.TabIndex = 16;
            this.btnneuf.Text = "9";
            this.btnneuf.UseVisualStyleBackColor = true;
            this.btnneuf.Click += new System.EventHandler(this.button_click);
            // 
            // btnhuit
            // 
            this.btnhuit.Location = new System.Drawing.Point(95, 54);
            this.btnhuit.Name = "btnhuit";
            this.btnhuit.Size = new System.Drawing.Size(95, 59);
            this.btnhuit.TabIndex = 15;
            this.btnhuit.Text = "8";
            this.btnhuit.UseVisualStyleBackColor = true;
            this.btnhuit.Click += new System.EventHandler(this.button_click);
            // 
            // txtR
            // 
            this.txtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtR.Enabled = false;
            this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtR.Location = new System.Drawing.Point(3, 25);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(357, 48);
            this.txtR.TabIndex = 1;
            this.txtR.Text = "0";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblafficher
            // 
            this.lblafficher.BackColor = System.Drawing.SystemColors.Window;
            this.lblafficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafficher.Location = new System.Drawing.Point(3, -1);
            this.lblafficher.Name = "lblafficher";
            this.lblafficher.Size = new System.Drawing.Size(357, 23);
            this.lblafficher.TabIndex = 2;
            this.lblafficher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(370, 359);
            this.Controls.Add(this.lblafficher);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.pnlcalcul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculatrice";
            this.Text = "calculatrice";
            this.pnlcalcul.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlcalcul;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Button btnNegatif;
        private System.Windows.Forms.Button btnegale;
        private System.Windows.Forms.Button btnvergule;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnun;
        private System.Windows.Forms.Button btnaddition;
        private System.Windows.Forms.Button btntrois;
        private System.Windows.Forms.Button btndeux;
        private System.Windows.Forms.Button btnpourcentage;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnquatre;
        private System.Windows.Forms.Button btnsoustraction;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btncinque;
        private System.Windows.Forms.Button btnsept;
        private System.Windows.Forms.Button btnmultiplication;
        private System.Windows.Forms.Button btnneuf;
        private System.Windows.Forms.Button btnhuit;
        private System.Windows.Forms.Label lblafficher;
    }
}

