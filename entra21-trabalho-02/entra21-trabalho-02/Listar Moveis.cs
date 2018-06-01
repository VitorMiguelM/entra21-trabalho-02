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
    public partial class Listar_Moveis : Form
    {
        public Listar_Moveis()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_de_móveis cadastromoveis = new Cadastro_de_móveis();
            cadastromoveis.ShowDialog();
        }

        

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarLista();
        }
        private void AtualizarLista()
        {
            dgvListaPeca.Rows.Clear();
            for (int i = 0; i < Program.movel.Count; i++)
            {
                Moveis movel = Program.movel[i];
                dgvListaPeca.Rows.Add(new object[]{
                                       movel.nome,movel.Endereco,movel.preco,movel.tipoMaterial,movel.peso,movel.altura,
                                       movel.email,movel.macho,movel.mulher,movel.RG,movel.telefone,movel.cidade,movel.estado,
                                       movel.marca
 
                });
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Não tem nehuma linha selecionada");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Moveis movel = Program.movel[linhaSelecionada];
            new Cadastro_de_móveis(movel, linhaSelecionada).ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma peça selecionada");
                return;
            }

            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Moveis movel = Program.movel[linhaSelecionada];
            DialogResult resultado = MessageBox.Show("Deseja apagar o registro?", "AVISO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Program.movel.RemoveAt(linhaSelecionada);
                AtualizarLista();
                MessageBox.Show("Registro apagado com sucesso");
            }
            else
            {
                MessageBox.Show("RELAXA ,ta safe");
            }
        }

       

        


        
    }
}
