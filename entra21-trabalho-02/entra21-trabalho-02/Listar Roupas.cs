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
    public partial class Listar_Roupas : Form
    {
        public Listar_Roupas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_de_roupas cadastroroupas = new Cadastro_de_roupas();
            cadastroroupas.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualziarLista();
        }
        private void AtualziarLista()
        {
            dgvListaPeca.Rows.Clear();
            for (int i = 0; i < Program.roupas.Count; i++)
            {
                Roupas roupas = Program.roupas[i];
                dgvListaPeca.Rows.Add(new object[]{roupas.Nome,roupas.Tamanho,roupas.Altura,roupas.Email,roupas.Telefone,
                                                   roupas.Cidade,roupas.Estado,roupas.Marca,

                });
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Roupas roupas = Program.roupas[linhaSelecionada];
            //new Cadastro_de_roupas(roupas, linhaSelecionada).ShowDialog();


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if(dgvListaPeca.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma peça selecionada");
                return;
            }
            int linhaSelecionada = dgvListaPeca.CurrentRow.Index;
            Roupas roupas = Program.roupas[linhaSelecionada];

            DialogResult resultado = MessageBox.Show("Deseja apagar o registro?","AVISO",MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Program.roupas.RemoveAt(linhaSelecionada);
                AtualziarLista();
                MessageBox.Show("O registro foi apagado com sucesso");
            }
            else
            {
                MessageBox.Show("TA SAFE");
            }

        }
        

        

        

       

        

        

       
    }
}
