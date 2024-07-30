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
            label1 = new Label();
            txtMontant = new TextBox();
            chkRetrait = new CheckBox();
            chkDepot = new CheckBox();
            label2 = new Label();
            dtTransaction = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
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
            txtMontant.Size = new Size(329, 31);
            txtMontant.TabIndex = 1;
            // 
            // chkRetrait
            // 
            chkRetrait.AutoSize = true;
            chkRetrait.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkRetrait.Location = new Point(374, 175);
            chkRetrait.Name = "chkRetrait";
            chkRetrait.Size = new Size(98, 32);
            chkRetrait.TabIndex = 2;
            chkRetrait.Text = "Retrait";
            chkRetrait.UseVisualStyleBackColor = true;
            // 
            // chkDepot
            // 
            chkDepot.AutoSize = true;
            chkDepot.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkDepot.Location = new Point(259, 175);
            chkDepot.Name = "chkDepot";
            chkDepot.Size = new Size(91, 32);
            chkDepot.TabIndex = 3;
            chkDepot.Text = "Depot";
            chkDepot.UseVisualStyleBackColor = true;
            chkDepot.CheckedChanged += checkBox2_CheckedChanged;
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
            dtTransaction.Size = new Size(295, 31);
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
            // 
            // frmTransactions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 572);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(dtTransaction);
            Controls.Add(label2);
            Controls.Add(chkDepot);
            Controls.Add(chkRetrait);
            Controls.Add(txtMontant);
            Controls.Add(label1);
            Name = "frmTransactions";
            Text = "frmTransactions";
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
    }
}