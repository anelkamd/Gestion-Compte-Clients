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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(223, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 31);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(105, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(388, 31);
            textBox3.TabIndex = 5;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(193, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 6;
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
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmAdmin";
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
    }
}