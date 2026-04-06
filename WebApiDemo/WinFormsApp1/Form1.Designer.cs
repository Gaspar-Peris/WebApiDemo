namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            buttonCategory = new Button();
            panelMenu = new Panel();
            button6 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(25, 232);
            button5.Name = "button5";
            button5.Size = new Size(194, 45);
            button5.TabIndex = 5;
            button5.Text = "Role";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // buttonCategory
            // 
            buttonCategory.BackColor = SystemColors.ActiveCaption;
            buttonCategory.Location = new Point(25, 179);
            buttonCategory.Name = "buttonCategory";
            buttonCategory.Size = new Size(194, 47);
            buttonCategory.TabIndex = 6;
            buttonCategory.Text = "Category Magnament";
            buttonCategory.UseVisualStyleBackColor = false;
            buttonCategory.Click += buttonCategory_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.HotTrack;
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(buttonCategory);
            panelMenu.Controls.Add(button5);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 502);
            panelMenu.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(25, 126);
            button6.Name = "button6";
            button6.Size = new Size(194, 47);
            button6.TabIndex = 7;
            button6.Text = "Product Magnament";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 120);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dieta;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = SystemColors.Highlight;
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(749, 60);
            panelTitleBar.TabIndex = 8;
            panelTitleBar.Paint += panelTitleBar_Paint;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 60);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(749, 442);
            panelDesktop.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 502);
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Recargar";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private Button buttonCategory;
        private Panel panelMenu;
        private Panel panelTitleBar;
        private Panel panelDesktop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button6;
    }
}
