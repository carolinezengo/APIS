namespace WinFormsAPI
{
    partial class FrmProduto
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
            TxtId = new TextBox();
            TxtDescricao = new TextBox();
            TxtCusto = new TextBox();
            TxtVenda = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            btnSalvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // TxtId
            // 
            TxtId.Location = new Point(98, 37);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(132, 23);
            TxtId.TabIndex = 0;
            // 
            // TxtDescricao
            // 
            TxtDescricao.Location = new Point(98, 66);
            TxtDescricao.Name = "TxtDescricao";
            TxtDescricao.Size = new Size(246, 23);
            TxtDescricao.TabIndex = 1;
            // 
            // TxtCusto
            // 
            TxtCusto.Location = new Point(98, 174);
            TxtCusto.Name = "TxtCusto";
            TxtCusto.Size = new Size(132, 23);
            TxtCusto.TabIndex = 2;
            // 
            // TxtVenda
            // 
            TxtVenda.Location = new Point(98, 213);
            TxtVenda.Name = "TxtVenda";
            TxtVenda.Size = new Size(132, 23);
            TxtVenda.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(98, 136);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(246, 23);
            comboBox2.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.Control;
            btnSalvar.Location = new Point(173, 255);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 37);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 8;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 110);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 9;
            label3.Text = "Un";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 139);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 182);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 11;
            label5.Text = "Preço de Custo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 216);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Preço de Venda";
            // 
            // lblMensagem
            // 
            lblMensagem.BorderStyle = BorderStyle.Fixed3D;
            lblMensagem.Location = new Point(4, 294);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(360, 23);
            lblMensagem.TabIndex = 13;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 318);
            Controls.Add(lblMensagem);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalvar);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(TxtVenda);
            Controls.Add(TxtCusto);
            Controls.Add(TxtDescricao);
            Controls.Add(TxtId);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtId;
        private TextBox TxtDescricao;
        private TextBox TxtCusto;
        private TextBox TxtVenda;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button btnSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblMensagem;
    }
}