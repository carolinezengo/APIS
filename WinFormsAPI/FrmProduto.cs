using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAPI
{
    public partial class FrmProduto : Form
    {
        Produto _produto = new Produto();
        Operacao _operacao = new Operacao();
        Categoria _categoria = new Categoria();
        UnidadeMedida _unidadeMedida = new UnidadeMedida();
        public FrmProduto(int id, Operacao operacao)
        {
            InitializeComponent();
            _produto.id = id;
            _operacao = operacao;
            Despachante();

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private async void Despachante()
        {
            await PopularUnidadeMedida();
            await PopularCategoria();

            if (_operacao == Operacao.Consultar)
            {
                _produto = await _produto.ObterProdutoAsync(_produto.id);
                if (_produto != null)

                    MostrarProduto(_produto);
                BloquearControles(true);
            }
            else if (_operacao == Operacao.Alterar)

            {
                btnSalvar.Visible = true;
                _produto = await _produto.ObterProdutoAsync(_produto.id);
                if (_produto != null)
                    MostrarProduto(_produto);

            }
            else if (_operacao == Operacao.Adicionar)
            {
                _produto = await _produto.ObterProdutoAsync(_produto.id);
                btnSalvar.Visible = true;
            }
            else if (_operacao == Operacao.Excluir)
            {
                _produto = await _produto.ObterProdutoAsync(_produto.id);
                if (_produto != null)
                    MostrarProduto(_produto);
                BloquearControles(true);
                btnexcluir.Visible = true;

            }
        }
        private void MostrarProduto(Produto produto)
        {
            TxtId.Text = Convert.ToInt32(_produto.id).ToString();
            TxtDescricao.Text = _produto.descricao.ToString();
            TxtCusto.Text = Convert.ToDecimal(_produto.precoCusto).ToString();
            TxtVenda.Text = Convert.ToDecimal(_produto.precoVenda).ToString();
            comboBox1.SelectedValue = produto.un;
            comboBox2.SelectedValue = produto.idCategoria;



        }

        private async Task<bool> PopularUnidadeMedida()
        {
            List<UnidadeMedida> lista = await new UnidadeMedida().ObterUnidadeMedidasAsync();
            comboBox1.ValueMember = "sigla";
            comboBox1.DisplayMember = "descricao";
            comboBox1.DataSource = lista;
            comboBox1.SelectedIndex = -1;
            return true;
        }

        private async Task<bool> PopularCategoria()
        {
            List<Categoria> lista = await new Categoria().ObterCategoriaAsync();
            comboBox2.ValueMember = "id";
            comboBox2.DisplayMember = "descricao";
            comboBox2.DataSource = lista;
            comboBox2.SelectedIndex = -1;
            return true;
        }

        private void BloquearControles(bool travar)
        {
            TxtDescricao.Enabled = !travar;
            comboBox1.Enabled = !travar;
            comboBox2.Enabled = !travar;
            TxtCusto.Enabled = !travar;
            TxtVenda.Enabled = !travar;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {

        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            _produto.id = Convert.ToInt32("0" + TxtId.Text);
            _produto.descricao = TxtDescricao.Text;
            _produto.un = comboBox1.SelectedValue.ToString();
            _produto.idCategoria = (int)comboBox2.SelectedValue;
            _produto.precoCusto = Convert.ToDecimal(TxtCusto.Text);
            _produto.precoVenda = Convert.ToDecimal(TxtVenda.Text);

            if(_produto.id == 0)
            {
                var produto = await _produto.AdicionarProdutoAsync(_produto);
                if (_produto.id > 0)
                {
                    MessageBox.Show("Salvou com ID: " + _produto.id);
                    Close();

                }
                else
                    MessageBox.Show("Falha ao tentar Salvar!");

            }
            else
            {
                bool ok = await _produto.AtualizarProdutoAsync(_produto.id, _produto);
                if (ok)
                {
                    MessageBox.Show("Salvou com sucesso!");
                    Close();
                }
                else
                    MessageBox.Show("Falaha ao Salvar!");
            }
        }
    }
}
