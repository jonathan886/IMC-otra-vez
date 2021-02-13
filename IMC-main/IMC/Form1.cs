using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    
    public partial class IMC : Form
    {
        static info info = new info();
        static Operaciones operaciones = new Operaciones();
        public IMC()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPesolb_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPesoLB_Click(object sender, EventArgs e)
        {
            lblResKG1.Text = operaciones.Convertidor(double.Parse(txtPesolb.Text)).ToString();
        }

        private void txtPesolb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblresIMC.Text = operaciones.IMC(double.Parse(txtAltura.Text), (double.Parse(txtPeso.Text))).ToString();
            if (double.Parse(lblresIMC.Text)<18.5)
            {
                lblpesofinal.Text = ("Peso bajo");
            }
            if (double.Parse(lblresIMC.Text) > 18.5 && double.Parse(lblresIMC.Text) < 24.9 )
            {
                lblpesofinal.Text = ("Peso Ideal");
            }
            if (double.Parse(lblresIMC.Text) > 24.9 && double.Parse(lblresIMC.Text) < 29.9)
            {
                lblpesofinal.Text = ("Sobrepeso");
            }
            if (double.Parse(lblresIMC.Text) > 29.9 && double.Parse(lblresIMC.Text) < 34.9)
            {
                lblpesofinal.Text = ("Obesidad");
            }
            if (double.Parse(lblresIMC.Text) >= 35 )
            {
                lblpesofinal.Text = ("Obesidad severa");
            }
        }

        private void linklblForm2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            info.Show();
           
        }
    }
}
