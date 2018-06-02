namespace entra21_trabalho_02
{
    partial class Listar_PC
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
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvListaPeca = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gabinete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaVídeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fonte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaMãe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPeca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = global::entra21_trabalho_02.Properties.Resources.actualize_arrows_couple_in_circle;
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(900, 117);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(95, 44);
            this.btnAtualizar.TabIndex = 18;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Image = global::entra21_trabalho_02.Properties.Resources.delete;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeletar.Location = new System.Drawing.Point(1092, 117);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(89, 44);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::entra21_trabalho_02.Properties.Resources.edit__1_;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1001, 117);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 44);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvListaPeca
            // 
            this.dgvListaPeca.AllowUserToAddRows = false;
            this.dgvListaPeca.AllowUserToDeleteRows = false;
            this.dgvListaPeca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPeca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Gabinete,
            this.Processador,
            this.PlacaVídeo,
            this.RAM,
            this.HD,
            this.Fonte,
            this.PlacaMãe,
            this.Email,
            this.Telefone,
            this.Cidade});
            this.dgvListaPeca.Location = new System.Drawing.Point(144, 215);
            this.dgvListaPeca.Name = "dgvListaPeca";
            this.dgvListaPeca.ReadOnly = true;
            this.dgvListaPeca.Size = new System.Drawing.Size(1146, 313);
            this.dgvListaPeca.TabIndex = 14;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Gabinete
            // 
            this.Gabinete.HeaderText = "Gabinete";
            this.Gabinete.Name = "Gabinete";
            this.Gabinete.ReadOnly = true;
            // 
            // Processador
            // 
            this.Processador.HeaderText = "Processador";
            this.Processador.Name = "Processador";
            this.Processador.ReadOnly = true;
            // 
            // PlacaVídeo
            // 
            this.PlacaVídeo.HeaderText = "PlacaVídeo";
            this.PlacaVídeo.Name = "PlacaVídeo";
            this.PlacaVídeo.ReadOnly = true;
            // 
            // RAM
            // 
            this.RAM.HeaderText = "RAM";
            this.RAM.Name = "RAM";
            this.RAM.ReadOnly = true;
            // 
            // HD
            // 
            this.HD.HeaderText = "HD";
            this.HD.Name = "HD";
            this.HD.ReadOnly = true;
            // 
            // Fonte
            // 
            this.Fonte.HeaderText = "Fonte";
            this.Fonte.Name = "Fonte";
            this.Fonte.ReadOnly = true;
            // 
            // PlacaMãe
            // 
            this.PlacaMãe.HeaderText = "PlacaMãe";
            this.PlacaMãe.Name = "PlacaMãe";
            this.PlacaMãe.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = global::entra21_trabalho_02.Properties.Resources.plus;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(1187, 117);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(103, 44);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(602, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(688, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar";
            // 
            // Listar_PC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 639);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvListaPeca);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Listar_PC";
            this.Text = "Listar_PC";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPeca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvListaPeca;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gabinete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processador;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaVídeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fonte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaMãe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}