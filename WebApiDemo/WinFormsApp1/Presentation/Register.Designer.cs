namespace WinFormsApp1.Presentation
{
    partial class Register
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
            linkLabel1 = new LinkLabel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label9 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(316, 347);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 20);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Iniciar Sesion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(316, 241);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(316, 285);
            button1.Name = "button1";
            button1.Size = new Size(94, 59);
            button1.TabIndex = 10;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 248);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 244);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 196);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(316, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(316, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 155);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 151);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 15;
            label5.Text = "LastName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 103);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "Name";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(210, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 79);
            panel2.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 19);
            label7.Name = "label7";
            label7.Size = new Size(260, 41);
            label7.TabIndex = 0;
            label7.Text = "Registre su cuenta";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 392);
            panel1.TabIndex = 19;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(24, 139);
            label8.Name = "label8";
            label8.Size = new Size(153, 111);
            label8.TabIndex = 1;
            label8.Text = "Sistema de Gestión de Inventario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 22);
            label9.Name = "label9";
            label9.Size = new Size(182, 38);
            label9.TabIndex = 0;
            label9.Text = "Bienvenido!!";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 392);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Label label7;
        private Panel panel1;
        private Label label8;
        private Label label9;
    }
}