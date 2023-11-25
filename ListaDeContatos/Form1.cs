using ListaDeContatos.Classes.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeContatos
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            Contatos contatos = new Contatos();
            dgvContatos.DataSource = contatos.ListarTudo();

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbNomeCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Instanciar o usuário:
            Contatos contatos = new Contatos();
            // Obter os valores dos campos:
            contatos.Nome = txbNomeCad.Text;
            contatos.Email = txbTelefoneCad.Text;
            contatos.Telefone = int.Parse(txbTelefoneCad.Text);



            if (contatos.Cadastrar() == true)
            {
                MessageBox.Show("Contato cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeCad.Clear();
                txbEmailCad.Clear();
                txbTelefoneCad.Clear();
                // Atualizar o dgv:
                dgvContatos.DataSource = contatos.ListarTudo();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o contato!");
            }
        }

        private void txbTelefoneCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
