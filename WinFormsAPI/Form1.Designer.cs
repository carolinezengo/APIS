namespace WinFormsAPI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnconsulta = new Button();
            btnaltera = new Button();
            btnadicionar = new Button();
            btnexcluir = new Button();
            btnbuscar = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            lblmensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnconsulta
            // 
            btnconsulta.Location = new Point(28, 23);
            btnconsulta.Name = "btnconsulta";
            btnconsulta.Size = new Size(75, 23);
            btnconsulta.TabIndex = 0;
            btnconsulta.Text = "Consultar";
            btnconsulta.UseVisualStyleBackColor = true;
            btnconsulta.Click += btnconsulta_Click;
            // 
            // btnaltera
            // 
            btnaltera.Location = new Point(109, 23);
            btnaltera.Name = "btnaltera";
            btnaltera.Size = new Size(75, 23);
            btnaltera.TabIndex = 1;
            btnaltera.Text = "Alterar";
            btnaltera.UseVisualStyleBackColor = true;
            btnaltera.Click += btnaltera_Click;
            // 
            // btnadicionar
            // 
            btnadicionar.Location = new Point(190, 23);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(75, 23);
            btnadicionar.TabIndex = 2;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // btnexcluir
            // 
            btnexcluir.Location = new Point(271, 23);
            btnexcluir.Name = "btnexcluir";
            btnexcluir.Size = new Size(75, 23);
            btnexcluir.TabIndex = 3;
            btnexcluir.Text = "Excluir";
            btnexcluir.UseVisualStyleBackColor = true;
            btnexcluir.Click += btnexcluir_Click;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(271, 71);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 4;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(472, 215);
            dataGridView1.TabIndex = 6;
            // 
            // lblmensagem
            // 
            lblmensagem.BorderStyle = BorderStyle.Fixed3D;
            lblmensagem.Location = new Point(28, 364);
            lblmensagem.Name = "lblmensagem";
            lblmensagem.Size = new Size(472, 23);
            lblmensagem.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 470);
            Controls.Add(lblmensagem);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(btnbuscar);
            Controls.Add(btnexcluir);
            Controls.Add(btnadicionar);
            Controls.Add(btnaltera);
            Controls.Add(btnconsulta);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consumir API";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnconsulta;
        private Button btnaltera;
        private Button btnadicionar;
        private Button btnexcluir;
        private Button btnbuscar;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label lblmensagem;
    }
}