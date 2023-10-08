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
        public FrmProduto(int id, Operacao operacao)
        {
            InitializeComponent();
            _produto.id = id;
            _operacao= operacao;
            Despachante();

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private async void Despachante()
        {
            if(_operacao == Operacao.Consultar)
            {

            }
            else if(_operacao == Operacao.Alterar)
            {

            }
            else if(_operacao == Operacao.Adicionar)
            {

            }
            else if(_operacao == Operacao.Excluir)
            {

            }
        }
    }
}
