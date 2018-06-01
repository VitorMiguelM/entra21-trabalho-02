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
    public partial class Listar_PC : Form
    {
        public Listar_PC()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_de_computadores cadastropc = new Cadastro_de_computadores();
            cadastropc.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualziarLista();
        }
        private void AtualziarLista()
        {
            dgvListaPeca.Rows.Clear();
            for (int i = 0; i < Program.computadores.Count; i++)
			{
			 Computador computador = Program.computadores[i];
                dgvListaPeca.Rows.Add(new object[]{
                                      computador.Nome,computador.Gabinete,computador.Processador,computador.PlacaDeVideo,
                                      computador.RAM,computador.HD,computador.Fonte,computador.PlacaMae,computador.Email,
                                      computador.Telefone,computador.Cidade}
            );
			}

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma peça selecionada");
                return;
            }

            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Computador computador = Program.computadores[linhaSelecionada];
            //new Cadastro_de_computadores(computador, linhaSelecionada).ShowDialog();


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if(dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada");
                return;
            }

            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Computador computador = Program.computadores[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja mesmo apagar a linha selecionada?","AVISO",MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.computadores.RemoveAt(linhaSelecionada);
                AtualziarLista();
                MessageBox.Show("Registro apagado com sucesso XD");
            }
            else
            {
                MessageBox.Show("Ta seguro,Ta SAFE");
            }





        }

       

    }
    }

