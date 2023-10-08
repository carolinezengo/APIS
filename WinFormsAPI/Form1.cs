using System.Windows.Forms;

namespace WinFormsAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnbuscar_Click(object sender, EventArgs e)
        {
            lblmensagem.Text = "Buscando, aguarde...";
            var produto = new Produto();
            var listaProduto = await produto.ObterProdutosAsync();
            dataGridView1.DataSource = listaProduto;

            ConfigurarGrade();
            lblmensagem.Text = "Lista Completa";

        }
        private void ConfigurarGrade()
        {

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView1.RowHeadersWidth = 25;

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Codigo";
            dataGridView1.Columns[2].HeaderText = "Descricao";
            dataGridView1.Columns[2].Width = 350;

            dataGridView1.Columns[3].HeaderText = "Un";
            dataGridView1.Columns[4].HeaderText = "IdCategoria";
            dataGridView1.Columns[5].HeaderText = "PrecoCusto";
            dataGridView1.Columns[6].HeaderText = "PrecoVenda";
            dataGridView1.Columns[7].HeaderText = "EstoqueMaximo";
            dataGridView1.Columns[8].HeaderText = "EstoqueMinimo";
            dataGridView1.Columns[9].HeaderText = "EstoqueSaldoInicial";
            dataGridView1.Columns[10].HeaderText = "EstoqueSaldoInicialData";
            dataGridView1.Columns[11].HeaderText = "Ativo";
            dataGridView1.Columns[12].HeaderText = "CadastroUsuario";
            dataGridView1.Columns[13].HeaderText = "CadastroData";
            dataGridView1.Columns[14].HeaderText = "Ativo";
            dataGridView1.Columns[15].HeaderText = "AlteradoUsario";
            dataGridView1.Columns[16].HeaderText = "AlteradoData";
            dataGridView1.Columns[17].HeaderText = "unNavigation";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            dataGridView1.Columns[11].Visible = false;

            dataGridView1.Columns[12].Visible = false;

            dataGridView1.Columns[13].Visible = false;

            dataGridView1.Columns[14].Visible = false;

            dataGridView1.Columns[15].Visible = false;

            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;


        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (var frm = new FrmProduto(id, Operacao.Consultar))
                    frm.ShowDialog();
            }
            else
                MessageBox.Show("Primeiro selecione um produto na grade!", "Avido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnaltera_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (var frm = new FrmProduto(id, Operacao.Alterar))
                    frm.ShowDialog();
            }
            else
                MessageBox.Show("Primeiro selecione um produto na grade!", "Avido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (var frm = new FrmProduto(id, Operacao.Adicionar))
                    frm.ShowDialog();
            }
            else
                MessageBox.Show("Primeiro selecione um produto na grade!", "Avido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (var frm = new FrmProduto(id, Operacao.Excluir))
                    frm.ShowDialog();
            }
            else
                MessageBox.Show("Primeiro selecione um produto na grade!", "Avido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}