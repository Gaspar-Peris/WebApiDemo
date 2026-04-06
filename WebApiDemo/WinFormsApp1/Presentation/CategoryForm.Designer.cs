namespace WinFormsApp1.Presentation
{
    partial class CategoryForm
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
            dataGridView1 = new DataGridView();
            buttonNew = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 212);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(725, 226);
            dataGridView1.TabIndex = 0;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(267, 30);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(94, 29);
            buttonNew.TabIndex = 1;
            buttonNew.Text = "New Category";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // button2
            // 
            button2.Location = new Point(367, 30);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(267, 65);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(334, 177);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "Reload";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buttonNew);
            Controls.Add(dataGridView1);
            Name = "CategoryForm";
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonNew;
        private Button button2;
        private Button button3;
        private Button button5;
    }
}