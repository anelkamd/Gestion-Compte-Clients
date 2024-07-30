namespace Gestion_Compte_Clients
{
    partial class frmComptes
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
            txtSolde = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 92);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "Solde :";
            // 
            // txtSolde
            // 
            txtSolde.Location = new Point(104, 92);
            txtSolde.Name = "txtSolde";
            txtSolde.Size = new Size(402, 31);
            txtSolde.TabIndex = 1;
            txtSolde.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(206, 139);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 139);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 3;
            label2.Text = "Date de Creation :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 225);
            dataGridView1.TabIndex = 4;
            // 
            // frmComptes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtSolde);
            Controls.Add(label1);
            Name = "frmComptes";
            Text = "frmComptes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSolde;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}