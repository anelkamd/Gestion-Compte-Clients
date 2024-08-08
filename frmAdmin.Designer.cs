namespace Gestion_Compte_Clients
{
    partial class frmAdmin
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
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            dtAjoutAdmin = new DateTimePicker();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 67);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 0;
            label1.Text = "Nom ( Username ) :";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(223, 64);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(270, 31);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 103);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(307, 31);
            txtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 106);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 2;
            label2.Text = "Mots de Passe :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(388, 31);
            txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 145);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 4;
            label3.Text = "Email :";
            // 
            // dtAjoutAdmin
            // 
            dtAjoutAdmin.Location = new Point(193, 184);
            dtAjoutAdmin.Name = "dtAjoutAdmin";
            dtAjoutAdmin.Size = new Size(300, 31);
            dtAjoutAdmin.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(28, 187);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 7;
            label4.Text = "Date de l'ajout :";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(303, 404);
            button3.Name = "button3";
            button3.Size = new Size(129, 34);
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
            button2.Location = new Point(168, 404);
            button2.Name = "button2";
            button2.Size = new Size(129, 34);
            button2.TabIndex = 15;
            button2.Text = "Modifier";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Poppins Medium", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(33, 404);
            button1.Name = "button1";
            button1.Size = new Size(129, 34);
            button1.TabIndex = 14;
            button1.Text = "Enregistrer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dtAjoutAdmin);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUser);
            Controls.Add(label1);
            Name = "frmAdmin";
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private DateTimePicker dtAjoutAdmin;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}