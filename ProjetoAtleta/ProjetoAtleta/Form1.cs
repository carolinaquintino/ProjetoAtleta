using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;
            int idade;

            altura = double.Parse(txtAltura.Text);
            peso = double.Parse(txtPeso.Text);
            idade = int.Parse(txtIdade.Text);

            Atleta atleta = new Atleta();
            imc = peso / (altura * altura);
            if (txtNome.Text == "")
            {
                MessageBox.Show("Você deve inserir o nome!");
            }
            else if(altura < 0)
            {
                MessageBox.Show("O valor da altura deve ser positivo");
            }
            else if(idade < 0)
            {
                MessageBox.Show("O valor da idade deve ser positivo");
            }
            else if (peso < 0)
            {
                MessageBox.Show("O valor do peso deve ser positivo");
            }
            else
            {
                txtResultado.Text = "O IMC é " + imc.ToString("F");
            }
        }
    }
}
