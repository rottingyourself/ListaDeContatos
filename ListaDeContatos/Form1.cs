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
using static System.Windows.Forms.LinkLabel;

namespace ListaDeContatos
{
    public partial class Form1 : Form
    {
        int idSelecionado = 0;

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
            // Ativar os grbs:
            gbxEditar.Enabled = true;

            // obter a linha clicada:
            int linhaSelecionada = dgvContatos.CurrentCell.RowIndex;

            // Armazenar os dados da linha seleciona em "linha" (tipo um vetor)
            var linha = dgvContatos.Rows[linhaSelecionada];

            txbNomeEdi.Text = linha.Cells[1].Value.ToString();
            txbTelefoneEdi.Text = linha.Cells[2].Value.ToString();
            txbEmailEdi.Text = linha.Cells[3].Value.ToString();
            


            // Salvar o id do selecionado na variavel global:
            idSelecionado = (int)linha.Cells[0].Value;
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
            contatos.Telefone = txbTelefoneCad.Text;
            contatos.Data_aniversario =  dateTimePickerCAD.Value;




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
            Contatos contatos = new Contatos();
            contatos.Id = idSelecionado;
            contatos.Nome = txbNomeEdi.Text;
            contatos.Email = txbEmailEdi.Text;
            contatos.Telefone = txbTelefoneEdi.Text;
            contatos.Data_aniversario = dateTimePickerEDI.Value;

            // Editar:
            if (contatos.Modificar() == true)
            {
                MessageBox.Show("Contato modificado!", "Sucesso!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                // Atualizar o dgv:
                dgvContatos.DataSource = contatos.ListarContato();
                // Limpar os campos da edição:
                txbNomeEdi.Clear();
                txbTelefoneEdi.Clear();
                txbEmailEdi.Clear();

            }
            else
            {
                MessageBox.Show("Falha ao modificar o contato!", "Falha!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void txbEmailEdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTelefoneEdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Contatos contatos = new Contatos();
            contatos.Id = idSelecionado;
            // Apagar:
            var r = MessageBox.Show("Tem certeza que deseja remover?", "Atenção!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Apagar:
                if (contatos.Apagar() == true)
                {
                    MessageBox.Show("Contato removido!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dgv:
                    dgvContatos.DataSource = contatos.ListarContato();
                    // Limpar os campos da edição:
                    txbEmailEdi.Clear();
                    txbNomeEdi.Clear();
                    txbTelefoneEdi.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto!", "Falha!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
    }

 

