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

       

        private void AtualizarLista()
        {

            dgvListaPeca.Rows.Clear();
            for (int i = 0; i < Program.carro.Count; i++)
            {
                Carros carro = Program.carro[i];
                dgvListaPeca.Rows.Add(new object[] { 
                                                    carro.NomeDaPessoa, carro.Marca, carro.Placa, carro.CPF, carro.RG,
                                                    carro.Telefone,carro.Altura,carro.Peso,carro.Cidade,carro.Idade,
                                                    carro,carro.Email,carro.Profissao,carro.Estado});
            }


        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void Listar_de_carro_Load(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nçao tem nenhuma linha selecionada");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Carros carros = Program.carro[linhaSelecionada];
            // new Cadastro_de_carros(carros, linhaSelecionada).ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não tem nenhuma peça selecionada");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            DialogResult resultado = MessageBox.Show("Deseja apagar O registro?","AVISO",MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.carro.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("O registro foi apagado");
            }
            else
            {
                MessageBox.Show("Ta tranquilho,ta favoravel...Salvo");
            }








        }

        
    }
}
