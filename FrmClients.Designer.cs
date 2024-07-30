namespace Gestion_Compte_Clients
{
    partial class FrmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClients));
            txtNom = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPrenom = new TextBox();
            label3 = new Label();
            txtAdresse = new TextBox();
            label4 = new Label();
            txtTelephone = new TextBox();
            dbClients = new DataGridView();
            clientsBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            clientIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prenomDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telephoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dbClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(137, 80);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(339, 31);
            txtNom.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 1;
            label1.Text = "Nom :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 136);
            label2.Name = "label2";
            label2.Size = new Size(102, 31);
            label2.TabIndex = 3;
            label2.Text = "Prenom :";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(137, 136);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(339, 31);
            txtPrenom.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 195);
            label3.Name = "label3";
            label3.Size = new Size(106, 31);
            label3.TabIndex = 5;
            label3.Text = "Adresse :";
            label3.Click += label3_Click;
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(137, 195);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(339, 31);
            txtAdresse.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 247);
            label4.Name = "label4";
            label4.Size = new Size(129, 31);
            label4.TabIndex = 7;
            label4.Text = "Telephone :";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(162, 247);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(314, 31);
            txtTelephone.TabIndex = 6;
            // 
            // dbClients
            // 
            dbClients.AutoGenerateColumns = false;
            dbClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbClients.Columns.AddRange(new DataGridViewColumn[] { clientIDDataGridViewTextBoxColumn, nomDataGridViewTextBoxColumn, prenomDataGridViewTextBoxColumn, adresseDataGridViewTextBoxColumn, telephoneDataGridViewTextBoxColumn });
            dbClients.DataSource = clientsBindingSource;
            dbClients.Location = new Point(27, 307);
            dbClients.Name = "dbClients";
            dbClients.RowHeadersWidth = 62;
            dbClients.Size = new Size(814, 180);
            dbClients.TabIndex = 8;
            dbClients.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clientsBindingSource
            // 
            clientsBindingSource.DataSource = typeof(Mes_Classes.Clients);
            clientsBindingSource.CurrentChanged += clientsBindingSource_CurrentChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_default_icon;
            pictureBox1.Location = new Point(529, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(277, 25);
            label5.Name = "label5";
            label5.Size = new Size(213, 31);
            label5.TabIndex = 10;
            label5.Text = "Enregistrement Client";
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(27, 503);
            button1.Name = "button1";
            button1.Size = new Size(129, 34);
            button1.TabIndex = 11;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(162, 503);
            button2.Name = "button2";
            button2.Size = new Size(129, 34);
            button2.TabIndex = 12;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(297, 503);
            button3.Name = "button3";
            button3.Size = new Size(129, 34);
            button3.TabIndex = 13;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(432, 503);
            button4.Name = "button4";
            button4.Size = new Size(129, 34);
            button4.TabIndex = 14;
            button4.Text = "Afficher";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            clientIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            clientIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            nomDataGridViewTextBoxColumn.MinimumWidth = 8;
            nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            nomDataGridViewTextBoxColumn.Width = 150;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            prenomDataGridViewTextBoxColumn.MinimumWidth = 8;
            prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            prenomDataGridViewTextBoxColumn.Width = 150;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            adresseDataGridViewTextBoxColumn.MinimumWidth = 8;
            adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            adresseDataGridViewTextBoxColumn.Width = 150;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            telephoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            telephoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmClients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 549);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dbClients);
            Controls.Add(label4);
            Controls.Add(txtTelephone);
            Controls.Add(label3);
            Controls.Add(txtAdresse);
            Controls.Add(label2);
            Controls.Add(txtPrenom);
            Controls.Add(label1);
            Controls.Add(txtNom);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enregistrement Clients";
            Load += FrmClients_Load;
            ((System.ComponentModel.ISupportInitialize)dbClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private Label label1;
        private Label label2;
        private TextBox txtPrenom;
        private Label label3;
        private TextBox txtAdresse;
        private Label label4;
        private TextBox txtTelephone;
        private DataGridView dbClients;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private BindingSource clientsBindingSource;
        private DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
    }
}