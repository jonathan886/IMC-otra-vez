namespace IMC
{
    partial class IMC
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMC));
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesolb = new System.Windows.Forms.TextBox();
            this.lblResKG = new System.Windows.Forms.Label();
            this.lblResKG1 = new System.Windows.Forms.Label();
            this.buttonPesoLB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblresIMC = new System.Windows.Forms.Label();
            this.lblpesofinal = new System.Windows.Forms.Label();
            this.linklblForm2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(203, 129);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(53, 27);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            this.lblAltura.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(216, 81);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(43, 27);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(716, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(73, 10);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPeso.Location = new System.Drawing.Point(272, 126);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(149, 28);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAltura.Location = new System.Drawing.Point(272, 79);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(149, 28);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "¿No sabes tu peso en kilogramos?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPesolb
            // 
            this.txtPesolb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesolb.Location = new System.Drawing.Point(191, 395);
            this.txtPesolb.Name = "txtPesolb";
            this.txtPesolb.Size = new System.Drawing.Size(53, 28);
            this.txtPesolb.TabIndex = 7;
            this.txtPesolb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesolb.TextChanged += new System.EventHandler(this.txtPesolb_TextChanged);
            this.txtPesolb.Enter += new System.EventHandler(this.txtPesolb_Enter);
            // 
            // lblResKG
            // 
            this.lblResKG.AutoSize = true;
            this.lblResKG.Location = new System.Drawing.Point(288, 392);
            this.lblResKG.Name = "lblResKG";
            this.lblResKG.Size = new System.Drawing.Size(0, 27);
            this.lblResKG.TabIndex = 8;
            // 
            // lblResKG1
            // 
            this.lblResKG1.AutoSize = true;
            this.lblResKG1.Location = new System.Drawing.Point(250, 392);
            this.lblResKG1.Name = "lblResKG1";
            this.lblResKG1.Size = new System.Drawing.Size(15, 27);
            this.lblResKG1.TabIndex = 9;
            this.lblResKG1.Text = ".";
            this.lblResKG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPesoLB
            // 
            this.buttonPesoLB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonPesoLB.Location = new System.Drawing.Point(12, 389);
            this.buttonPesoLB.Name = "buttonPesoLB";
            this.buttonPesoLB.Size = new System.Drawing.Size(173, 40);
            this.buttonPesoLB.TabIndex = 10;
            this.buttonPesoLB.Text = "Conviertelo aquí:";
            this.buttonPesoLB.UseVisualStyleBackColor = true;
            this.buttonPesoLB.Click += new System.EventHandler(this.buttonPesoLB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "m";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(284, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblresIMC
            // 
            this.lblresIMC.AutoSize = true;
            this.lblresIMC.Location = new System.Drawing.Point(337, 233);
            this.lblresIMC.Name = "lblresIMC";
            this.lblresIMC.Size = new System.Drawing.Size(21, 27);
            this.lblresIMC.TabIndex = 14;
            this.lblresIMC.Text = "0";
            this.lblresIMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpesofinal
            // 
            this.lblpesofinal.AutoSize = true;
            this.lblpesofinal.Location = new System.Drawing.Point(324, 269);
            this.lblpesofinal.Name = "lblpesofinal";
            this.lblpesofinal.Size = new System.Drawing.Size(15, 27);
            this.lblpesofinal.TabIndex = 15;
            this.lblpesofinal.Text = ".";
            this.lblpesofinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linklblForm2
            // 
            this.linklblForm2.AutoSize = true;
            this.linklblForm2.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linklblForm2.Location = new System.Drawing.Point(403, 402);
            this.linklblForm2.Name = "linklblForm2";
            this.linklblForm2.Size = new System.Drawing.Size(273, 27);
            this.linklblForm2.TabIndex = 16;
            this.linklblForm2.TabStop = true;
            this.linklblForm2.Text = "Para saber mas información, de clic aqui.";
            this.linklblForm2.VisitedLinkColor = System.Drawing.Color.Red;
            this.linklblForm2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblForm2_LinkClicked);
            // 
            // IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(678, 439);
            this.Controls.Add(this.linklblForm2);
            this.Controls.Add(this.lblpesofinal);
            this.Controls.Add(this.lblresIMC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPesoLB);
            this.Controls.Add(this.lblResKG1);
            this.Controls.Add(this.lblResKG);
            this.Controls.Add(this.txtPesolb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "IMC";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesolb;
        private System.Windows.Forms.Label lblResKG;
        private System.Windows.Forms.Label lblResKG1;
        private System.Windows.Forms.Button buttonPesoLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblresIMC;
        private System.Windows.Forms.Label lblpesofinal;
        private System.Windows.Forms.LinkLabel linklblForm2;
    }
}

