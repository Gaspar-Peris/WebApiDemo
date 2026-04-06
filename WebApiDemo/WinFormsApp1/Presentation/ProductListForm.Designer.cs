namespace WinFormsApp1.Presentation
{
    partial class ProductListForm
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
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(326, 90);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(726, 226);
            dataGridView1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(639, 151);
            button3.Name = "button3";
            button3.Size = new Size(94, 55);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(326, 151);
            button4.Name = "button4";
            button4.Size = new Size(94, 55);
            button4.TabIndex = 9;
            button4.Text = "Reload";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(7, 151);
            button2.Name = "button2";
            button2.Size = new Size(94, 55);
            button2.TabIndex = 7;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Name = "ProductListForm";
            Text = "ProductListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Button button2;
    }
}