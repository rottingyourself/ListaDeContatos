using System;

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
            this.lblNiverCad = new System.Windows.Forms.Label();
            this.txbTelefoneCad = new System.Windows.Forms.TextBox();
            this.txbEmailCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblTelefoneCad = new System.Windows.Forms.Label();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbxEditar = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEDI = new System.Windows.Forms.DateTimePicker();
            this.lblNiverEdi = new System.Windows.Forms.Label();
            this.txbTelefoneEdi = new System.Windows.Forms.TextBox();
            this.txbEmailEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblTelefoneEdi = new System.Windows.Forms.Label();
            this.lblEmailEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dateTimePickerCAD = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.gbxCad.SuspendLayout();
            this.gbxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(17, 21);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(554, 288);
            this.dgvContatos.TabIndex = 0;
            this.dgvContatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbxCad
            // 
            this.gbxCad.Controls.Add(this.dateTimePickerCAD);
            this.gbxCad.Controls.Add(this.lblNiverCad);
            this.gbxCad.Controls.Add(this.txbTelefoneCad);
            this.gbxCad.Controls.Add(this.txbEmailCad);
            this.gbxCad.Controls.Add(this.txbNomeCad);
            this.gbxCad.Controls.Add(this.lblTelefoneCad);
            this.gbxCad.Controls.Add(this.lblEmailCad);
            this.gbxCad.Controls.Add(this.lblNomeCad);
            this.gbxCad.Controls.Add(this.btnCadastrar);
            this.gbxCad.Location = new System.Drawing.Point(17, 332);
            this.gbxCad.Name = "gbxCad";
            this.gbxCad.Size = new System.Drawing.Size(183, 167);
            this.gbxCad.TabIndex = 1;
            this.gbxCad.TabStop = false;
            this.gbxCad.Text = "Cadastrar";
            // 
            // lblNiverCad
            // 
            this.lblNiverCad.AutoSize = true;
            this.lblNiverCad.Location = new System.Drawing.Point(3, 109);
            this.lblNiverCad.Name = "lblNiverCad";
            this.lblNiverCad.Size = new System.Drawing.Size(62, 13);
            this.lblNiverCad.TabIndex = 8;
            this.lblNiverCad.Text = "Aniversário:";
            // 
            // txbTelefoneCad
            // 
            this.txbTelefoneCad.Location = new System.Drawing.Point(68, 80);
            this.txbTelefoneCad.Name = "txbTelefoneCad";
            this.txbTelefoneCad.Size = new System.Drawing.Size(100, 20);
            this.txbTelefoneCad.TabIndex = 6;
            this.txbTelefoneCad.TextChanged += new System.EventHandler(this.txbTelefoneCad_TextChanged);
            // 
            // txbEmailCad
            // 
            this.txbEmailCad.Location = new System.Drawing.Point(68, 54);
            this.txbEmailCad.Name = "txbEmailCad";
            this.txbEmailCad.Size = new System.Drawing.Size(100, 20);
            this.txbEmailCad.TabIndex = 5;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Location = new System.Drawing.Point(68, 28);
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
            this.btnCadastrar.Location = new System.Drawing.Point(86, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbxEditar
            // 
            this.gbxEditar.Controls.Add(this.dateTimePickerEDI);
            this.gbxEditar.Controls.Add(this.lblNiverEdi);
            this.gbxEditar.Controls.Add(this.txbTelefoneEdi);
            this.gbxEditar.Controls.Add(this.txbEmailEdi);
            this.gbxEditar.Controls.Add(this.txbNomeEdi);
            this.gbxEditar.Controls.Add(this.lblTelefoneEdi);
            this.gbxEditar.Controls.Add(this.lblEmailEdi);
            this.gbxEditar.Controls.Add(this.lblNomeEdi);
            this.gbxEditar.Controls.Add(this.btnEditar);
            this.gbxEditar.Location = new System.Drawing.Point(388, 332);
            this.gbxEditar.Name = "gbxEditar";
            this.gbxEditar.Size = new System.Drawing.Size(183, 167);
            this.gbxEditar.TabIndex = 7;
            this.gbxEditar.TabStop = false;
            this.gbxEditar.Text = "Editar";
            // 
            // dateTimePickerEDI
            // 
            this.dateTimePickerEDI.Location = new System.Drawing.Point(71, 107);
            this.dateTimePickerEDI.Name = "dateTimePickerEDI";
            this.dateTimePickerEDI.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEDI.TabIndex = 11;
            // 
            // lblNiverEdi
            // 
            this.lblNiverEdi.AutoSize = true;
            this.lblNiverEdi.Location = new System.Drawing.Point(6, 107);
            this.lblNiverEdi.Name = "lblNiverEdi";
            this.lblNiverEdi.Size = new System.Drawing.Size(62, 13);
            this.lblNiverEdi.TabIndex = 10;
            this.lblNiverEdi.Text = "Aniversário:";
            // 
            // txbTelefoneEdi
            // 
            this.txbTelefoneEdi.Location = new System.Drawing.Point(71, 80);
            this.txbTelefoneEdi.Name = "txbTelefoneEdi";
            this.txbTelefoneEdi.Size = new System.Drawing.Size(100, 20);
            this.txbTelefoneEdi.TabIndex = 6;
            this.txbTelefoneEdi.TextChanged += new System.EventHandler(this.txbTelefoneEdi_TextChanged);
            // 
            // txbEmailEdi
            // 
            this.txbEmailEdi.Location = new System.Drawing.Point(71, 54);
            this.txbEmailEdi.Name = "txbEmailEdi";
            this.txbEmailEdi.Size = new System.Drawing.Size(100, 20);
            this.txbEmailEdi.TabIndex = 5;
            this.txbEmailEdi.TextChanged += new System.EventHandler(this.txbEmailEdi_TextChanged);
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Location = new System.Drawing.Point(71, 28);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(100, 20);
            this.txbNomeEdi.TabIndex = 4;
            this.txbNomeEdi.TextChanged += new System.EventHandler(this.txbNomeEdi_TextChanged);
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
            this.btnEditar.Location = new System.Drawing.Point(86, 130);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(260, 409);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // dateTimePickerCAD
            // 
            this.dateTimePickerCAD.Location = new System.Drawing.Point(68, 106);
            this.dateTimePickerCAD.Name = "dateTimePickerCAD";
            this.dateTimePickerCAD.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerCAD.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 554);
            this.Controls.Add(this.btnApagar);
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

        private void txbNomeEdi_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatos;
        private System.Windows.Forms.GroupBox gbxCad;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.TextBox txbTelefoneCad;
        private System.Windows.Forms.TextBox txbEmailCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblTelefoneCad;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.GroupBox gbxEditar;
        private System.Windows.Forms.TextBox txbTelefoneEdi;
        private System.Windows.Forms.TextBox txbEmailEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblTelefoneEdi;
        private System.Windows.Forms.Label lblEmailEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblNiverCad;
        private System.Windows.Forms.Label lblNiverEdi;
        private System.Windows.Forms.DateTimePicker dateTimePickerCAD;
        private System.Windows.Forms.DateTimePicker dateTimePickerEDI;
    }
}

