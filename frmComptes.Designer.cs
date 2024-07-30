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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComptes));
            label1 = new Label();
            txtSolde = new TextBox();
            dtCreation = new DateTimePicker();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 104);
            label1.Name = "label1";
            label1.Size = new Size(72, 28);
            label1.TabIndex = 0;
            label1.Text = "Solde :";
            // 
            // txtSolde
            // 
            txtSolde.Location = new Point(104, 104);
            txtSolde.Name = "txtSolde";
            txtSolde.Size = new Size(396, 31);
            txtSolde.TabIndex = 1;
            txtSolde.TextChanged += textBox1_TextChanged;
            // 
            // dtCreation
            // 
            dtCreation.Location = new Point(206, 151);
            dtCreation.Name = "dtCreation";
            dtCreation.Size = new Size(294, 31);
            dtCreation.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 151);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 3;
            label2.Text = "Date de Creation :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(750, 225);
            dataGridView1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(293, 440);
            button3.Name = "button3";
            button3.Size = new Size(129, 34);
            button3.TabIndex = 16;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(158, 440);
            button2.Name = "button2";
            button2.Size = new Size(129, 34);
            button2.TabIndex = 15;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 440);
            button1.Name = "button1";
            button1.Size = new Size(129, 34);
            button1.TabIndex = 14;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(506, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 10F);
            label5.Location = new Point(197, 19);
            label5.Name = "label5";
            label5.Size = new Size(365, 36);
            label5.TabIndex = 22;
            label5.Text = "Enregistrement Des Compte Clients";
            // 
            // frmComptes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
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
            Name = "frmComptes";
            Text = "frmComptes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}