namespace WinFormsApp1.Presentation
{
    partial class EditRole
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
            button1 = new Button();
            cmbRoles = new ComboBox();
            cmbUsuarios = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(194, 244);
            button1.Name = "button1";
            button1.Size = new Size(103, 48);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(303, 69);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(151, 28);
            cmbRoles.TabIndex = 1;
            cmbRoles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(139, 69);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(151, 28);
            cmbUsuarios.TabIndex = 2;
            cmbUsuarios.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(303, 244);
            button2.Name = "button2";
            button2.Size = new Size(103, 48);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 304);
            Controls.Add(button2);
            Controls.Add(cmbUsuarios);
            Controls.Add(cmbRoles);
            Controls.Add(button1);
            Name = "EditRole";
            Text = "EditRole";
            Load += EditRole_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ComboBox cmbRoles;
        private ComboBox cmbUsuarios;
        private Button button2;
    }
}