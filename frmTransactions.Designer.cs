namespace Gestion_Compte_Clients
{
    partial class frmTransactions
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            label1 = new Label();
            txtMontant = new TextBox();
            label2 = new Label();
            dtTransaction = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            transactionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compteIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeTransactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            montantDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTransactionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            transactionsBindingSource = new BindingSource(components);
            button2 = new Button();
            button1 = new Button();
            rbDepot = new RadioButton();
            rbRetrait = new RadioButton();
            txtNumClient = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 129);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "Montant :";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(143, 129);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(376, 31);
            txtMontant.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 189);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 4;
            label2.Text = "Type de transaction :";
            // 
            // dtTransaction
            // 
            dtTransaction.Location = new Point(177, 243);
            dtTransaction.Name = "dtTransaction";
            dtTransaction.Size = new Size(342, 31);
            dtTransaction.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 248);
            label3.Name = "label3";
            label3.Size = new Size(143, 31);
            label3.TabIndex = 6;
            label3.Text = "Date & Heure :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { transactionIDDataGridViewTextBoxColumn, compteIDDataGridViewTextBoxColumn, typeTransactionDataGridViewTextBoxColumn, montantDataGridViewTextBoxColumn, dateTransactionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = transactionsBindingSource;
            dataGridView1.Location = new Point(28, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(815, 188);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            transactionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            transactionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // compteIDDataGridViewTextBoxColumn
            // 
            compteIDDataGridViewTextBoxColumn.DataPropertyName = "CompteID";
            compteIDDataGridViewTextBoxColumn.HeaderText = "CompteID";
            compteIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            compteIDDataGridViewTextBoxColumn.Name = "compteIDDataGridViewTextBoxColumn";
            compteIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeTransactionDataGridViewTextBoxColumn
            // 
            typeTransactionDataGridViewTextBoxColumn.DataPropertyName = "TypeTransaction";
            typeTransactionDataGridViewTextBoxColumn.HeaderText = "TypeTransaction";
            typeTransactionDataGridViewTextBoxColumn.MinimumWidth = 8;
            typeTransactionDataGridViewTextBoxColumn.Name = "typeTransactionDataGridViewTextBoxColumn";
            typeTransactionDataGridViewTextBoxColumn.Width = 150;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            montantDataGridViewTextBoxColumn.MinimumWidth = 8;
            montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            montantDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateTransactionDataGridViewTextBoxColumn
            // 
            dateTransactionDataGridViewTextBoxColumn.DataPropertyName = "DateTransaction";
            dateTransactionDataGridViewTextBoxColumn.HeaderText = "DateTransaction";
            dateTransactionDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateTransactionDataGridViewTextBoxColumn.Name = "dateTransactionDataGridViewTextBoxColumn";
            dateTransactionDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactionsBindingSource
            // 
            transactionsBindingSource.DataSource = typeof(Mes_Classes.Transactions);
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(161, 499);
            button2.Name = "button2";
            button2.Size = new Size(129, 34);
            button2.TabIndex = 15;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 499);
            button1.Name = "button1";
            button1.Size = new Size(129, 34);
            button1.TabIndex = 14;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rbDepot
            // 
            rbDepot.AutoSize = true;
            rbDepot.Cursor = Cursors.Hand;
            rbDepot.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbDepot.Location = new Point(268, 189);
            rbDepot.Name = "rbDepot";
            rbDepot.Size = new Size(90, 32);
            rbDepot.TabIndex = 16;
            rbDepot.TabStop = true;
            rbDepot.Text = "Depot";
            rbDepot.UseVisualStyleBackColor = true;
            // 
            // rbRetrait
            // 
            rbRetrait.AutoSize = true;
            rbRetrait.Cursor = Cursors.Hand;
            rbRetrait.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbRetrait.Location = new Point(375, 189);
            rbRetrait.Name = "rbRetrait";
            rbRetrait.Size = new Size(97, 32);
            rbRetrait.TabIndex = 17;
            rbRetrait.TabStop = true;
            rbRetrait.Text = "Retrait";
            rbRetrait.UseVisualStyleBackColor = true;
            // 
            // txtNumClient
            // 
            txtNumClient.Location = new Point(192, 78);
            txtNumClient.Name = "txtNumClient";
            txtNumClient.Size = new Size(327, 31);
            txtNumClient.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 78);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 18;
            label4.Text = "Num Compte :";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(524, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F);
            label5.Location = new Point(214, 19);
            label5.Name = "label5";
            label5.Size = new Size(340, 36);
            label5.TabIndex = 21;
            label5.Text = "Enregistrement Des Transactions";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._61167;
            pictureBox2.Location = new Point(28, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 541);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(txtNumClient);
            Controls.Add(label4);
            Controls.Add(rbRetrait);
            Controls.Add(rbDepot);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(dtTransaction);
            Controls.Add(label2);
            Controls.Add(txtMontant);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les Transactions";
            Load += frmTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMontant;
        private CheckBox chkRetrait;
        private CheckBox chkDepot;
        private Label label2;
        private DateTimePicker dtTransaction;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private RadioButton rbDepot;
        private RadioButton rbRetrait;
        private TextBox txtNumClient;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn compteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeTransactionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTransactionDataGridViewTextBoxColumn;
        private BindingSource transactionsBindingSource;
    }
}