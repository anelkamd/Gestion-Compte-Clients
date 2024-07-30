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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            label1 = new Label();
            txtMontant = new TextBox();
            label2 = new Label();
            dtTransaction = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            rbDepot = new RadioButton();
            rbRetrait = new RadioButton();
            txtNumClient = new TextBox();
            label4 = new Label();
            txtTransaction = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 113);
            label1.Name = "label1";
            label1.Size = new Size(109, 31);
            label1.TabIndex = 0;
            label1.Text = "Montant :";
            // 
            // txtMontant
            // 
            txtMontant.Location = new Point(143, 113);
            txtMontant.Name = "txtMontant";
            txtMontant.Size = new Size(376, 31);
            txtMontant.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 173);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 4;
            label2.Text = "Type de transaction :";
            // 
            // dtTransaction
            // 
            dtTransaction.Location = new Point(177, 227);
            dtTransaction.Name = "dtTransaction";
            dtTransaction.Size = new Size(342, 31);
            dtTransaction.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 232);
            label3.Name = "label3";
            label3.Size = new Size(143, 31);
            label3.TabIndex = 6;
            label3.Text = "Date & Heure :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(736, 225);
            dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(161, 526);
            button2.Name = "button2";
            button2.Size = new Size(129, 34);
            button2.TabIndex = 15;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 526);
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
            rbDepot.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbDepot.Location = new Point(560, 61);
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
            rbRetrait.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbRetrait.Location = new Point(667, 61);
            rbRetrait.Name = "rbRetrait";
            rbRetrait.Size = new Size(97, 32);
            rbRetrait.TabIndex = 17;
            rbRetrait.TabStop = true;
            rbRetrait.Text = "Retrait";
            rbRetrait.UseVisualStyleBackColor = true;
            // 
            // txtNumClient
            // 
            txtNumClient.Location = new Point(192, 62);
            txtNumClient.Name = "txtNumClient";
            txtNumClient.Size = new Size(327, 31);
            txtNumClient.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 62);
            label4.Name = "label4";
            label4.Size = new Size(158, 31);
            label4.TabIndex = 18;
            label4.Text = "Num Compte :";
            // 
            // txtTransaction
            // 
            txtTransaction.Font = new Font("Poppins Thin", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTransaction.Location = new Point(260, 170);
            txtTransaction.Name = "txtTransaction";
            txtTransaction.Size = new Size(259, 31);
            txtTransaction.TabIndex = 20;
            txtTransaction.Text = "Depot ou Retrait";
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 572);
            Controls.Add(txtTransaction);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les Transactions";
            Load += frmTransactions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtTransaction;
    }
}