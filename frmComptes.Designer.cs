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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComptes));
            label1 = new Label();
            txtSolde = new TextBox();
            dtCreation = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            compteIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soldeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCreationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            comptesBindingSource = new BindingSource(components);
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtClientID = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comptesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 157);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "Solde :";
            // 
            // txtSolde
            // 
            txtSolde.Location = new Point(104, 157);
            txtSolde.Margin = new Padding(3, 4, 3, 4);
            txtSolde.Name = "txtSolde";
            txtSolde.Size = new Size(396, 31);
            txtSolde.TabIndex = 1;
            txtSolde.TextChanged += textBox1_TextChanged;
            // 
            // dtCreation
            // 
            dtCreation.Cursor = Cursors.Hand;
            dtCreation.Location = new Point(206, 210);
            dtCreation.Margin = new Padding(3, 4, 3, 4);
            dtCreation.Name = "dtCreation";
            dtCreation.Size = new Size(294, 31);
            dtCreation.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 210);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 3;
            label2.Text = "Date de Creation :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { compteIDDataGridViewTextBoxColumn, clientIDDataGridViewTextBoxColumn, soldeDataGridViewTextBoxColumn, dateCreationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = comptesBindingSource;
            dataGridView1.Location = new Point(62, 260);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(666, 225);
            dataGridView1.TabIndex = 4;
            // 
            // compteIDDataGridViewTextBoxColumn
            // 
            compteIDDataGridViewTextBoxColumn.DataPropertyName = "CompteID";
            compteIDDataGridViewTextBoxColumn.HeaderText = "CompteID";
            compteIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            compteIDDataGridViewTextBoxColumn.Name = "compteIDDataGridViewTextBoxColumn";
            compteIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            clientIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            clientIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // soldeDataGridViewTextBoxColumn
            // 
            soldeDataGridViewTextBoxColumn.DataPropertyName = "Solde";
            soldeDataGridViewTextBoxColumn.HeaderText = "Solde";
            soldeDataGridViewTextBoxColumn.MinimumWidth = 8;
            soldeDataGridViewTextBoxColumn.Name = "soldeDataGridViewTextBoxColumn";
            soldeDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            dateCreationDataGridViewTextBoxColumn.DataPropertyName = "DateCreation";
            dateCreationDataGridViewTextBoxColumn.HeaderText = "DateCreation";
            dateCreationDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            dateCreationDataGridViewTextBoxColumn.Width = 150;
            // 
            // comptesBindingSource
            // 
            comptesBindingSource.DataSource = typeof(Mes_Classes.Comptes);
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(293, 493);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(129, 38);
            button3.TabIndex = 16;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(158, 493);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(129, 38);
            button2.TabIndex = 15;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 493);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(129, 38);
            button1.TabIndex = 14;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(506, -6);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 251);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F);
            label5.Location = new Point(197, 27);
            label5.Name = "label5";
            label5.Size = new Size(365, 36);
            label5.TabIndex = 22;
            label5.Text = "Enregistrement Des Compte Clients";
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(158, 112);
            txtClientID.Margin = new Padding(3, 4, 3, 4);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(342, 31);
            txtClientID.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 112);
            label3.Name = "label3";
            label3.Size = new Size(126, 28);
            label3.TabIndex = 23;
            label3.Text = "Code Client :";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources._61167;
            pictureBox2.Location = new Point(45, 27);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // frmComptes
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(pictureBox2);
            Controls.Add(txtClientID);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(dtCreation);
            Controls.Add(txtSolde);
            Controls.Add(label1);
            Font = new Font("Poppins", 8F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmComptes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Les Comptes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)comptesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSolde;
        private DateTimePicker dtCreation;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label5;
        private TextBox txtClientID;
        private Label label3;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn compteIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private BindingSource comptesBindingSource;
    }
}