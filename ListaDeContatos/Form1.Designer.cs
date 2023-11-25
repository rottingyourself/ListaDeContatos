namespace ListaDeContatos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            this.gbxCad = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblTelefoneCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbxEditar = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblTelefoneEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.gbxCad.SuspendLayout();
            this.gbxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(36, 21);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(728, 288);
            this.dgvContatos.TabIndex = 0;
            this.dgvContatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbxCad
            // 
            this.gbxCad.Controls.Add(this.textBox3);
            this.gbxCad.Controls.Add(this.textBox2);
            this.gbxCad.Controls.Add(this.txbNomeCad);
            this.gbxCad.Controls.Add(this.lblTelefoneCad);
            this.gbxCad.Controls.Add(this.lblEmailCad);
            this.gbxCad.Controls.Add(this.lblNomeCad);
            this.gbxCad.Controls.Add(this.btnCadastrar);
            this.gbxCad.Location = new System.Drawing.Point(36, 343);
            this.gbxCad.Name = "gbxCad";
            this.gbxCad.Size = new System.Drawing.Size(183, 167);
            this.gbxCad.TabIndex = 1;
            this.gbxCad.TabStop = false;
            this.gbxCad.Text = "Cadastrar";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(61, 28);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(100, 20);
            this.txbNomeCad.TabIndex = 4;
            this.txbNomeCad.TextChanged += new System.EventHandler(this.txbNomeCad_TextChanged);
            // 
            // lblTelefoneCad
            // 
            this.lblTelefoneCad.AutoSize = true;
            this.lblTelefoneCad.Location = new System.Drawing.Point(6, 83);
            this.lblTelefoneCad.Name = "lblTelefoneCad";
            this.lblTelefoneCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneCad.TabIndex = 3;
            this.lblTelefoneCad.Text = "Telefone:";
            this.lblTelefoneCad.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(20, 57);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 2;
            this.lblEmailCad.Text = "Email:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(17, 31);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 1;
            this.lblNomeCad.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(86, 120);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbxEditar
            // 
            this.gbxEditar.Controls.Add(this.textBox4);
            this.gbxEditar.Controls.Add(this.textBox5);
            this.gbxEditar.Controls.Add(this.txbNomeEdi);
            this.gbxEditar.Controls.Add(this.lblTelefoneEdi);
            this.gbxEditar.Controls.Add(this.lblEmailEdi);
            this.gbxEditar.Controls.Add(this.lblNomeEdi);
            this.gbxEditar.Controls.Add(this.btnEditar);
            this.gbxEditar.Location = new System.Drawing.Point(306, 343);
            this.gbxEditar.Name = "gbxEditar";
            this.gbxEditar.Size = new System.Drawing.Size(183, 167);
            this.gbxEditar.TabIndex = 7;
            this.gbxEditar.TabStop = false;
            this.gbxEditar.Text = "Editar";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(61, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(61, 28);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(100, 20);
            this.txbNomeEdi.TabIndex = 4;
            // 
            // lblTelefoneEdi
            // 
            this.lblTelefoneEdi.AutoSize = true;
            this.lblTelefoneEdi.Location = new System.Drawing.Point(6, 83);
            this.lblTelefoneEdi.Name = "lblTelefoneEdi";
            this.lblTelefoneEdi.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneEdi.TabIndex = 3;
            this.lblTelefoneEdi.Text = "Telefone:";
            // 
            // lblEmailEdi
            // 
            this.lblEmailEdi.AutoSize = true;
            this.lblEmailEdi.Location = new System.Drawing.Point(20, 57);
            this.lblEmailEdi.Name = "lblEmailEdi";
            this.lblEmailEdi.Size = new System.Drawing.Size(35, 13);
            this.lblEmailEdi.TabIndex = 2;
            this.lblEmailEdi.Text = "Email:";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Location = new System.Drawing.Point(17, 31);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(38, 13);
            this.lblNomeEdi.TabIndex = 1;
            this.lblNomeEdi.Text = "Nome:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(86, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.gbxEditar);
            this.Controls.Add(this.gbxCad);
            this.Controls.Add(this.dgvContatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Lista de Contatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.gbxCad.ResumeLayout(false);
            this.gbxCad.PerformLayout();
            this.gbxEditar.ResumeLayout(false);
            this.gbxEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.GroupBox gbxCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblTelefoneCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.GroupBox gbxEditar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblTelefoneEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.Button btnEditar;
    }
}

