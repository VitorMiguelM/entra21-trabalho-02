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
    public partial class Listar_de_carro : Form
    {
        public Listar_de_carro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_de_carros cadastroCarros = new Cadastro_de_carros();
            cadastroCarros.ShowDialog();
        }
    }
}
