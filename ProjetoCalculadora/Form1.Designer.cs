namespace ProjetoCalculadora
{
    partial class frmCalculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl7 = new Label();
            lblIgual = new Label();
            lblPonto = new Label();
            lbl0 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            panel1 = new Panel();
            txtResultado = new TextBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblValor2 = new Label();
            lblValor1 = new Label();
            lblSinal = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblSoma = new Label();
            lblSubtracao = new Label();
            lblMultiplicacao = new Label();
            lblDivisao = new Label();
            lblC = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lbl7, 0, 0);
            tableLayoutPanel1.Controls.Add(lblIgual, 2, 3);
            tableLayoutPanel1.Controls.Add(lblPonto, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl0, 0, 3);
            tableLayoutPanel1.Controls.Add(lbl3, 2, 2);
            tableLayoutPanel1.Controls.Add(lbl2, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl1, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl6, 2, 1);
            tableLayoutPanel1.Controls.Add(lbl5, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl4, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl9, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl8, 1, 0);
            tableLayoutPanel1.Location = new Point(2, 186);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(244, 325);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl7
            // 
            lbl7.Anchor = AnchorStyles.None;
            lbl7.AutoSize = true;
            lbl7.Cursor = Cursors.Hand;
            lbl7.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl7.ForeColor = Color.White;
            lbl7.Location = new Point(18, 17);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(45, 46);
            lbl7.TabIndex = 15;
            lbl7.Text = "7";
            lbl7.TextAlign = ContentAlignment.MiddleCenter;
            lbl7.Click += lbl7_Click;
            // 
            // lblIgual
            // 
            lblIgual.Anchor = AnchorStyles.None;
            lblIgual.AutoSize = true;
            lblIgual.Cursor = Cursors.Hand;
            lblIgual.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIgual.ForeColor = Color.White;
            lblIgual.Location = new Point(177, 261);
            lblIgual.Name = "lblIgual";
            lblIgual.Size = new Size(51, 46);
            lblIgual.TabIndex = 14;
            lblIgual.Text = "=";
            lblIgual.TextAlign = ContentAlignment.MiddleCenter;
            lblIgual.Click += lblIgual_Click;
            // 
            // lblPonto
            // 
            lblPonto.Anchor = AnchorStyles.None;
            lblPonto.AutoSize = true;
            lblPonto.Cursor = Cursors.Hand;
            lblPonto.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPonto.ForeColor = Color.White;
            lblPonto.Location = new Point(104, 261);
            lblPonto.Name = "lblPonto";
            lblPonto.Size = new Size(34, 46);
            lblPonto.TabIndex = 13;
            lblPonto.Text = ",";
            lblPonto.TextAlign = ContentAlignment.MiddleCenter;
            lblPonto.Click += lblPonto_Click;
            // 
            // lbl0
            // 
            lbl0.Anchor = AnchorStyles.None;
            lbl0.AutoSize = true;
            lbl0.Cursor = Cursors.Hand;
            lbl0.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0.ForeColor = Color.White;
            lbl0.Location = new Point(18, 261);
            lbl0.Name = "lbl0";
            lbl0.Size = new Size(45, 46);
            lbl0.TabIndex = 12;
            lbl0.Text = "0";
            lbl0.TextAlign = ContentAlignment.MiddleCenter;
            lbl0.Click += lbl0_Click;
            // 
            // lbl3
            // 
            lbl3.Anchor = AnchorStyles.None;
            lbl3.AutoSize = true;
            lbl3.Cursor = Cursors.Hand;
            lbl3.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3.ForeColor = Color.White;
            lbl3.Location = new Point(180, 179);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(45, 46);
            lbl3.TabIndex = 11;
            lbl3.Text = "3";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            lbl3.Click += lbl3_Click;
            // 
            // lbl2
            // 
            lbl2.Anchor = AnchorStyles.None;
            lbl2.AutoSize = true;
            lbl2.Cursor = Cursors.Hand;
            lbl2.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(99, 179);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(45, 46);
            lbl2.TabIndex = 10;
            lbl2.Text = "2";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            lbl2.Click += lbl2_Click;
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.None;
            lbl1.AutoSize = true;
            lbl1.Cursor = Cursors.Hand;
            lbl1.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(18, 179);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(45, 46);
            lbl1.TabIndex = 9;
            lbl1.Text = "1";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            lbl1.Click += lbl1_Click;
            // 
            // lbl6
            // 
            lbl6.Anchor = AnchorStyles.None;
            lbl6.AutoSize = true;
            lbl6.Cursor = Cursors.Hand;
            lbl6.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl6.ForeColor = Color.White;
            lbl6.Location = new Point(180, 98);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(45, 46);
            lbl6.TabIndex = 8;
            lbl6.Text = "6";
            lbl6.TextAlign = ContentAlignment.MiddleCenter;
            lbl6.Click += lbl6_Click;
            // 
            // lbl5
            // 
            lbl5.Anchor = AnchorStyles.None;
            lbl5.AutoSize = true;
            lbl5.Cursor = Cursors.Hand;
            lbl5.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5.ForeColor = Color.White;
            lbl5.Location = new Point(99, 98);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(45, 46);
            lbl5.TabIndex = 7;
            lbl5.Text = "5";
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            lbl5.Click += lbl5_Click;
            // 
            // lbl4
            // 
            lbl4.Anchor = AnchorStyles.None;
            lbl4.AutoSize = true;
            lbl4.Cursor = Cursors.Hand;
            lbl4.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4.ForeColor = Color.White;
            lbl4.Location = new Point(18, 98);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(45, 46);
            lbl4.TabIndex = 6;
            lbl4.Text = "4";
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            lbl4.Click += lbl4_Click;
            // 
            // lbl9
            // 
            lbl9.Anchor = AnchorStyles.None;
            lbl9.AutoSize = true;
            lbl9.Cursor = Cursors.Hand;
            lbl9.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl9.ForeColor = Color.White;
            lbl9.Location = new Point(180, 17);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(45, 46);
            lbl9.TabIndex = 5;
            lbl9.Text = "9";
            lbl9.TextAlign = ContentAlignment.MiddleCenter;
            lbl9.Click += lbl9_Click;
            // 
            // lbl8
            // 
            lbl8.Anchor = AnchorStyles.None;
            lbl8.AutoSize = true;
            lbl8.Cursor = Cursors.Hand;
            lbl8.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl8.ForeColor = Color.White;
            lbl8.Location = new Point(99, 17);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(45, 46);
            lbl8.TabIndex = 4;
            lbl8.Text = "8";
            lbl8.TextAlign = ContentAlignment.MiddleCenter;
            lbl8.Click += lbl8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(57, 8, 90);
            panel1.Controls.Add(txtResultado);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 184);
            panel1.TabIndex = 2;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(57, 8, 90);
            txtResultado.BorderStyle = BorderStyle.None;
            txtResultado.Font = new Font("MS Reference Sans Serif", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(0, 123);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(329, 58);
            txtResultado.TabIndex = 10;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.KeyDown += txtResultado_KeyDown;
            txtResultado.KeyPress += txtResultado_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.logout;
            pictureBox1.Location = new Point(302, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(lblValor2, 2, 0);
            tableLayoutPanel3.Controls.Add(lblValor1, 0, 0);
            tableLayoutPanel3.Controls.Add(lblSinal, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 57);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(326, 41);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Cursor = Cursors.Hand;
            lblValor2.Dock = DockStyle.Fill;
            lblValor2.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor2.ForeColor = Color.White;
            lblValor2.Location = new Point(219, 0);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(104, 41);
            lblValor2.TabIndex = 7;
            lblValor2.Text = "0";
            lblValor2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Cursor = Cursors.Hand;
            lblValor1.Dock = DockStyle.Fill;
            lblValor1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor1.ForeColor = Color.White;
            lblValor1.Location = new Point(3, 0);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(102, 41);
            lblValor1.TabIndex = 6;
            lblValor1.Text = "0";
            lblValor1.TextAlign = ContentAlignment.MiddleCenter;
            lblValor1.Click += lblValor1_Click;
            // 
            // lblSinal
            // 
            lblSinal.AutoSize = true;
            lblSinal.Cursor = Cursors.Hand;
            lblSinal.Dock = DockStyle.Fill;
            lblSinal.Font = new Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSinal.ForeColor = Color.White;
            lblSinal.Location = new Point(111, 0);
            lblSinal.Name = "lblSinal";
            lblSinal.Size = new Size(102, 41);
            lblSinal.TabIndex = 8;
            lblSinal.Text = "+";
            lblSinal.TextAlign = ContentAlignment.MiddleCenter;
            lblSinal.Click += lblSinal_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(57, 8, 75);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(lblSoma, 0, 4);
            tableLayoutPanel2.Controls.Add(lblSubtracao, 0, 3);
            tableLayoutPanel2.Controls.Add(lblMultiplicacao, 0, 2);
            tableLayoutPanel2.Controls.Add(lblDivisao, 0, 1);
            tableLayoutPanel2.Controls.Add(lblC, 0, 0);
            tableLayoutPanel2.Location = new Point(252, 186);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(82, 325);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblSoma
            // 
            lblSoma.Anchor = AnchorStyles.None;
            lblSoma.AutoSize = true;
            lblSoma.Cursor = Cursors.Hand;
            lblSoma.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoma.ForeColor = Color.White;
            lblSoma.Location = new Point(15, 269);
            lblSoma.Name = "lblSoma";
            lblSoma.Size = new Size(51, 46);
            lblSoma.TabIndex = 10;
            lblSoma.Text = "+";
            lblSoma.TextAlign = ContentAlignment.MiddleCenter;
            lblSoma.Click += lblSoma_Click;
            // 
            // lblSubtracao
            // 
            lblSubtracao.Anchor = AnchorStyles.None;
            lblSubtracao.AutoSize = true;
            lblSubtracao.Cursor = Cursors.Hand;
            lblSubtracao.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtracao.ForeColor = Color.White;
            lblSubtracao.Location = new Point(22, 204);
            lblSubtracao.Name = "lblSubtracao";
            lblSubtracao.Size = new Size(38, 46);
            lblSubtracao.TabIndex = 9;
            lblSubtracao.Text = "-";
            lblSubtracao.TextAlign = ContentAlignment.MiddleCenter;
            lblSubtracao.Click += lblSubtracao_Click;
            // 
            // lblMultiplicacao
            // 
            lblMultiplicacao.Anchor = AnchorStyles.None;
            lblMultiplicacao.AutoSize = true;
            lblMultiplicacao.Cursor = Cursors.Hand;
            lblMultiplicacao.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMultiplicacao.ForeColor = Color.White;
            lblMultiplicacao.Location = new Point(18, 139);
            lblMultiplicacao.Name = "lblMultiplicacao";
            lblMultiplicacao.Size = new Size(46, 46);
            lblMultiplicacao.TabIndex = 8;
            lblMultiplicacao.Text = "X";
            lblMultiplicacao.TextAlign = ContentAlignment.MiddleCenter;
            lblMultiplicacao.Click += lblMultiplicacao_Click;
            // 
            // lblDivisao
            // 
            lblDivisao.Anchor = AnchorStyles.None;
            lblDivisao.AutoSize = true;
            lblDivisao.Cursor = Cursors.Hand;
            lblDivisao.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDivisao.ForeColor = Color.White;
            lblDivisao.Location = new Point(15, 74);
            lblDivisao.Name = "lblDivisao";
            lblDivisao.Size = new Size(51, 46);
            lblDivisao.TabIndex = 7;
            lblDivisao.Text = "÷";
            lblDivisao.TextAlign = ContentAlignment.MiddleCenter;
            lblDivisao.Click += lblDivisao_Click;
            // 
            // lblC
            // 
            lblC.Anchor = AnchorStyles.None;
            lblC.AutoSize = true;
            lblC.Cursor = Cursors.Hand;
            lblC.Font = new Font("MS Reference Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblC.ForeColor = Color.White;
            lblC.Location = new Point(17, 9);
            lblC.Name = "lblC";
            lblC.Size = new Size(47, 46);
            lblC.TabIndex = 6;
            lblC.Text = "C";
            lblC.TextAlign = ContentAlignment.MiddleCenter;
            lblC.Click += lblC_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 10, 80);
            ClientSize = new Size(332, 512);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += frmCalculadora_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lblIgual;
        private Label lblPonto;
        private Label lbl0;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Label lbl6;
        private Label lbl5;
        private Label lbl4;
        private Label lbl9;
        private Label lbl8;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSoma;
        private Label lblSubtracao;
        private Label lblMultiplicacao;
        private Label lblDivisao;
        private Label lblC;
        private PictureBox pictureBox1;
        private TextBox txtResultado;
        private Label lbl7;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblValor2;
        private Label lblValor1;
        private Label lblSinal;
    }
}
