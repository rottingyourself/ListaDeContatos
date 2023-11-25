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
            contatos.Nome = txbNomeProdCad.Text;
            contatos.Email = double.Parse(txbPrecoCad.Text);
            contatos.Telefone = usuario.Id;



            if (produto.CadastrarProduto() == true)
            {
                MessageBox.Show("produto cadastrado com sucesso!");
                // Limpar os campos:
                txbNomeProdCad.Clear();
                txbPrecoCad.Clear();
                cmbCategoriasCad.SelectedIndex = -1;
                // Atualizar o dgv:
                dgvProdutos.DataSource = produto.ListarProduto();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o produto!");
            }
        }
    }
}
