using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entra21_trabalho_02
{
    public partial class btnListar : Form
    {
        public btnListar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void btnCadastroCarrros_Click(object sender, EventArgs e)
        {
            Cadastro_de_carros cadastro_de_carros = new Cadastro_de_carros();
            cadastro_de_carros.Show();
        }

        private void btnCadastroMoveis_Click(object sender, EventArgs e)
        {
            Cadastro_de_móveis cadastro_de_moveis = new Cadastro_de_móveis();
            cadastro_de_moveis.Show();
        }

        private void btnCadastroComputadores_Click(object sender, EventArgs e)
        {
            Cadastro_de_computadores cadastro_de_cmputadores = new Cadastro_de_computadores();
            cadastro_de_cmputadores.Show();
        }

        private void btnCadstroRoupas_Click(object sender, EventArgs e)
        {
            Cadastro_de_roupas cadastro_de_roupas = new Cadastro_de_roupas();
            cadastro_de_roupas.Show();
        }
    }
}
